namespace WinFormsApp104Array
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            lblCount = new Label();
            lblAverage = new Label();
            lblSum = new Label();
            lblMin = new Label();
            lblMax = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(307, 411);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "กรอกข้อมูลตัวเลข";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(358, 27);
            button1.Name = "button1";
            button1.Size = new Size(95, 58);
            button1.TabIndex = 2;
            button1.Text = "ประมวลผล";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 12F);
            lblCount.Location = new Point(513, 32);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(88, 21);
            lblCount.TabIndex = 3;
            lblCount.Text = "จำนวนข้อมูล";
            lblCount.Click += lblCount_Click;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Font = new Font("Segoe UI", 12F);
            lblAverage.Location = new Point(544, 101);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(57, 21);
            lblAverage.TabIndex = 4;
            lblAverage.Text = "ค่าเฉลี่ย";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Segoe UI", 12F);
            lblSum.Location = new Point(549, 68);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(52, 21);
            lblSum.TabIndex = 5;
            lblSum.Text = "ผลรวม";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Font = new Font("Segoe UI", 12F);
            lblMin.Location = new Point(541, 133);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(60, 21);
            lblMin.TabIndex = 6;
            lblMin.Text = "ค่าต่ำสุด";
            lblMin.Click += label2_Click;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Font = new Font("Segoe UI", 12F);
            lblMax.Location = new Point(542, 163);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(59, 21);
            lblMax.TabIndex = 7;
            lblMax.Text = "ค่าสูงสุด";
            // 
            // button2
            // 
            button2.BackColor = Color.Chartreuse;
            button2.Location = new Point(358, 230);
            button2.Name = "button2";
            button2.Size = new Size(155, 47);
            button2.TabIndex = 8;
            button2.Text = "ทดสอบ Array 2 มิคิ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(358, 283);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(430, 155);
            textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(lblMax);
            Controls.Add(lblMin);
            Controls.Add(lblSum);
            Controls.Add(lblAverage);
            Controls.Add(lblCount);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "ทดสอบการใช้งาน Array";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label lblCount;
        private Label lblAverage;
        private Label lblSum;
        private Label lblMin;
        private Label lblMax;
        private Button button2;
        private TextBox textBox2;
    }
}
