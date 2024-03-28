namespace Task1_Real_
{
    partial class SignUp
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signupname = new System.Windows.Forms.TextBox();
            this.signuppassword = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.TextBox();
            this.from2back = new System.Windows.Forms.Button();
            this.form2next = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.form2next);
            this.panel2.Controls.Add(this.from2back);
            this.panel2.Controls.Add(this.role);
            this.panel2.Controls.Add(this.signuppassword);
            this.panel2.Controls.Add(this.signupname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.mainlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // mainlabel
            // 
            this.mainlabel.AutoSize = true;
            this.mainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.Location = new System.Drawing.Point(91, 38);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(617, 55);
            this.mainlabel.TabIndex = 1;
            this.mainlabel.Text = " SignIn SignUp Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role";
            // 
            // signupname
            // 
            this.signupname.Location = new System.Drawing.Point(249, 149);
            this.signupname.Name = "signupname";
            this.signupname.Size = new System.Drawing.Size(377, 22);
            this.signupname.TabIndex = 5;
            this.signupname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // signuppassword
            // 
            this.signuppassword.Location = new System.Drawing.Point(249, 200);
            this.signuppassword.Name = "signuppassword";
            this.signuppassword.Size = new System.Drawing.Size(377, 22);
            this.signuppassword.TabIndex = 6;
            this.signuppassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // role
            // 
            this.role.Location = new System.Drawing.Point(249, 250);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(377, 22);
            this.role.TabIndex = 7;
            this.role.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // from2back
            // 
            this.from2back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.from2back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from2back.ForeColor = System.Drawing.Color.White;
            this.from2back.Location = new System.Drawing.Point(170, 339);
            this.from2back.Name = "from2back";
            this.from2back.Size = new System.Drawing.Size(75, 36);
            this.from2back.TabIndex = 8;
            this.from2back.Text = "Back";
            this.from2back.UseVisualStyleBackColor = false;
            this.from2back.Click += new System.EventHandler(this.button1_Click);
            // 
            // form2next
            // 
            this.form2next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.form2next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form2next.ForeColor = System.Drawing.Color.White;
            this.form2next.Location = new System.Drawing.Point(576, 339);
            this.form2next.Name = "form2next";
            this.form2next.Size = new System.Drawing.Size(75, 36);
            this.form2next.TabIndex = 9;
            this.form2next.Text = "Next";
            this.form2next.UseVisualStyleBackColor = false;
            this.form2next.Click += new System.EventHandler(this.button2_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button form2next;
        private System.Windows.Forms.Button from2back;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.TextBox signuppassword;
        private System.Windows.Forms.TextBox signupname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mainlabel;
    }
}