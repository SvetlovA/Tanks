using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class FieldView
    {
        private Field _field = new Field();
        private PictureBox _fieldView = new PictureBox();

        public FieldView()
        { }

        public FieldView(int x, int y, int width, int height)
        {
            _field.X = x;
            _field.Y = y;
            _field.Width = width;
            _field.Height = height;
        }

        public int X
        {
            get
            {
                return _field.X;
            }
            set
            {
                _field.X = value;
            }
        }

        public int Y
        {
            get
            {
                return _field.Y;
            }
            set
            {
                _field.Y = value;
            }
        }

        public int Width
        {
            get
            {
                return _field.Width;
            }
            set
            {
                _field.Width = value;
            }
        }

        public int Height
        {
            get
            {
                return _field.Height;
            }
            set
            {
                _field.Height = value;
            }
        }

        public PictureBox Draw()
        {
            _fieldView.Location = new Point(_field.X, _field.Y);
            _fieldView.Size = new Size(_field.Width, _field.Height);
            _fieldView.BackColor = Color.White;

            return _fieldView;
        }
    }
}
