using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace PodaciTetris
{
    public class Kvadrat
    {
        private int _redKvadrata;
        private int _kolonaKvadrata;
        private Label _labela;
        private bool _jeFigura = false;


        public Kvadrat()
        {

        }
        public Kvadrat(int r,int k, Label l)
        {
            _redKvadrata = r;
            _kolonaKvadrata = k;
            _labela = l;
        }

        public int RedKvadrata { get => _redKvadrata; set => _redKvadrata = value; }
        public int KolonaKvadrata { get => _kolonaKvadrata; set => _kolonaKvadrata = value; }
        public Label Labela { get => _labela; set => _labela = value; }
        public bool JeFigura { get => _jeFigura; set => _jeFigura = value; }
    }
}
