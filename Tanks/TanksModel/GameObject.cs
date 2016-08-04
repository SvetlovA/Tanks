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
    /// Class game object
    /// </summary>
    public class GameObject : IDisposable
    {
        private PictureBox _gameObject = new PictureBox();

        /// <summary>
        /// Constructor of game object
        /// </summary>
        public GameObject()
        {
            _gameObject.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Constructor of game object
        /// </summary>
        /// <param name="x"> Coordinate X</param>
        /// <param name="y"> Coordinate Y</param>
        /// <param name="width"> Width</param>
        /// <param name="height"> Height</param>
        /// <param name="color"> Color</param>
        public GameObject(int x, int y, int width, int height, Color color)
        {
            _gameObject.Location = new Point(x, y);
            _gameObject.Size = new Size(width, height);
            _gameObject.BackColor = color;
            _gameObject.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Constructor of game object
        /// </summary>
        /// <param name="x"> Coordinate X</param>
        /// <param name="y"> Coordinate Y</param>
        /// <param name="width"> Width</param>
        /// <param name="height"> Height</param>
        public GameObject(int x, int y, int width, int height, Bitmap image)
        {
            _gameObject.Location = new Point(x, y);
            _gameObject.Size = new Size(width, height);
            _gameObject.SizeMode = PictureBoxSizeMode.StretchImage;
            _gameObject.Image = image;
        }

        /// <summary>
        /// Coordinate X
        /// </summary>
        public int X
        {
            get
            {
                return _gameObject.Location.X;
            }
        }

        /// <summary>
        /// Coordinate Y
        /// </summary>
        public int Y
        {
            get
            {
                return _gameObject.Location.Y;
            }
        }

        /// <summary>
        /// Width of game object
        /// </summary>
        public int Width
        {
            get
            {
                return _gameObject.Size.Width;
            }
        }

        /// <summary>
        /// Height of game object
        /// </summary>
        public int Height
        {
            get
            {
                return _gameObject.Size.Height;
            }
        }

        /// <summary>
        /// Location of game object
        /// </summary>
        public Point Location
        {
            get
            {
                return _gameObject.Location;
            }
            set
            {
                _gameObject.Location = value;
            }
        }

        /// <summary>
        /// Size of game object
        /// </summary>
        public Size Size
        {
            get
            {
                return _gameObject.Size;
            }
            set
            {
                _gameObject.Size = value;
            }
        }

        /// <summary>
        /// Color of game object
        /// </summary>
        public Color Color
        {
            get
            {
                return _gameObject.BackColor;
            }
            set
            {
                _gameObject.BackColor = value;
            }
        }

        /// <summary>
        /// Bounds of game object
        /// </summary>
        public Rectangle Bounds
        {
            get
            {
                return _gameObject.Bounds;
            }
        }

        /// <summary>
        /// Image of game object
        /// </summary>
        public Image Image
        {
            get
            {
                return _gameObject.Image;
            }
            set
            {
                _gameObject.Image = value;
            }
        }

        /// <summary>
        /// Intersects with another game object
        /// </summary>
        /// <param name="gameObject">Game object</param>
        /// <returns> Intersects or not</returns>
        public bool IntersectsWith(GameObject gameObject)
        {
            return _gameObject.Bounds.IntersectsWith(gameObject.Bounds);
        }

        /// <summary>
        /// Draw game object
        /// </summary>
        /// <returns> View of game object</returns>
        public PictureBox Draw()
        {
            return _gameObject;
        }

        /// <summary>
        /// Dispose view of game object
        /// </summary>
        public void Dispose()
        {
            _gameObject.Dispose();
        }
    }
}
