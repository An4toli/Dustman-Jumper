﻿using System;
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
        Equipment EQ = new Equipment();
        bool goLeft, goRight, jumping, isGameOver;
        // zmienne dla postaci gracza
        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;
        public int setRubbish = 0;
        //bool plastik1,plastik2,plastik3,szkło,papier = false;
        bool plastik1 = false;
        bool EQ1Wolne = true;
        bool EQ2Wolne = true;
        bool EQ3Wolne = true;

        public Form1()
        {
            InitializeComponent();

            //inicjalizacja ekwipunku
            PictureBox[] slots = { EQ1, EQ2, EQ3 };
            EQ.setup(slots);
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

            txtScore.Text = "Punkty: " + score;

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

            foreach (Control x in this.Controls)
            {
                if (!(x is PictureBox))
                    continue;

                if (!player.Bounds.IntersectsWith(x.Bounds))
                    continue;

                if (!(x.Visible))
                    continue;

                string tag = (string)x.Tag;

                switch(tag)
                {
                    
                    case "platform":
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;

                            x.BringToFront(); //platformy z przodu

                            break;
                        }
                    case "botle":
                        {
                            x.Visible = false;
                            EQ.pickup(Rubbish.Botle);
                            break;
                        }
                    case "jar":
                        {
                            x.Visible = false;
                            EQ.pickup(Rubbish.Jar);
                            break;
                        }
                    case "paper":
                        {
                            x.Visible = false;
                            EQ.pickup(Rubbish.Paper);
                            break;
                        }
                }

            }


        }


        private void KeyIsDown(object sender, KeyEventArgs e)
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
            /*
            if (e.KeyCode == Keys.D1)
            {
               if (EQ1.Visible == true)
                {
                    Console.WriteLine("Nacisnieto 1");
                    plastik1 = true;
                }
               
            }
            if (e.KeyCode == Keys.D2)
            {
                if (EQ2butelka.Visible == true)
                {
                    Console.WriteLine("Nacisnieto 2");
                    plastik2 = true;
                }
            }
            if (e.KeyCode == Keys.D3)
            {
                if (EQ3butelka.Visible == true)
                {
                    Console.WriteLine("Nacisnieto 3");
                    plastik3 = true;
                }
            }
            */


        }

        private void butelkaKosz_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                if (EQ1.BackgroundImage == Properties.Resources.butelka && e.KeyCode == Keys.D1)
                    plastik1 = true;
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
            if (jumping == true)
            {
                jumping = false;
            }


            /*
            //jak pusczasz guzik to wtedy nie ma wyrzucania
            if (e.KeyCode == Keys.D1)
            {
                plastik1 = false;
            }
            if (e.KeyCode == Keys.D2)
            {
                plastik2 = false;
            }
            if (e.KeyCode == Keys.D3)
            {
                plastik3 = false;
            }
            */
        }

        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;

            score = 0;

            txtScore.Text = "Punkty: " + score;

            foreach (Control x in this.Controls)
            {
                //ustawienie wszystkich przedmiotów jako widzialne
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            //restart pozycji gracza

            player.Left = 33;
            player.Top = 592;
        }


        private void PickingRubbish(Control x)  //funkcja kontrolujaca zbieranie smieci (znikanie z planszy i pojawainie w eq)
        {

            if (EQ1Wolne)
            {
                x.Visible = false;
                switch (setRubbish)
                {

                    case 1:

                        EQ1.BackgroundImage = Properties.Resources.butelka;
                        EQ1Wolne = false;
                        break;

                    case 2:
                        EQ1.BackgroundImage = Properties.Resources.sloik;
                        EQ1Wolne = false;
                        break;
                    case 3:
                        EQ1.BackgroundImage = Properties.Resources.kartka;
                        EQ1Wolne = false;
                        break;



                }
            }
            else if (EQ2Wolne)
            {
                x.Visible = false;
                switch (setRubbish)
                {

                    case 1:

                        EQ2.BackgroundImage = Properties.Resources.butelka;
                        EQ2Wolne = false;
                        break;

                    case 2:
                        EQ2.BackgroundImage = Properties.Resources.sloik;
                        EQ2Wolne = false;
                        break;
                    case 3:
                        EQ2.BackgroundImage = Properties.Resources.kartka;
                        EQ2Wolne = false;
                        break;


                }
            }
            else if (EQ3Wolne)
            {
                x.Visible = false;
                switch (setRubbish)
                {

                    case 1:

                        EQ3.BackgroundImage = Properties.Resources.butelka;
                        EQ3Wolne = false;
                        break;

                    case 2:
                        EQ3.BackgroundImage = Properties.Resources.sloik;
                        EQ3Wolne = false;
                        break;
                    case 3:
                        EQ3.BackgroundImage = Properties.Resources.kartka;
                        EQ3Wolne = false;
                        break;
                }
            }




        }




    }
}

