using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Dustman_Jumper
{
    /// <summary>
    /// Klasa zawieraja informacje dotyczace gracza: poruszanie interakcje z przedmiotami oznaczonymi tagami
    /// </summary>
    public class PlayerControler
    {
        Equipment EQ = new Equipment();
        public Life life = new Life();

        /// <summary>
        /// zmienne zawierjace informacje o ruchu
        /// </summary>
        bool goLeft, goRight, jumping;
       
        // zmienne dla postaci gracza
        int jumpSpeed = 0;
        int force = 0;
        public int score = 0;
        const int playerSpeed = 7;
        bool button1pressed = false,
             button2pressed = false,
             button3pressed = false;
        PictureBox player;
        int itemsToCollect = 0;
        public bool isGameOver;

        /// <summary>
        /// funckja ktora pozwala na przekazanie parametrow
        /// </summary>
        /// <param name="player"> przekazuje postac gracza</param>
        /// <param name="slots">przekazuje referencje do ekpinku</param>
        /// <param name="lifes">przekazuje referencje do ilosci zyc/energi</param>
        /// <param name="itemsToCollect">referencje ile przedmiotow zostalo do zebrania</param>
        public void setup(PictureBox player, PictureBox[] slots, PictureBox[] lifes, int itemsToCollect)
        {
            this.player = player;
            EQ.setup(slots);
            life.setup(lifes);

            this.itemsToCollect = itemsToCollect;
            isGameOver = false;
        }

        /// <summary>
        /// funkcja wykonywana zgodnie z zegarem w kazdej klatce
        /// </summary>
        /// <param name="controls"> referencje do obrazkow aby gracz mogl wchodzic z nimi w interakcje</param>
        public void update(ControlCollection controls)
        {
            if (isGameOver)
                return;

            player.Top += jumpSpeed;

            //sprawdzanie ruchu gracza zgodnie z zegarem
            if (goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach (Control x in controls)
            {
                if (!(x is PictureBox))
                    continue;

                if (!player.Bounds.IntersectsWith(x.Bounds))
                    continue;

                if (!(x.Visible))
                    continue;

                string tag = (string)x.Tag;
                int clickedSlot = getClickedSlot();

                switch (tag)
                {

                    case "platform":
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;
                            break;
                        }
                    case "botle":
                        {
                            if (EQ.pickup(Rubbish.Botle))
                                x.Visible = false;
                            break;
                        }
                    case "jar":
                        {
                            if (EQ.pickup(Rubbish.Jar))
                                x.Visible = false;
                            break;
                        }
                    case "paper":
                        {
                            if (EQ.pickup(Rubbish.Paper))
                                x.Visible = false;
                            break;
                        }
                    case "paperdumpster":
                        {
                            if (clickedSlot == -1)
                                break;

                            Rubbish rub = EQ.drop(clickedSlot);
                            if (rub == Rubbish.Paper)
                            {
                                score++;
                                break;
                            }
                            if (rub == Rubbish.Empty)
                                break;

                            life.takeLife();
                            break;
                        }
                    case "glassdumpster":
                        {
                            if (clickedSlot == -1)
                                break;

                            Rubbish rub = EQ.drop(clickedSlot);
                            if (rub == Rubbish.Jar)
                            {
                                score++;
                                break;
                            }
                            if (rub == Rubbish.Empty)
                                break;

                            life.takeLife();
                            break;
                        }
                    case "plasticdumpster":
                        {
                            if (clickedSlot == -1)
                                break;


                            Rubbish rub = EQ.drop(clickedSlot);
                            if (rub == Rubbish.Botle)
                            {
                                score++;
                                break;
                                    }
                            if (rub == Rubbish.Empty)
                                break;

                            life.takeLife();
                            break;
                        }
                }
            }

            // przegrana
            if (life.stillAlive() == false)
                isGameOver = true;

            //wygrana
            if (EQ.isEmpty() && EQ.collectedItemsAmount == itemsToCollect)
                isGameOver = true;

        }
        /// <summary>
        /// wykrywanie nacisniecia klawisza
        /// </summary>
        /// <param name="e"> wydarzenie zwiazane z nacisnieciem klawisza</param>
        public void KeyPressed(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.W && jumping == false)
            {
                jumping = true;
            }

            //tutaj dodajemy do sprawdzenia czy zadziala wyrzucanie smieci
            // Do przerobienia wyrzucanie smieci

            if (e.KeyCode == Keys.D1)
                button1pressed = true;

            if (e.KeyCode == Keys.D2)
                button2pressed = true;

            if (e.KeyCode == Keys.D3)
                button3pressed = true;
        }

        /// <summary>
        /// puszczenie klawisza
        /// </summary>
        /// <param name="e">wydarzenia zwiazane z puszczeniem klawisza</param>
        public void KeyReleased(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }


            //jak pusczasz guzik to wtedy nie ma wyrzucania
            if (e.KeyCode == Keys.D1)
                button1pressed = false;

            if (e.KeyCode == Keys.D2)
                button2pressed = false;

            if (e.KeyCode == Keys.D3)
                button3pressed = false;

        }

        /// <summary>
        /// funckja zwracajaca wartosc liczobwa zaleznie od tego jaki klawisz zostal nacisniety
        /// </summary>
        /// <returns></returns>
        private int getClickedSlot()
        {
            if (button1pressed) return 0;
            if (button2pressed) return 1;
            if (button3pressed) return 2;

            return -1;
        }
    }
}
