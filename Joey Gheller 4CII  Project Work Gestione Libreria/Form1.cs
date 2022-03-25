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
    public partial class frm1 : Form
    {
        List<Utente> Lista_Utenti;
        Dictionary<string, Utente> Dictionary_Utenti;

        List<Libro> Lista_Libri;
        Dictionary<string, Libro> Dictionary_Libri;

        List<Prestito> Lista_Prestiti;

        Utente CurrentUser;

        public frm1()
        {
            InitializeComponent();

            Initialize();
            Loader();
            BindData();

            dgwUtenti.AutoGenerateColumns = false;
            dgwLibri.AutoGenerateColumns = false;
            dgwPrestiti.AutoGenerateColumns = false;

            login.BringToFront();
            login.AccessoEffettuato += VerificaAccesso;

            prenotazione.Close += Prenotazione_Close;
            prenotazione.AddPrestito += Prenotazione_AddPrestito;

            prenotazione.BindData();
        }

        public void Initialize()
        {
            Lista_Utenti = new List<Utente>();
            Dictionary_Utenti = new Dictionary<string, Utente>();

            Lista_Libri = new List<Libro>();
            Dictionary_Libri = new Dictionary<string, Libro>();

            Lista_Prestiti = new List<Prestito>();
        }

        public void Loader()
        {
            Lista_Utenti = JsonConvert.DeserializeObject<List<Utente>>(File.ReadAllText("../Data/users.json"));
            Lista_Libri = JsonConvert.DeserializeObject<List<Libro>>(File.ReadAllText("../Data/books.json"));
            Lista_Prestiti = JsonConvert.DeserializeObject<List<Prestito>>(File.ReadAllText("../Data/prestiti.json"));

            foreach (Utente user in Lista_Utenti)
            {
                Dictionary_Utenti.Add(user.code, user);
            }

            foreach (Libro book in Lista_Libri)
            {
                Dictionary_Libri.Add(book.isbn, book);
            }
        }

        public void BindData()
        {
            BindDataUtenti();
            BindDataLibri();
            BindDataPrestiti();

            prenotazione.Dictionary_Utenti = Dictionary_Utenti;
            prenotazione.Dictionary_Libri = Dictionary_Libri;

            //prenotazione.Dictionary_Prestiti = Dictionary_Prestiti;
        }

        public void BindDataUtenti()
        {
            dgwUtenti.DataSource = null;
            dgwUtenti.DataSource = Lista_Utenti;
        }

        public void BindDataLibri()
        {
            dgwLibri.DataSource = null;
            dgwLibri.DataSource = Lista_Libri;
        }

        public void BindDataPrestiti()
        {
            dgwPrestiti.DataSource = null;
            dgwPrestiti.DataSource = Lista_Prestiti;
        }

        private void VerificaAccesso(object sender, EventArgs e)
        {

            if (Dictionary_Utenti.ContainsKey(((Dati)e).code))
            {
                CurrentUser = Dictionary_Utenti[((Dati)e).code];

                if (CurrentUser.password == ((Dati)e).password)
                {
                    login.SendToBack();
                    LoadUser();
                }
            }
        }

        public void LoadUser()
        { 
            if(CurrentUser.role == "admin")
            {
                tbc.TabPages.Remove(tbpUtenti);
                tbc.TabPages.Remove(tbpLibri);
                tbc.TabPages.Remove(tbpPrestiti);

                tbc.TabPages.Add(tbpUtenti);
                tbc.TabPages.Add(tbpLibri);
                tbc.TabPages.Add(tbpPrestiti);

                tabComandi.Enabled = true;
                btnUtenti.Enabled = true;
            }

            else if (CurrentUser.role == "user")
            {
                tbc.TabPages.Remove(tbpUtenti);

                tabComandi.Enabled = false;
                btnUtenti.Enabled = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login.BringToFront();
        }

        private void btnUtenti_Click(object sender, EventArgs e)
        {
            tbpUtenti.Show();
            tbc.SelectedIndex = 0;
        }

        private void btnLibri_Click(object sender, EventArgs e)
        {
            tbpLibri.Show();
            tbc.SelectedIndex = 1;
        }

        private void btnPrestiti_Click(object sender, EventArgs e)
        {
            tbpPrestiti.Show();
            tbc.SelectedIndex = 2;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            if (tbc.SelectedIndex == 0) { Search_User(); }

            else if (tbc.SelectedIndex == 1) { Search_Book(); }

            else if (tbc.SelectedIndex == 2) { Search_Prestito(); }

            else { return; }
        }

        public void Search_User()
        {
            string ToSearch = txbSearch.Text.ToLower();

            var Result = from d in Dictionary_Utenti
                         where d.Key.ToLower().Contains(ToSearch) || d.Value.first_name.ToLower().Contains(ToSearch) || d.Value.last_name.ToLower().Contains(ToSearch) || d.Value.city.ToLower().Contains(ToSearch)
                         select d.Value;

            List<Utente> tmp = Result.ToList();

            dgwUtenti.DataSource = tmp;
        }

        public void Search_Book()
        {
            string ToSearch = txbSearch.Text.ToLower();

            var Result = from d in Dictionary_Libri
                         where d.Key.ToLower().Contains(ToSearch) || d.Value.title.ToLower().Contains(ToSearch) || d.Value.authors.ToLower().Contains(ToSearch) || d.Value.categories.ToLower().Contains(ToSearch)
                         select d.Value;

            List<Libro> tmp = Result.ToList();

            dgwLibri.DataSource = tmp;
        }

        public void Search_Prestito()
        {
            string ToSearch = txbSearch.Text.ToLower();

            var Result = from d in Dictionary_Libri
                         where d.Key.ToLower().Contains(ToSearch) || d.Value.title.ToLower().Contains(ToSearch) || d.Value.authors.ToLower().Contains(ToSearch) || d.Value.categories.ToLower().Contains(ToSearch)
                         select d.Value;

            List<Libro> tmp = Result.ToList();

            dgwLibri.DataSource = tmp;
        }

        private void btnPrenota_Click(object sender, EventArgs e)
        {
            prenotazione.BringToFront();
        }

        private void Prenotazione_Close(object sender, EventArgs e)
        {
            prenotazione.SendToBack();
        }

        private void Prenotazione_AddPrestito(object sender, EventArgs e)
        {

            if (Dictionary_Utenti.ContainsKey(((Dati)e).prestito.code))
            {
                if(Dictionary_Utenti[((Dati)e).prestito.code].libri_prenotati > 3){

                    MessageBox.Show("L'utente ha già 3 prenotazioni in corso");

                }
                else
                {
                    Dictionary_Utenti[((Dati)e).prestito.code].libri_prenotati += 1;

                    Lista_Prestiti.Add(((Dati)e).prestito);

                    File.WriteAllText("../Data/prestiti.json", JsonConvert.SerializeObject(Lista_Prestiti));
                    File.WriteAllText("../Data/users.json", JsonConvert.SerializeObject(Dictionary_Utenti.Values.ToList()));

                    Initialize();
                    Loader();
                    BindData();
                }
            }  
        }
    }
}
