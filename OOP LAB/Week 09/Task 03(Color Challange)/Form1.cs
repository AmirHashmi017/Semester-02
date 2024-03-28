using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorChallange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Color> colors = new List<Color>() { Color.Red,Color.Green,Color.Blue};
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int index = rnd.Next(colors.Count);
          
           textBox1.BackColor = colors[index];
            


        }
    }
}
