using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PodaciTetris
{
    public class TetrisPodaci
    {
        private int _redovi;
        private int _kolone;
        private Kvadrat[][] _matricaTetris;
        private static TetrisPodaci _instanca;

        public int Redovi { get => _redovi; set => _redovi = value; }
        public int Kolone { get => _kolone; set => _kolone = value; }
        public Kvadrat[][] MatricaTetris { get => _matricaTetris; set => _matricaTetris = value; }

        public static TetrisPodaci Instanca
        {
            get
            {
                if (_instanca == null)
                    _instanca = new TetrisPodaci();
                return _instanca;
            }
        }

        public TetrisPodaci()
        {

        }

        public TetrisPodaci(int r,int k)
        {
            _redovi = r;
            _kolone = k;
        }


    }
}
