using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class TankView
    {
        private Tank _tank = new Tank();
        private PictureBox _tankView = new PictureBox();
        private PartsOfTheWorld _direction;

        public TankView()
        { }

        public TankView(int x, int y, int width, int height)
        {
            _tank.X = x;
            _tank.Y = y;
            _tank.Width = width;
            _tank.Height = height;
        }

        public int X
        {
            get
            {
                return _tank.X;
            }
            set
            {
                _tank.X = value;
            }
        }

        public int Y
        {
            get
            {
                return _tank.Y;
            }
            set
            {
                _tank.Y = value;
            }
        }

        public int Width
        {
            get
            {
                return _tank.Width;
            }
            set
            {
                _tank.Width = value;
            }
        }

        public int Height
        {
            get
            {
                return _tank.Height;
            }
            set
            {
                _tank.Height = value;
            }
        }

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

        public PictureBox Draw()
        {
            _tankView.BackColor = Color.Black;
            _tankView.Location = new Point(_tank.X, _tank.Y);
            _tankView.Size = new Size(10, 10);

            return _tankView;
        }

        public void Move(int newX, int newY)
        {
            _tankView.Location = _tank.Move(newX, newY);
        }
    }
}
