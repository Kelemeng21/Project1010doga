namespace Project1010doga
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
            lbl1 = new Label();
            lbl2 = new Label();
            lbl5 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            txtInput1 = new TextBox();
            txtInput2 = new TextBox();
            txtInput3 = new TextBox();
            txtInput4 = new TextBox();
            txtInput5 = new TextBox();
            btnnew = new Button();
            btncheck = new Button();
            btnclose = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl1.Location = new Point(33, 31);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(121, 32);
            lbl1.TabIndex = 0;
            lbl1.Text = "XX + YY =";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl2.Location = new Point(33, 91);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(115, 32);
            lbl2.TabIndex = 0;
            lbl2.Text = "XX - YY =";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl5.Location = new Point(33, 306);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(121, 32);
            lbl5.TabIndex = 0;
            lbl5.Text = "XX + YY =";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl3.Location = new Point(33, 162);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(121, 32);
            lbl3.TabIndex = 0;
            lbl3.Text = "XX + YY =";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl4.Location = new Point(33, 231);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(115, 32);
            lbl4.TabIndex = 0;
            lbl4.Text = "XX - YY =";
            // 
            // txtInput1
            // 
            txtInput1.Location = new Point(176, 40);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(100, 23);
            txtInput1.TabIndex = 1;
            // 
            // txtInput2
            // 
            txtInput2.Location = new Point(176, 91);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(100, 23);
            txtInput2.TabIndex = 1;
            // 
            // txtInput3
            // 
            txtInput3.Location = new Point(176, 162);
            txtInput3.Name = "txtInput3";
            txtInput3.Size = new Size(100, 23);
            txtInput3.TabIndex = 1;
            // 
            // txtInput4
            // 
            txtInput4.Location = new Point(176, 231);
            txtInput4.Name = "txtInput4";
            txtInput4.Size = new Size(100, 23);
            txtInput4.TabIndex = 1;
            // 
            // txtInput5
            // 
            txtInput5.Location = new Point(176, 306);
            txtInput5.Name = "txtInput5";
            txtInput5.Size = new Size(100, 23);
            txtInput5.TabIndex = 1;
            // 
            // btnnew
            // 
            btnnew.Location = new Point(308, 41);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(75, 23);
            btnnew.TabIndex = 2;
            btnnew.Text = "Új feladat";
            btnnew.UseVisualStyleBackColor = true;
            // 
            // btncheck
            // 
            btncheck.Location = new Point(308, 90);
            btncheck.Name = "btncheck";
            btncheck.Size = new Size(75, 23);
            btncheck.TabIndex = 2;
            btncheck.Text = "Ellenőrzés";
            btncheck.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(308, 305);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(75, 23);
            btnclose.TabIndex = 2;
            btnclose.Text = "Bezár";
            btnclose.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(308, 158);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "Tölsd ki a bal oldali  oldali";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btnclose);
            Controls.Add(btncheck);
            Controls.Add(btnnew);
            Controls.Add(txtInput5);
            Controls.Add(txtInput4);
            Controls.Add(txtInput3);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl5;
        private Label lbl3;
        private Label lbl4;
        private TextBox txtInput1;
        private TextBox txtInput2;
        private TextBox txtInput3;
        private TextBox txtInput4;
        private TextBox txtInput5;
        private Button btnnew;
        private Button btncheck;
        private Button btnclose;
        private RichTextBox richTextBox1;
    }
}
