namespace Login
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncreate2 = new System.Windows.Forms.Button();
            this.txtpass2 = new System.Windows.Forms.TextBox();
            this.txtcpassword = new System.Windows.Forms.TextBox();
            this.txtuesr2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btncreate2
            // 
            this.btncreate2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncreate2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate2.Location = new System.Drawing.Point(149, 186);
            this.btncreate2.Name = "btncreate2";
            this.btncreate2.Size = new System.Drawing.Size(132, 38);
            this.btncreate2.TabIndex = 5;
            this.btncreate2.Text = "Create Account";
            this.btncreate2.UseVisualStyleBackColor = false;
            this.btncreate2.Click += new System.EventHandler(this.btncreate2_Click);
            // 
            // txtpass2
            // 
            this.txtpass2.Location = new System.Drawing.Point(185, 91);
            this.txtpass2.Multiline = true;
            this.txtpass2.Name = "txtpass2";
            this.txtpass2.Size = new System.Drawing.Size(195, 30);
            this.txtpass2.TabIndex = 6;
            // 
            // txtcpassword
            // 
            this.txtcpassword.Location = new System.Drawing.Point(185, 139);
            this.txtcpassword.Multiline = true;
            this.txtcpassword.Name = "txtcpassword";
            this.txtcpassword.Size = new System.Drawing.Size(195, 30);
            this.txtcpassword.TabIndex = 7;
            // 
            // txtuesr2
            // 
            this.txtuesr2.Location = new System.Drawing.Point(185, 28);
            this.txtuesr2.Multiline = true;
            this.txtuesr2.Name = "txtuesr2";
            this.txtuesr2.Size = new System.Drawing.Size(195, 30);
            this.txtuesr2.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 236);
            this.Controls.Add(this.txtuesr2);
            this.Controls.Add(this.txtcpassword);
            this.Controls.Add(this.txtpass2);
            this.Controls.Add(this.btncreate2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncreate2;
        private System.Windows.Forms.TextBox txtpass2;
        private System.Windows.Forms.TextBox txtcpassword;
        private System.Windows.Forms.TextBox txtuesr2;
    }
}