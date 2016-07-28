﻿using System;
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
        private readonly GameObjectsFactory _factory = new GameObjectsFactory();
        private readonly FieldView _fieldView;
        private List<TankView> _tanks = new List<TankView>();
        private KolobokView _kolobok;

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
            field.Controls.AddRange(DrawTanks(3).ToArray());
            field.Controls.Add(DrawKolobok());
            return field;
        }

        private PictureBox DrawKolobok()
        {
            _kolobok = _factory.CreateKolobok(_fieldView.Width / 2, _fieldView.Height / 2, 10, 10);
            return _kolobok.Draw();
        }

        private IEnumerable<PictureBox> DrawTanks(int count)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < count; i++)
            {
                TankView tank = _factory.CreateTank(x, y, 10, 10);
                _tanks.Add(tank);
                x += 20;
                yield return tank.Draw();
            }
        }

        public void KolobokDirection(Keys key)
        {
            switch (key)
            {
                case Keys.Up:
                    _kolobok.Direction = PartsOfTheWorld.North;
                    break;
                case Keys.Down:
                    _kolobok.Direction = PartsOfTheWorld.South;
                    break;
                case Keys.Left:
                    _kolobok.Direction = PartsOfTheWorld.West;
                    break;
                case Keys.Right:
                    _kolobok.Direction = PartsOfTheWorld.East;
                    break;
                default:
                    break;
            }
        }

        private void KolobokMovement()
        {
            if (_kolobok.Direction == PartsOfTheWorld.None)
            {
                _kolobok.Direction = Direction(_kolobok);
                Move(_kolobok.Direction, _kolobok, 1);
            }
            else
            {
                Move(_kolobok.Direction, _kolobok, 1);
            }
        }

        public void Movement()
        {
            KolobokMovement();
            TanksMovement();
        }

        private void TanksMovement()
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

        private PartsOfTheWorld Direction(GameObjectView gameObject)
        {
            Random rnd = new Random();
            switch (rnd.Next(0, 4))
            {
                case 0:
                    if (gameObject.Y > 0)
                    {
                        return PartsOfTheWorld.North;
                    }
                    else
                    {
                        return PartsOfTheWorld.None;
                    }
                case 1:
                    if (gameObject.Y + gameObject.Width < _fieldView.Height)
                    {
                        return PartsOfTheWorld.South;
                    }
                    else
                    {
                        return PartsOfTheWorld.None;
                    }
                case 2:
                    if (gameObject.X > 0)
                    {
                        return PartsOfTheWorld.West;
                    }
                    else
                    {
                        return PartsOfTheWorld.None;
                    }
                case 3:
                    if (gameObject.Y + gameObject.Width < _fieldView.Width)
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

        private void Move(PartsOfTheWorld direction, MovableGameObjectView gameObject, int step)
        {
            switch (direction)
            {
                case PartsOfTheWorld.North:
                    MoveY(gameObject, -step);
                    break;
                case PartsOfTheWorld.South:
                    MoveY(gameObject, step);
                    break;
                case PartsOfTheWorld.West:
                    MoveX(gameObject, -step);
                    break;
                case PartsOfTheWorld.East:
                    MoveX(gameObject, step);
                    break;
                default:
                    break;
            }
        }

        private void MoveY(MovableGameObjectView gameObject, int step)
        {
            if (gameObject.Y + step >= 0 && gameObject.Y + step + gameObject.Height <= _fieldView.Height)
            {
                gameObject.Move(gameObject.X, gameObject.Y + step);
            }
            else
            {
                gameObject.Direction = Direction(gameObject);
            }
        }

        private void MoveX(MovableGameObjectView gameObject, int step)
        {
            if (gameObject.X + step >= 0 && gameObject.X + step + gameObject.Width <= _fieldView.Width)
            {
                gameObject.Move(gameObject.X + step, gameObject.Y);
            }
            else
            {
                gameObject.Direction = Direction(gameObject);
            }
        }
    }
}
