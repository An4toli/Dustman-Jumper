using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dustman_Jumper
{
    public enum Rubbish
    {
        Botle,
        Paper,
        Jar,
        Empty
    }

    class Equipment    // próba przeniesienia ekwipunku do osbnej klasy
    {
        List<Rubbish> content = new List<Rubbish>();
        List<PictureBox> slotsPictures = new List<PictureBox>();

        public void setup(PictureBox[] slots)
        {
            for (int i = 0; i < slots.Length; ++i)
            {
                slotsPictures.Add(slots[i]);
                content.Add(Rubbish.Empty);
            }
        }

        public void pickup(Rubbish item)
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
                    break;
                }
                // else Ekwipuned jest pełen!
            }
        }
        public void drop(int slot)
        {
            if (content.ElementAtOrDefault(slot) != Rubbish.Empty)
            {
                //usuń
                content[slot] = Rubbish.Empty;
                slotsPictures[slot].BackgroundImage = null;
            }
        }
    }
}
