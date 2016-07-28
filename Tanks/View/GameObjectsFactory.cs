using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class GameObjectsFactory : AbstractFactory
    {
        public override FieldView CreateField()
        {
            return new FieldView();
        }

        public override FieldView CreateField(int x, int y, int width, int height)
        {
            return new FieldView(x, y, width, height);
        }

        public override KolobokView CreateKolobok()
        {
            return new KolobokView();
        }

        public override KolobokView CreateKolobok(int x, int y, int width, int height)
        {
            return new KolobokView(x, y, width, height);
        }

        public override TankView CreateTank()
        {
            return new TankView();
        }

        public override TankView CreateTank(int x, int y, int width, int height)
        {
            return new TankView(x, y, width, height);
        }
    }
}
