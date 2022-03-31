using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public partial class PrenotazioneLibro : UserControl
    {

        public event EventHandler Close;

        public event EventHandler AddPrestito;

        public Dictionary<string, Utente> Dictionary_Utenti { get; set; }
        public Dictionary<string, Libro> Dictionary_Libri { get; set; }

        BindingSource sorgente_Utenti;
        BindingSource sorgente_Libri;

        public PrenotazioneLibro()
        {
            InitializeComponent();

            Dictionary_Utenti = new Dictionary<string, Utente>();
            Dictionary_Libri = new Dictionary<string, Libro>();

            sorgente_Utenti = new BindingSource();
            sorgente_Libri = new BindingSource();
            
        }

        public void BindData()
        {
            //mediante i databinding modifico i valori delle txb sulla base dei valori visualizzati nella rispettiva cmb
            sorgente_Utenti.DataSource = Dictionary_Utenti.Values.ToList();

            cmbUser.DataSource = sorgente_Utenti;
            cmbUser.DisplayMember = "first_name";

            txbNome.DataBindings.Add(new Binding("Text", sorgente_Utenti, "first_name"));
            txbCode.DataBindings.Add(new Binding("Text", sorgente_Utenti, "code"));


            sorgente_Libri.DataSource = Dictionary_Libri.Values.ToList();

            cmbBook.DataSource = sorgente_Libri;
            cmbBook.DisplayMember = "title";

            txbTitolo.DataBindings.Add(new Binding("Text", sorgente_Libri, "title"));
            txbIsbn.DataBindings.Add(new Binding("Text", sorgente_Libri, "isbn"));

            txbA.Text = DateTime.Now.AddMonths(1).ToString();
        }

        private void btnAddPrenotation_Click(object sender, EventArgs e)//al click del btn AddPrenotation scateno l'evento AddPrestito passando come valori il nuovo prestito 
        {
            AddPrestito.Invoke(null, new Dati(new Prestito(txbIsbn.Text, txbCode.Text, txbDa.Text, (Dictionary_Utenti[txbCode.Text].libri_prenotati + 1).ToString()))); //l'ultimo valore passato è quello dei libri prenotati dall'utente che servità per formare il codice univoco del prestito
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close.Invoke(null, null);
        }

        //btn che permettono scatenare le funzioni di ricerca dati contenuti nei rispettivi cmb sulla base del valore inserito nella txb ricerca

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            string ToSearch = txbSearch.Text.ToLower();

            var Result = from d in Dictionary_Utenti
                         where d.Value.first_name.ToLower().Contains(ToSearch)
                         select d.Value;

            List<Utente> tmp = Result.ToList();

            sorgente_Utenti.DataSource = tmp;
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            string ToSearch = txbSearch.Text.ToLower();

            var Result = from d in Dictionary_Libri
                         where d.Value.title.ToLower().Contains(ToSearch)
                         select d.Value;

            List<Libro> tmp = Result.ToList();

            sorgente_Libri.DataSource = tmp;
        }
    }
}