using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    /// <summary>
    /// Class movable game object
    /// </summary>
    public class MovableGameObject : GameObject
    {
        private PartsOfTheWorld _direction;

        /// <summary>
        /// Constructor of movable game object
        /// </summary>
        public MovableGameObject() : base()
        { }

        /// <summary>
        /// Constructor of movable game object
        /// </summary>
        /// <param name="x"> Coordinate X</param>
        /// <param name="y"> Coordinate Y</param>
        /// <param name="width"> Width</param>
        /// <param name="height"> Height</param>
        /// <param name="color"> Color</param>
        public MovableGameObject(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        { }

        /// <summary>
        /// Constructor of movable game object
        /// </summary>
        /// <param name="x"> Coordinate X</param>
        /// <param name="y"> Coordinate Y</param>
        /// <param name="width"> Width</param>
        /// <param name="height"> Height</param>
        /// <param name="image"> Image</param>
        public MovableGameObject(int x, int y, int width, int height, Bitmap image) : base(x, y, width, height, image)
        { }

        /// <summary>
        /// Directon of game object
        /// </summary>
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

        /// <summary>
        /// Move game object
        /// </summary>
        /// <param name="newX"> New coordinate X</param>
        /// <param name="newY"> New coordinate Y</param>
        public void Move(int newX, int newY)
        {
            Location = new Point(newX, newY);
        }
    }
}
