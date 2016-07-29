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
        public override GameObject CreateField()
        {
            return new GameObject();
        }

        public override GameObject CreateField(int x, int y, int width, int height, Color color)
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
    }
}
