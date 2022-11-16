using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dustman_Jumper
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping, isGameOver;
        // zmienne dla postaci gracza
        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Punkty: " + score;

            player.Top += jumpSpeed;

            //sprawdzanie ruchu gracza zgodnie z zegarem
            if(goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
            }

            if(jumping == true && force < 0)
            {
                jumping = false;
            }

            if(jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach( Control x in this.Controls)
            {
                if((string)x.Tag == "platform")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds)) //jak stanie na platformie to moze znowu skakac
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }

                    x.BringToFront(); //platformy z przodu
                }
            }


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Up && jumping == false)
            {
                jumping = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(jumping == true)
            {
                jumping = false;
            }
        }

        private void RestartGame ()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;

            score = 0;

            txtScore.Text = "Punkty: " + score;

            foreach(Control x in this.Controls)
            {
                //ustawienie wszystkich przedmiotów jako widzialne
                if( x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            //restart pozycji gracza

            player.Left = 33;
            player.Top = 592;
        }
    }
}
