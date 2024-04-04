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
    public partial class UpdateOrder : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlConnection sqlConnection2 = null;
        private int orderId;
        private string sum;

        public UpdateOrder(int orderId)
        {
            this.orderId = orderId;

            InitializeComponent();
        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {
            label4.Text = "Номер заказа: " + orderId;

            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);
                sqlConnection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);

                sqlConnection.Open();
                sqlConnection2.Open();

                SqlCommand cmd = new SqlCommand("SELECT Id_Dish, DishQuantity FROM Orders_Details WHERE Id_Order = @orderId", sqlConnection);
                cmd.Parameters.AddWithValue("@orderId", orderId);

                SqlDataReader reader = cmd.ExecuteReader();

                int idDish;
                string dish;
                int quantity;

                while (reader.Read())
                {
                    idDish = reader.GetInt32(0);
                    quantity = reader.GetInt32(1);

                    using (SqlCommand command = new SqlCommand("SELECT Title FROM Dishes WHERE Id_Dish = @Id", sqlConnection2))
                    {
                        command.Parameters.AddWithValue("@Id", idDish);
                        dish = command.ExecuteScalar()?.ToString();
                    }

                    dataGridView1.Rows.Add(dish, quantity);
                }

                reader.Close();
                sqlConnection2.Close();

                cmd = new SqlCommand("SELECT Order_Price FROM Orders WHERE Id_Order = @Id", sqlConnection);
                cmd.Parameters.AddWithValue("@Id", orderId);
                sum = cmd.ExecuteScalar()?.ToString();

                label1.Text = "Итоговая сумма: " + sum + " руб.";

                int idClient;

                cmd = new SqlCommand("SELECT Id_Client FROM Orders WHERE Id_Order = @Id", sqlConnection);
                cmd.Parameters.AddWithValue("@Id", orderId);
                idClient = Convert.ToInt32(cmd.ExecuteScalar());

                cmd = new SqlCommand("SELECT Surname + ' ' + FirstName AS FullName FROM Clients WHERE Id_Client = @Id", sqlConnection);
                cmd.Parameters.AddWithValue("@Id", idClient);
                string client = cmd.ExecuteScalar()?.ToString();

                textBox1.Text = client;

                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
