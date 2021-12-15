using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SnakeGame : Form
    {
        public SnakeGame()
        {
            InitializeComponent();
        }

        private void PlayGame()
        {
            Game play = new Game();
            play.ShowDialog();

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayGame();
        }

        private void gameMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayGame();
        }
    }
}
