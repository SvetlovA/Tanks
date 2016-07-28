using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace UserInterface
{
    public partial class MainForm : Form
    {
        PackmanController _controller = new PackmanController();

        public MainForm()
        {
            InitializeComponent();
            _controller.FieldWidth = 400;
            _controller.FieldHeight = 400;
            Controls.Add(_controller.Draw());
            Width = _controller.FieldWidth + 40;
            Height = _controller.FieldHeight + 60;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _controller.Movement();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            _controller.KolobokDirection(e.KeyCode);
        }
    }
}
