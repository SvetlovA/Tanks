using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Model
{
    public class Kolobok : MovableGameObject
    {
        private int _points;

        public Kolobok()  : base()
        {
            Image = new Bitmap("C:/Users/21art/Desktop/Tanks/Images/kolobok.png");
        }

        public Kolobok(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        {
            Image = new Bitmap("C:/Users/21art/Desktop/Tanks/Images/kolobok.png");
        }

        public int Points
        {
            get
            {
                return _points;
            }
        }

        public void GetPoint()
        {
            _points++;
        }
    }
}
