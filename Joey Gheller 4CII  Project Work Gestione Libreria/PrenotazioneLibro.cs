using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public partial class PrenotazioneLibro : UserControl
    {

        public event EventHandler Close;

        public event EventHandler AddPrestito;

        public Dictionary<string, Utente> Dictionary_Utenti {get; set; }
        public Dictionary<string, Libro> Dictionary_Libri {get; set; }

        public PrenotazioneLibro()
        {
            InitializeComponent();

            Dictionary_Utenti = new Dictionary<string, Utente>();

            Dictionary_Libri = new Dictionary<string, Libro>();
        }

        public void BindData()
        {

            BindingSource sorgente_Utenti = new BindingSource();
            sorgente_Utenti.DataSource = Dictionary_Utenti.Values.ToList();

            cmbUser.DataSource = sorgente_Utenti;
            cmbUser.DisplayMember = "first_name";

            txbNome.DataBindings.Add(new Binding("Text", sorgente_Utenti, "first_name"));
            txbCode.DataBindings.Add(new Binding("Text", sorgente_Utenti, "code"));

            BindingSource sorgente_Libri = new BindingSource();
            sorgente_Libri.DataSource = Dictionary_Libri.Values.ToList();

            cmbBook.DataSource = sorgente_Libri;
            cmbBook.DisplayMember = "title";

            txbTitolo.DataBindings.Add(new Binding("Text", sorgente_Libri, "title"));
            txbIsbn.DataBindings.Add(new Binding("Text", sorgente_Libri, "isbn"));
        }

        private void btnAddPrenotation_Click(object sender, EventArgs e)
        {
            AddPrestito.Invoke(null, new Dati(new Prestito(txbIsbn.Text, txbCode.Text, txbDa.Text)));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close.Invoke(null, null);
        }
    }
}