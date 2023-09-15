namespace cs_builder.Libraries.Labs.var_19.lab8
{
    partial class Form_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_8));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button_update = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            label_message = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Delete = new Button();
            button_update_record = new Button();
            comboBox1 = new ComboBox();
            textBox_money = new TextBox();
            textBox_DOB = new TextBox();
            textBox_middleName = new TextBox();
            textBox_name = new TextBox();
            textBox_surname = new TextBox();
            textBox_aID = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(560, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button_update);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(552, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "View Data";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            button_update.Location = new Point(6, 389);
            button_update.Name = "button_update";
            button_update.Size = new Size(105, 27);
            button_update.TabIndex = 1;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(540, 374);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label_message);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(Delete);
            tabPage2.Controls.Add(button_update_record);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(textBox_money);
            tabPage2.Controls.Add(textBox_DOB);
            tabPage2.Controls.Add(textBox_middleName);
            tabPage2.Controls.Add(textBox_name);
            tabPage2.Controls.Add(textBox_surname);
            tabPage2.Controls.Add(textBox_aID);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(552, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Control Data";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_message
            // 
            label_message.AutoSize = true;
            label_message.Location = new Point(65, 14);
            label_message.Name = "label_message";
            label_message.Size = new Size(16, 15);
            label_message.TabIndex = 19;
            label_message.Text = "...";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 14);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 18;
            label10.Text = "Message : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(288, 306);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 17;
            label9.Text = "Format(SSS.DD)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(255, 258);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 16;
            label8.Text = "Format(yyyy-MM-dd)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 58);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 15;
            label7.Text = "Select existing ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 283);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 14;
            label6.Text = "Money amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 235);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 13;
            label5.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 206);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 12;
            label4.Text = "Middle Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 177);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 11;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 148);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 119);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 9;
            label1.Text = "Account ID";
            // 
            // Delete
            // 
            Delete.Location = new Point(87, 390);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 8;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += button2_Click;
            // 
            // button_update_record
            // 
            button_update_record.Location = new Point(6, 390);
            button_update_record.Name = "button_update_record";
            button_update_record.Size = new Size(75, 23);
            button_update_record.TabIndex = 7;
            button_update_record.Text = "Update";
            button_update_record.UseVisualStyleBackColor = true;
            button_update_record.Click += button_update_record_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All" });
            comboBox1.Location = new Point(196, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 23);
            comboBox1.TabIndex = 6;
            comboBox1.DropDown += comboBox1_DropDown;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox_money
            // 
            textBox_money.Location = new Point(196, 280);
            textBox_money.Name = "textBox_money";
            textBox_money.Size = new Size(182, 23);
            textBox_money.TabIndex = 5;
            // 
            // textBox_DOB
            // 
            textBox_DOB.Location = new Point(196, 232);
            textBox_DOB.Name = "textBox_DOB";
            textBox_DOB.Size = new Size(182, 23);
            textBox_DOB.TabIndex = 4;
            // 
            // textBox_middleName
            // 
            textBox_middleName.Location = new Point(196, 203);
            textBox_middleName.Name = "textBox_middleName";
            textBox_middleName.Size = new Size(182, 23);
            textBox_middleName.TabIndex = 3;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(196, 174);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(182, 23);
            textBox_name.TabIndex = 2;
            // 
            // textBox_surname
            // 
            textBox_surname.Location = new Point(196, 145);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(182, 23);
            textBox_surname.TabIndex = 1;
            // 
            // textBox_aID
            // 
            textBox_aID.Location = new Point(196, 116);
            textBox_aID.Name = "textBox_aID";
            textBox_aID.Size = new Size(182, 23);
            textBox_aID.TabIndex = 0;
            // 
            // Form_8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(577, 489);
            MinimumSize = new Size(577, 489);
            Name = "Form_8";
            Text = "CRUD";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button_update;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private TextBox textBox_money;
        private TextBox textBox_DOB;
        private TextBox textBox_middleName;
        private TextBox textBox_name;
        private TextBox textBox_surname;
        private TextBox textBox_aID;
        private Button Delete;
        private Button button_update_record;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label_message;
        private Label label10;
    }
}