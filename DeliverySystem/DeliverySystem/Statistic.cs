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
    public partial class Statistic : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlConnection sqlConnection2 = null;

        public Statistic()
        {
            InitializeComponent();
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Statistic_Load(object sender, EventArgs e)
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

            int currentYear = DateTime.Now.Year;
            string DishName = "";
            int idDish, quantity;

            sqlConnection.Open();
            sqlConnection2.Open();

            SqlCommand command = new SqlCommand("SELECT od.Id_Dish, SUM(od.DishQuantity) AS TotalQuantity " +
                "FROM Orders_Details od " +
                "JOIN Orders o ON od.Id_Order = o.Id_Order " +
                "WHERE YEAR(o.Order_DateTime) = @currYear " +
                "GROUP BY od.Id_Dish " +
                "ORDER BY TotalQuantity DESC", sqlConnection);
            command.Parameters.AddWithValue("@currYear", currentYear);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                idDish = reader.GetInt32(0);
                quantity = reader.GetInt32(1);

                using (SqlCommand cmd = new SqlCommand("SELECT Title FROM Dishes WHERE Id_Dish = @idDish", sqlConnection2))
                {
                    cmd.Parameters.AddWithValue("@idDish", idDish);
                    DishName = cmd.ExecuteScalar()?.ToString();
                }

                dataGridView1.Rows.Add(DishName, quantity);
            }

            reader.Close();
            sqlConnection2.Close();
            sqlConnection.Close();
        }
    }
}
