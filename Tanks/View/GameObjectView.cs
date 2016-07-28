using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;

namespace View
{
    public class GameObjectView
    {
        private readonly GameObject _gameObject;
        private PictureBox _gameObjectView = new PictureBox();
        public GameObjectView(GameObject gameObject)
        {
            _gameObject = gameObject;
        }

        public int X
        {
            get
            {
                return _gameObject.X;
            }
            set
            {
                _gameObject.X = value;
            }
        }

        public int Y
        {
            get
            {
                return _gameObject.Y;
            }
            set
            {
                _gameObject.Y = value;
            }
        }

        public int Width
        {
            get
            {
                return _gameObject.Width;
            }
            set
            {
                _gameObject.Width = value;
            }
        }

        public int Height
        {
            get
            {
                return _gameObject.Height;
            }
            set
            {
                _gameObject.Height = value;
            }
        }

        public GameObject GameObject
        {
            get
            {
                return _gameObject;
            }
        }

        public PictureBox ObjectView
        {
            get
            {
                return _gameObjectView;
            }

            set
            {
                _gameObjectView = value;
            }
        }
    }
}
