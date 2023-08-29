namespace cs_builder.Libraries.Labs.var_19.lab3
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            Draw = new Button();
            Clear = new Button();
            textBox_SidesAmount = new TextBox();
            textBox_posX = new TextBox();
            textBox_posY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 415);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // Draw
            // 
            Draw.Location = new Point(327, 422);
            Draw.Name = "Draw";
            Draw.Size = new Size(90, 32);
            Draw.TabIndex = 4;
            Draw.Text = "Draw";
            Draw.UseVisualStyleBackColor = true;
            Draw.Click += Draw_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(327, 460);
            Clear.Name = "Clear";
            Clear.Size = new Size(90, 32);
            Clear.TabIndex = 5;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // textBox_SidesAmount
            // 
            textBox_SidesAmount.Location = new Point(95, 422);
            textBox_SidesAmount.Name = "textBox_SidesAmount";
            textBox_SidesAmount.Size = new Size(81, 23);
            textBox_SidesAmount.TabIndex = 1;
            // 
            // textBox_posX
            // 
            textBox_posX.Location = new Point(240, 462);
            textBox_posX.Name = "textBox_posX";
            textBox_posX.Size = new Size(81, 23);
            textBox_posX.TabIndex = 3;
            // 
            // textBox_posY
            // 
            textBox_posY.Location = new Point(240, 422);
            textBox_posY.Name = "textBox_posY";
            textBox_posY.Size = new Size(81, 23);
            textBox_posY.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 425);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 6;
            label1.Text = "Sides Amount :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 425);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Pos Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 465);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Pos X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 465);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 9;
            label4.Text = "On screen : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 465);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 497);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_posY);
            Controls.Add(textBox_posX);
            Controls.Add(textBox_SidesAmount);
            Controls.Add(Clear);
            Controls.Add(Draw);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(437, 536);
            MinimumSize = new Size(437, 536);
            Name = "Form1";
            Text = "Painter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Draw;
        private Button Clear;
        private TextBox textBox_SidesAmount;
        private TextBox textBox_posX;
        private TextBox textBox_posY;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}