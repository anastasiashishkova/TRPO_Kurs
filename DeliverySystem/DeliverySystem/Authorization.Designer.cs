
namespace DeliverySystem
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.label1 = new System.Windows.Forms.Label();
            this.login_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enter_button = new System.Windows.Forms.Button();
            this.show_hide_button = new System.Windows.Forms.Button();
            this.error_messege = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // login_box
            // 
            this.login_box.BackColor = System.Drawing.SystemColors.Control;
            this.login_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_box.Location = new System.Drawing.Point(127, 129);
            this.login_box.MaxLength = 20;
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(221, 23);
            this.login_box.TabIndex = 1;
            this.login_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_box_KeyPress);
            // 
            // password_box
            // 
            this.password_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_box.BackColor = System.Drawing.SystemColors.Control;
            this.password_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_box.Location = new System.Drawing.Point(127, 196);
            this.password_box.MaxLength = 20;
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(195, 23);
            this.password_box.TabIndex = 2;
            this.password_box.UseSystemPasswordChar = true;
            this.password_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_box_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(124, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.DarkOrange;
            this.enter_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_button.ForeColor = System.Drawing.SystemColors.Control;
            this.enter_button.Location = new System.Drawing.Point(127, 259);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(221, 48);
            this.enter_button.TabIndex = 5;
            this.enter_button.Text = "Войти";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // show_hide_button
            // 
            this.show_hide_button.BackgroundImage = global::DeliverySystem.Properties.Resources.free_icon_hide_2767146;
            this.show_hide_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show_hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_hide_button.Location = new System.Drawing.Point(325, 196);
            this.show_hide_button.Name = "show_hide_button";
            this.show_hide_button.Size = new System.Drawing.Size(23, 23);
            this.show_hide_button.TabIndex = 6;
            this.show_hide_button.UseVisualStyleBackColor = true;
            this.show_hide_button.Click += new System.EventHandler(this.show_hide_button_Click);
            // 
            // error_messege
            // 
            this.error_messege.AutoSize = true;
            this.error_messege.ForeColor = System.Drawing.Color.Red;
            this.error_messege.Location = new System.Drawing.Point(134, 238);
            this.error_messege.Name = "error_messege";
            this.error_messege.Size = new System.Drawing.Size(207, 18);
            this.error_messege.TabIndex = 7;
            this.error_messege.Text = "Неверный логин или пароль!";
            this.error_messege.Visible = false;
            // 
            // Authorization
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.error_messege);
            this.Controls.Add(this.show_hide_button);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskDine";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button show_hide_button;
        private System.Windows.Forms.Label error_messege;
    }
}

