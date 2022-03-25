using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public class Prestito
    {
        [JsonConstructor]
        public Prestito(string isbn, string code, DateTime data_inizio, DateTime data_fine)
        {
            this.isbn = isbn;
            this.code = code;
            this.data_inizio = data_inizio;
            this.data_fine = data_fine;
            tempo_mancante = GetTime();
        }

        public  Prestito(string isbn, string code, string data_inizio)
        {
            this.isbn = isbn;
            this.code = code;
            this.data_inizio = Convert.ToDateTime(data_inizio);
            data_fine = GetEndDate();
            tempo_mancante = GetTime();
        }

        public string isbn { get; }
        public string code { get; }
        public DateTime data_inizio { get; }
        public DateTime data_fine { get; }
        public string tempo_mancante { get; }

        public DateTime GetEndDate()
        {
            return data_inizio.AddMonths(1);
        }

        public string GetTime()
        {
            return (Math.Round((data_fine - DateTime.Now).TotalDays, 0)).ToString() + " giorni";
        }


    }
}
