
namespace DeliverySystem
{
    partial class MainMenuManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuManager));
            this.title_label = new System.Windows.Forms.Label();
            this.role_label = new System.Windows.Forms.Label();
            this.orders_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.menu_button = new System.Windows.Forms.Button();
            this.dishes_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.Location = new System.Drawing.Point(107, 61);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(288, 29);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Главное меню DeskDine";
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.role_label.Location = new System.Drawing.Point(164, 100);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(164, 18);
            this.role_label.TabIndex = 4;
            this.role_label.Text = "Ваша роль:  Менеджер";
            // 
            // orders_button
            // 
            this.orders_button.BackColor = System.Drawing.Color.DarkOrange;
            this.orders_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.orders_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orders_button.ForeColor = System.Drawing.SystemColors.Control;
            this.orders_button.Location = new System.Drawing.Point(167, 330);
            this.orders_button.Name = "orders_button";
            this.orders_button.Size = new System.Drawing.Size(161, 48);
            this.orders_button.TabIndex = 7;
            this.orders_button.Text = "Заказы";
            this.orders_button.UseVisualStyleBackColor = false;
            this.orders_button.Click += new System.EventHandler(this.orders_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.DarkOrange;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.Control;
            this.exit_button.Location = new System.Drawing.Point(167, 451);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(161, 48);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // menu_button
            // 
            this.menu_button.BackColor = System.Drawing.Color.DarkOrange;
            this.menu_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_button.ForeColor = System.Drawing.SystemColors.Control;
            this.menu_button.Location = new System.Drawing.Point(167, 162);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(161, 48);
            this.menu_button.TabIndex = 5;
            this.menu_button.Text = "Меню";
            this.menu_button.UseVisualStyleBackColor = false;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // dishes_button
            // 
            this.dishes_button.BackColor = System.Drawing.Color.DarkOrange;
            this.dishes_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.dishes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dishes_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishes_button.ForeColor = System.Drawing.SystemColors.Control;
            this.dishes_button.Location = new System.Drawing.Point(167, 246);
            this.dishes_button.Name = "dishes_button";
            this.dishes_button.Size = new System.Drawing.Size(161, 48);
            this.dishes_button.TabIndex = 6;
            this.dishes_button.Text = "Блюда";
            this.dishes_button.UseVisualStyleBackColor = false;
            this.dishes_button.Click += new System.EventHandler(this.dishes_button_Click);
            // 
            // MainMenuManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(498, 561);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.orders_button);
            this.Controls.Add(this.dishes_button);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.role_label);
            this.Controls.Add(this.title_label);
            this.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskDine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.Button orders_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Button dishes_button;
    }
}