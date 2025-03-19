namespace Project_DB_G4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel6 = new Panel();
            label8 = new Label();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel7 = new Panel();
            panel8 = new Panel();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(127, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 400);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SandyBrown;
            panel6.Controls.Add(label8);
            panel6.Location = new Point(324, 100);
            panel6.Name = "panel6";
            panel6.Size = new Size(155, 74);
            panel6.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(3, 5);
            label8.Name = "label8";
            label8.Size = new Size(142, 19);
            label8.TabIndex = 10;
            label8.Text = "Active Students ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.SandyBrown;
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(18, 21);
            panel5.Name = "panel5";
            panel5.Size = new Size(256, 360);
            panel5.TabIndex = 11;
            panel5.Paint += panel5_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.profile;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(81, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 75);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Stencil", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(24, 117);
            label3.Name = "label3";
            label3.Size = new Size(214, 26);
            label3.TabIndex = 4;
            label3.Text = "Ch. Zafar Iqbal ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SandyBrown;
            label4.Font = new Font("Sylfaen", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(4, 143);
            label4.Name = "label4";
            label4.Size = new Size(249, 22);
            label4.TabIndex = 5;
            label4.Text = "Director Allama Iqbal Public School";
            label4.Click += label4_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.Controls.Add(label7);
            panel4.Location = new Point(485, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(155, 74);
            panel4.TabIndex = 10;
            panel4.Paint += panel4_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(3, 5);
            label7.Name = "label7";
            label7.Size = new Size(104, 19);
            label7.TabIndex = 10;
            label7.Text = "Active Staff";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SandyBrown;
            panel3.Controls.Add(label6);
            panel3.Location = new Point(485, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 73);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(3, 8);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 11;
            label6.Text = "Total Staff";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(324, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 73);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(0, 8);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 10;
            label5.Text = "Total Students";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 7.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 71);
            label2.Name = "label2";
            label2.Size = new Size(121, 18);
            label2.TabIndex = 3;
            label2.Text = "Director Portal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Maroon;
            label1.Font = new Font("Stencil", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 5);
            label1.Name = "label1";
            label1.Size = new Size(431, 26);
            label1.TabIndex = 1;
            label1.Text = "ALLAMA IQBAL PUBLIC HIGH SCHOOL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LOGO1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(18, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 65);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(3, 202);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Staff";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(3, 162);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Students";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SandyBrown;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.TopLeft;
            button3.Location = new Point(-1, 392);
            button3.Name = "button3";
            button3.Size = new Size(119, 34);
            button3.TabIndex = 6;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 224, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Maroon;
            button4.Location = new Point(3, 122);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 6;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Controls.Add(button1);
            panel7.Controls.Add(button3);
            panel7.Controls.Add(button2);
            panel7.Controls.Add(button4);
            panel7.Controls.Add(pictureBox1);
            panel7.Location = new Point(3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(118, 434);
            panel7.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Controls.Add(label1);
            panel8.Location = new Point(127, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(661, 28);
            panel8.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button2;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel panel3;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Panel panel5;
        private Label label8;
        private Panel panel4;
        private Label label7;
        private Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel6;
        private Label label3;
        private Panel panel7;
        private Panel panel8;
    }
}
