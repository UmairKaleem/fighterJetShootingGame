using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jf_17
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, isGameOver, shooting;

        int speed;
        int score;
        int playerSpeed = 30;
        int enemySpeed;
        int bulletSpeed;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }


        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text=score.ToString();

            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;


            if (enemyOne.Top > 560|| enemyTwo.Top > 560 || enemyThree.Top > 560)
            {
                gameOver();
            }


            if(goLeft== true && player.Left >0)
            {
                player.Left -= playerSpeed;
            }
            if(goRight == true && player.Left < 747)
            {
                player.Left += playerSpeed;
            }
            // playr moving logic
            if(shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }
            if (bullet.Top < -30)
            {
                shooting = false;

            }
            if (bullet.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                score += 1;
                enemyOne.Top = -450;
                enemyOne.Left = rand.Next(20, 600);
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                score += 1;
                enemyTwo.Top = -600;
                enemyTwo.Left = rand.Next(20, 600);
                //enemyTwo.Left = rand.Next(20, 600);
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                score += 1;
                enemyThree.Top = -750;
                enemyThree.Left = rand.Next(20, 600);
                shooting = false;
            }
            if(score == 10)
            {
                enemySpeed = 10;
            }
        }
        


        private void keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting ==false)
            {
                shooting = true;

                bullet.Top =  player.Top - 30;
                bullet.Left = player.Left + (player.Width/2);
                

            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }


        }

        private void resetGame()
        {
            gameTimer.Start();
            enemySpeed = 6;


            enemyOne.Left = rand.Next(20, 600);
            enemyTwo.Left = rand.Next(20, 600);
            enemyThree.Left = rand.Next(20, 600);

            enemyOne.Top = rand.Next(0, 200)* -1;
            enemyTwo.Top = rand.Next(0, 500) * -1;
            enemyThree.Top = rand.Next(0, 900) * -1;

            score = 0;
            bulletSpeed = 10;
            bullet.Left = -300;
            shooting = false;
            txtScore.Text = score.ToString();


        }
        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text += Environment.NewLine + " Game Over ! " + Environment.NewLine + " Press Enter to Try again ";
        }
    }
}

