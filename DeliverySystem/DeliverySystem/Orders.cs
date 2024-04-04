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
    public partial class Orders : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlConnection sqlConnection2 = null;
        int lastRowNumber = 0;

        public Orders()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddNewOrder newOrder = new AddNewOrder();
            this.Hide();
            newOrder.ShowDialog();
            this.Show();
            RefreshDataGrid();
        }

        private void order_details_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Не введен номер заказа!");
            }
            else
            {
                UpdateOrder updateOrder = new UpdateOrder(Convert.ToInt32(textBox2.Text));
                this.Hide();
                updateOrder.ShowDialog();
                this.Show();            
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);
                sqlConnection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);

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
            sqlConnection2.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM Orders", sqlConnection);

            SqlDataReader reader = com.ExecuteReader();

            int idOrder;
            int idClient;
            DateTime orderDate;
            decimal orderPrice;
            string clientFullName;

            while (reader.Read())
            {
                idOrder = reader.GetInt32(0);
                idClient = reader.GetInt32(1);
                orderDate = reader.GetDateTime(2);
                orderPrice = reader.GetDecimal(3);

                using (SqlCommand command = new SqlCommand("SELECT Surname + ' ' + FirstName AS FullName FROM Clients WHERE Id_Client = @id", sqlConnection2))
                {
                    command.Parameters.AddWithValue("@Id", idClient);
                    clientFullName = command.ExecuteScalar()?.ToString();
                }

                dataGridView1.Rows.Add(idOrder, clientFullName, orderDate, orderPrice);
            }

            reader.Close();
            sqlConnection2.Close();
            sqlConnection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox2.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[2].Value.ToString();
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        //статистика
        private void button1_Click(object sender, EventArgs e)
        {
            Statistic stat = new Statistic();
            this.Hide();
            stat.ShowDialog();
            this.Show();
        }

        //квитанция
        private void receipt_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введите номер заказа!");
            }
            else
            {
                try
                {
                    lastRowNumber = 0;
                    PrintDocument printDoc = new PrintDocument();
                    printDoc.DocumentName = "Квитанция заказа";
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
        }

        //печать квитанции
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            sqlConnection.Open();

            int orderId = Convert.ToInt32(textBox2.Text);

            SqlCommand command = new SqlCommand("SELECT " +
                "O.Id_Order, " +
                "O.Id_Client, " +
                "O.Order_DateTime, " +
                "O.Order_Price, " +
                "OD.Id_Dish, " +
                "D.Title," + 
                "OD.DishQuantity, " +
                "C.FirstName, " +
                "C.Surname, " +
                "C.Street, " +
                "C.House, " +
                "C.Apartment, " +
                "D.Price, " +
                "D.Price * OD.DishQuantity AS TotalDishPrice " +
                "FROM " +
                "Orders O " +
                "JOIN " +
                "Orders_Details OD ON O.Id_Order = OD.Id_Order " +
                "JOIN " +
                "Clients C ON O.Id_Client = C.Id_Client " +
                "JOIN " +
                "Dishes D ON OD.Id_Dish = D.Id_Dish " +
                "WHERE O.Id_Order = @orderId; ", sqlConnection);

            command.Parameters.AddWithValue("@orderId", orderId);

            SqlDataReader reader = command.ExecuteReader();

            for (int i = 0; i < lastRowNumber; i++)
            {
                reader.Read();
            }

            float yPos = 10;

            float titleX = 10;
            float countX = 310;
            float priceX = 510;
            float dishespriceX = 610;

            Font headerFont = new Font("Montserrat", 10, FontStyle.Bold);
            Font dataFont = new Font("Montserrat", 8);
            Font mainFont = new Font("Montserrat", 8 , FontStyle.Bold);

            e.Graphics.DrawString("КВИТАНЦИЯ ПО ЗАКАЗУ № " + orderId.ToString(), headerFont, Brushes.Black, new PointF(10, yPos));

            bool isClientEntered = false;
            bool isAddressEntered = false;
            bool isTableHeaderEnered = false;

            string firstName;
            string surname;
            string street;
            string house;
            string apart;
            string totalprice = "";
            string date = "";
            string dish;
            string count;
            string price;
            string totalDishPrice;

            int countStrings = 2;

            e.HasMorePages = false;

            while (reader.Read())
            {
                firstName = reader[7].ToString();
                surname = reader[8].ToString();
                street = reader[9].ToString();
                house = reader[10].ToString();
                apart = reader[11].ToString();
                totalprice = reader[3].ToString();
                date = reader[2].ToString();
                dish = reader[5].ToString();
                count = reader[6].ToString();
                price = reader[12].ToString();
                totalDishPrice = reader[13].ToString();

                if (isClientEntered == false)
                {
                    yPos += 30;
                    e.Graphics.DrawString("Заказчик:     " + firstName + " " + surname, dataFont, Brushes.Black, new PointF(10, yPos));
                    isClientEntered = true;
                    countStrings++;
                }

                if (isAddressEntered == false)
                {
                    yPos += 20;
                    e.Graphics.DrawString("Адрес:     " + street + ", д. " + house + ", пом. " + apart, dataFont, Brushes.Black, new PointF(10, yPos));
                    isAddressEntered = true;
                    countStrings++;
                }
                
                if (isTableHeaderEnered == false)
                {
                    yPos += 50;
                    e.Graphics.DrawString("Блюдо", mainFont, Brushes.Black, new PointF(titleX, yPos));
                    e.Graphics.DrawString("Кол-во", mainFont, Brushes.Black, new PointF(countX, yPos));
                    e.Graphics.DrawString("Цена", mainFont, Brushes.Black, new PointF(priceX, yPos));
                    e.Graphics.DrawString("Сумма", mainFont, Brushes.Black, new PointF(dishespriceX, yPos));
                    isTableHeaderEnered = true;
                    countStrings++;
                }

                yPos += 20;
                e.Graphics.DrawString(dish, dataFont, Brushes.Black, new PointF(titleX, yPos));
                e.Graphics.DrawString(count, dataFont, Brushes.Black, new PointF(countX, yPos));
                e.Graphics.DrawString(price, dataFont, Brushes.Black, new PointF(priceX, yPos));
                e.Graphics.DrawString(totalDishPrice, dataFont, Brushes.Black, new PointF(dishespriceX, yPos));

                countStrings ++;
                lastRowNumber++;

                if (countStrings >= 30)
                {
                    break;
                }
            }

            yPos += 50;
            e.Graphics.DrawString("Итого: " + totalprice + " руб., коп.", mainFont, Brushes.Black, new PointF(10, yPos));

            yPos += 50;
            e.Graphics.DrawString("Дата: " + date, dataFont, Brushes.Black, new PointF(10, yPos));

            yPos += 50;
            e.Graphics.DrawString("Оплатил заказчик:   ________________________________", dataFont, Brushes.Black, new PointF(10, yPos));
            yPos += 50;
            e.Graphics.DrawString("Получил кассир:     ________________________________", dataFont, Brushes.Black, new PointF(10, yPos));

            countStrings += 4;

            if (countStrings >= 30)
            {
                e.HasMorePages = true;
            }

            reader.Close();
            sqlConnection.Close();
        }

        //бланк заказа
        private void form_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Выберите номер заказа!");
            }
            else
            {
                try
                {
                    lastRowNumber = 0;
                    PrintDocument printDoc = new PrintDocument();
                    printDoc.DocumentName = "Бланк заказа";
                    printDoc.PrintPage += printDocument2_PrintPage;
                    PrintPreviewDialog previewDlg = new PrintPreviewDialog();
                    previewDlg.Document = printDoc;
                    previewDlg.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
                }
            }
        }

        //печать бланка
        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            sqlConnection.Open();

            int orderId = Convert.ToInt32(textBox2.Text);

            SqlCommand command = new SqlCommand("SELECT " +
                "O.Id_Order, " +
                "O.Id_Client, " +
                "O.Order_DateTime, " +
                "OD.Id_Dish, " +
                "D.Title, " +
                "OD.DishQuantity, " +
                "C.FirstName, " +
                "C.Surname, " +
                "C.Street, " +
                "C.House, " +
                "C.Apartment, " +
                "DP.Id_Point " +
                "FROM Orders O " +
                "JOIN " +
                "Orders_Details OD ON O.Id_Order = OD.Id_Order " +
                "JOIN " +
                "Clients C ON O.Id_Client = C.Id_Client " +
                "JOIN " +
                "Dishes D ON OD.Id_Dish = D.Id_Dish " +
                "JOIN " +
                "DeliveryPoints DP ON C.Street = DP.StreetName " +
                "WHERE O.Id_Order = @orderId; ", sqlConnection);

            command.Parameters.AddWithValue("@orderId", orderId);

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
            Font mainFont = new Font("Montserrat", 8, FontStyle.Bold);

            e.Graphics.DrawString("БЛАНК ЗАКАЗА № " + orderId.ToString(), headerFont, Brushes.Black, new PointF(10, yPos));

            bool isClientEntered = false;
            bool isAddressEntered = false;
            bool isPointEntered = false;
            bool isTableHeaderEntered = false;

            string firstName;
            string surname;
            string street;
            string house;
            string apart;
            string date = "";
            string dish;
            string count;
            string point;

            int countStrings = 2;

            e.HasMorePages = false;

            while (reader.Read())
            {
                firstName = reader[6].ToString();
                surname = reader[7].ToString();
                street = reader[8].ToString();
                house = reader[9].ToString();
                apart = reader[10].ToString();
                date = reader[2].ToString();
                dish = reader[4].ToString();
                count = reader[5].ToString();
                point = reader[11].ToString();

                if (isClientEntered == false)
                {
                    yPos += 30;
                    e.Graphics.DrawString("Получатель:     " + firstName + " " + surname, dataFont, Brushes.Black, new PointF(10, yPos));
                    isClientEntered = true;
                    countStrings++;
                }

                if (isAddressEntered == false)
                {
                    yPos += 20;
                    e.Graphics.DrawString("Адрес:     " + street + ", д. " + house + ", пом. " + apart, dataFont, Brushes.Black, new PointF(10, yPos));
                    isAddressEntered = true;
                    countStrings++;
                }

                if (isPointEntered == false)
                {
                    yPos += 20;
                    e.Graphics.DrawString("Участок:     " + point, dataFont, Brushes.Black, new PointF(10, yPos));
                    isPointEntered = true;
                    countStrings++;
                }

                if (isTableHeaderEntered == false)
                {
                    yPos += 50;
                    e.Graphics.DrawString("Блюдо", mainFont, Brushes.Black, new PointF(titleX, yPos));
                    e.Graphics.DrawString("Кол-во", mainFont, Brushes.Black, new PointF(countX, yPos));
                    isTableHeaderEntered = true;
                    countStrings++;
                }

                yPos += 20;
                e.Graphics.DrawString(dish, dataFont, Brushes.Black, new PointF(titleX, yPos));
                e.Graphics.DrawString(count, dataFont, Brushes.Black, new PointF(countX, yPos));

                countStrings++;
                lastRowNumber++;

                if (countStrings >= 30)
                {
                    break;
                }
            }

            yPos += 50;
            e.Graphics.DrawString("Дата: " + date, dataFont, Brushes.Black, new PointF(10, yPos));

            yPos += 50;
            e.Graphics.DrawString("Собрал заказ:   ________________________________", dataFont, Brushes.Black, new PointF(10, yPos));

            if (countStrings >= 30)
            {
                e.HasMorePages = true;
            }

            reader.Close();
            sqlConnection.Close();
        }

        private void filter_button_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введите номер заказа!");
            }
            else
            {
                dataGridView1.Rows.Clear();

                int orderId = Convert.ToInt32(textBox2.Text);

                try
                {
                    sqlConnection.Open();
                    sqlConnection2.Open();

                    SqlCommand com = new SqlCommand("SELECT * FROM Orders WHERE Id_Order = @orderId", sqlConnection);
                    com.Parameters.AddWithValue("@orderId", orderId);

                    SqlDataReader reader = com.ExecuteReader();

                    int idOrder;
                    int idClient;
                    DateTime orderDate;
                    decimal orderPrice;
                    string clientFullName;

                    while (reader.Read())
                    {
                        idOrder = reader.GetInt32(0);
                        idClient = reader.GetInt32(1);
                        orderDate = reader.GetDateTime(2);
                        orderPrice = reader.GetDecimal(3);

                        using (SqlCommand command = new SqlCommand("SELECT Surname + ' ' + FirstName AS FullName FROM Clients WHERE Id_Client = @id", sqlConnection2))
                        {
                            command.Parameters.AddWithValue("@Id", idClient);
                            clientFullName = command.ExecuteScalar()?.ToString();
                        }

                        dataGridView1.Rows.Add(idOrder, clientFullName, orderDate, orderPrice);
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
        }

        private void filter_date_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите дату!");
            }
            else
            {
                dataGridView1.Rows.Clear();

                try
                {
                    DateTime date = DateTime.Parse(textBox1.Text);

                    sqlConnection.Open();
                    sqlConnection2.Open();

                    SqlCommand com = new SqlCommand("SELECT * FROM Orders WHERE CONVERT(DATE, Order_DateTime) = CONVERT(DATE, @date)", sqlConnection);
                    com.Parameters.AddWithValue("@date", date);

                    SqlDataReader reader = com.ExecuteReader();

                    int idOrder;
                    int idClient;
                    DateTime orderDate;
                    decimal orderPrice;
                    string clientFullName;

                    while (reader.Read())
                    {
                        idOrder = reader.GetInt32(0);
                        idClient = reader.GetInt32(1);
                        orderDate = reader.GetDateTime(2);
                        orderPrice = reader.GetDecimal(3);

                        using (SqlCommand command = new SqlCommand("SELECT Surname + ' ' + FirstName AS FullName FROM Clients WHERE Id_Client = @id", sqlConnection2))
                        {
                            command.Parameters.AddWithValue("@Id", idClient);
                            clientFullName = command.ExecuteScalar()?.ToString();
                        }

                        dataGridView1.Rows.Add(idOrder, clientFullName, orderDate, orderPrice);
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
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                return;
            }
            else
            {
                e.Handled = true; // Запретить ввод других символов
            }
        }
        //список продуктов на день печать
        private void products_list_btn_Click(object sender, EventArgs e)
        {
            try
            {
                lastRowNumber = 0;
                PrintDocument printDoc = new PrintDocument();
                printDoc.DocumentName = "Список продуктов на день";
                printDoc.PrintPage += printDocument4_PrintPage;
                PrintPreviewDialog previewDlg = new PrintPreviewDialog();
                previewDlg.Document = printDoc;
                previewDlg.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
        }

        //список блюд на день печать
        private void dishes_list_btn_Click(object sender, EventArgs e)
        {
            try
            {
                lastRowNumber = 0;
                PrintDocument printDoc = new PrintDocument();
                printDoc.DocumentName = "Список блюд на день";
                printDoc.PrintPage += printDocument3_PrintPage;
                PrintPreviewDialog previewDlg = new PrintPreviewDialog();
                previewDlg.Document = printDoc;
                previewDlg.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
        }

        //печать блюд на день
        private void printDocument3_PrintPage(object sender, PrintPageEventArgs e)
        {
            DateTime currentDate = DateTime.Today;

            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT d.Title, SUM(od.DishQuantity) AS TotalQuantity " +
                "FROM Orders o " +
                "JOIN Orders_Details od ON o.Id_Order = od.Id_Order " +
                "JOIN Dishes d ON od.Id_Dish = d.Id_Dish " +
                "WHERE CONVERT(DATE, o.Order_DateTime) = @today " +
                "GROUP BY d.Title;", sqlConnection);

            command.Parameters.AddWithValue("@today", currentDate);

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

            e.Graphics.DrawString("СПИСОК ЗАКАЗАННЫХ БЛЮД НА " + currentDate.ToString("dd.MM.yyyy"), headerFont, Brushes.Black, new PointF(10, yPos));

            yPos += 30;

            int count = 2;

            string dishTile;
            string quantity;

            e.HasMorePages = false;

            while (reader.Read())
            {
                dishTile = reader[0].ToString();
                quantity = reader[1].ToString();

                e.Graphics.DrawString(dishTile, dataFont, Brushes.Black, new PointF(titleX, yPos));
                e.Graphics.DrawString(quantity, dataFont, Brushes.Black, new PointF(countX, yPos));
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

        //печать списка продуктов
        private void printDocument4_PrintPage(object sender, PrintPageEventArgs e)
        {
            DateTime currentDate = DateTime.Today;

            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT s.Title AS ProductTitle, " +
                "SUM(od.DishQuantity * pid.Quantity) AS TotalQuantity " +
                "FROM Orders o " +
                "JOIN Orders_Details od ON o.Id_Order = od.Id_Order " +
                "JOIN Products_In_Dishes pid ON od.Id_Dish = pid.Id_Dish " +
                "JOIN Stock s ON pid.Id_Product = s.Id_Product " +
                "WHERE CONVERT(DATE, o.Order_DateTime) = @today " +
                "GROUP BY s.Title; ", sqlConnection);

            command.Parameters.AddWithValue("@today", currentDate);

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

            e.Graphics.DrawString("СПИСОК ПРОДУКТОВ НА " + currentDate.ToString("dd.MM.yyyy"), headerFont, Brushes.Black, new PointF(10, yPos));

            yPos += 30;

            int count = 2;

            string productTile;
            string quantity;

            e.HasMorePages = false;

            while (reader.Read())
            {
                productTile = reader[0].ToString();
                quantity = reader[1].ToString();

                e.Graphics.DrawString(productTile, dataFont, Brushes.Black, new PointF(titleX, yPos));
                e.Graphics.DrawString(quantity + " кг", dataFont, Brushes.Black, new PointF(countX, yPos));
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
