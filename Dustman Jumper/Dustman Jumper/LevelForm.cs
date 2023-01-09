using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dustman_Jumper
{
    public class LevelForm : Form
    {
        public PlayerControler playerControler = new PlayerControler();
        public LevelResult result = LevelResult.Back;
        public int score = 0;
        //liczba przedmiotw do podniesienia na kazdym lvlu
        protected const int itemsToCollect = 0;
    }
}
