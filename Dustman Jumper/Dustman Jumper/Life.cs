using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dustman_Jumper
{
    public class Life
    {
        int HP;

        List<PictureBox> lifePictures = new List<PictureBox>();

        public void setup(PictureBox[] lifes)
        {
            for (int i = 0; i < lifes.Length; ++i)
            {
                lifePictures.Add(lifes[i]);
               
            }
            HP = lifes.Length;
        }

        public void takeLife()
        {
            HP--;
            if (HP >= 0)
                 lifePictures[HP].BackgroundImage = Properties.Resources.pustaenrgia;
        }
        public bool stillAlive()
        {
            if (HP > 0)
                return true;

            return false;
        }



    }
}
