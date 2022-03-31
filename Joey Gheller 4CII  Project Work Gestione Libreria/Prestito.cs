using Newtonsoft.Json;
using System;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public class Prestito
    {
        [JsonConstructor]
        public Prestito(string isbn, string code, DateTime data_inizio, DateTime data_fine, string codice_prestito)
        {
            this.isbn = isbn;
            this.code = code;
            this.data_inizio = data_inizio;
            this.data_fine = data_fine;
            tempo_mancante = GetTime();
            this.codice_prestito = codice_prestito;
        }

        public Prestito(string isbn, string code, string data_inizio, string tmp)
        {
            this.isbn = isbn;
            this.code = code;
            this.data_inizio = Convert.ToDateTime(data_inizio);
            data_fine = GetEndDate();
            tempo_mancante = GetTime();
            codice_prestito = GetCode(tmp);
        }

        public string isbn { get; }
        public string code { get; }
        public DateTime data_inizio { get; }
        public DateTime data_fine { get; }
        public string tempo_mancante { get; set; }
        public string codice_prestito { get; }

        public DateTime GetEndDate()//la data di riconsegna del libro viene calcolata aggiungendo un mese alla data in cui viene prestato
        {
            return data_inizio.AddMonths(1);
        }

        public string GetTime()//funzione che calcola il tempo rimanente prima che il libro debba essere restituito
        {
            return (Math.Round((data_fine - DateTime.Now).TotalDays, 0)).ToString() + " giorni";
        }

        public string GetCode(string tmp)//funzione che genera il codice univoco per il prestito
        {
            return isbn + "_" + code + "_" + tmp + "_" + data_inizio.Day + "/" + data_inizio.Month;
        }

    }
}
