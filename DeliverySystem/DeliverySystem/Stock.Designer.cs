
namespace DeliverySystem
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.title_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.change_btn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.filter_day_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.title_label.Size = new System.Drawing.Size(83, 29);
            this.title_label.TabIndex = 10;
            this.title_label.Text = "Склад";
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
            this.Column3});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(39, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(737, 259);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.change_btn);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.refresh_button);
            this.panel1.Controls.Add(this.filter_day_button);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(39, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 201);
            this.panel1.TabIndex = 15;
            // 
            // change_btn
            // 
            this.change_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.change_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_btn.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.change_btn.Location = new System.Drawing.Point(465, 134);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(244, 41);
            this.change_btn.TabIndex = 19;
            this.change_btn.Text = "Изменить";
            this.change_btn.UseVisualStyleBackColor = false;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(24, 150);
            this.textBox3.MaxLength = 10;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(319, 23);
            this.textBox3.TabIndex = 18;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 95);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 23);
            this.textBox2.TabIndex = 17;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 41);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 23);
            this.textBox1.TabIndex = 16;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Количество:";
            // 
            // refresh_button
            // 
            this.refresh_button.BackgroundImage = global::DeliverySystem.Properties.Resources.free_icon_refresh_button_4856659;
            this.refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.refresh_button.Location = new System.Drawing.Point(381, 40);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(26, 26);
            this.refresh_button.TabIndex = 14;
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // filter_day_button
            // 
            this.filter_day_button.BackgroundImage = global::DeliverySystem.Properties.Resources.free_icon_filter_2676824;
            this.filter_day_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filter_day_button.Location = new System.Drawing.Point(349, 40);
            this.filter_day_button.Name = "filter_day_button";
            this.filter_day_button.Size = new System.Drawing.Size(26, 26);
            this.filter_day_button.TabIndex = 12;
            this.filter_day_button.UseVisualStyleBackColor = true;
            this.filter_day_button.Click += new System.EventHandler(this.filter_day_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.DarkOrange;
            this.delete_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_button.Location = new System.Drawing.Point(465, 79);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(244, 41);
            this.delete_button.TabIndex = 11;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.DarkOrange;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.ForeColor = System.Drawing.SystemColors.Control;
            this.add_button.Location = new System.Drawing.Point(465, 25);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(244, 41);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Цена закупки за кг:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название продукта:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Продукт";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена закупки за кг";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Кол-во на складе, кг";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Stock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title_label);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskDine";
            this.Load += new System.EventHandler(this.Stock_Load);
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
        private System.Windows.Forms.Button filter_day_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}