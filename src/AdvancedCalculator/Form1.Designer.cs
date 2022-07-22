namespace AdvancedCalculator
{
    partial class CalculatorForm
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
            this.display = new System.Windows.Forms.RichTextBox();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.Bsum = new System.Windows.Forms.Button();
            this.Bminus = new System.Windows.Forms.Button();
            this.Bmul = new System.Windows.Forms.Button();
            this.Bdiv = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.Bpow = new System.Windows.Forms.Button();
            this.Bopen = new System.Windows.Forms.Button();
            this.Bclose = new System.Windows.Forms.Button();
            this.Bequal = new System.Windows.Forms.Button();
            this.Bclear = new System.Windows.Forms.Button();
            this.Binorder = new System.Windows.Forms.RadioButton();
            this.Bpreorder = new System.Windows.Forms.RadioButton();
            this.Bpostorder = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(13, 51);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(290, 37);
            this.display.TabIndex = 1;
            this.display.Text = "0";
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(14, 108);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(37, 33);
            this.B1.TabIndex = 2;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(57, 108);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(37, 33);
            this.B2.TabIndex = 3;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(100, 108);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(37, 33);
            this.B3.TabIndex = 4;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button1_Click);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.Location = new System.Drawing.Point(14, 156);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(37, 33);
            this.B4.TabIndex = 5;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5.Location = new System.Drawing.Point(57, 156);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(37, 33);
            this.B5.TabIndex = 6;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = false;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B6
            // 
            this.B6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B6.Location = new System.Drawing.Point(100, 156);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(37, 33);
            this.B6.TabIndex = 7;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = false;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B7
            // 
            this.B7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B7.Location = new System.Drawing.Point(14, 205);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(37, 33);
            this.B7.TabIndex = 8;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = false;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // B8
            // 
            this.B8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B8.Location = new System.Drawing.Point(57, 205);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(37, 33);
            this.B8.TabIndex = 9;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = false;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B9
            // 
            this.B9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B9.Location = new System.Drawing.Point(100, 205);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(37, 33);
            this.B9.TabIndex = 10;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = false;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // Bsum
            // 
            this.Bsum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsum.Location = new System.Drawing.Point(167, 108);
            this.Bsum.Name = "Bsum";
            this.Bsum.Size = new System.Drawing.Size(37, 33);
            this.Bsum.TabIndex = 11;
            this.Bsum.Text = "+";
            this.Bsum.UseVisualStyleBackColor = false;
            this.Bsum.Click += new System.EventHandler(this.Bsum_Click);
            // 
            // Bminus
            // 
            this.Bminus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bminus.Location = new System.Drawing.Point(167, 156);
            this.Bminus.Name = "Bminus";
            this.Bminus.Size = new System.Drawing.Size(37, 33);
            this.Bminus.TabIndex = 12;
            this.Bminus.Text = "-";
            this.Bminus.UseVisualStyleBackColor = false;
            this.Bminus.Click += new System.EventHandler(this.Bminus_Click);
            // 
            // Bmul
            // 
            this.Bmul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmul.Location = new System.Drawing.Point(167, 205);
            this.Bmul.Name = "Bmul";
            this.Bmul.Size = new System.Drawing.Size(37, 33);
            this.Bmul.TabIndex = 13;
            this.Bmul.Text = "*";
            this.Bmul.UseVisualStyleBackColor = false;
            this.Bmul.Click += new System.EventHandler(this.Bmul_Click);
            // 
            // Bdiv
            // 
            this.Bdiv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bdiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdiv.Location = new System.Drawing.Point(167, 254);
            this.Bdiv.Name = "Bdiv";
            this.Bdiv.Size = new System.Drawing.Size(37, 33);
            this.Bdiv.TabIndex = 14;
            this.Bdiv.Text = "/";
            this.Bdiv.UseVisualStyleBackColor = false;
            this.Bdiv.Click += new System.EventHandler(this.Bdiv_Click);
            // 
            // B0
            // 
            this.B0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B0.Location = new System.Drawing.Point(57, 254);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(37, 33);
            this.B0.TabIndex = 15;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = false;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // Bpow
            // 
            this.Bpow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bpow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpow.Location = new System.Drawing.Point(212, 108);
            this.Bpow.Name = "Bpow";
            this.Bpow.Size = new System.Drawing.Size(37, 33);
            this.Bpow.TabIndex = 16;
            this.Bpow.Text = "^";
            this.Bpow.UseVisualStyleBackColor = false;
            this.Bpow.Click += new System.EventHandler(this.Bpow_Click);
            // 
            // Bopen
            // 
            this.Bopen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bopen.Location = new System.Drawing.Point(212, 156);
            this.Bopen.Name = "Bopen";
            this.Bopen.Size = new System.Drawing.Size(37, 33);
            this.Bopen.TabIndex = 17;
            this.Bopen.Text = "(";
            this.Bopen.UseVisualStyleBackColor = false;
            this.Bopen.Click += new System.EventHandler(this.Bopen_Click);
            // 
            // Bclose
            // 
            this.Bclose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclose.Location = new System.Drawing.Point(212, 205);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(37, 33);
            this.Bclose.TabIndex = 18;
            this.Bclose.Text = ")";
            this.Bclose.UseVisualStyleBackColor = false;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // Bequal
            // 
            this.Bequal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bequal.Location = new System.Drawing.Point(212, 254);
            this.Bequal.Name = "Bequal";
            this.Bequal.Size = new System.Drawing.Size(37, 33);
            this.Bequal.TabIndex = 19;
            this.Bequal.Text = "=";
            this.Bequal.UseVisualStyleBackColor = false;
            this.Bequal.Click += new System.EventHandler(this.Bequal_Click);
            // 
            // Bclear
            // 
            this.Bclear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclear.Location = new System.Drawing.Point(255, 108);
            this.Bclear.Name = "Bclear";
            this.Bclear.Size = new System.Drawing.Size(48, 33);
            this.Bclear.TabIndex = 20;
            this.Bclear.Text = "C";
            this.Bclear.UseVisualStyleBackColor = false;
            this.Bclear.Click += new System.EventHandler(this.Bclear_Click);
            // 
            // Binorder
            // 
            this.Binorder.AutoSize = true;
            this.Binorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binorder.Location = new System.Drawing.Point(12, 24);
            this.Binorder.Name = "Binorder";
            this.Binorder.Size = new System.Drawing.Size(78, 21);
            this.Binorder.TabIndex = 23;
            this.Binorder.Text = "Inorder";
            this.Binorder.UseVisualStyleBackColor = true;
            this.Binorder.CheckedChanged += new System.EventHandler(this.Binorder_CheckedChanged);
            // 
            // Bpreorder
            // 
            this.Bpreorder.AutoSize = true;
            this.Bpreorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpreorder.Location = new System.Drawing.Point(100, 24);
            this.Bpreorder.Name = "Bpreorder";
            this.Bpreorder.Size = new System.Drawing.Size(90, 21);
            this.Bpreorder.TabIndex = 24;
            this.Bpreorder.Text = "Preorder";
            this.Bpreorder.UseVisualStyleBackColor = true;
            this.Bpreorder.CheckedChanged += new System.EventHandler(this.Bpreorder_CheckedChanged);
            // 
            // Bpostorder
            // 
            this.Bpostorder.AutoSize = true;
            this.Bpostorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpostorder.Location = new System.Drawing.Point(199, 24);
            this.Bpostorder.Name = "Bpostorder";
            this.Bpostorder.Size = new System.Drawing.Size(97, 21);
            this.Bpostorder.TabIndex = 25;
            this.Bpostorder.Text = "Postorder";
            this.Bpostorder.UseVisualStyleBackColor = true;
            this.Bpostorder.CheckedChanged += new System.EventHandler(this.Bpostorder_CheckedChanged);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 307);
            this.Controls.Add(this.Bpostorder);
            this.Controls.Add(this.Bpreorder);
            this.Controls.Add(this.Binorder);
            this.Controls.Add(this.Bclear);
            this.Controls.Add(this.Bequal);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.Bopen);
            this.Controls.Add(this.Bpow);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.Bdiv);
            this.Controls.Add(this.Bmul);
            this.Controls.Add(this.Bminus);
            this.Controls.Add(this.Bsum);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.display);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox display;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button Bsum;
        private System.Windows.Forms.Button Bminus;
        private System.Windows.Forms.Button Bmul;
        private System.Windows.Forms.Button Bdiv;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button Bpow;
        private System.Windows.Forms.Button Bopen;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.Button Bequal;
        private System.Windows.Forms.Button Bclear;
        private System.Windows.Forms.RadioButton Binorder;
        private System.Windows.Forms.RadioButton Bpreorder;
        private System.Windows.Forms.RadioButton Bpostorder;
    }
}

