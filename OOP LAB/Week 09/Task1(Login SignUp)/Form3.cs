using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_Real_
{
    public partial class Form3 : Form
    {
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

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
