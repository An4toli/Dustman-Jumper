using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dustman_Jumper
{
    /// <summary>
    /// Zawiera mozliwe stany ekwipunku
    /// </summary>
    public enum Rubbish
    {
        Botle,
        Paper,
        Jar,
        Empty
    }
    /// <summary>
    /// Klasa do zazadzania ekwipunkiem podmienia obrazkow i usuwanie przedmiotw z eq
    /// </summary>
    class Equipment    // próba przeniesienia ekwipunku do osbnej klasy
    {
        List<Rubbish> content = new List<Rubbish>();
        List<PictureBox> slotsPictures = new List<PictureBox>();
        public int collectedItemsAmount = 0;

        public void setup(PictureBox[] slots)
        {
            for (int i = 0; i < slots.Length; ++i)
            {
                slotsPictures.Add(slots[i]);
                content.Add(Rubbish.Empty);
            }
        }

        /// <summary>
        /// funckja pozwalajaca na podnoszenie przedmiotow i pojawia sie ich w eq
        /// </summary>
        /// <param name="item"> parametr okresjacy jaki przedmiot z typu enum zostal posniesiony</param>
        /// <returns>zwraca informacje czy przedmiot zostal podniesiony</returns>
        public bool pickup(Rubbish item)
        {
            for (int i = 0; i < content.Count(); ++i)
            {
                if (content[i] == Rubbish.Empty)
                {
                    content[i] = item;

                    System.Drawing.Bitmap picture = null;
                    switch (item)
                    {
                        case Rubbish.Botle:
                            {
                                picture = Properties.Resources.butelka;
                                break;
                            }

                        case Rubbish.Paper:
                            {
                                picture = Properties.Resources.kartka;
                                break;
                            }

                        case Rubbish.Jar:
                            {
                                picture = Properties.Resources.sloik;
                                break;
                            }
                    }

                    slotsPictures[i].BackgroundImage = picture;
                    //kazde zebranie przedmiotu do eq zwieksza ilosc
                    collectedItemsAmount++;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// funkcja sluzacja do pozbywania sie przedmiot z eq (wyrzucania do kosza)
        /// </summary>
        /// <param name="slot">parametr okreslajacy miejsce w eq i co sie w nim znajduje</param>
        /// <returns>zwraca co za przedmiot zostal wyrzucony</returns>
        public Rubbish drop(int slot)
        {
            if (content.ElementAtOrDefault(slot) != Rubbish.Empty)
            {
                //usuń
                Rubbish ret = content[slot];
                content[slot] = Rubbish.Empty;
                slotsPictures[slot].BackgroundImage = null;
                return ret;
            }
            return Rubbish.Empty;
        }

        //ekwipunek sprawdza czy eq jest puste
        /// <summary>
        /// funkja sprawdzajaca czy ekwpinuek jest pusty
        /// </summary>
        /// <returns>zwraca wartosc true jesli wszystkie sloty w ekwipunku sa puste</returns>
        public bool isEmpty()
        {
            for (int i = 0; i < content.Count(); ++i)
            {
                if (content[i] != Rubbish.Empty)
                    return false;
            }
            return true;
        }
    }
}
