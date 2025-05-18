using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PodaciTetris
{
    [Serializable]
    public class Igrac
    {
        private string _ime;
        private string _prezime;
        private int _brojPoena;
        private DateTime _datum;
        private int _vreme;


        public Igrac()
        {
             
        }

        public Igrac(string ime, string pre, int bp, DateTime dt, int vr)
        {
            _ime=ime;
            _prezime=pre;
            _brojPoena=bp;
            _datum=dt;
            _vreme=vr;
        }


        [XmlElementAttribute("Ime")]
        public string Ime { get => _ime; set => _ime = value; }

        [XmlElementAttribute("Prezime")]
        public string Prezime { get => _prezime; set => _prezime = value; }

        [XmlElementAttribute("BrojPoena")]
        public int BrojPoena { get => _brojPoena; set => _brojPoena = value; }

        [XmlElementAttribute("Datum")]
        public DateTime Datum { get => _datum; set => _datum = value; }

        [XmlElementAttribute("Vreme")]
        public int Vreme { get => _vreme; set => _vreme = value; }

        [XmlIgnore]
        public String ZaPrikaz
        {
            get
            {
                return "Broj poena: " + _brojPoena.ToString()+" "+_ime + " " + _prezime + " datum:" + _datum.ToString("dd.MM.yyyy.") + " vreme:" + _vreme.ToString() + " s";
            }
        }
    }
}
