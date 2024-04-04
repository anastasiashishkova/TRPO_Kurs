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
    public partial class Dishes_Details : Form
    {
        string dish;
        private SqlConnection sqlConnection = null;
        private SqlConnection sqlConnection2 = null;

        public Dishes_Details(string dish)
        {
            this.dish = dish;
            InitializeComponent();
        }

        private void Dishes_Details_Load(object sender, EventArgs e)
        {
            label4.Text = "Блюдо: " + dish;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);
            sqlConnection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);

            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            try
            {
                sqlConnection.Open();
                sqlConnection2.Open();

                SqlCommand com = new SqlCommand("SELECT Title FROM Stock", sqlConnection);

                SqlDataReader read = com.ExecuteReader();

                while (read.Read())
                {
                    comboBox1.Items.Add(read[0].ToString());
                }

                read.Close();

                SqlCommand cmd = new SqlCommand("SELECT pid.Id_Product, pid.Quantity " +
                    "FROM Products_In_Dishes pid " +
                    "WHERE pid.Id_Dish = ( " +
                    "SELECT d.Id_Dish " +
                    "FROM Dishes d " +
                    "WHERE d.Title = @dish); ", sqlConnection);

                cmd.Parameters.AddWithValue("@dish", dish);

                int product;
                string title;
                decimal quantity;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    product = Convert.ToInt32(reader[0]);
                    quantity = Math.Round(Convert.ToDecimal(reader[1]), 2);

                    using (SqlCommand command = new SqlCommand("SELECT Title FROM Stock WHERE Id_Product = @Id", sqlConnection2))
                    {
                        command.Parameters.AddWithValue("@Id", product);
                        title = command.ExecuteScalar()?.ToString();
                    }

                    dataGridView1.Rows.Add(title, quantity);
                }

                reader.Close();
                sqlConnection2.Close();
                sqlConnection.Close();

            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
        }

        private void weight_btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                return;
            }
            else if (e.KeyChar == ',' && !((sender as TextBox).Text.Contains(',') || (sender as TextBox).Text.Length == 0))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(weight_btn.Text))
                {
                    MessageBox.Show("Ошибка добавления записи!\nПроверьте, чтобы были заполнены все поля.");
                }
                else
                {
                    string product = comboBox1.Text;
                    decimal quantity = Math.Round(Convert.ToDecimal(weight_btn.Text), 2);

                    sqlConnection.Open();

                    SqlCommand com = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM Products_In_Dishes pid " +
                                "JOIN Dishes d ON pid.Id_Dish = d.Id_Dish " +
                                "JOIN Stock s ON pid.Id_Product = s.Id_Product " +
                                "WHERE d.Title = @dish AND s.Title = @product) " +
                                "BEGIN " +
                                "INSERT INTO Products_In_Dishes (Id_Dish, Id_Product, Quantity) VALUES " +
                                "( " +
                                "(SELECT Id_Dish FROM Dishes WHERE Title = @dish), " +
                                "(SELECT Id_Product FROM Stock WHERE Title = @product), " +
                                "@quantity); " +
                                "END", sqlConnection);
                    com.Parameters.AddWithValue("@dish", dish);
                    com.Parameters.AddWithValue("@product", product);
                    com.Parameters.AddWithValue("@quantity", quantity);

                    com.ExecuteNonQuery();

                    sqlConnection.Close();

                    RefreshDataGrid();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления данных!\nОбратитесь к системному администратору.");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Ошибка удаления записи!\nПроверьте, чтобы было заполнено поле 'Название'.");
                }
                else
                {
                    string product = comboBox1.Text;

                    sqlConnection.Open();

                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?",
                            "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        SqlCommand com = new SqlCommand("DELETE FROM Products_In_Dishes " +
                            "WHERE Id_Dish = (SELECT Id_Dish FROM Dishes WHERE Title = @dish) " +
                            "AND Id_Product = (SELECT Id_Product FROM Stock WHERE Title = @product); ", sqlConnection);
                        com.Parameters.AddWithValue("@dish", dish);
                        com.Parameters.AddWithValue("@product", product);
                        com.ExecuteNonQuery();
                    }

                    sqlConnection.Close();

                    RefreshDataGrid();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления данных!\nОбратитесь к системному администратору.");
            }
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(weight_btn.Text))
                {
                    MessageBox.Show("Ошибка изменения записи!\nПроверьте, чтобы были заполнены все поля.");
                }
                else
                {
                    string product = comboBox1.Text;
                    decimal quantity = Math.Round(Convert.ToDecimal(weight_btn.Text), 2);

                    sqlConnection.Open();

                    SqlCommand com = new SqlCommand("UPDATE Products_In_Dishes " +
                        "SET Quantity = @quantity " +
                        "WHERE Id_Dish = (SELECT Id_Dish FROM Dishes WHERE Title = @dish) " +
                        "AND Id_Product = (SELECT Id_Product FROM Stock WHERE Title = @product); ", sqlConnection);

                    com.Parameters.AddWithValue("@quantity", quantity);
                    com.Parameters.AddWithValue("@dish", dish);
                    com.Parameters.AddWithValue("@product", product);
                    com.ExecuteNonQuery();

                    sqlConnection.Close();

                    RefreshDataGrid();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка изменения данных!\nОбратитесь к системному администратору.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                comboBox1.Text = row.Cells[0].Value.ToString();
                weight_btn.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
