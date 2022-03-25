using System;
using System.Collections.Generic;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public class Dati : EventArgs
    {
        public Dati(string code, string password)
        {
            this.code = code;
            this.password = password;
        }

        public Dati(Prestito prestito)
        {
            this.prestito = prestito;
        }

        public string code { get; set; }
        public string password { get; set; }

        public Prestito prestito { get; set; }

    }
}
