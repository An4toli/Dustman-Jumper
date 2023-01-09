using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Dustman_Jumper
{
    class PlayerControler
    {
        Equipment EQ = new Equipment();
        bool goLeft, goRight, jumping, isGameOver;
        // zmienne dla postaci gracza
        int jumpSpeed = 0;
        int force = 0;
        public int score = 0;
        const int playerSpeed = 7;
        bool button1pressed = false,
             button2pressed = false,
             button3pressed = false;
        PictureBox player;

        public void setup(PictureBox player, PictureBox[] slots)
        {
            this.player = player;
            EQ.setup(slots);
        }


        public void update(ControlCollection controls)
        {
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

                            if (EQ.drop(clickedSlot) == Rubbish.Paper)
                                score++;
                            //else


                            break;
                        }
                    case "glassdumpster":
                        {
                            if (clickedSlot == -1)
                                break;

                            if (EQ.drop(clickedSlot) == Rubbish.Jar)
                                score++;
                            break;
                        }
                    case "plasticdumpster":
                        {
                            if (clickedSlot == -1)
                                break;

                            if (EQ.drop(clickedSlot) == Rubbish.Botle)
                                score++;
                            break;
                        }
                }
            }
        }
        public void KeyPressed(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && jumping == false)
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

        public void KeyReleased(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
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

        private int getClickedSlot()
        {
            if (button1pressed) return 0;
            if (button2pressed) return 1;
            if (button3pressed) return 2;

            return -1;
        }
    }
}
