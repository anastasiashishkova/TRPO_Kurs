
namespace DeliverySystem
{
    partial class Dishes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dishes));
            this.title_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dish_details_btn = new System.Windows.Forms.Button();
            this.price_btn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.weight_btn = new System.Windows.Forms.TextBox();
            this.change_button = new System.Windows.Forms.Button();
            this.delete_dish_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title_box = new System.Windows.Forms.TextBox();
            this.refresh_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.add_dish_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dishes_list = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
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
            this.title_label.Size = new System.Drawing.Size(89, 29);
            this.title_label.TabIndex = 2;
            this.title_label.Text = "Блюда";
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
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(39, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(737, 259);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Артикул блюда";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Категория";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Вес, г";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Цена, руб.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dish_details_btn);
            this.panel1.Controls.Add(this.price_btn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.weight_btn);
            this.panel1.Controls.Add(this.change_button);
            this.panel1.Controls.Add(this.delete_dish_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.title_box);
            this.panel1.Controls.Add(this.refresh_button);
            this.panel1.Controls.Add(this.filter_button);
            this.panel1.Controls.Add(this.add_dish_button);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(39, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 284);
            this.panel1.TabIndex = 11;
            // 
            // dish_details_btn
            // 
            this.dish_details_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.dish_details_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.dish_details_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dish_details_btn.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dish_details_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.dish_details_btn.Location = new System.Drawing.Point(426, 210);
            this.dish_details_btn.Name = "dish_details_btn";
            this.dish_details_btn.Size = new System.Drawing.Size(286, 41);
            this.dish_details_btn.TabIndex = 21;
            this.dish_details_btn.Text = "Состав блюда";
            this.dish_details_btn.UseVisualStyleBackColor = false;
            this.dish_details_btn.Click += new System.EventHandler(this.dish_details_btn_Click);
            // 
            // price_btn
            // 
            this.price_btn.Location = new System.Drawing.Point(426, 104);
            this.price_btn.MaxLength = 13;
            this.price_btn.Name = "price_btn";
            this.price_btn.Size = new System.Drawing.Size(286, 23);
            this.price_btn.TabIndex = 20;
            this.price_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_btn_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Цена, руб.:";
            // 
            // weight_btn
            // 
            this.weight_btn.Location = new System.Drawing.Point(426, 43);
            this.weight_btn.MaxLength = 13;
            this.weight_btn.Name = "weight_btn";
            this.weight_btn.Size = new System.Drawing.Size(286, 23);
            this.weight_btn.TabIndex = 18;
            this.weight_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_btn_KeyPress);
            // 
            // change_button
            // 
            this.change_button.BackColor = System.Drawing.Color.DarkOrange;
            this.change_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.change_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_button.ForeColor = System.Drawing.SystemColors.Control;
            this.change_button.Location = new System.Drawing.Point(426, 150);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(286, 41);
            this.change_button.TabIndex = 15;
            this.change_button.Text = "Изменить";
            this.change_button.UseVisualStyleBackColor = false;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // delete_dish_button
            // 
            this.delete_dish_button.BackColor = System.Drawing.Color.DarkOrange;
            this.delete_dish_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.delete_dish_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_dish_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_dish_button.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_dish_button.Location = new System.Drawing.Point(24, 210);
            this.delete_dish_button.Name = "delete_dish_button";
            this.delete_dish_button.Size = new System.Drawing.Size(286, 41);
            this.delete_dish_button.TabIndex = 11;
            this.delete_dish_button.Text = "Удалить";
            this.delete_dish_button.UseVisualStyleBackColor = false;
            this.delete_dish_button.Click += new System.EventHandler(this.delete_dish_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Вес, г:";
            // 
            // title_box
            // 
            this.title_box.Location = new System.Drawing.Point(24, 43);
            this.title_box.Name = "title_box";
            this.title_box.Size = new System.Drawing.Size(286, 23);
            this.title_box.TabIndex = 16;
            this.title_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.title_box_KeyPress);
            // 
            // refresh_button
            // 
            this.refresh_button.BackgroundImage = global::DeliverySystem.Properties.Resources.free_icon_refresh_button_4856659;
            this.refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.refresh_button.Location = new System.Drawing.Point(348, 42);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(26, 26);
            this.refresh_button.TabIndex = 14;
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.BackgroundImage = global::DeliverySystem.Properties.Resources.free_icon_filter_2676824;
            this.filter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filter_button.Location = new System.Drawing.Point(316, 42);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(26, 26);
            this.filter_button.TabIndex = 12;
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // add_dish_button
            // 
            this.add_dish_button.BackColor = System.Drawing.Color.DarkOrange;
            this.add_dish_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.add_dish_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_dish_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_dish_button.ForeColor = System.Drawing.SystemColors.Control;
            this.add_dish_button.Location = new System.Drawing.Point(24, 150);
            this.add_dish_button.Name = "add_dish_button";
            this.add_dish_button.Size = new System.Drawing.Size(286, 41);
            this.add_dish_button.TabIndex = 10;
            this.add_dish_button.Text = "Добавить";
            this.add_dish_button.UseVisualStyleBackColor = false;
            this.add_dish_button.Click += new System.EventHandler(this.add_dish_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Категория:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox3.Location = new System.Drawing.Point(24, 101);
            this.comboBox3.MaxDropDownItems = 5;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(286, 26);
            this.comboBox3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название:";
            // 
            // dishes_list
            // 
            this.dishes_list.BackColor = System.Drawing.Color.DarkOrange;
            this.dishes_list.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.dishes_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dishes_list.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishes_list.ForeColor = System.Drawing.SystemColors.Control;
            this.dishes_list.Location = new System.Drawing.Point(490, 30);
            this.dishes_list.Name = "dishes_list";
            this.dishes_list.Size = new System.Drawing.Size(286, 41);
            this.dishes_list.TabIndex = 22;
            this.dishes_list.Text = "Прейскурант";
            this.dishes_list.UseVisualStyleBackColor = false;
            this.dishes_list.Click += new System.EventHandler(this.dishes_list_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Dishes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 680);
            this.Controls.Add(this.dishes_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title_label);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dishes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " DeskDine";
            this.Load += new System.EventHandler(this.Dishes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.Button delete_dish_button;
        private System.Windows.Forms.Button add_dish_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox price_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weight_btn;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_box;
        private System.Windows.Forms.Button dish_details_btn;
        private System.Windows.Forms.Button dishes_list;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}