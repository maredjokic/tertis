using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PodaciTetris
{
    public class Figura
    {
        public Color col;
        public Kvadrat[] kockice;

        public Figura(int broj)
        {
            if (broj == 0)
            {
                col = Color.Yellow;
                kockice = new Kvadrat[1];

                kockice[0] = new Kvadrat();


                kockice[0].RedKvadrata = 0;
                kockice[0].KolonaKvadrata = 0;
            }
            else if (broj == 1)
            {
                col = Color.Blue;
                kockice = new Kvadrat[3];



                for (int i = 0; i < 3; i++)
                {
                    kockice[i] = new Kvadrat();
                    kockice[i].RedKvadrata = i;
                    kockice[i].KolonaKvadrata = 1;
                }
            }
            else if (broj == 2)
            {
                col = Color.BlueViolet;
                kockice = new Kvadrat[5];
                for (int i = 0; i < 5; i++)
                {
                    kockice[i] = new Kvadrat();
                }

                for (int i = 0; i < 3; i++)
                {

                    kockice[i].RedKvadrata = i;
                    kockice[i].KolonaKvadrata = 1;
                }


                kockice[3].RedKvadrata = 1;
                kockice[3].KolonaKvadrata = 0;

                kockice[4].RedKvadrata = 1;
                kockice[4].KolonaKvadrata = 2;

            }
            else if (broj == 3)
            {
                col = Color.Green;
                kockice = new Kvadrat[9];

                for (int i = 0; i < 9; i++)
                {
                    kockice[i] = new Kvadrat();
                }

                for (int i = 0; i < 9; i++)
                {
                    kockice[i] = new Kvadrat();
                }

                kockice[0].RedKvadrata = 0;
                kockice[0].KolonaKvadrata = 0;

                kockice[1].RedKvadrata = 0;
                kockice[1].KolonaKvadrata = 1;


                kockice[2].RedKvadrata = 0;
                kockice[2].KolonaKvadrata = 2;


                kockice[3].RedKvadrata = 1;
                kockice[3].KolonaKvadrata = 0;


                kockice[4].RedKvadrata = 1;
                kockice[4].KolonaKvadrata = 1;


                kockice[5].RedKvadrata = 1;
                kockice[5].KolonaKvadrata = 2;


                kockice[6].RedKvadrata = 2;
                kockice[6].KolonaKvadrata = 0;


                kockice[7].RedKvadrata = 2;
                kockice[7].KolonaKvadrata = 1;


                kockice[8].RedKvadrata = 2;
                kockice[8].KolonaKvadrata = 2;

            }
            else if (broj == 4)
            {
                col = Color.Red;
                kockice = new Kvadrat[4];
                for (int i = 0; i < 4; i++)
                {
                    kockice[i] = new Kvadrat();
                }

                kockice[0].RedKvadrata = 0;
                kockice[0].KolonaKvadrata = 1;

                for (int i = 1; i < 4; i++)
                {

                    kockice[i].RedKvadrata = 1;
                    kockice[i].KolonaKvadrata = i - 1;
                }
            }

            for (int i = 0; i < kockice.Length; i++)
            {
                kockice[0].JeFigura = true;
            }
        }

        public static bool PostojiLi(Kvadrat a, Kvadrat[] aa )
        {
            if (aa == null || a == null)
                return false;
            for (int i = 0; i < aa.Length; i++)
                if (aa[i].Labela == a.Labela)
                    return true;

            return false;

        }
    }
}
