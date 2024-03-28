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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainbutton_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Form3 f3=new Form3();
                f3.TopLevel=false;
                f3.FormBorderStyle = FormBorderStyle.None;
                f3.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(f3);
                f3.Show();
            }
            else if(checkBox2.Checked)
            {
                SignUp f2 = new SignUp();
                f2.TopLevel = false;
                f2.FormBorderStyle = FormBorderStyle.None;
                f2.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(f2);
                f2.Show();
            }
        }
    }
}
