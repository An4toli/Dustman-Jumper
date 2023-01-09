using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dustman_Jumper
{
    /// <summary>
    /// klasa do zarzadzania poziomem energii (zyc)
    /// </summary>
    public class Life
    {
        int HP;

        List<PictureBox> lifePictures = new List<PictureBox>();

        /// <summary>
        /// funkcja sluzacja do inicjalizacji
        /// </summary>
        /// <param name="lifes">przekazanie obrazkow zyc</param>
        public void setup(PictureBox[] lifes)
        {
            for (int i = 0; i < lifes.Length; ++i)
            {
                lifePictures.Add(lifes[i]);
               
            }
            HP = lifes.Length;
        }

        /// <summary>
        /// funkcja sluzaca do odejmowania zyc
        /// </summary>
        public void takeLife()
        {
            HP--;
            if (HP >= 0)
                 lifePictures[HP].BackgroundImage = Properties.Resources.pustaenrgia;
        }
        /// <summary>
        /// funckja sprawdzajaca czy gracz posiada jakies zycia
        /// </summary>
        /// <returns>zwraca true jesli gracz zyje</returns>
        public bool stillAlive()
        {
            if (HP > 0)
                return true;

            return false;
        }



    }
}
