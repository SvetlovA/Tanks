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
        public Kolobok()  : base()
        { }

        public Kolobok(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        { }
    }
}
