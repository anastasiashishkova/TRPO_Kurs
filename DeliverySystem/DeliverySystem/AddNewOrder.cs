using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliverySystem
{
    public partial class AddNewOrder : Form
    {
        private SqlConnection sqlConnection = null;
        decimal totalSum = 0;

        public AddNewOrder()
        {
            InitializeComponent();
        }

        private void AddNewOrder_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            label4.Text = "Итоговая сумма: " + totalSum + " руб.";

            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);

                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("SELECT Title FROM Dishes", sqlConnection);

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    comboBox1.Items.Add(read["Title"].ToString());
                }

                read.Close();
                sqlConnection.Close();

            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
        }

        private void add_dish_to_list_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Блюдо не выбрано!");
                }
                else
                {
                    string dish = comboBox1.Text;
                    int quantity = Convert.ToInt32(numericUpDown1.Value);
                    decimal price;

                    sqlConnection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Price FROM Dishes WHERE Title = @dish", sqlConnection);
                    cmd.Parameters.AddWithValue("@dish", dish);
                    price = Convert.ToDecimal(cmd.ExecuteScalar());

                    bool dishFound = false;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == dish)
                        {
                            dishFound = true;

                            int currentQuantity = Convert.ToInt32(row.Cells[1].Value);
                            if(currentQuantity + quantity <= 15)
                            {
                                row.Cells[1].Value = currentQuantity + quantity;
                                row.Cells[2].Value = price * (currentQuantity + quantity);
                                break;
                            }
                            else
                            {
                                MessageBox.Show("В заказ нельзя добавить больше 15 одинаковых блюд!");
                                break;
                            }
                        }
                    }

                    if (!dishFound)
                    {
                        dataGridView1.Rows.Add(dish, quantity, price * quantity);
                    }

                    sqlConnection.Close();

                    totalSum = 0;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        totalSum += Convert.ToDecimal(row.Cells[2].Value);
                    }

                    label4.Text = "Итоговая сумма: " + totalSum + " руб.";
                    
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления заказа!\nОбратитесь к системному администратору.");
            }
        }

        private void delete_dish_from_list_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Выберите блюдо, которое хотите удалить из заказа!");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == comboBox1.Text)
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?",
                            "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            dataGridView1.Rows.Remove(row);
                            break;
                        }
                    }
                }

                totalSum = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    totalSum += Convert.ToDecimal(row.Cells[2].Value);
                }

                label4.Text = "Итоговая сумма: " + totalSum + " руб.";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                comboBox1.Text = row.Cells[0].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_client_btn_Click(object sender, EventArgs e)
        {
            Clients newClient = new Clients();
            this.Hide();
            newClient.ShowDialog();
            this.Show();
        }

        private void add_new_order_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comboBox2.Text) || dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Не добавлены блюда в заказ или не выбран пункт 'Клиент'!");
                }
                else
                {
                    string clientFullName = comboBox2.Text;
                    int idClient;
                    string dishTitle;
                    int idDish;
                    int dishQuantity;
                    int orderId;

                    DateTime currentTime = DateTime.Now;

                    sqlConnection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Id_Client FROM Clients WHERE Surname + ' ' + FirstName = @clientFullName", sqlConnection);
                    cmd.Parameters.AddWithValue("@clientFullName", clientFullName);
                    idClient = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd = new SqlCommand("INSERT INTO Orders (Id_Client, Order_DateTime) VALUES (@idClient, @currentTime)", sqlConnection);
                    cmd.Parameters.AddWithValue("@idClient", idClient);
                    cmd.Parameters.AddWithValue("@currentTime", currentTime);

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("SELECT Id_Order FROM Orders WHERE Id_Client = @idClient AND Order_DateTime = @currentTime", sqlConnection);
                    cmd.Parameters.AddWithValue("@idClient", idClient);
                    cmd.Parameters.AddWithValue("@currentTime", currentTime);
                    orderId = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        dishTitle = row.Cells[0].Value.ToString();
                        dishQuantity = Convert.ToInt32(row.Cells[1].Value);

                        cmd = new SqlCommand("SELECT Id_Dish FROM Dishes WHERE Title = @dishTitle", sqlConnection);
                        cmd.Parameters.AddWithValue("@dishTitle", dishTitle);
                        idDish = Convert.ToInt32(cmd.ExecuteScalar());


                        string query = "INSERT INTO Orders_Details (Id_Order, Id_Dish, DishQuantity) VALUES (@order, @dish, @quantity)";

                        using (cmd = new SqlCommand(query, sqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@dish", idDish);
                            cmd.Parameters.AddWithValue("@order", orderId);
                            cmd.Parameters.AddWithValue("@quantity", dishQuantity);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    sqlConnection.Close();

                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления данных!\nОбратитесь к системному администратору.");
            }
        }

        private void AddNewOrder_Activated(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);

                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Surname + ' ' + FirstName AS FullName FROM Clients", sqlConnection);

                SqlDataReader read = cmd.ExecuteReader();

                comboBox2.Items.Clear();

                while (read.Read())
                {
                    comboBox2.Items.Add(read["FullName"].ToString());
                }

                read.Close();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
        }
    }
}
