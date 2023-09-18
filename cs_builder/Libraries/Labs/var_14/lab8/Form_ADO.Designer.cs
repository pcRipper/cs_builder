namespace cs_builder.Libraries.Labs.var_14.lab8
{
    partial class Form_ADO
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
            dataGridView1 = new DataGridView();
            button_update = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_deleteElement = new Button();
            button_updateElement = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(604, 568);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button_update
            // 
            button_update.Location = new Point(71, 36);
            button_update.Name = "button_update";
            button_update.Size = new Size(120, 33);
            button_update.TabIndex = 1;
            button_update.Text = "Update List";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_update);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(613, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 86);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data List";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button_deleteElement);
            groupBox2.Controls.Add(button_updateElement);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(613, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 476);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Element";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(39, 320);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 16;
            label7.Text = "seat(CCC)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(39, 272);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 15;
            label6.Text = "Carriage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 224);
            label5.Name = "label5";
            label5.Size = new Size(117, 17);
            label5.TabIndex = 14;
            label5.Text = "Date(yyyy-MM-dd)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 176);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 13;
            label4.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 128);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 12;
            label3.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 80);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 11;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(20, 17);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // button_deleteElement
            // 
            button_deleteElement.Location = new Point(141, 441);
            button_deleteElement.Name = "button_deleteElement";
            button_deleteElement.Size = new Size(114, 29);
            button_deleteElement.TabIndex = 9;
            button_deleteElement.Text = "Delete";
            button_deleteElement.UseVisualStyleBackColor = true;
            button_deleteElement.Click += button_deleteElement_Click;
            // 
            // button_updateElement
            // 
            button_updateElement.Location = new Point(6, 441);
            button_updateElement.Name = "button_updateElement";
            button_updateElement.Size = new Size(114, 29);
            button_updateElement.TabIndex = 8;
            button_updateElement.Text = "Update";
            button_updateElement.UseVisualStyleBackColor = true;
            button_updateElement.Click += button_updateElement_Click;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(39, 340);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(185, 25);
            textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(39, 292);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(185, 25);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(39, 244);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(185, 25);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(39, 196);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 25);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(39, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 25);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(39, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(39, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 25);
            textBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(39, 385);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 24);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Luggage";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form_ADO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 592);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            MaximumSize = new Size(902, 631);
            MinimumSize = new Size(902, 631);
            Name = "Form_ADO";
            Text = "Panasiuk #8";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_update;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_deleteElement;
        private Button button_updateElement;
        private RadioButton radioButton1;
    }
}