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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            Form1 gameWindow = new Form1();
            gameWindow.Location = this.Location;
            gameWindow.StartPosition = FormStartPosition.Manual;
            gameWindow.FormClosing += delegate { this.Show(); };
            gameWindow.Show();
            this.Hide();
        }
    }
}
