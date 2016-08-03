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

namespace View
{
    public partial class MainForm : Form
    {
        PackmanController _controller;
        ResultForm resultForm;
        private const int MENU_WIDTH = 200;
        private const int MENU_HEIGHT = 250;

        public MainForm()
        {
            InitializeComponent();
            Width = MENU_WIDTH;
            Height = MENU_HEIGHT;
            buttonNewGame.Location = new Point(MENU_WIDTH / 2 - buttonNewGame.Width / 2 - 10, MENU_HEIGHT / 2 - 100);
            buttonExit.Location = new Point(MENU_WIDTH / 2 - buttonExit.Width / 2 - 10, MENU_HEIGHT / 2 - 50);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _controller.Movement();
            _controller.GetFruit();
            if (_controller.Fighting())
            {
                MoveTimer.Enabled = false;
                FruitTimer.Enabled = false;
                resultForm = new ResultForm(_controller);
                if (resultForm.ShowDialog() == DialogResult.Cancel)
                {
                    DeleteControls();
                    Width = MENU_WIDTH;
                    Height = MENU_HEIGHT;
                    buttonNewGame.Visible = true;
                    buttonExit.Visible = true;
                }
            }
        }

        private void DeleteControls()
        {
            foreach (Control control in Controls)
            {
                if (control.GetType() != typeof(Button))
                {
                    Controls.Remove(control);
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            _controller.KolobokDirection(e.KeyCode);
        }

        private void FruitTimer_Tick(object sender, EventArgs e)
        {
            _controller.DrawFruit();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            _controller = new PackmanController();
            Controls.Add(_controller.Draw());
            Width = _controller.Field.Width + 40;
            Height = _controller.Field.Height + 60;
            buttonNewGame.Visible = false;
            buttonExit.Visible = false;
            MoveTimer.Enabled = true;
            FruitTimer.Enabled = true;
            Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
