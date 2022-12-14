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
    /// <summary>
    /// klasa zawierajaca informacje o poziomie 2
    /// </summary>
    public partial class Level2 : LevelForm
    {
        /// <summary>
        /// Określa ile przedmiotów jest do podniesienia na kazdym poziomie
        /// </summary>
        const int itemsToCollect = 4;
        
        public Level2()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = LevelResult.Restart;
            Close();
        }
    }
}
