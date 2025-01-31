namespace Calculator_App
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
            txtBox = new TextBox();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btnPoint = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnEqual = new Button();
            btnC = new Button();
            btnCE = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBox.Location = new Point(12, 21);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.ReadOnly = true;
            txtBox.Size = new Size(358, 51);
            txtBox.TabIndex = 0;
            txtBox.TabStop = false;
            txtBox.Text = "0";
            txtBox.TextAlign = HorizontalAlignment.Right;
            txtBox.TextChanged += txtBox_TextChanged;
            // 
            // btn7
            // 
            btn7.Font = new Font("Arial", 14.25F);
            btn7.Location = new Point(12, 101);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 56);
            btn7.TabIndex = 1;
            btn7.TabStop = false;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Arial", 14.25F);
            btn4.Location = new Point(12, 163);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 56);
            btn4.TabIndex = 2;
            btn4.TabStop = false;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Arial", 14.25F);
            btn1.Location = new Point(12, 225);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 56);
            btn1.TabIndex = 3;
            btn1.TabStop = false;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Arial", 14.25F);
            btn0.Location = new Point(12, 287);
            btn0.Name = "btn0";
            btn0.Size = new Size(140, 56);
            btn0.TabIndex = 4;
            btn0.TabStop = false;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Arial", 14.25F);
            btn2.Location = new Point(85, 225);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 56);
            btn2.TabIndex = 7;
            btn2.TabStop = false;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Arial", 14.25F);
            btn5.Location = new Point(85, 163);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 56);
            btn5.TabIndex = 6;
            btn5.TabStop = false;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Arial", 14.25F);
            btn8.Location = new Point(85, 101);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 56);
            btn8.TabIndex = 5;
            btn8.TabStop = false;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("Arial", 14.25F);
            btnPoint.Location = new Point(158, 287);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(67, 56);
            btnPoint.TabIndex = 12;
            btnPoint.TabStop = false;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Arial", 14.25F);
            btn3.Location = new Point(158, 225);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 56);
            btn3.TabIndex = 11;
            btn3.TabStop = false;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Arial", 14.25F);
            btn6.Location = new Point(158, 163);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 56);
            btn6.TabIndex = 10;
            btn6.TabStop = false;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Arial", 14.25F);
            btn9.Location = new Point(158, 101);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 56);
            btn9.TabIndex = 9;
            btn9.TabStop = false;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 14.25F);
            btnAdd.Location = new Point(231, 287);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 56);
            btnAdd.TabIndex = 16;
            btnAdd.TabStop = false;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Arial", 14.25F);
            btnSubtract.Location = new Point(231, 225);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(66, 56);
            btnSubtract.TabIndex = 15;
            btnSubtract.TabStop = false;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Arial", 14.25F);
            btnMultiply.Location = new Point(231, 163);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(66, 56);
            btnMultiply.TabIndex = 14;
            btnMultiply.TabStop = false;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Arial", 14.25F);
            btnDivide.Location = new Point(231, 101);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(66, 56);
            btnDivide.TabIndex = 13;
            btnDivide.TabStop = false;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Arial", 14.25F);
            btnEqual.Location = new Point(303, 225);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(67, 118);
            btnEqual.TabIndex = 19;
            btnEqual.TabStop = false;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Arial", 14.25F);
            btnC.Location = new Point(303, 163);
            btnC.Name = "btnC";
            btnC.Size = new Size(67, 56);
            btnC.TabIndex = 18;
            btnC.TabStop = false;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.White;
            btnCE.Font = new Font("Arial", 14.25F);
            btnCE.Location = new Point(303, 101);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(67, 56);
            btnCE.TabIndex = 17;
            btnCE.TabStop = false;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 366);
            Controls.Add(btnEqual);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnPoint);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(txtBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Calculator App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btn0;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btnPoint;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEqual;
        private Button btnC;
        private Button btnCE;
    }
}
