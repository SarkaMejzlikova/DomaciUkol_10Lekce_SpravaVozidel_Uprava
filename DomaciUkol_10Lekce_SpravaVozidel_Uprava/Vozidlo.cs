using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_10Lekce_SpravaVozidel_Uprava
{
    internal class Vozidlo
    {
        // properties
        public readonly string TypVozidla;
        public readonly int RokVyroby;

        private string _barva { get; set; } = string.Empty;
        public string Barva
        {
            get
            {
                return _barva;
            }
            set
            {
                _barva = value;
                if ( string.IsNullOrEmpty(_barva))
                {
                    _barva = "neuvedeno";
                }
            }
        }

        // constructor
        public Vozidlo(string typVozidla, int rokVyroby, string barva)
        {
            TypVozidla = typVozidla;
            RokVyroby = rokVyroby;
            Barva = barva;
        }
    }
}
