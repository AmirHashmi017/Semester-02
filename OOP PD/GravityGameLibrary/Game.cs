using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GravityGameLibrary
{
    public class Game
    {
        private Form formreference;
        private double Gravity;
        private List<GameObject> gameObjects;
        public Game(double Gravity, Form form)
        {
            this.Gravity = Gravity;
            this.formreference = form;
            gameObjects = new List<GameObject>();
        }
        public void addGameObject(Image img, int Left, int Top, bool fallsundergravity)
        {
            PictureBox objectp= new PictureBox();
            objectp.Image = img;
            objectp.Width = img.Width;
            objectp.Height = img.Height;
            objectp.BackColor = Color.Transparent;
            objectp.Top = Top;
            objectp.Left = Left;
            this.formreference.Controls.Add(objectp);
            GameObject gameobject = new GameObject(objectp, fallsundergravity);
            gameObjects.Add(gameobject);
        }
        public void update()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                GameObject gameobject = gameObjects[i];
                PictureBox objectp = gameobject.PictureBox;
                bool fallsUnderGravity = gameobject.FallsUnderGravity;

                if (fallsUnderGravity)
                {
                    objectp.Top += (int)(0.25 * Gravity);
                    if (objectp.Top >= formreference.Height)
                    {

                        gameObjects.RemoveAt(i);
                        formreference.Controls.Remove(objectp);
                    }
                }
            }
        }
    }
}
