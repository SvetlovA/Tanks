using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class GameObject
    {
        private PictureBox _gameObject = new PictureBox();

        public GameObject()
        { }

        public GameObject(int x, int y, int width, int height, Color color)
        {
            _gameObject.Location = new Point(x, y);
            _gameObject.Size = new Size(width, height);
            _gameObject.BackColor = color;
        }

        public int X
        {
            get
            {
                return _gameObject.Location.X;
            }
        }

        public int Y
        {
            get
            {
                return _gameObject.Location.Y;
            }
        }

        public int Width
        {
            get
            {
                return _gameObject.Size.Width;
            }
        }

        public int Height
        {
            get
            {
                return _gameObject.Size.Height;
            }
        }

        public Point Location
        {
            get
            {
                return _gameObject.Location;
            }
            set
            {
                _gameObject.Location = value;
            }
        }

        public Size Size
        {
            get
            {
                return _gameObject.Size;
            }
            set
            {
                _gameObject.Size = value;
            }
        }

        public Color Color
        {
            get
            {
                return _gameObject.BackColor;
            }
            set
            {
                _gameObject.BackColor = value;
            }
        }

        public PictureBox Draw()
        {
            return _gameObject;
        }
    }
}
