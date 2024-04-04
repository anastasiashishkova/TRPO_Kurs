
namespace DeliverySystem
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.title_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.receipt_btn = new System.Windows.Forms.Button();
            this.filter_date = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dishes_list_btn = new System.Windows.Forms.Button();
            this.products_list_btn = new System.Windows.Forms.Button();
            this.form_btn = new System.Windows.Forms.Button();
            this.order_details = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.printDocument4 = new System.Drawing.Printing.PrintDocument();
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
            this.title_label.Size = new System.Drawing.Size(96, 29);
            this.title_label.TabIndex = 3;
            this.title_label.Text = "Заказы";
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
            this.Column4});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(39, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(737, 259);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер заказа";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Клиент";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Сумма, руб.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.receipt_btn);
            this.panel1.Controls.Add(this.filter_date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dishes_list_btn);
            this.panel1.Controls.Add(this.products_list_btn);
            this.panel1.Controls.Add(this.form_btn);
            this.panel1.Controls.Add(this.order_details);
            this.panel1.Controls.Add(this.refresh_button);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.filter_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(39, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 294);
            this.panel1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(317, 23);
            this.textBox2.TabIndex = 27;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // receipt_btn
            // 
            this.receipt_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.receipt_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.receipt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receipt_btn.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receipt_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.receipt_btn.Location = new System.Drawing.Point(24, 158);
            this.receipt_btn.Name = "receipt_btn";
            this.receipt_btn.Size = new System.Drawing.Size(349, 41);
            this.receipt_btn.TabIndex = 26;
            this.receipt_btn.Text = "Распечатать квитанцию заказа";
            this.receipt_btn.UseVisualStyleBackColor = false;
            this.receipt_btn.Click += new System.EventHandler(this.receipt_btn_Click);
            // 
            // filter_date
            // 
            this.filter_date.BackgroundImage = global::DeliverySystem.Properties.Resources.free_icon_filter_2676824;
            this.filter_date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filter_date.Location = new System.Drawing.Point(347, 110);
            this.filter_date.Name = "filter_date";
            this.filter_date.Size = new System.Drawing.Size(26, 26);
            this.filter_date.TabIndex = 25;
            this.filter_date.UseVisualStyleBackColor = true;
            this.filter_date.Click += new System.EventHandler(this.filter_date_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Дата:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 23);
            this.textBox1.TabIndex = 23;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dishes_list_btn
            // 
            this.dishes_list_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.dishes_list_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.dishes_list_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dishes_list_btn.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishes_list_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.dishes_list_btn.Location = new System.Drawing.Point(454, 217);
            this.dishes_list_btn.Name = "dishes_list_btn";
            this.dishes_list_btn.Size = new System.Drawing.Size(257, 41);
            this.dishes_list_btn.TabIndex = 22;
            this.dishes_list_btn.Text = "Список блюд на день";
            this.dishes_list_btn.UseVisualStyleBackColor = false;
            this.dishes_list_btn.Click += new System.EventHandler(this.dishes_list_btn_Click);
            // 
            // products_list_btn
            // 
            this.products_list_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.products_list_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.products_list_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_list_btn.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.products_list_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.products_list_btn.Location = new System.Drawing.Point(454, 158);
            this.products_list_btn.Name = "products_list_btn";
            this.products_list_btn.Size = new System.Drawing.Size(257, 41);
            this.products_list_btn.TabIndex = 21;
            this.products_list_btn.Text = "Список продуктов на день";
            this.products_list_btn.UseVisualStyleBackColor = false;
            this.products_list_btn.Click += new System.EventHandler(this.products_list_btn_Click);
            // 
            // form_btn
            // 
            this.form_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.form_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.form_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.form_btn.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.form_btn.Location = new System.Drawing.Point(24, 217);
            this.form_btn.Name = "form_btn";
            this.form_btn.Size = new System.Drawing.Size(349, 41);
            this.form_btn.TabIndex = 20;
            this.form_btn.Text = "Распечатать бланк заказа";
            this.form_btn.UseVisualStyleBackColor = false;
            this.form_btn.Click += new System.EventHandler(this.form_btn_Click);
            // 
            // order_details
            // 
            this.order_details.BackColor = System.Drawing.Color.DarkOrange;
            this.order_details.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.order_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_details.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_details.ForeColor = System.Drawing.SystemColors.Control;
            this.order_details.Location = new System.Drawing.Point(454, 100);
            this.order_details.Name = "order_details";
            this.order_details.Size = new System.Drawing.Size(257, 41);
            this.order_details.TabIndex = 19;
            this.order_details.Text = "Подробности заказа";
            this.order_details.UseVisualStyleBackColor = false;
            this.order_details.Click += new System.EventHandler(this.order_details_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.BackgroundImage = global::DeliverySystem.Properties.Resources.free_icon_refresh_button_4856659;
            this.refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.refresh_button.Location = new System.Drawing.Point(379, 43);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(26, 26);
            this.refresh_button.TabIndex = 14;
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.DarkOrange;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.ForeColor = System.Drawing.SystemColors.Control;
            this.add_button.Location = new System.Drawing.Point(454, 42);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(257, 41);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "Добавить новый заказ";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.BackgroundImage = global::DeliverySystem.Properties.Resources.free_icon_filter_2676824;
            this.filter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filter_button.Location = new System.Drawing.Point(347, 43);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(26, 26);
            this.filter_button.TabIndex = 12;
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер заказа:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(571, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Статистика блюд";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // printDocument4
            // 
            this.printDocument4.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument4_PrintPage);
            // 
            // Orders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title_label);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskDine";
            this.Load += new System.EventHandler(this.Orders_Load);
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
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button order_details;
        private System.Windows.Forms.Button form_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dishes_list_btn;
        private System.Windows.Forms.Button products_list_btn;
        private System.Windows.Forms.Button receipt_btn;
        private System.Windows.Forms.Button filter_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private System.Drawing.Printing.PrintDocument printDocument4;
    }
}