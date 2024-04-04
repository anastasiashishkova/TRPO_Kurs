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
    public partial class Stock : Form
    {
        private SqlConnection sqlConnection = null;

        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);
                RefreshDataGrid();
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            sqlConnection.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM Stock", sqlConnection);

            SqlDataReader reader = com.ExecuteReader();

            string product;
            string price;
            string quantity;

            while (reader.Read())
            {
                product = reader[1].ToString();
                price = reader[2].ToString();
                quantity = reader[3].ToString();

                dataGridView1.Rows.Add(product, price, quantity);
            }

            reader.Close();
            sqlConnection.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '%' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
            }
        }

        private void filter_day_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string title = textBox1.Text;

            try
            {
                sqlConnection.Open();

                SqlCommand com = new SqlCommand("SELECT * FROM Stock WHERE Title = @title", sqlConnection);
                com.Parameters.AddWithValue("@title", title);

                SqlDataReader reader = com.ExecuteReader();

                string product;
                string price;
                string quantity;

                while (reader.Read())
                {
                    product = reader[1].ToString();
                    price = reader[2].ToString();
                    quantity = reader[3].ToString();

                    dataGridView1.Rows.Add(product, price, quantity);
                }

                reader.Close();
                sqlConnection.Close();

            }
            catch
            {
                MessageBox.Show("Не заполнено поле 'Название'!");
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Ошибка добавления записи!\nПроверьте, чтобы были заполнены все поля.");
                }
                else
                {
                    string product = textBox1.Text;
                    decimal price = Math.Round(Convert.ToDecimal(textBox2.Text), 2);
                    decimal quantity = Math.Round(Convert.ToDecimal(textBox3.Text), 2); 

                    sqlConnection.Open();

                    SqlCommand com = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM Stock WHERE Title = @title) " +
                                 "BEGIN " +
                                 "INSERT INTO Stock (Title, Price, Quantity) VALUES (@title, @price, @quantity) " +
                                 "END", sqlConnection);
                    com.Parameters.AddWithValue("@title", product);
                    com.Parameters.AddWithValue("@price", price);
                    com.Parameters.AddWithValue("@quantity", quantity);

                    com.ExecuteNonQuery();

                    sqlConnection.Close();

                    RefreshDataGrid();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Ошибка удаления записи!\nПроверьте, чтобы было заполнено поле 'Название'.");
                }
                else
                {
                    string titleSearch = textBox1.Text;

                    sqlConnection.Open();

                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?",
                            "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        SqlCommand com = new SqlCommand("DELETE FROM Stock WHERE Title = @title", sqlConnection);
                        com.Parameters.AddWithValue("@title", titleSearch);
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
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Ошибка изменения записи!\nПроверьте, чтобы были заполнены все поля.");
                }
                else
                {
                    string product = textBox1.Text;
                    decimal price = Math.Round(Convert.ToDecimal(textBox2.Text), 2);
                    decimal quantity = Math.Round(Convert.ToDecimal(textBox3.Text), 2);

                    sqlConnection.Open();

                    SqlCommand com = new SqlCommand("UPDATE Stock " +
                            "SET Price = @price, Quantity = @quantity " +
                            "WHERE Title = @title", sqlConnection);

                    com.Parameters.AddWithValue("@title", product);
                    com.Parameters.AddWithValue("@price", price);
                    com.Parameters.AddWithValue("@quantity", quantity);

                    com.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно обновлена!");

                    sqlConnection.Close();

                    RefreshDataGrid();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка изменения данных!\nОбратитесь к системному администратору.");
            }
        }
    }
}
