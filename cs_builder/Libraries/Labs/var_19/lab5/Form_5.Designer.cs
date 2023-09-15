
namespace cs_builder.Libraries.Labs.var_19.lab5
{
    partial class Form_5
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            groupBox2 = new GroupBox();
            button5 = new Button();
            textBox_path = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            button_setReflection = new Button();
            pictureBox2 = new PictureBox();
            button_draw = new Button();
            button_save = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 12);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(63, 43);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 18);
            label1.TabIndex = 2;
            label1.Text = "A = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 18);
            label2.TabIndex = 3;
            label2.Text = "B =";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Calibri", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(216, 10);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(113, 96);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serialization";
            // 
            // button3
            // 
            button3.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(7, 59);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(88, 27);
            button3.TabIndex = 1;
            button3.Text = "XML";
            button3.UseVisualStyleBackColor = true;
            button3.Click += xml_serialize;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(7, 25);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 0;
            button2.Text = "Binary";
            button2.UseVisualStyleBackColor = true;
            button2.Click += binary_serialize;
            // 
            // button4
            // 
            button4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(7, 24);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(88, 27);
            button4.TabIndex = 2;
            button4.Text = "Binary";
            button4.UseVisualStyleBackColor = true;
            button4.Click += binary_deserialize;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Font = new Font("Calibri", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(337, 11);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(122, 96);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Deserialization";
            // 
            // button5
            // 
            button5.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(7, 58);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(88, 27);
            button5.TabIndex = 3;
            button5.Text = "XML";
            button5.UseVisualStyleBackColor = true;
            button5.Click += xml_deserialize;
            // 
            // textBox_path
            // 
            textBox_path.Location = new Point(79, 112);
            textBox_path.Margin = new Padding(4, 3, 4, 3);
            textBox_path.Name = "textBox_path";
            textBox_path.Size = new Size(374, 23);
            textBox_path.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 18);
            label3.TabIndex = 11;
            label3.Text = "File Path :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(5, 148);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(222, 275);
            textBox4.TabIndex = 12;
            // 
            // button_setReflection
            // 
            button_setReflection.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_setReflection.Location = new Point(5, 429);
            button_setReflection.Margin = new Padding(4, 3, 4, 3);
            button_setReflection.Name = "button_setReflection";
            button_setReflection.Size = new Size(115, 27);
            button_setReflection.TabIndex = 13;
            button_setReflection.Text = "Reflection";
            button_setReflection.UseVisualStyleBackColor = true;
            button_setReflection.Click += button_setReflection_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(234, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 275);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // button_draw
            // 
            button_draw.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_draw.Location = new Point(344, 429);
            button_draw.Name = "button_draw";
            button_draw.Size = new Size(115, 27);
            button_draw.TabIndex = 15;
            button_draw.Text = "Draw";
            button_draw.UseVisualStyleBackColor = true;
            button_draw.Click += button_draw_Click_1;
            // 
            // button_save
            // 
            button_save.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_save.Location = new Point(63, 73);
            button_save.Name = "button_save";
            button_save.Size = new Size(116, 23);
            button_save.TabIndex = 16;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // Form_5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 460);
            Controls.Add(button_save);
            Controls.Add(button_draw);
            Controls.Add(pictureBox2);
            Controls.Add(button_setReflection);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox_path);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(482, 499);
            MinimumSize = new Size(482, 499);
            Name = "Form_5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 5";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox2;
        private Button button5;
        private TextBox textBox_path;
        private Label label3;
        private TextBox textBox4;
        private Button button_setReflection;
        private PictureBox pictureBox2;
        private Button button_draw;
        private Button button_save;
    }
}

