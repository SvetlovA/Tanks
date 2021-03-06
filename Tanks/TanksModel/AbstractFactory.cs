﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class AbstractFactory
    {
        public abstract Field CreateField();
        public abstract Field CreateField(int x, int y, int width, int height, Color color);
        public abstract Field CreateField(int x, int y, int width, int height, Bitmap image);
        public abstract GameObject CreateWall();
        public abstract GameObject CraateWall(int x, int y, int width, int height, Color color);
        public abstract GameObject CraateWall(int x, int y, int width, int height, Bitmap image);
        public abstract Kolobok CreateKolobok();
        public abstract Kolobok CreateKolobok(int x, int y, int width, int height, Color color);
        public abstract Kolobok CreateKolobok(int x, int y, int width, int height, Bitmap image);
        public abstract Tank CreateTank();
        public abstract Tank CreateTank(int x, int y, int width, int height, Color color);
        public abstract Tank CreateTank(int x, int y, int width, int height, Bitmap image);
        public abstract GameObject CreateFruit();
        public abstract GameObject CreateFruit(int x, int y, int width, int height, Color color);
        public abstract GameObject CreateFruit(int x, int y, int width, int height, Bitmap image);
    }
}
