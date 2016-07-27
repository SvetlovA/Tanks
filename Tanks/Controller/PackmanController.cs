using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using System.Windows.Forms;

namespace Controller
{
    public class PackmanController
    {
        private GameObjectsFactory _factory = new GameObjectsFactory();
        private readonly FieldView _fieldView;
        List<TankView> _tanks = new List<TankView>();
        private int _speedX;
        private int _speedY;

        public PackmanController()
        {
            _fieldView = _factory.CreateField();
        }

        public int FieldWidth
        {
            get
            {
                return _fieldView.Width;
            }
            set
            {
                _fieldView.Width = value;
            }
        }

        public int FieldHeight
        {
            get
            {
                return _fieldView.Height;
            }
            set
            {
                _fieldView.Height = value;
            }
        }

        public PictureBox Draw()
        {
            PictureBox field = _factory.CreateField(10, 10, FieldWidth, FieldHeight).Draw();
            int x = 0;
            int y = 0;
            for (int i = 0; i < 3; i++)
            {
                TankView tank = _factory.CreateTank(x, y, 10, 10);
                field.Controls.Add(tank.Draw());
                _tanks.Add(tank);
                x += 20;
            }
            return field;
        }

        public void Movement()
        {
            foreach (var tank in _tanks)
            {
                if (tank.Direction == PartsOfTheWorld.None)
                {
                    tank.Direction = Direction(tank);
                    Move(tank.Direction, tank, 1);
                }
                else
                {
                    Move(tank.Direction, tank, 1);
                }
            }
        }

        private PartsOfTheWorld Direction(TankView tank)
        {
            Random rnd = new Random();
            switch (rnd.Next(0, 4))
            {
                case 0:
                    if (tank.Y > 0)
                    {
                        return PartsOfTheWorld.North;
                    }
                    else
                    {
                        return PartsOfTheWorld.None;
                    }
                case 1:
                    if (tank.Y + tank.Width < _fieldView.Height)
                    {
                        return PartsOfTheWorld.South;
                    }
                    else
                    {
                        return PartsOfTheWorld.None;
                    }
                case 2:
                    if (tank.X > 0)
                    {
                        return PartsOfTheWorld.West;
                    }
                    else
                    {
                        return PartsOfTheWorld.None;
                    }
                case 3:
                    if (tank.Y + tank.Width < _fieldView.Width)
                    {
                        return PartsOfTheWorld.East;
                    }
                    else
                    {
                        return PartsOfTheWorld.None;
                    }
                default:
                    return PartsOfTheWorld.None;
            }
        }

        private void Move(PartsOfTheWorld direction, TankView tank, int step)
        {
            switch (direction)
            {
                case PartsOfTheWorld.North:
                    MoveY(tank, -step);
                    break;
                case PartsOfTheWorld.South:
                    MoveY(tank, step);
                    break;
                case PartsOfTheWorld.West:
                    MoveX(tank, -step);
                    break;
                case PartsOfTheWorld.East:
                    MoveX(tank, step);
                    break;
                default:
                    break;
            }
        }

        private void MoveY(TankView tank, int step)
        {
            if (tank.Y + step >= 0 && tank.Y + step + tank.Height <= _fieldView.Height)
            {
                tank.Move(tank.X, tank.Y + step);
            }
            else
            {
                tank.Direction = Direction(tank);
            }
        }

        private void MoveX(TankView tank, int step)
        {
            if (tank.X + step >= 0 && tank.X + step + tank.Width <= _fieldView.Width)
            {
                tank.Move(tank.X + step, tank.Y);
            }
            else
            {
                tank.Direction = Direction(tank);
            }
        }
    }
}
