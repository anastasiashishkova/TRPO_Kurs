
namespace DeliverySystem
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.title_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.print_button = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_dish_button = new System.Windows.Forms.Button();
            this.delete_dish_button = new System.Windows.Forms.Button();
            this.filter_day_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.Location = new System.Drawing.Point(34, 32);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(81, 29);
            this.title_label.TabIndex = 2;
            this.title_label.Text = "Меню";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(39, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(737, 259);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "День недели";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Блюдо";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // print_button
            // 
            this.print_button.BackColor = System.Drawing.Color.DarkOrange;
            this.print_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.print_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.print_button.ForeColor = System.Drawing.SystemColors.Control;
            this.print_button.Location = new System.Drawing.Point(598, 20);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(178, 41);
            this.print_button.TabIndex = 13;
            this.print_button.Text = "Распечатать меню";
            this.print_button.UseVisualStyleBackColor = false;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Блюдо:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(24, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(395, 26);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox3.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница"});
            this.comboBox3.Location = new System.Drawing.Point(24, 152);
            this.comboBox3.MaxDropDownItems = 5;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(395, 26);
            this.comboBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "День недели:";
            // 
            // add_dish_button
            // 
            this.add_dish_button.BackColor = System.Drawing.Color.DarkOrange;
            this.add_dish_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.add_dish_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_dish_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_dish_button.ForeColor = System.Drawing.SystemColors.Control;
            this.add_dish_button.Location = new System.Drawing.Point(570, 43);
            this.add_dish_button.Name = "add_dish_button";
            this.add_dish_button.Size = new System.Drawing.Size(139, 41);
            this.add_dish_button.TabIndex = 10;
            this.add_dish_button.Text = "Добавить";
            this.add_dish_button.UseVisualStyleBackColor = false;
            this.add_dish_button.Click += new System.EventHandler(this.add_dish_button_Click);
            // 
            // delete_dish_button
            // 
            this.delete_dish_button.BackColor = System.Drawing.Color.DarkOrange;
            this.delete_dish_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.delete_dish_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_dish_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_dish_button.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_dish_button.Location = new System.Drawing.Point(570, 110);
            this.delete_dish_button.Name = "delete_dish_button";
            this.delete_dish_button.Size = new System.Drawing.Size(139, 41);
            this.delete_dish_button.TabIndex = 11;
            this.delete_dish_button.Text = "Удалить";
            this.delete_dish_button.UseVisualStyleBackColor = false;
            this.delete_dish_button.Click += new System.EventHandler(this.delete_dish_button_Click);
            // 
            // filter_day_button
            // 
            this.filter_day_button.BackgroundImage = global::DeliverySystem.Properties.Resources.free_icon_filter_2676824;
            this.filter_day_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filter_day_button.Location = new System.Drawing.Point(426, 152);
            this.filter_day_button.Name = "filter_day_button";
            this.filter_day_button.Size = new System.Drawing.Size(26, 26);
            this.filter_day_button.TabIndex = 12;
            this.filter_day_button.UseVisualStyleBackColor = true;
            this.filter_day_button.Click += new System.EventHandler(this.filter_day_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.BackgroundImage = global::DeliverySystem.Properties.Resources.free_icon_refresh_button_4856659;
            this.refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.refresh_button.Location = new System.Drawing.Point(458, 152);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(26, 26);
            this.refresh_button.TabIndex = 14;
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.refresh_button);
            this.panel1.Controls.Add(this.filter_day_button);
            this.panel1.Controls.Add(this.delete_dish_button);
            this.panel1.Controls.Add(this.add_dish_button);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(39, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 201);
            this.panel1.TabIndex = 10;
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 599);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title_label);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskDine";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_dish_button;
        private System.Windows.Forms.Button delete_dish_button;
        private System.Windows.Forms.Button filter_day_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Panel panel1;
    }
}