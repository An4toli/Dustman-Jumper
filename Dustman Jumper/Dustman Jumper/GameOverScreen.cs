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
    /// Klasa sluzaca do zarzadzanai ekranem konca gry (przegrana)
    /// </summary>
    public partial class GameOverScreen : Form
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
