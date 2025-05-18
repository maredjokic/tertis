using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PodaciTetris
{
    [Serializable]
    public class ListaIgraca
    {
        private List<Igrac> _listaIgraca;

        [XmlArrayItem("Igrac", typeof(Igrac))]
        public List<Igrac> ListaIgraci
        {
            get => _listaIgraca;
            set => _listaIgraca = value;
        }

        public ListaIgraca()
        {
            _listaIgraca = new List<Igrac>();
        }

        public void DodajIgraca(Igrac i)
        {
            _listaIgraca.Add(i);
        }

        public void Sortiraj(List<Igrac> i)
        {
            i.Sort(PoBrojuBodova);
        }

        private int PoBrojuBodova(Igrac i1,Igrac i2)
        {
            return i2.BrojPoena.CompareTo(i1.BrojPoena);
        }
        
    }
}
