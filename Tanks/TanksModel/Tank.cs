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
    /// Class Tank
    /// </summary>
    public class Tank : MovableGameObject
    {
        /// <summary>
        /// Constructor of Tank
        /// </summary>
        public Tank() : base()
        {
            Image = new Bitmap("C:/Users/21art/Desktop/Tanks/Images/tank.png");
        }

        /// <summary>
        /// Constructor of Tank
        /// </summary>
        /// <param name="x"> Coordinate X</param>
        /// <param name="y"> Coordinate Y</param>
        /// <param name="width"> Width</param>
        /// <param name="height"> Height</param>
        /// <param name="color"> Color</param>
        public Tank(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        { }

        /// <summary>
        /// Constructor of Tank
        /// </summary>
        /// <param name="x"> Coordinate X</param>
        /// <param name="y"> Coordinate Y</param>
        /// <param name="width"> Width</param>
        /// <param name="height"> Height</param>
        /// <param name="image"> Image</param>
        public Tank(int x, int y, int width, int height, Bitmap image) : base(x, y, width, height, image)
        {
            Image = new Bitmap("C:/Users/21art/Desktop/Tanks/Images/tank.png");
        }

        /// <summary>
        /// Attack game object
        /// </summary>
        /// <param name="kolobok"> Game object that tank may attack</param>
        public void Attack(Kolobok kolobok)
        {
            kolobok.Dispose();
        }
    }
}
