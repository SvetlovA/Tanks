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
    public class FieldView : GameObjectView
    {
        private Field _field;
        private PictureBox _fieldView = new PictureBox();

        public FieldView() : base(new Field())
        {
            _field = (Field)GameObject;
        }

        public FieldView(int x, int y, int width, int height) : base(new Field(x, y, width, height))
        {
            _field = (Field)GameObject;
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
