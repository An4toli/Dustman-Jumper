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
    public partial class Level1 : LevelForm
    {
        //liczba przedmiotw do podniesienia na kazdym lvlu
        const int itemsToCollect = 4;

        public Level1()
        {
            InitializeComponent();

            //inicjalizacja ekwipunku
            PictureBox[] slots = { EQ1, EQ2, EQ3 };
            PictureBox[] lifes = { L1, L2, L3 };
            playerControler.setup(player, slots, lifes, itemsToCollect);
        }

        //ładowanie kojnego poziomu

        private void Form1_Load(object sender, EventArgs e) { }


        private void MainGameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Punkty: " + playerControler.score;
            playerControler.update(Controls);

            if (playerControler.isGameOver)
            {
                if (playerControler.life.stillAlive())
                    result = LevelResult.Win;
                else
                    result = LevelResult.Lose;

                score = playerControler.score;
                this.Close();
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            result = LevelResult.Restart;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

