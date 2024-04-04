
namespace DeliverySystem
{
    partial class Dishes_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dishes_Details));
            this.title_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weight_btn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.change_btn = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.Location = new System.Drawing.Point(34, 32);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(172, 29);
            this.title_label.TabIndex = 6;
            this.title_label.Text = "Состав блюда";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(36, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(740, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Блюдо: ";
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
            this.dataGridView1.Location = new System.Drawing.Point(39, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(737, 279);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 447);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 26);
            this.comboBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Продукт:";
            // 
            // weight_btn
            // 
            this.weight_btn.Location = new System.Drawing.Point(39, 553);
            this.weight_btn.MaxLength = 10;
            this.weight_btn.Name = "weight_btn";
            this.weight_btn.Size = new System.Drawing.Size(360, 23);
            this.weight_btn.TabIndex = 40;
            this.weight_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_btn_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Количество, кг:";
            // 
            // change_btn
            // 
            this.change_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.change_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_btn.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.change_btn.Location = new System.Drawing.Point(532, 535);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(244, 41);
            this.change_btn.TabIndex = 43;
            this.change_btn.Text = "Изменить";
            this.change_btn.UseVisualStyleBackColor = false;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.DarkOrange;
            this.delete_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_button.Location = new System.Drawing.Point(532, 480);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(244, 41);
            this.delete_button.TabIndex = 42;
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
            this.add_button.Location = new System.Drawing.Point(532, 426);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(244, 41);
            this.add_button.TabIndex = 41;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Продукт";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Количество, кг";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Dishes_Details
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 612);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.weight_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.title_label);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dishes_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskDine";
            this.Load += new System.EventHandler(this.Dishes_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weight_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}