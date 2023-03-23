namespace WinFormsApp1
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
            b1 = new Button();
            display = new TextBox();
            b2 = new Button();
            b4 = new Button();
            b3 = new Button();
            b5 = new Button();
            b6 = new Button();
            b9 = new Button();
            b8 = new Button();
            b7 = new Button();
            bClear = new Button();
            bEqual = new Button();
            b0 = new Button();
            bAdd = new Button();
            bSubtract = new Button();
            bMultiply = new Button();
            bDivision = new Button();
            bMod = new Button();
            bXor = new Button();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b1.Location = new Point(30, 254);
            b1.Name = "b1";
            b1.Size = new Size(133, 61);
            b1.TabIndex = 0;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += button1_Click;
            // 
            // display
            // 
            display.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            display.Location = new Point(12, 12);
            display.Multiline = true;
            display.Name = "display";
            display.Size = new Size(827, 150);
            display.TabIndex = 1;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(200, 254);
            b2.Name = "b2";
            b2.Size = new Size(133, 61);
            b2.TabIndex = 2;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click_1;
            // 
            // b4
            // 
            b4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b4.Location = new Point(30, 321);
            b4.Name = "b4";
            b4.Size = new Size(133, 61);
            b4.TabIndex = 3;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click_1;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b3.Location = new Point(363, 254);
            b3.Name = "b3";
            b3.Size = new Size(133, 61);
            b3.TabIndex = 4;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click_1;
            // 
            // b5
            // 
            b5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b5.Location = new Point(200, 321);
            b5.Name = "b5";
            b5.Size = new Size(133, 61);
            b5.TabIndex = 5;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click_1;
            // 
            // b6
            // 
            b6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b6.Location = new Point(363, 321);
            b6.Name = "b6";
            b6.Size = new Size(133, 61);
            b6.TabIndex = 6;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click_1;
            // 
            // b9
            // 
            b9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b9.Location = new Point(363, 396);
            b9.Name = "b9";
            b9.Size = new Size(133, 61);
            b9.TabIndex = 9;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click_1;
            // 
            // b8
            // 
            b8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b8.Location = new Point(200, 396);
            b8.Name = "b8";
            b8.Size = new Size(133, 61);
            b8.TabIndex = 8;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click_1;
            // 
            // b7
            // 
            b7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b7.Location = new Point(30, 396);
            b7.Name = "b7";
            b7.Size = new Size(133, 61);
            b7.TabIndex = 7;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click_1;
            // 
            // bClear
            // 
            bClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bClear.Location = new Point(200, 187);
            bClear.Name = "bClear";
            bClear.Size = new Size(133, 61);
            bClear.TabIndex = 12;
            bClear.Text = "clear";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += button10_Click;
            // 
            // bEqual
            // 
            bEqual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bEqual.Location = new Point(363, 188);
            bEqual.Name = "bEqual";
            bEqual.Size = new Size(133, 61);
            bEqual.TabIndex = 11;
            bEqual.Text = " =";
            bEqual.UseVisualStyleBackColor = true;
            bEqual.Click += bEqual_Click_1;
            // 
            // b0
            // 
            b0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b0.Location = new Point(30, 187);
            b0.Name = "b0";
            b0.Size = new Size(133, 61);
            b0.TabIndex = 10;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += button12_Click;
            // 
            // bAdd
            // 
            bAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bAdd.Location = new Point(521, 206);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(133, 61);
            bAdd.TabIndex = 15;
            bAdd.Text = "+";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bSubtract
            // 
            bSubtract.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bSubtract.Location = new Point(521, 286);
            bSubtract.Name = "bSubtract";
            bSubtract.Size = new Size(133, 61);
            bSubtract.TabIndex = 14;
            bSubtract.Text = "-";
            bSubtract.UseVisualStyleBackColor = true;
            bSubtract.Click += bSubtract_Click;
            // 
            // bMultiply
            // 
            bMultiply.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bMultiply.Location = new Point(521, 369);
            bMultiply.Name = "bMultiply";
            bMultiply.Size = new Size(133, 61);
            bMultiply.TabIndex = 13;
            bMultiply.Text = "x";
            bMultiply.UseVisualStyleBackColor = true;
            bMultiply.Click += bMultiply_Click;
            // 
            // bDivision
            // 
            bDivision.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bDivision.Location = new Point(670, 369);
            bDivision.Name = "bDivision";
            bDivision.Size = new Size(133, 61);
            bDivision.TabIndex = 16;
            bDivision.Text = "/";
            bDivision.UseVisualStyleBackColor = true;
            bDivision.Click += bDivision_Click;
            // 
            // bMod
            // 
            bMod.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bMod.Location = new Point(670, 286);
            bMod.Name = "bMod";
            bMod.Size = new Size(133, 61);
            bMod.TabIndex = 17;
            bMod.Text = "%";
            bMod.UseVisualStyleBackColor = true;
            bMod.Click += bMod_Click;
            // 
            // bXor
            // 
            bXor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bXor.Location = new Point(670, 206);
            bXor.Name = "bXor";
            bXor.Size = new Size(133, 61);
            bXor.TabIndex = 18;
            bXor.Text = "xor";
            bXor.UseVisualStyleBackColor = true;
            bXor.Click += button18_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 490);
            Controls.Add(bXor);
            Controls.Add(bMod);
            Controls.Add(bDivision);
            Controls.Add(bAdd);
            Controls.Add(bSubtract);
            Controls.Add(bMultiply);
            Controls.Add(bClear);
            Controls.Add(bEqual);
            Controls.Add(b0);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b3);
            Controls.Add(b4);
            Controls.Add(b2);
            Controls.Add(display);
            Controls.Add(b1);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b1;
        private TextBox display;
        private Button b2;
        private Button b4;
        private Button b3;
        private Button b5;
        private Button b6;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button bClear;
        private Button bEqual;
        private Button b0;
        private Button bAdd;
        private Button bSubtract;
        private Button bMultiply;
        private Button bDivision;
        private Button bMod;
        private Button bXor;
    }
}