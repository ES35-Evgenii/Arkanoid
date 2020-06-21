using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();//создадим новую форму "Game"
            game.ShowDialog();//открытие вновь созданной формы, так чтобы нельзя
                              //было вернуться в родительскую форму не закрыв эту.
        }
    }
}
