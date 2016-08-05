using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Model
{
    /// <summary>
    /// Class Kolobok
    /// </summary>
    public class Kolobok : MovableGameObject
    {
        private int _points;

        /// <summary>
        /// Constructor of kolobok
        /// </summary>
        public Kolobok()  : base()
        { }

        /// <summary>
        /// Constructor of kolobok
        /// </summary>
        /// <param name="x"> Coordinate X</param>
        /// <param name="y"> Coordinate Y</param>
        /// <param name="width"> Width</param>
        /// <param name="height"> Height</param>
        /// <param name="color"> Color</param>
        public Kolobok(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        { }

        /// <summary>
        /// Constructor of kolobok
        /// </summary>
        /// <param name="x"> Coordinate X</param>
        /// <param name="y"> Coordinate Y</param>
        /// <param name="width"> Width</param>
        /// <param name="height"> Height</param>
        /// <param name="image"> Image</param>
        public Kolobok(int x, int y, int width, int height, Bitmap image) : base(x, y, width, height, image)
        { }

        /// <summary>
        /// Player points
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
        }

        /// <summary>
        /// Get points
        /// </summary>
        public void GetPoint()
        {
            _points++;
        }
    }
}
