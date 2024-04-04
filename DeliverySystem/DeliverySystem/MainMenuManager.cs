using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliverySystem
{
    public partial class MainMenuManager : Form
    {

        public MainMenuManager()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Show();
        }

        private void dishes_button_Click(object sender, EventArgs e)
        {
            Dishes dishes = new Dishes();
            this.Hide();
            dishes.ShowDialog();
            this.Show();
        }

        private void orders_button_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            this.Hide();
            orders.ShowDialog();
            this.Show();
        }
    }
}
