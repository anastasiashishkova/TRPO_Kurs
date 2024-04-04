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
    public partial class Menu : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlConnection sqlConnection2 = null;
        int lastRowNumber = 0;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);

                sqlConnection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);

                RefreshDataGrid();

                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("SELECT Title FROM Dishes", sqlConnection);

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    comboBox2.Items.Add(read["Title"].ToString());
                }

                read.Close();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
            
        }

        private void filter_day_button_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();

            string day = comboBox3.Text;

            try
            {
                sqlConnection.Open();
                sqlConnection2.Open();

                SqlCommand com = new SqlCommand("SELECT * FROM Menu WHERE Id_Day = @day", sqlConnection);
                com.Parameters.AddWithValue("@day", day);

                SqlDataReader reader = com.ExecuteReader();

                string Day;
                int Dish;
                string dishName;

                while (reader.Read())
                {
                    Day = reader.GetString(0);
                    Dish = reader.GetInt32(1);


                    using (SqlCommand command = new SqlCommand("SELECT Title FROM Dishes WHERE Id_Dish = @IdDish", sqlConnection2))
                    {
                        command.Parameters.AddWithValue("@IdDish", Dish);
                        dishName = command.ExecuteScalar()?.ToString();
                    }

                    dataGridView1.Rows.Add(Day, dishName);
                }

                reader.Close();
                sqlConnection2.Close();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Не выбран пункт 'День недели'! ");
            }


        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            sqlConnection.Open();
            sqlConnection2.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM Menu", sqlConnection);

            SqlDataReader reader = com.ExecuteReader();

            string Day;
            int Dish;
            string dishName;

            while (reader.Read())
            {
                Day = reader.GetString(0);
                Dish = reader.GetInt32(1);


                using (SqlCommand command = new SqlCommand("SELECT Title FROM Dishes WHERE Id_Dish = @IdDish", sqlConnection2))
                {
                    command.Parameters.AddWithValue("@IdDish", Dish);
                    dishName = command.ExecuteScalar()?.ToString();
                }

                dataGridView1.Rows.Add(Day, dishName);
            }

            reader.Close();
            sqlConnection2.Close();
            sqlConnection.Close();
        }

        private void add_dish_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox3.Text))
                {
                    MessageBox.Show("Не выбран пункт 'День недели' или 'Блюдо'!");
                }
                else
                {
                    string dish = comboBox2.Text;
                    string day = comboBox3.Text;
                    int DishId = 0;

                    sqlConnection.Open();

                    SqlCommand com = new SqlCommand("SELECT Id_Dish FROM Dishes WHERE Title = @dish", sqlConnection);
                    com.Parameters.AddWithValue("@dish", dish);
                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DishId = reader.GetInt32(0);
                        }
                        reader.Close();

                        com = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM Menu WHERE Id_Day = @day AND Id_Dish = @dish) " +
                                 "BEGIN " +
                                 "INSERT INTO Menu (Id_Day, Id_Dish) VALUES (@day, @dish) " +
                                 "END", sqlConnection);

                        com.Parameters.AddWithValue("@day", day);
                        com.Parameters.AddWithValue("@dish", DishId);

                        int rowsAffected = com.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Запись уже существует!");
                        }
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

        private void refresh_button_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshDataGrid();
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
                if (string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox3.Text))
                {
                    MessageBox.Show("Не выбран пункт 'День недели' или 'Блюдо'!");
                }
                else
                {
                    string dish = comboBox2.Text;
                    string day = comboBox3.Text;
                    int DishId = 0;

                    sqlConnection.Open();

                    SqlCommand com = new SqlCommand("SELECT Id_Dish FROM Dishes WHERE Title = @dish", sqlConnection);
                    com.Parameters.AddWithValue("@dish", dish);
                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DishId = reader.GetInt32(0);
                        }
                        reader.Close();

                        DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?",
                            "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {

                            com = new SqlCommand("DELETE FROM Menu WHERE Id_Day = @day AND Id_Dish = @dish", sqlConnection);
                            com.Parameters.AddWithValue("@day", day);
                            com.Parameters.AddWithValue("@dish", DishId);

                            com.ExecuteNonQuery();
                        }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                comboBox2.Text = row.Cells[1].Value.ToString();
                comboBox3.Text = row.Cells[0].Value.ToString();
            }
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            try
            {
                lastRowNumber = 0;
                PrintDocument printDoc = new PrintDocument();
                printDoc.DocumentName = "Меню";
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT c.Title, d.Title, d.Price, m.Id_Day FROM Menu m" +
                " JOIN Dishes d ON m.Id_Dish = d.Id_Dish " +
                "JOIN Categories c ON d.Id_Category = c.Id_Category " +
                "ORDER BY " +
                "" +
                "CASE m.Id_Day " +
                "WHEN N'Понедельник' THEN 1 " +
                "WHEN N'Вторник' THEN 2 " +
                "WHEN N'Среда' THEN 3 " +
                "WHEN N'Четверг' THEN 4 " +
                "WHEN N'Пятница' THEN 5 " +
                "END, " +
                "c.Id_Category; ", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            for (int i = 0; i < lastRowNumber; i++)
            {
                reader.Read();
            }

            float yPos = 10;

            // Шрифт для дней недели
            Font dayFont = new Font("Montserrat", 8, FontStyle.Bold);

            // Шрифт для блюд и категорий
            Font dataFont = new Font("Montserrat", 8);

            // Текущий день в ридере
            string currentDay = "";

            // Текущая категория в ридере
            string currentCategory = "";

            int count = 0;

            e.HasMorePages = false;

            while (reader.Read())
            {
                string day = reader.GetString(3);

                // Проверка на смену дня
                if (day != currentDay)
                {
                    if (!string.IsNullOrEmpty(currentDay))
                        yPos += 10; // Интервал между днями

                    currentDay = day;
                    yPos += 10; // Интервал между днями
                    e.Graphics.DrawString(currentDay, dayFont, Brushes.Black, new PointF(10, yPos));
                    yPos += 10; // Интервал между днем и блюдами
                    count++;
                }

                string category = reader.GetString(0);
                string dish = reader.GetString(1);
                string price = reader.GetDecimal(2).ToString("N2");

                // Координаты X для каждого столбца
                float categoryX = 10;
                float dishX = categoryX + 200;
                float priceX = dishX + 450;

                // Проверка на смену категории
                if (category != currentCategory)
                {
                    yPos += 5; // Интервал между категориями
                    e.Graphics.DrawString(category, dataFont, Brushes.Black, new PointF(categoryX, yPos));
                    currentCategory = category;
                    yPos += 5; // Интервал между категорией и блюдами
                    count++;
                }

                e.Graphics.DrawString(dish, dataFont, Brushes.Black, new PointF(dishX, yPos));
                e.Graphics.DrawString(price + " руб.", dataFont, Brushes.Black, new PointF(priceX, yPos));
                yPos += 20; // Интервал между строками

                count++;

                lastRowNumber++;

                if (count >= 61)
                {
                    break;
                }
            }

            if(count >= 61)
            {
                e.HasMorePages = true;
            }

            reader.Close();
            sqlConnection.Close();
        }
    }
}
