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

            DataScore.DataSet = DataScore.CreateData();

            //get max score
            DataView top = DataScore.DataSet.DefaultView;
            top.Sort = "Score desc";
            DataScore.HighScore = Convert.ToInt32(top[0]["Score"]);
        }

        private void PlayGame()
        {
            Game play = new Game();
            this.Visible = false;
            play.ShowDialog();
            this.Visible = true;

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayGame();
        }

        private void gameMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SnakeGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataScore.Save();
        }

        private void HighScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HighScore().Show();
        }
    }
}
