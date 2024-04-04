using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliverySystem
{
    public partial class Dishes : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlConnection sqlConnection2 = null;
        int lastRowNumber = 0;

        public Dishes()
        {
            InitializeComponent();
        }

        private void Dishes_Load(object sender, EventArgs e)
        {
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);

                sqlConnection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);

                RefreshDataGrid();

                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("SELECT Title FROM Categories", sqlConnection);

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    comboBox3.Items.Add(read["Title"].ToString());
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
            sqlConnection2.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM Dishes", sqlConnection);

            SqlDataReader reader = com.ExecuteReader();
            int id;
            string title;
            int idCat;
            decimal weight;
            decimal price;
            string catName;

            while (reader.Read())
            {
                id = reader.GetInt32(0);
                title = reader.GetString(1);
                idCat = reader.GetInt32(2);
                weight = reader.GetDecimal(3);
                price = reader.GetDecimal(4);


                using (SqlCommand command = new SqlCommand("SELECT Title FROM Categories WHERE Id_Category = @IdCat", sqlConnection2))
                {
                    command.Parameters.AddWithValue("@IdCat", idCat);
                    catName = command.ExecuteScalar()?.ToString();
                }

                dataGridView1.Rows.Add(id, title, catName, weight, price);
            }

            reader.Close();
            sqlConnection2.Close();
            sqlConnection.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void title_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                return;
            }
            else
            {
                e.Handled = true;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                title_box.Text = row.Cells[1].Value.ToString();
                comboBox3.Text = row.Cells[2].Value.ToString();
                weight_btn.Text = row.Cells[3].Value.ToString();
                price_btn.Text = row.Cells[4].Value.ToString();
            }
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string title = title_box.Text;

            try
            {
                sqlConnection.Open();
                sqlConnection2.Open();

                SqlCommand com = new SqlCommand("SELECT * FROM Dishes WHERE Title = @title", sqlConnection);
                com.Parameters.AddWithValue("@title", title);

                SqlDataReader reader = com.ExecuteReader();

                int id;
                string titleSearch;
                int idCat;
                decimal weight;
                decimal price;
                string catName;

                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    titleSearch = reader.GetString(1);
                    idCat = reader.GetInt32(2);
                    weight = reader.GetDecimal(3);
                    price = reader.GetDecimal(4);


                    using (SqlCommand command = new SqlCommand("SELECT Title FROM Categories WHERE Id_Category = @IdCat", sqlConnection2))
                    {
                        command.Parameters.AddWithValue("@IdCat", idCat);
                        catName = command.ExecuteScalar()?.ToString();
                    }

                    dataGridView1.Rows.Add(id, title, catName, weight, price);
                }

                reader.Close();
                sqlConnection2.Close();
                sqlConnection.Close();

            }
            catch
            {
                MessageBox.Show("Не заполнено поле 'Название'!");
            }

        }

        private void add_dish_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(title_box.Text) || string.IsNullOrWhiteSpace(comboBox3.Text)  || string.IsNullOrWhiteSpace(weight_btn.Text) || string.IsNullOrWhiteSpace(price_btn.Text))
                {
                    MessageBox.Show("Ошибка добавления записи!\nПроверьте, чтобы были заполнены все поля.");
                }
                else
                {
                    string titleSearch = title_box.Text;
                    string catName = comboBox3.Text;
                    decimal weight = Math.Round(Convert.ToDecimal(weight_btn.Text), 2);
                    decimal price = Math.Round(Convert.ToDecimal(price_btn.Text), 2);
                    int idCat = 0;

                    sqlConnection.Open();

                    SqlCommand com = new SqlCommand("SELECT Id_Category FROM Categories WHERE Title = @catName", sqlConnection);
                    com.Parameters.AddWithValue("@catName", catName);
                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            idCat = reader.GetInt32(0);
                        }
                        reader.Close();

                        com = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM Dishes WHERE Title = @title) " +
                                 "BEGIN " +
                                 "INSERT INTO Dishes (Title, Id_Category, Weight, Price ) VALUES (@title, @idCat, @weight, @price) " +
                                 "END", sqlConnection);

                        com.Parameters.AddWithValue("@title", titleSearch);
                        com.Parameters.AddWithValue("@idCat", idCat);
                        com.Parameters.AddWithValue("@weight", weight);
                        com.Parameters.AddWithValue("@price", price);

                        com.ExecuteNonQuery();

                    }
                    sqlConnection.Close();

                    RefreshDataGrid();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
        }

        private void delete_dish_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(title_box.Text))
                {
                    MessageBox.Show("Ошибка удаления записи!\nПроверьте, чтобы было заполнено поле 'Название'.");
                }
                else
                {
                    string titleSearch = title_box.Text;

                    sqlConnection.Open();

                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?",
                            "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        SqlCommand com = new SqlCommand("DELETE FROM Dishes WHERE Title = @title", sqlConnection);
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

        private void change_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(title_box.Text) || string.IsNullOrWhiteSpace(comboBox3.Text) || string.IsNullOrWhiteSpace(weight_btn.Text) || string.IsNullOrWhiteSpace(price_btn.Text))
                {
                    MessageBox.Show("Ошибка изменения записи!\nПроверьте, чтобы были заполнены все поля.");
                }
                else
                {
                    string titleSearch = title_box.Text;
                    string catName = comboBox3.Text;
                    decimal weight = Math.Round(Convert.ToDecimal(weight_btn.Text), 2);
                    decimal price = Math.Round(Convert.ToDecimal(price_btn.Text), 2);
                    int idCat = 0;

                    sqlConnection.Open();

                    SqlCommand com = new SqlCommand("SELECT Id_Category FROM Categories WHERE Title = @catName", sqlConnection);
                    com.Parameters.AddWithValue("@catName", catName);
                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            idCat = reader.GetInt32(0);
                        }
                        reader.Close();

                        com = new SqlCommand("UPDATE Dishes " +
                            "SET Id_Category = @idCat, Weight = @weight, Price = @price " +
                            "WHERE Title = @title", sqlConnection);

                        com.Parameters.AddWithValue("@title", titleSearch);
                        com.Parameters.AddWithValue("@idCat", idCat);
                        com.Parameters.AddWithValue("@weight", weight);
                        com.Parameters.AddWithValue("@price", price);

                        com.ExecuteNonQuery();

                        MessageBox.Show("Запись успешно обновлена!");
                    }
                    sqlConnection.Close();

                    RefreshDataGrid();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка изменения данных!\nОбратитесь к системному администратору.");
            }
        }

        private void dish_details_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(title_box.Text))
            {
                MessageBox.Show("Не введено название блюда!");
            }
            else
            {
                string dish = title_box.Text;
                Dishes_Details dishDetails = new Dishes_Details(dish);
                this.Hide();
                dishDetails.ShowDialog();
                this.Show();
            }
        }

        private void dishes_list_Click(object sender, EventArgs e)
        {
            try
            {
                lastRowNumber = 0;
                PrintDocument printDoc = new PrintDocument();
                printDoc.DocumentName = "Прейскурант";
                printDoc.PrintPage += printDocument1_PrintPage;
                PrintPreviewDialog previewDlg = new PrintPreviewDialog();
                previewDlg.Document = printDoc;
                previewDlg.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
        }

        //печать прейскуранта
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT " +
                "d.Title AS DishTitle, " +
                "SUM(pid.Quantity * s.Price) AS Cost " +
                "FROM " +
                "Dishes d " +
                "JOIN " +
                "Products_In_Dishes pid ON d.Id_Dish = pid.Id_Dish " +
                "JOIN " +
                "Stock s ON pid.Id_Product = s.Id_Product " +
                "GROUP BY " +
                "d.Id_Dish, d.Title; ", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            for (int i = 0; i < lastRowNumber; i++)
            {
                reader.Read();
            }

            float yPos = 10;

            float titleX = 10;
            float countX = 310;

            Font headerFont = new Font("Montserrat", 10, FontStyle.Bold);
            Font dataFont = new Font("Montserrat", 8);

            e.Graphics.DrawString("ПРЕЙСКУРАНТ", headerFont, Brushes.Black, new PointF(10, yPos));

            yPos += 30;

            e.Graphics.DrawString("Блюдо", headerFont, Brushes.Black, new PointF(titleX, yPos));
            e.Graphics.DrawString("Себестоимость, руб.", headerFont, Brushes.Black, new PointF(countX, yPos));

            yPos += 30;

            int count = 6;

            string dishTile;
            decimal coast;

            e.HasMorePages = false;

            while (reader.Read())
            {
                dishTile = reader[0].ToString();
                coast = Math.Round(Convert.ToDecimal(reader[1]), 2); 

                e.Graphics.DrawString(dishTile, dataFont, Brushes.Black, new PointF(titleX, yPos));
                e.Graphics.DrawString(coast.ToString(), dataFont, Brushes.Black, new PointF(countX, yPos));
                yPos += 20;

                count++;

                lastRowNumber++;

                if (count >= 61)
                {
                    break;
                }
            }

            if (count >= 61)
            {
                e.HasMorePages = true;
            }

            reader.Close();
            sqlConnection.Close();
        }
    }
}
