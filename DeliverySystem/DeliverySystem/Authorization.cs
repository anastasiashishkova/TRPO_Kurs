using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DeliverySystem
{
    public partial class Authorization : Form
    {
        private SqlConnection sqlConnection = null;
        private int show_click;

        string role;

        public Authorization()
        {
            InitializeComponent();
        }

        private void show_hide_button_Click(object sender, EventArgs e)
        {
            show_click++;

            if (show_click % 2 == 0)
            {
                password_box.UseSystemPasswordChar = true;
                show_hide_button.BackgroundImage = Properties.Resources.free_icon_hide_2767146;
            }
            else
            {
                password_box.UseSystemPasswordChar = false;
                show_hide_button.BackgroundImage = Properties.Resources.free_icon_eye_158746;
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            show_click = 0;
            try
            {
                //экземпляр класса для подключения к БД
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliverySystemDB"].ConnectionString);
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к базе данных!\nОбратитесь к системному администратору.");
            }
        }

        private void login_box_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '_')
            {
                // Разрешаем буквы, цифры и символы управления (например, Backspace)
                return;
            }
            else
            {
                // Блокируем все остальные символы
                e.Handled = true;
            }
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("SELECT Login, Password, Role FROM Employees WHERE Login = @login AND Password = @password", sqlConnection);
                command.Parameters.AddWithValue("@login", login_box.Text);
                command.Parameters.AddWithValue("@password", password_box.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    error_messege.Visible = false;

                    while (reader.Read())
                    {
                        role = reader.GetString(2);
                        if (role == "manager")
                        {
                            MainMenuManager menuManager = new MainMenuManager();
                            menuManager.Show();

                        }
                        else if (role == "dispatcher")
                        {
                            MainMenuDispatcher mainDispatcher = new MainMenuDispatcher();
                            mainDispatcher.Show();
                        }
                        else
                        {
                            MainMenuCalculator mainCalculator = new MainMenuCalculator();
                            mainCalculator.Show();
                        }

                        this.Hide();
                    }
                }
                else
                {
                    error_messege.Visible = true;
                }

                reader.Close();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка получения данных!\nОбратитесь к системному администратору.");
            }
        }
    }
}
