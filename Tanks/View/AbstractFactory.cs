using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public abstract class AbstractFactory
    {
        public abstract FieldView CreateField();
        public abstract FieldView CreateField(int x, int y, int width, int height);
        public abstract KolobokView CreateKolobok();
        public abstract KolobokView CreateKolobok(int x, int y, int width, int height);
        public abstract TankView CreateTank();
        public abstract TankView CreateTank(int x, int y, int width, int height);
    }
}
