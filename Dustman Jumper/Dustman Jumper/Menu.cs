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
    /// typ wyliczeniowy zawieracy mozliwe stany gry
    /// </summary>
    public enum LevelResult
    {
        Win,
        Lose,
        Back,
        Restart
    }

    /// <summary>
    /// klasa zawierajaca w sobie mozliwosc kontrolowania gry (wczytywanie kolejnych poziomow)
    /// </summary>
    public partial class Menu : Form
    {
        int score = 0;
        int nextLevel = 1;

        GameOverScreen gameOver = null;
        GameWinScreen gameWin = null;
        LevelForm lvl = null;

        public Menu()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            showNextLevel();
        }

        private void gameOverHandler(object sender, EventArgs e)
        {
            score = score + lvl.score;
            //Wygrana
            if (lvl.result == LevelResult.Win)
            {
                gameWin = new GameWinScreen();
                gameWin.txtScore.Text = "Punkty: " + score;
                gameWin.FormClosing += delegate
                {
                    if (gameWin.goToNextLevel)
                    {
                        showNextLevel();
                    }
                    else
                    {
                        score = 0;
                        nextLevel = 1;
                        Show();
                    }
                };

                gameWin.Show();
                return;
            }
            //Przegrana
            if (lvl.result == LevelResult.Lose)
            {
                gameOver = new GameOverScreen();
                gameOver.txtScore.Text = "Punkty: " + score;
                gameOver.FormClosing += delegate
                {
                    score = 0;
                    nextLevel = 1;
                    Show();
                };

                gameOver.Show();
                return;
            }
            //Restart
            if (lvl.result == LevelResult.Restart)
            {
                nextLevel--;
                showNextLevel();
                return;
            }

            //Wróć do menu
            score = 0;
            nextLevel = 1;
            Show();
        }

        private LevelForm getNextLevel()
        {
            switch (nextLevel)
            {
                case 1:
                    {
                        LevelForm l = new Level1();
                        l.Location = Location;
                        l.StartPosition = FormStartPosition.Manual;
                        l.FormClosing += gameOverHandler;
                        return l;
                    }
                case 2:
                    {
                        LevelForm l = new Level2();
                        l.Location = Location;
                        l.StartPosition = FormStartPosition.Manual;
                        l.FormClosing += gameOverHandler;
                        return l;
                    }
                default:
                    {
                        LevelForm l = new Level3();
                        l.Location = Location;
                        l.StartPosition = FormStartPosition.Manual;
                        l.FormClosing += gameOverHandler;
                        return l;
                    }
            }
        }

        private void showNextLevel()
        {
            //Wróć do menu
            if (nextLevel >= 4)
                Show();

            if (lvl != null)
                lvl.Dispose();

            lvl = getNextLevel();
            lvl.Show();
            Hide();

            nextLevel++;
        }
    }
}
