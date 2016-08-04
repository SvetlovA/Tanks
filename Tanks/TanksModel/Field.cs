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
        /// <summary>
        /// Constructor of field
        /// </summary>
        public Field()
        { }

        /// <summary>
        /// Constructor of field
        /// </summary>
        /// <param name="x"> Coordinate X</param>
        /// <param name="y"> Coordina Y</param>
        /// <param name="width"> Width</param>
        /// <param name="height"> Height</param>
        /// <param name="color"> Color</param>
        public Field(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        { }

        /// <summary>
        /// Constructor of field
        /// </summary>
        /// <param name="x"> Coordinate X</param>
        /// <param name="y"> Coordina Y</param>
        /// <param name="width"> Width</param>
        /// <param name="height"> Height</param>
        /// <param name="image"> Image</param>
        public Field(int x, int y, int width, int height, Bitmap image) : base(x, y, width, height, image)
        { }

        /// <summary>
        /// Add game objects to field
        /// </summary>
        /// <param name="gameObject"></param>
        public void Add(GameObject gameObject)
        {
            Draw().Controls.Add(gameObject.Draw());
        }
    }
}
