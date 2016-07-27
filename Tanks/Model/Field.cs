using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Field : GameObject
    {
        private Color _backColor;

        public Field()
        { }

        public Field(int x, int y, int width, int height) : base(x, y, width, height)
        { }

        public Color BackColor
        {
            get
            {
                return _backColor;
            }

            set
            {
                _backColor = value;
            }
        }
    }
}
