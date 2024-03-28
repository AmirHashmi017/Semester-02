using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Task1_Real_
{
    public partial class Form3 : Form
    {
        string path = "data.txt";
        public Form3()
        {
            InitializeComponent();
        }

        private void signupname_TextChanged(object sender, EventArgs e)
        {

        }

        private void signinpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void from3back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(f1);
            f1.Show();
        }

        private void form3next_Click(object sender, EventArgs e)
        {
            MUserDL.ReadDataFromFile();
            string username = signinname.Text;
            string password = signinpassword.Text;
            MUserBL user = new MUserBL(username, password);
           MUserBL storedUser = MUserDL.SignIn(user);
            if (storedUser != null)
            {
                MessageBox.Show("User signed in successfully");
                if (storedUser.IsAdmin())
                {
                    MessageBox.Show("Welcome Admin");
                }
                else
                {
                    MessageBox.Show("Welcome User");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            ClearData();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void ClearData()
        {
            signinname.Text = "";
            signinpassword.Text = "";
        }
    }
}
