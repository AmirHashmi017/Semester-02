using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GravityGameLibrary
{
    internal class GameObject
    {
        public PictureBox PictureBox;
        public bool FallsUnderGravity;


        public GameObject(PictureBox pictureBox, bool fallsUnderGravity)
        {
            this.PictureBox = pictureBox;
            this.FallsUnderGravity = fallsUnderGravity;
        }
    }

}
