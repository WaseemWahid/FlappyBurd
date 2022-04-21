using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBurd
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if(pipeDown.Left < -150)
            {
                pipeDown.Left = 800;
                score++;
            }
            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappybird.Bounds.IntersectsWith(pipeDown.Bounds) || 
                flappybird.Bounds.IntersectsWith(pipeTop.Bounds)  ||
                flappybird.Bounds.IntersectsWith(ground.Bounds) || flappybird.Top < -25

                )
            {
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 15;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!";
        }
    }
}
