using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public class Utente
    {

        [JsonConstructor]
        public Utente(string first_name, string last_name, string email, string role, string city, string code, string password, string birth_Date)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.role = role;
            this.city = city;
            this.code = code;
            this.password = password;
            birth_date = Convert.ToDateTime(birth_Date);
            this.libri_prenotati = 0;
            this.libri_richiesti = 0;
            this.storico_prestiti = new List<Prestito>();
        }

        public Utente() { }

        public string first_name { get; }
        public string last_name { get; }
        public string email { get; }
        public string role { get; }
        public string city { get; }
        public string code { get; }
        public string password { get; }
        public DateTime birth_date { get; }
        public int libri_prenotati { get; set; }
        public int libri_richiesti { get; set; }
        public List<Prestito> storico_prestiti { get; set;}
    }
}
