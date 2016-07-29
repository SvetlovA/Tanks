using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class AbstractFactory
    {
        public abstract GameObject CreateField();
        public abstract GameObject CreateField(int x, int y, int width, int height, Color color);
        public abstract Kolobok CreateKolobok();
        public abstract Kolobok CreateKolobok(int x, int y, int width, int height, Color color);
        public abstract Tank CreateTank();
        public abstract Tank CreateTank(int x, int y, int width, int height, Color color);
    }
}
