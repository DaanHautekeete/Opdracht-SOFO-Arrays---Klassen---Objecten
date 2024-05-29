using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSofoTaakKlassesEnObjecten
{

    
    internal class Contactpersoon
    {

        frmMenu frmMenu = new frmMenu();
        ///|/////////////////////////////////////////////////////////////////////////////////////
        //|Eigenschappen aanmaken
        ///|/////////////////////////////////////////////////////////////////////////////////////

        //algemeen
        private string _Naam;
        private string _Voornaam;
        private string _VolledigeNaam;
        private string _Telefoonnummer;
        private string _Emailadres;

        //Adres
        private string _Straatnaam;
        private string _Huisnummer;
        private bool _Appartement;
        private string _Bus;
        private string _Land;
        private string _Stad;


        //standaardwaarden meegeven voor de eigenschappen
        public Contactpersoon() 
        {
            //algemeen
            _Naam = "Onbekend";
            _Voornaam = "Onbekend";
            _Telefoonnummer = "Onbekend";
            _Emailadres = "Onbekend";

            //adres
            _Straatnaam = "Onbekend";
            _Huisnummer = "Onbekend";
            _Appartement = false;
            _Bus = null;
            _Land = "Onbekend";
            _Stad = "Onbekend";
        }

        ///|/////////////////////////////////////////////////////////////////////////////////////
        //|Gedrag lezen en schrijven van data
        ///|/////////////////////////////////////////////////////////////////////////////////////
        public string Naam
        {
            get
            {
                return _Naam;
            }
            set
            {
                _Naam = value;
            }
        }

        public string Voornaam
        {
            get
            {
                return _Voornaam;
            }
            set
            {
                _Voornaam = value;
            }
        }

        public string VolledigeNaam
        {
            get { return _VolledigeNaam; }
            set { _VolledigeNaam = value; }
        }
        public string Telefoonnummer
        {
            get
            {
                return _Telefoonnummer;
            }
            set
            {
                _Telefoonnummer = value;
            }
        }

        public string Emailadres
        {
            get
            {
                return _Emailadres;
            }
            set
            {
                _Emailadres = value;
            }
        }

        public string Straatnaam
        {
            get
            {
                return _Straatnaam;
            }
            set
            {
                _Straatnaam = value;
            }
        }

        public string Huisnummer
        {
            get
            {
                return _Huisnummer;
            }
            set
            {
                _Huisnummer = value;
            }
        }

        public bool Appartement
        {
            get
            {
                return _Appartement;
            }
            set
            {
                _Appartement = value;
            }
        }

        public string Bus
        {
            get
            {
                return _Bus;
            }
            set
            {
                _Bus = value;
            }
        }

        public string Land
        {
            get
            {
                return _Land;
            }
            set
            {
                _Land = value;
            }
        }

        public string Stad
        {
            get
            {
                return _Stad;
            }
            set
            {
                _Stad = value;
            }
        }


        ///|/////////////////////////////////////////////////////////////////////////////////////
        //|Constructor
        ///|/////////////////////////////////////////////////////////////////////////////////////

        public Contactpersoon(string strNaam, string strVooraam, string strTelefoonnummer, string strEmailadres, string strStraatnaam, string strHuisnummer, bool blnAppartement, string strBus, string strLand, string strStad)
        {
            _Naam = strNaam;
            _Voornaam = strVooraam;
            _VolledigeNaam = strNaam + " " + strVooraam;
            _Telefoonnummer = strTelefoonnummer;
            _Emailadres = strEmailadres;
            _Straatnaam = strStraatnaam;
            _Huisnummer = strHuisnummer;
            _Land = strLand;
            _Stad = strStad;
            _Bus = strBus;
            _Appartement = blnAppartement;
        }

        
    }
}
