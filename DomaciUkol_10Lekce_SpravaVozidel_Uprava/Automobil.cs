using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_10Lekce_SpravaVozidel_Uprava
{
    internal class Automobil : Vozidlo
    {
        // properties

        public readonly string Model;
        public bool MaleAuto;

        private int _pocetDveri;
        public int PocetDveri
        {
            get
            {
                return _pocetDveri;
            }
            set
            {
                _pocetDveri = value;
                if(_pocetDveri <= 3) 
                {
                    MaleAuto = true;
                }
                else
                {
                    MaleAuto = false;
                }
            }
        }

        // constructor
        public Automobil(int pocetDveri, string model, int rokVyroby, string barva) : base("Automobil", rokVyroby, barva)
        {
            PocetDveri = pocetDveri;
            Model = model;
        }

        // methods
        public override string ToString()
        {
            return $"{TypVozidla} - Model: {Model}, Rok výroby: {RokVyroby}, Barva: {Barva}, Počet dveří: {PocetDveri}, Malé auto: {MaleAuto};";
        }
    }
}
