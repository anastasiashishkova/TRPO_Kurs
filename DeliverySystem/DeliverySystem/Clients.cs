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
    public partial class Clients : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlConnection sqlConnection2 = null;

        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);
                sqlConnection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);

                RefreshDataGrid();

                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("SELECT StreetName FROM DeliveryPoints", sqlConnection);

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    comboBox1.Items.Add(read["StreetName"].ToString());
                }

                read.Close();
                sqlConnection.Close();
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

            SqlCommand com = new SqlCommand("SELECT * FROM Clients", sqlConnection);

            SqlDataReader reader = com.ExecuteReader();

            string surname;
            string firstName;
            string phone = null;
            string street;
            string house;
            string apart;

            while (reader.Read())
            {
                surname = reader.GetString(1);
                firstName = reader.GetString(2);
                phone = reader.GetString(3);
                street = reader.GetString(4);
                house = reader.GetString(5);
                apart = reader.GetString(6);

                dataGridView1.Rows.Add(surname, firstName, phone, street, house, apart);
            }

            reader.Close();
            sqlConnection.Close();
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
                comboBox1.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Ошибка добавления записи!\nПроверьте, чтобы были заполнены все поля.");
            }
            else
            {
                string surname = textBox1.Text;
                string firstName = textBox2.Text;
                string phone = textBox3.Text;
                string street = comboBox1.Text;
                string house = textBox4.Text;
                string apart = textBox5.Text;

                sqlConnection.Open();

                SqlCommand com = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM Clients WHERE Surname = @surname AND FirstName = @firstName) " +
                                 "BEGIN " +
                                 "INSERT INTO Clients (Surname, FirstName, Phone, Street, House, Apartment) VALUES (@surname, @firstName, @phone, @street, @house, @apart) " +
                                 "END", sqlConnection);
                com.Parameters.AddWithValue("@surname", surname);
                com.Parameters.AddWithValue("@firstName", firstName);
                com.Parameters.AddWithValue("@phone", phone);
                com.Parameters.AddWithValue("@street", street);
                com.Parameters.AddWithValue("@house", house);
                com.Parameters.AddWithValue("@apart", apart);

                com.ExecuteNonQuery();

                sqlConnection.Close();

                RefreshDataGrid();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '-')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Ошибка изменения записи!\nПроверьте, чтобы были заполнены все поля.");
            }
            else
            {
                try
                {
                    string surname = textBox1.Text;
                    string firstName = textBox2.Text;
                    string phone = textBox3.Text;
                    string street = comboBox1.Text;
                    string house = textBox4.Text;
                    string apart = textBox5.Text;

                    sqlConnection.Open();

                    SqlCommand com = new SqlCommand("UPDATE Clients " +
                                "SET Surname = @surname, FirstName = @firstName, Phone = @phone, Street = @street, House = @house, Apartment = @apart " +
                                "WHERE Surname = @surname AND FirstName = @firstName", sqlConnection);

                    com.Parameters.AddWithValue("@surname", surname);
                    com.Parameters.AddWithValue("@firstName", firstName);
                    com.Parameters.AddWithValue("@phone", phone);
                    com.Parameters.AddWithValue("@street", street);
                    com.Parameters.AddWithValue("@house", house);
                    com.Parameters.AddWithValue("@apart", apart);

                    com.ExecuteNonQuery();

                    sqlConnection.Close();
                    RefreshDataGrid();
                }
                catch
                {
                    MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
                }
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void filter_day_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string surname = textBox1.Text;

            try
            {
                sqlConnection.Open();

                SqlCommand com = new SqlCommand("SELECT * FROM Clients WHERE Surname = @surname", sqlConnection);
                com.Parameters.AddWithValue("@surname", surname);

                SqlDataReader reader = com.ExecuteReader();

                string surnameFronDb;
                string firstName;
                string phone = null;
                string street;
                string house;
                string apart;

                while (reader.Read())
                {
                    surnameFronDb = reader.GetString(1);
                    firstName = reader.GetString(2);
                    phone = reader.GetString(3);
                    street = reader.GetString(4);
                    house = reader.GetString(5);
                    apart = reader.GetString(6);

                    dataGridView1.Rows.Add(surnameFronDb, firstName, phone, street, house, apart);
                }

                reader.Close();
                sqlConnection.Close();

            }
            catch
            {
                MessageBox.Show("Не заполнено поле 'Фамилия'!");
            }
        }
    }
}
