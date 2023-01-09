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
    public partial class Level3 : LevelForm
    {
        const int itemsToCollect = 7;
        public Level3()
        {
            InitializeComponent();

            //inicjalizacja ekwipunku
            PictureBox[] slots = { EQ1, EQ2, EQ3 };
            PictureBox[] lifes = { L1, L2, L3 };
            playerControler.setup(player, slots, lifes, itemsToCollect);
        }

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
