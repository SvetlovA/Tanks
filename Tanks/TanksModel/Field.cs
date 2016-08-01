using Model;
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
        public Field()
        { }

        public Field(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        { }

        public void Add(GameObject gameObject)
        {
            Draw().Controls.Add(gameObject.Draw());
        }
    }
}
