using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GravityGameLibrary;

namespace GravityGame
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            game = new Game(10, this);

         
            game.addGameObject(Properties.Resources.airplane, 40, 10, true);
            game.addGameObject(Properties.Resources.flights, 820, 10, false);
            game.addGameObject(Properties.Resources.cashier, 1500, 10, true);

        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            game.update();
        }
    }
}
