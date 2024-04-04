
namespace DeliverySystem
{
    partial class AddNewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewOrder));
            this.title_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.add_dish_to_list_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.add_client_btn = new System.Windows.Forms.Button();
            this.add_new_order_btn = new System.Windows.Forms.Button();
            this.delete_dish_from_list_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.Location = new System.Drawing.Point(34, 32);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(238, 29);
            this.title_label.TabIndex = 4;
            this.title_label.Text = "Добавление заказа";
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
            this.dataGridView1.Location = new System.Drawing.Point(396, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(380, 262);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Блюдо";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Количество";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сумма, руб.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(39, 151);
            this.comboBox1.MaxDropDownItems = 5;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 26);
            this.comboBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Блюдо:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(39, 226);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Количество:";
            // 
            // add_dish_to_list_button
            // 
            this.add_dish_to_list_button.BackColor = System.Drawing.Color.DarkOrange;
            this.add_dish_to_list_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.add_dish_to_list_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_dish_to_list_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_dish_to_list_button.ForeColor = System.Drawing.SystemColors.Control;
            this.add_dish_to_list_button.Location = new System.Drawing.Point(39, 281);
            this.add_dish_to_list_button.Name = "add_dish_to_list_button";
            this.add_dish_to_list_button.Size = new System.Drawing.Size(317, 41);
            this.add_dish_to_list_button.TabIndex = 23;
            this.add_dish_to_list_button.Text = "Добавить блюдо в заказ";
            this.add_dish_to_list_button.UseVisualStyleBackColor = false;
            this.add_dish_to_list_button.Click += new System.EventHandler(this.add_dish_to_list_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Клиент:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox2.Location = new System.Drawing.Point(39, 433);
            this.comboBox2.MaxDropDownItems = 5;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(672, 26);
            this.comboBox2.TabIndex = 24;
            // 
            // add_client_btn
            // 
            this.add_client_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.add_client_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.add_client_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_client_btn.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_client_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.add_client_btn.Location = new System.Drawing.Point(728, 433);
            this.add_client_btn.Name = "add_client_btn";
            this.add_client_btn.Size = new System.Drawing.Size(48, 26);
            this.add_client_btn.TabIndex = 26;
            this.add_client_btn.Text = "+";
            this.add_client_btn.UseVisualStyleBackColor = false;
            this.add_client_btn.Click += new System.EventHandler(this.add_client_btn_Click);
            // 
            // add_new_order_btn
            // 
            this.add_new_order_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.add_new_order_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.add_new_order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_new_order_btn.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_new_order_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.add_new_order_btn.Location = new System.Drawing.Point(39, 494);
            this.add_new_order_btn.Name = "add_new_order_btn";
            this.add_new_order_btn.Size = new System.Drawing.Size(317, 41);
            this.add_new_order_btn.TabIndex = 27;
            this.add_new_order_btn.Text = "Сохранить новый заказ";
            this.add_new_order_btn.UseVisualStyleBackColor = false;
            this.add_new_order_btn.Click += new System.EventHandler(this.add_new_order_btn_Click);
            // 
            // delete_dish_from_list_btn
            // 
            this.delete_dish_from_list_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.delete_dish_from_list_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.delete_dish_from_list_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_dish_from_list_btn.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_dish_from_list_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_dish_from_list_btn.Location = new System.Drawing.Point(39, 345);
            this.delete_dish_from_list_btn.Name = "delete_dish_from_list_btn";
            this.delete_dish_from_list_btn.Size = new System.Drawing.Size(317, 41);
            this.delete_dish_from_list_btn.TabIndex = 28;
            this.delete_dish_from_list_btn.Text = "Удалить блюдо из заказа";
            this.delete_dish_from_list_btn.UseVisualStyleBackColor = false;
            this.delete_dish_from_list_btn.Click += new System.EventHandler(this.delete_dish_from_list_btn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkOrange;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(459, 494);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(317, 41);
            this.button5.TabIndex = 36;
            this.button5.Text = "Отменить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(396, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Итоговая сумма:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddNewOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 571);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.delete_dish_from_list_btn);
            this.Controls.Add(this.add_new_order_btn);
            this.Controls.Add(this.add_client_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.add_dish_to_list_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title_label);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskDine";
            this.Activated += new System.EventHandler(this.AddNewOrder_Activated);
            this.Load += new System.EventHandler(this.AddNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_dish_to_list_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button add_client_btn;
        private System.Windows.Forms.Button add_new_order_btn;
        private System.Windows.Forms.Button delete_dish_from_list_btn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
    }
}