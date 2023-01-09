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
    public partial class GameWinScreen : Form
    {
        public bool goToNextLevel = false;
        public GameWinScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            goToNextLevel = true;
            this.Close();

        }
    }
}
