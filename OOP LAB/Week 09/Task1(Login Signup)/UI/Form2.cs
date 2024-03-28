using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_Real_
{
    public partial class SignUp : Form
    {
        string path = "data.txt";
        public SignUp()
        {
           
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(f1);
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (signupname.Text != "" && signuppassword.Text != "" && (role.Text == "admin" || role.Text == "user"))
            {
                
                MUserBL u1 = new MUserBL(signupname.Text, signuppassword.Text, role.Text);
                MUserDL.AddUser(u1);
                MUserDL.ReadDataFromFile();
                MUserDL.StoreUserInFile(u1);
                MessageBox.Show("User Added Successfully.");
                ClearTextBoxes();
            }
            else
            MessageBox.Show("Please Fill in the required fields", "WARNING");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SaveUser()
        {
           
        }
        private void ClearTextBoxes()
        {
            signupname.Text = "";
            signuppassword.Text = "";
            role.Text = "";

        }
    }
}
