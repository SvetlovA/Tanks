using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class MovableGameObject : GameObject
    {
        private PartsOfTheWorld _direction;

        public MovableGameObject() : base()
        { }

        public MovableGameObject(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        { }

        public MovableGameObject(int x, int y, int width, int height, Bitmap image) : base(x, y, width, height, image)
        { }

        public PartsOfTheWorld Direction
        {
            get
            {
                return _direction;
            }

            set
            {
                _direction = value;
            }
        }

        public void Move(int newX, int newY)
        {
            Location = new Point(newX, newY);
        }
    }
}
