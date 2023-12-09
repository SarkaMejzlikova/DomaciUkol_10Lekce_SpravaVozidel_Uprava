using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_10Lekce_SpravaVozidel_Uprava
{
    internal class Motocykl : Vozidlo
    {
        // properties
        public readonly string TypMotocyklu;
        public readonly int PocetKol;

        public string Ridicak;
        private int _objemMotoru;
        public int ObjemMotoru
        {
            get
            {
                return _objemMotoru;
            }
            set
            {
                _objemMotoru = value;
                if (_objemMotoru > 0  && _objemMotoru <= 50)
                {
                    Ridicak = "AM";
                }
                else if (_objemMotoru > 50 && _objemMotoru <= 125)
                {
                    Ridicak = "A1";
                }
                else if (_objemMotoru > 125)
                {
                    Ridicak = "A2";
                }
            }
        }

        // constructor
        public Motocykl(string typMotockylu, int pocetKol, int rokVyroby, string barva, int objemMotoru) : base("Motocykl", rokVyroby, barva)
        {
            TypMotocyklu = typMotockylu;
            PocetKol = pocetKol;
            ObjemMotoru = objemMotoru;
        }

        public override string ToString()
        {
            return $"{TypVozidla} - Typ motocyklu: {TypMotocyklu}, Rok výroby: {RokVyroby}, Barva: {Barva}, Počet kol: {PocetKol}, Objem motoru: {ObjemMotoru}, Potřebný ŘP: {Ridicak};";
        }
    }
}
