namespace WinFormsBankAccount
{
    partial class SecondFormBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondFormBank));
            choice1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // choice1
            // 
            choice1.BackColor = SystemColors.ScrollBar;
            choice1.Location = new Point(379, 394);
            choice1.Margin = new Padding(6);
            choice1.Name = "choice1";
            choice1.Size = new Size(227, 39);
            choice1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(670, 394);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(260, 43);
            button1.TabIndex = 1;
            button1.Text = "Submit Choice";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Location = new Point(46, 516);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 3;
            label1.Text = "Form2label1";
            label1.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(381, 509);
            numericUpDown1.Margin = new Padding(6, 4, 6, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(225, 39);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(670, 509);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(256, 50);
            button2.TabIndex = 5;
            button2.Text = "Complete Transaction";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Zilla Slab", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 71);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(282, 23);
            label3.TabIndex = 8;
            label3.Text = "1. Deposit into checkings Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Zilla Slab", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 142);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(314, 23);
            label2.TabIndex = 9;
            label2.Text = "3. Withdraw from Checkings Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Zilla Slab", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 107);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(266, 23);
            label4.TabIndex = 10;
            label4.Text = "2. Deposit into Savings Account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Zilla Slab", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 180);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(293, 23);
            label5.TabIndex = 11;
            label5.Text = "4. Withdraw from Savings Account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Zilla Slab", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 222);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(388, 23);
            label6.TabIndex = 12;
            label6.Text = "5. Transfer money from Checking into Savings";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Zilla Slab", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 263);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(388, 23);
            label7.TabIndex = 13;
            label7.Text = "6. Transfer money from Savings into Checking";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Zilla Slab", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(46, 309);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(350, 23);
            label8.TabIndex = 14;
            label8.Text = "7.  Display your Bank account information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(582, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 337);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // SecondFormBank
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1030, 627);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(choice1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "SecondFormBank";
            Text = "Bank Account";
            Load += SecondFormBank_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox choice1;
        private Button button1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
    }
}