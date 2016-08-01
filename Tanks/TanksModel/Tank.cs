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
        { }

        public Tank(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        { }

        public void Attack(Kolobok kolobok)
        {
            kolobok.Dispose();
        }
    }
}
