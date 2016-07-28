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
    public class KolobokView : MovableGameObjectView
    {
        private Kolobok _kolobok;

        public KolobokView()  : base(new Kolobok())
        {
            _kolobok = (Kolobok)GameObject;
        }

        public KolobokView(int x, int y, int width, int height) : base(new Kolobok(x, y, width, height))
        {
            _kolobok = (Kolobok)GameObject;
        }

        public PictureBox Draw()
        {
            ObjectView.BackColor = Color.Red;
            ObjectView.Location = new Point(_kolobok.X, _kolobok.Y);
            ObjectView.Size = new Size(_kolobok.Width, _kolobok.Height);

            return ObjectView;
        }
    }
}
