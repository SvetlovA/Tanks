using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Model
{
    public class Tank : MovableGameObject
    {
        public Tank() : base()
        {
            Image = new Bitmap("C:/Users/21art/Desktop/Tanks/Images/tank.png");
        }

        public Tank(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        { }

        public Tank(int x, int y, int width, int height, Bitmap image) : base(x, y, width, height, image)
        {
            Image = new Bitmap("C:/Users/21art/Desktop/Tanks/Images/tank.png");
        }

        public void Attack(Kolobok kolobok)
        {
            kolobok.Dispose();
        }
    }
}
