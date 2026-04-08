using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        bool pause = false;
        bool gameIsOver = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }
           
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {

            if (!pause)
            {
                if (e.KeyCode == Keys.Space)
                {
                    gravity = -10;
                }
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (!gameIsOver)
                {
                    if (pause)
                    {
                        StartTimer();
                        label1.Visible = false;
                        pause = false;
                    }
                    else
                    {
                        label1.Location = new Point(this.Width / 2 - 80, 150);
                        label1.Text = "PAUSED";
                        label1.Visible = true;
                        StopTimers();
                        pause = true;
                    }
                }
            }
        }

        private void StartTimer()
        {
            gameTimer.Start();
        }

        private void StopTimers()
        {
            gameTimer.Stop();
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!!!";
        }
    }
}
