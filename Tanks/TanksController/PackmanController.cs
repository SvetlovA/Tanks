using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;
using System.Drawing;

namespace Controller
{
    public class PackmanController
    {
        private readonly GameObjectsFactory _factory = new GameObjectsFactory();
        private Field _field;
        private List<Tank> _tanks = new List<Tank>();
        private List<GameObject> _walls = new List<GameObject>();
        private Kolobok _kolobok;
        private GameObject _fruit;

        private string[] map = new string[] 
        {
            "wwwwwwwwww",
            "w000w000ew",
            "w00ww000ew",
            "w00w00000w",
            "we0w00000w",
            "w00000000w",
            "w0000000pw",
            "wwwwwwwwww"
        };

        public PackmanController()
        {
            _field = _factory.CreateField();
        }

        public GameObject Field
        {
            get
            {
                return _field;
            }
        }

        public Kolobok Kolobok
        {
            get
            {
                return _kolobok;
            }
        }

        public List<Tank> Tanks
        {
            get
            {
                return _tanks;
            }
        }

        public PictureBox Draw()
        {
            _field = _factory.CreateField(10, 10, map[0].Length * 10, map.Length * 10, Color.White);
            for (int y = 0; y < map.Length; y++)
            {
                for (int x = 0; x < map[y].Length; x++)
                {
                    switch (map[y][x])
                    {
                        case 'w':
                            _field.Add(DrawWall(x, y));
                            break;
                        case 'e':
                            _field.Add(DrawTank(x, y));
                            break;
                        case 'p':
                            _field.Add(DrawKolobok(x, y));
                            break;
                        default:
                            break;
                    }
                }
            }
            return _field.Draw();
        }

        private Kolobok DrawKolobok(int x, int y)
        {
            _kolobok = _factory.CreateKolobok(_field.Width / 2, _field.Height / 2, 10, 10, Color.Red);
            return _kolobok;
        }

        private Tank DrawTank(int x, int y)
        {
            Tank tank = _factory.CreateTank(x * 10, y * 10, 10, 10, Color.Black);
            _tanks.Add(tank);
            return tank;
        }

        private GameObject DrawWall(int x, int y)
        {
            GameObject wall = _factory.CraateWall(x * 10, y * 10, 10, 10, Color.Blue);
            _walls.Add(wall);
            return wall;
        }

        public void DrawFruit()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, map[0].Length);
            int y = rnd.Next(0, map.Length);
            if (_fruit != null)
            {
                _fruit.Dispose();
            }
            if (map[y][x] != 'w')
            {
                _fruit = _factory.CreateFruit(x * 10, y * 10, 10, 10, Color.Red);
                _field.Add(_fruit);
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

        private PartsOfTheWorld Direction(GameObject gameObject)
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
                    if (gameObject.Y + gameObject.Width < _field.Height)
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
                    if (gameObject.Y + gameObject.Width < _field.Width)
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

        private void Move(PartsOfTheWorld direction, MovableGameObject gameObject, int step)
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

        private bool IntersectsWithWall(MovableGameObject gameObject)
        {
            foreach (var wall in _walls)
            {
                if (gameObject.IntersectsWith(wall))
                {
                    return false;
                }
            }
            return true;
        }

        private void MoveY(MovableGameObject gameObject, int step)
        {
            MovableGameObject nextPosition = new MovableGameObject(gameObject.X, gameObject.Y + step, gameObject.Width, gameObject.Height, gameObject.Color);
            if (nextPosition.Y >= 0 && nextPosition.Y + nextPosition.Height <= _field.Height && IntersectsWithWall(nextPosition))
            {
                gameObject.Move(gameObject.X, gameObject.Y + step);
            }
            else
            {
                gameObject.Direction = Direction(gameObject);
            }
        }

        private void MoveX(MovableGameObject gameObject, int step)
        {
            MovableGameObject nextPosition = new MovableGameObject(gameObject.X + step, gameObject.Y, gameObject.Width, gameObject.Height, gameObject.Color);
            if (nextPosition.X >= 0 && nextPosition.X + nextPosition.Width <= _field.Width && IntersectsWithWall(nextPosition))
            {
                gameObject.Move(gameObject.X + step, gameObject.Y);
            }
            else
            {
                gameObject.Direction = Direction(gameObject);
            }
        }

        public void Fighting()
        {
            foreach (var tank in _tanks)
            {
                if (_kolobok.IntersectsWith(tank))
                {
                    tank.Attack(_kolobok);
                }
            }
        }
    }
}
