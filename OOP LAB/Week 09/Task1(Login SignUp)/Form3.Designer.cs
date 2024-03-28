namespace Task1_Real_
{
    partial class Form3
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
            this.mainlabel = new System.Windows.Forms.Label();
            this.form3next = new System.Windows.Forms.Button();
            this.from3back = new System.Windows.Forms.Button();
            this.signinpassword = new System.Windows.Forms.TextBox();
            this.signinname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainlabel
            // 
            this.mainlabel.AutoSize = true;
            this.mainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.Location = new System.Drawing.Point(92, 22);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(617, 55);
            this.mainlabel.TabIndex = 2;
            this.mainlabel.Text = " SignIn SignUp Application";
            // 
            // form3next
            // 
            this.form3next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.form3next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form3next.ForeColor = System.Drawing.Color.White;
            this.form3next.Location = new System.Drawing.Point(578, 299);
            this.form3next.Name = "form3next";
            this.form3next.Size = new System.Drawing.Size(75, 36);
            this.form3next.TabIndex = 15;
            this.form3next.Text = "Next";
            this.form3next.UseVisualStyleBackColor = false;
            this.form3next.Click += new System.EventHandler(this.form3next_Click);
            // 
            // from3back
            // 
            this.from3back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.from3back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from3back.ForeColor = System.Drawing.Color.White;
            this.from3back.Location = new System.Drawing.Point(137, 299);
            this.from3back.Name = "from3back";
            this.from3back.Size = new System.Drawing.Size(75, 36);
            this.from3back.TabIndex = 14;
            this.from3back.Text = "Back";
            this.from3back.UseVisualStyleBackColor = false;
            this.from3back.Click += new System.EventHandler(this.from3back_Click);
            // 
            // signinpassword
            // 
            this.signinpassword.Location = new System.Drawing.Point(266, 211);
            this.signinpassword.Name = "signinpassword";
            this.signinpassword.Size = new System.Drawing.Size(377, 20);
            this.signinpassword.TabIndex = 13;
            this.signinpassword.TextChanged += new System.EventHandler(this.signinpassword_TextChanged);
            // 
            // signinname
            // 
            this.signinname.Location = new System.Drawing.Point(266, 130);
            this.signinname.Name = "signinname";
            this.signinname.Size = new System.Drawing.Size(377, 20);
            this.signinname.TabIndex = 12;
            this.signinname.TextChanged += new System.EventHandler(this.signupname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "UserName";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mainlabel);
            this.panel3.Controls.Add(this.from3back);
            this.panel3.Controls.Add(this.form3next);
            this.panel3.Controls.Add(this.signinname);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.signinpassword);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Name = "Form3";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainlabel;
        private System.Windows.Forms.Button form3next;
        private System.Windows.Forms.Button from3back;
        private System.Windows.Forms.TextBox signinpassword;
        private System.Windows.Forms.TextBox signinname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}