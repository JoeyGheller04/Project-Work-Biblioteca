using System;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public class Dati : EventArgs
    {
        //classe utilizzata per passare dati tra form e usercontrol mediante eventi
        public Dati(string code, string password)
        {
            this.code = code;
            this.password = password;
        }

        public Dati(Prestito prestito)
        {
            this.prestito = prestito;
        }

        public Dati(Prestito prestito, double valutazione)
        {
            this.prestito = prestito;
            this.valutazione = valutazione;
        }

        public Dati(Utente utente)
        {
            this.utente = utente;
        }

        public Dati(Libro libro)
        {
            this.libro = libro;
        }


        public string code { get; set; }
        public string password { get; set; }
        public double valutazione { get; set; }
        public Prestito prestito { get; set; }
        public Utente utente { get; set; }
        public Libro libro { get; set; }

    }
}
