using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GameObjectsFactory : AbstractFactory
    {
        public override Field CreateField()
        {
            return new Field();
        }

        public override Field CreateField(int x, int y, int width, int height, Color color)
        {
            return new Field(x, y, width, height, color);
        }

        public override GameObject CreateWall()
        {
            return new GameObject();
        }

        public override GameObject CraateWall(int x, int y, int width, int height, Color color)
        {
            return new GameObject(x, y, width, height, color);
        }

        public override Kolobok CreateKolobok()
        {
            return new Kolobok();
        }

        public override Kolobok CreateKolobok(int x, int y, int width, int height, Color color)
        {
            return new Kolobok(x, y, width, height, color);
        }

        public override Tank CreateTank()
        {
            return new Tank();
        }

        public override Tank CreateTank(int x, int y, int width, int height, Color color)
        {
            return new Tank(x, y, width, height, color);
        }

        public override GameObject CreateFruit()
        {
            return new GameObject();
        }

        public override GameObject CreateFruit(int x, int y, int width, int height, Color color)
        {
            return new GameObject(x, y, width, height, color);
        }
    }
}
