using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MovableGameObject : GameObject
    {
        public MovableGameObject()
        { }

        public MovableGameObject(int x, int y, int width, int height) : base(x, y, width, height)
        { }

        public Point Move(int newX, int newY)
        {
            X = newX;
            Y = newY;
            return new Point(X, Y);
        }
    }
}
