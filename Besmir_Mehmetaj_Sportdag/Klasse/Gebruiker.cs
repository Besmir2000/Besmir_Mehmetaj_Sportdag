using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Besmir_Mehmetaj_Sportdag.Klasse
{
    class Gebruiker
    {
        //Velden
        private string _login = "";
        private string _Sport = "";

        //properties
        public string PropLogin
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }

        public string PropSport
        {
            get
            {
                return _Sport;
            }
            set
            {
                _Sport = value;
            }
        }

        //Functies en methodes

        //constructors

        public Gebruiker()
        {

        }
        public Gebruiker (string ontvLogin, string ontvSport)
        {
            _login = ontvLogin;
            _Sport = ontvSport;
        }

    }
}
