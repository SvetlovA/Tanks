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
    public class TankView : MovableGameObjectView
    {
        private Tank _tank;

        public TankView() : base(new Tank())
        {
            _tank = (Tank)GameObject;   
        }

        public TankView(int x, int y, int width, int height) : base(new Tank(x, y, width, height))
        {
            _tank = (Tank)GameObject;
        }

        public PictureBox Draw()
        {
            ObjectView.BackColor = Color.Black;
            ObjectView.Location = new Point(_tank.X, _tank.Y);
            ObjectView.Size = new Size(_tank.Width, _tank.Height);

            return ObjectView;
        }
    }
}
