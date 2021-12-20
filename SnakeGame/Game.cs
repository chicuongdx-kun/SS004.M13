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
    public partial class Game : Form
    {
        //Data snake game
        List<PictureBox> snake;
        int snakeSize = 5;
        Point location = new Point(120, 120);
        string direction = "right";
        bool change = false;

        //data food
        PictureBox food = new PictureBox();
        Point foodLocation = new Point(0, 0);

        public Game()
        {
            InitializeComponent();
            StarGame();
        }
        private void btnReStart_Click(object sender, EventArgs e)
        {
            StarGame();
        }

        private void StarGame()
        {
            pnlGame.Controls.Clear();
            snake = null;
            lbScore.Text = "0";
            snakeSize = 5;
            direction = "right";
            location = new Point(120, 120);

            // start game
            drawSnake();
            drawFood();

            GameTimer.Start();

            btnStop.Enabled = true;
        }

        private void drawSnake()
        {
            snake = new List<PictureBox>();
            for (int i = 0; i < snakeSize; i++)
            {
                PictureBox part = new PictureBox();
                part.Size = new Size(15, 15);
                part.BackColor = Color.Red;
                part.BorderStyle = BorderStyle.FixedSingle;
                part.Location = new Point(location.X - (15 * i), location.Y);
                pnlGame.Controls.Add(part);
                snake.Add(part);
            }
        }
        private void drawFood()
        {
            Random rnd = new Random();
            int xrand = rnd.Next(Convert.ToInt32(pnlGame.Width / 15)) * 15;
            int yrand = rnd.Next(Convert.ToInt32(pnlGame.Height / 15)) * 15;

            bool isOnSnake = true;
            while (isOnSnake)
            {
                for (int i = 0; i < snakeSize; i++)
                {
                    if (snake[i].Location == new Point(xrand, yrand))
                    {
                        xrand = rnd.Next(Convert.ToInt32(pnlGame.Width / 15)) * 15;
                        yrand = rnd.Next(Convert.ToInt32(pnlGame.Height / 15)) * 15;
                    }
                    else
                    {
                        isOnSnake = false;
                    }
                }
            }

            if (isOnSnake == false)
            {
                foodLocation = new Point(xrand, yrand);
                food.Size = new Size(15, 15);
                food.BackColor = Color.Yellow;
                food.BorderStyle = BorderStyle.FixedSingle;
                food.Location = foodLocation;
                pnlGame.Controls.Add(food);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        private void Move()
        {
            Point point = new Point(0, 0);

            for (int i = 0; i < snakeSize; i++)
            {
                if (i == 0)
                {
                    point = snake[i].Location;
                    if (direction == "left")
                    {
                        snake[i].Location = new Point(snake[i].Location.X - 15, snake[i].Location.Y);
                    }
                    if (direction == "right")
                    {
                        snake[i].Location = new Point(snake[i].Location.X + 15, snake[i].Location.Y);
                    }
                    if (direction == "top")
                    {
                        snake[i].Location = new Point(snake[i].Location.X, snake[i].Location.Y - 15);
                    }
                    if (direction == "down")
                    {
                        snake[i].Location = new Point(snake[i].Location.X, snake[i].Location.Y + 15);
                    }
                }
                else
                {
                    Point newpoint = snake[i].Location;
                    snake[i].Location = point;
                    point = newpoint;
                }
            }

            change = false;

            //eat food
            if (snake[0].Location == foodLocation)
            {
                Eat();
                drawFood();
            }

            //hits the wall
            if (snake[0].Location.X < 0 || snake[0].Location.X >= pnlGame.Width || snake[0].Location.Y < 0 || snake[0].Location.Y >= pnlGame.Height)
            {
                Stop();
            }

            //hit itself
            for (int i = 3; i < snakeSize; i++)
            {
                if (snake[0].Location == snake[i].Location)
                {
                    Stop();
                }
            }
        }

        private void Eat()
        {
            snakeSize++;

            List<PictureBox> oldSnake = snake;
            pnlGame.Controls.Clear();

            snake = new List<PictureBox>();
            for (int i =0; i < snakeSize; i++)
            {
                PictureBox part = new PictureBox();
                part.Size = new Size(15, 15);
                part.BackColor = Color.Red;
                part.BorderStyle = BorderStyle.FixedSingle;
                
                if (i == 0)
                {
                    part.Location = foodLocation;
                }
                else
                {
                    part.Location = oldSnake[i - 1].Location;
                }
                pnlGame.Controls.Add(part);
                snake.Add(part);
            }

            //update score

            lbScore.Text = (Convert.ToInt32(lbScore.Text) + 1).ToString();
            // update highscore
        }

        private void Stop()
        {
            GameTimer.Stop();
            btnStop.Enabled = false;

            new FrmNotice(Convert.ToInt32(lbScore.Text)).ShowDialog();

            StarGame();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.W || keyData == Keys.Up) && direction != "down" && change != true)
            {
                direction = "top";
                change = true;
            }
            if ((keyData == Keys.S || keyData == Keys.Down) && direction != "up" && change != true)
            {
                direction = "down";
                change = true;
            }
            if ((keyData == Keys.A || keyData == Keys.Left) && direction != "right" && change != true)
            {
                direction = "left";
                change = true;
            }
            if ((keyData == Keys.D || keyData == Keys.Right) && direction != "left" && change != true)
            {
                direction = "right";
                change = true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameTimer.Stop();
        }
    }
}
