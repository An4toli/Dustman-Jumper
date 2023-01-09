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
        PlayerControler playerControler = new PlayerControler();
        public Form1()
        {
            InitializeComponent();

            //inicjalizacja ekwipunku
            PictureBox[] slots = { EQ1, EQ2, EQ3 };
            playerControler.setup(player,slots);

        }



        //ładowanie kojnego poziomu

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            
            LVL2 gameWindow = new LVL2();

            gameWindow.Show();
            */

        }


        private void MainGameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Punkty: " + playerControler.score;


            playerControler.update(Controls);
            
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            playerControler.KeyPressed(e);
            }


        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            playerControler.KeyReleased(e);
        }

       


        private void RestartGame()
        {
            //jumping = false;
            //goLeft = false;
            //goRight = false;
            //isGameOver = false;

            //score = 0;

            //txtScore.Text = "Punkty: " + score;

            //foreach (Control x in this.Controls)
            //{
            //    //ustawienie wszystkich przedmiotów jako widzialne
            //    if (x is PictureBox && x.Visible == false)
            //    {
            //        x.Visible = true;
            //    }
            //}

            ////restart pozycji gracza

            //player.Left = 33;
            //player.Top = 592;
        }


    }
}

