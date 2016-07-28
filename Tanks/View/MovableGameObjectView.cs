using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;

namespace View
{
    public class MovableGameObjectView : GameObjectView
    {
        private MovableGameObject _movableGameObject;
        private PartsOfTheWorld _direction;

        public MovableGameObjectView(MovableGameObject movableGameObject) : base(movableGameObject)
        {
            _movableGameObject = movableGameObject;
        }

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

        public void Move(int newX, int newY)
        {
            ObjectView.Location = _movableGameObject.Move(newX, newY);
        }
    }
}
