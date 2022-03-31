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
using System.Net;
using System.Net.Mail;


namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public partial class frm1 : Form
    {
        List<Utente> Lista_Utenti;
        Dictionary<string, Utente> Dictionary_Utenti;

        List<Libro> Lista_Libri;
        Dictionary<string, Libro> Dictionary_Libri;

        List<Prestito> Lista_Prestiti;
        Dictionary<string, Prestito> Dictionary_Prestiti;

        Utente CurrentUser;

        public int TbcIndex;

        public frm1()
        {

            InitializeComponent();

            //rimuovere l'header del tabcontrol
            tbc.Appearance = TabAppearance.FlatButtons;
            tbc.ItemSize = new Size(0, 1);
            tbc.SizeMode = TabSizeMode.Fixed;

            dgwUtenti.AutoGenerateColumns = false;
            dgwLibri.AutoGenerateColumns = false;
            dgwPrestiti.AutoGenerateColumns = false;

            login.BringToFront();
            login.AccessoEffettuato += VerificaAccesso;

            prenotazione.Close += Prenotazione_Close;
            prenotazione.AddPrestito += Prenotazione_AddPrestito;

            AddBooksAndUsers.AddUser += AddBooksAndUsers_AddUser;
            AddBooksAndUsers.AddBook += AddBooksAndUsers_AddBook;
            AddBooksAndUsers.Close += AddBooksAndUsers_Close;

            ModifyBookUser.AddUser += ModifyBookUser_AddUser;
            ModifyBookUser.AddBook += ModifyBookUser_AddBook;
            ModifyBookUser.Close += ModifyBookUser_Close;

            visualizza_profilo.Close += visualizza_profilo_Close;
            visualizza_profilo.DonoFedelta += visualizza_profilo_DonoFedelta;
            visualizza_libro.Close += visualizza_libro_Close;

            ValutazioneEPrestiti.Close += ValutazioneEPrestiti_Close;
            ValutazioneEPrestiti.FinePrestito += ValutazioneEPrestiti_FinePrestito;
            ValutazioneEPrestiti.SendEmail += ValutazioneEPrestiti_SendEmail;

            Statistiche.Close += Statistiche_Close;

            Initialize();
            Loader();
            BindData();

            prenotazione.BindData();
        }


        //funzioni relative al caricamento dei dati nel form e negli user control
        public void Initialize()
        {
            Lista_Utenti = new List<Utente>();
            Dictionary_Utenti = new Dictionary<string, Utente>();

            Lista_Libri = new List<Libro>();
            Dictionary_Libri = new Dictionary<string, Libro>();

            Lista_Prestiti = new List<Prestito>();
            Dictionary_Prestiti = new Dictionary<string, Prestito>();

            TbcIndex = 0;
        }

        public void Loader()//funzione che richiama le altre funzioni che caricano i dati dai file json al form
        {
            LoadUsers();
            LoadBooks();
            LoadPrestiti();
        }

        public void LoadUsers()//funzione che carica i dati dal file json alla lista
        {
            Lista_Utenti = JsonConvert.DeserializeObject<List<Utente>>(File.ReadAllText("../Data/users.json"));//leggo il file json che contiene i dati per poi deserializzarli in una lista

            foreach (Utente user in Lista_Utenti) //ciclo che permette di inserire ciascun utente, contenuto all'interno della lista utenti, nella dictionary degli utenti usando il code come key
            {
                Dictionary_Utenti.Add(user.code, user);
            }
        }

        public void LoadBooks()//funzione che carica i dati dal file json alla lista
        {
            Lista_Libri = JsonConvert.DeserializeObject<List<Libro>>(File.ReadAllText("../Data/books.json"));//leggo il file json che contiene i dati per poi deserializzarli in una lista

            foreach (Libro book in Lista_Libri)
            {
                Dictionary_Libri.Add(book.isbn, book); //ciclo che permette di inserire ciascun libro, contenuto all'interno della lista libri, nella dictionary dei libri usando l'isbn come key
            }
        }

        public void LoadPrestiti()//funzione che carica i dati dal file json alla lista
        {
            Lista_Prestiti = JsonConvert.DeserializeObject<List<Prestito>>(File.ReadAllText("../Data/prestiti.json"));//leggo il file json che contiene i dati per poi deserializzarli in una lista

            foreach (Prestito loan in Lista_Prestiti)
            {
                if(Math.Round((loan.data_fine - DateTime.Now).TotalDays, 0) < 5)
                {
                    string to, from, pass, mail, oggetto;

                    //inserire qui i dati per testare il funzionamento della funzionalità d'invio mail
                    to = "6189921@itisrossi.vi.it"; //la mail di chi deve ricevere
                    from = "joeyg20040114@gmail.com"; //la mail di chi invia
                    pass = "Aa.Bb_Cc/123456789$"; //la password di chi invia

                    //i seguenti dati sarebbero commentati sono quelli che dovrebbero essere utilizzati. Per poter verificare al meglio il funzionamento di questa funzionalità utilizzare due mail proprie inserendole sopra
                    //to = Dictionary_Utenti[((Dati)e).prestito.code].email;
                    //from = CurrentUser.email;
                    //pass = CurrentUser.password;
                    mail = "Gentile " + Dictionary_Utenti[loan.code].first_name + ". \nE' tenuto a restituire il libro: " + Dictionary_Libri[loan.isbn].title + ".  Tempo rimanente " + loan.tempo_mancante + ". \nCordiali Saluti";
                    oggetto = "Restituzione Libro";

                    SendEmail(to, from, pass, mail, oggetto);
                }

                Dictionary_Prestiti.Add(loan.codice_prestito, loan);
            }
        }

        public void BindData()//funzione che richiama le altre funzioni bindData 
        {
            BindDataUtenti();
            BindDataLibri();
            BindDataPrestiti();
        }

        public void BindDataUtenti() //funzione che assegna alla dgw e al campo dictionary dello usercontrol prenotazione i valori della dictionary utenti
        {
            dgwUtenti.DataSource = null;
            dgwUtenti.DataSource = Dictionary_Utenti.Values.ToList();

            prenotazione.Dictionary_Utenti = Dictionary_Utenti;
            Statistiche.Dictionary_Utenti = Dictionary_Utenti;
        }

        public void BindDataLibri()//funzione che assegna alla dgw e al campo dictionary dello usercontrol prenotazione i valori della dictionary libri
        {
            dgwLibri.DataSource = null;
            dgwLibri.DataSource = Dictionary_Libri.Values.ToList();

            prenotazione.Dictionary_Libri = Dictionary_Libri;
            Statistiche.Dictionary_Libri = Dictionary_Libri;
        }

        public void BindDataPrestiti()//funzione che permette di assegnare ad una datagridview i valori della rispettiva lista
        {
            dgwPrestiti.DataSource = null;
            dgwPrestiti.DataSource = Dictionary_Prestiti.Values.ToList();

            ValutazioneEPrestiti.Dictionary_Prestiti = Dictionary_Prestiti;

            ValutazioneEPrestiti.BindData();
        }


        //funzioni relative al caricamento dei dati contenuti nelle liste/directory all'interno dei file json
        public void ListToJSON_Users()//funzione che permette di caricare i dati da una lista al file json corrispondente
        {
            File.WriteAllText("../Data/users.json", JsonConvert.SerializeObject(Dictionary_Utenti.Values.ToList()));//serializzo i valori contenuti nella dictionary e poi li scrivo all'interno del file json corrispondente
        }

        public void ListToJSON_Books()//funzione che permette di caricare i dati da una lista al file json corrispondente
        {
            File.WriteAllText("../Data/books.json", JsonConvert.SerializeObject(Dictionary_Libri.Values.ToList()));//serializzo i valori contenuti nella dictionary e poi li scrivo all'interno del file json corrispondente
        }

        public void ListToJSON_Prestiti()//funzione che permette di caricare i dati da una lista al file json corrispondente
        {
            File.WriteAllText("../Data/prestiti.json", JsonConvert.SerializeObject(Dictionary_Prestiti.Values.ToList()));//serializzo i valori contenuti nella dictionary e poi li scrivo all'interno del file json corrispondente
        }


        //Accesso di un utente e gestione delle funzionalità di cui l'utente dispone
        private void VerificaAccesso(object sender, EventArgs e)//evento che si scatena al click del btn accesso nello usercontrol login
        {

            if (Dictionary_Utenti.ContainsKey(((Dati)e).code))//se la dictionary utente contiene la key inserita allora l'utente esiste
            {
                CurrentUser = Dictionary_Utenti[((Dati)e).code];

                if (CurrentUser.password == ((Dati)e).password)//se la password dell'utente a cui corrisponde la key inserita è quella inserita precedentemente allora l'accesso è effettuato
                {
                    login.SendToBack();//la schermata di login passa in secondo piano
                    GetRole();//funzione che, in base al ruolo dell'utente, sblocca le funzionalità
                }
            }
        }

        public void GetRole()//funzione che, in base al ruolo dell'utente, sblocca le funzionalità
        {
            if (CurrentUser.role.ToLower() == "admin")//se l'utente è un admin può accedere alla dgw utenti e alle funzionalità dell'utente admin
            {
                tabComandi.Enabled = true;
                btnUtenti.Enabled = true;
                btnViewUser.Enabled = true;
                btnViewBook.Enabled = false;

                Search_Prestito();
            }

            else if (CurrentUser.role.ToLower() == "user")//se l'utente è uuser ha solo le funzionalità di base
            {
                tabComandi.Enabled = false;
                btnUtenti.Enabled = false;
                btnViewUser.Enabled = false;

                //carico nella dgw prestiti soltanto i prestiti dell'utente che ha fatto l'accesso
                List<Prestito> storico_presiti = CurrentUser.storico_prestiti;

                foreach(Prestito loan in Dictionary_Prestiti.Values.ToList())
                {
                    if(loan.code == CurrentUser.code)
                    {
                        storico_presiti.Add(loan);
                    }
                }

                dgwPrestiti.DataSource = null;
                dgwPrestiti.DataSource = storico_presiti;

                tbpLibri.Show();
                tbc.SelectedIndex = 1;

                TbcIndex = 1;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)//evento scatenato al click del btn logout che permette di cambiare utente
        {
            login.BringToFront();
        }


        //Ricerca dei dati all'interno delle datagridview e navigazione nella tabcontrol che le contiene
        private void btnUtenti_Click(object sender, EventArgs e)//evento scatenato al click del btn che permette di visualizzare la tab page contenente la dgw utenti
        {
            tbpUtenti.Show();
            tbc.SelectedIndex = 0;

            TbcIndex = 0;

            btnViewBook.Enabled = false;
            btnViewUser.Enabled = true;
        }

        private void btnLibri_Click(object sender, EventArgs e)//evento scatenato al click del btn che permette di visualizzare la tab page contenente la dgw libri
        {
            tbpLibri.Show();
            tbc.SelectedIndex = 1;

            TbcIndex = 1;

            btnViewBook.Enabled = true;
            btnViewUser.Enabled = false;
        }

        private void btnPrestiti_Click(object sender, EventArgs e)//evento scatenato al click del btn che permette di visualizzare la tab page contenente la dgw prestiti
        {
            tbpPrestiti.Show();
            tbc.SelectedIndex = 2;

            TbcIndex = 2;
        }

        private void TxbSearch_TextChanged(object sender, EventArgs e)//gli elementi cercati nella datagridview cambiano finchè cambia il testo
        {
            Search();
        }

        private void btnFind_Click(object sender, EventArgs e)//evento scatenato al click del btn che permette di capire in che tab page ci si trova e richiamare la rispettiva funzione di ricerca
        {
            Search();
        }

        public void Search()
        {
            if (CurrentUser.role == "admin")
            {
                if (tbc.SelectedIndex == 0) { Search_User(); }

                else if (tbc.SelectedIndex == 1) { Search_Book(); }

                else if (tbc.SelectedIndex == 2) { Search_Prestito(); }

                else { return; }
            }
            else
            {
                if (tbc.SelectedIndex == 1) { Search_Book(); }

                else if (tbc.SelectedIndex == 2) { return; }

                else { return; }
            }
        }

        public void Search_User()//funzione che permette la ricerca degli utenti che, in alcuni loro campi, contengono ciò che viene inserito nella txb dei valori da cercare
        {
            string ToSearch = txbSearch.Text.ToLower();//assegno alla variabile ToSearch i valori inseriti nella txbSearch, quelli da cercare

            var Result = from d in Dictionary_Utenti
                         where d.Key.ToLower().Contains(ToSearch) || d.Value.first_name.ToLower().Contains(ToSearch) || d.Value.last_name.ToLower().Contains(ToSearch) || d.Value.city.ToLower().Contains(ToSearch)
                         select d.Value;

            List<Utente> tmp = Result.ToList();//converto i risultati della ricerca in una lista

            dgwUtenti.DataSource = tmp;//assegno alla datagridview i valori trovati nella ricerca
        }

        public void Search_Book()//funzione che permette la ricerca dei libri che, in alcuni loro campi, contengono ciò che viene inserito nella txb dei valori da cercare
        {
            string ToSearch = txbSearch.Text.ToLower();

            var Result = from d in Dictionary_Libri
                         where d.Key.ToLower().Contains(ToSearch) || d.Value.title.ToLower().Contains(ToSearch) || d.Value.authors.ToLower().Contains(ToSearch) || d.Value.categories.ToLower().Contains(ToSearch)
                         select d.Value;

            List<Libro> tmp = Result.ToList();

            dgwLibri.DataSource = tmp;
        }

        public void Search_Prestito()//funzione che permette la ricerca dei prestiti che, in alcuni loro campi, contengono ciò che viene inserito nella txb dei valori da cercare
        {
            string ToSearch = txbSearch.Text.ToLower();

            var Result = from d in Dictionary_Prestiti
                         where d.Key.ToLower().Contains(ToSearch) || d.Value.code.ToLower().Contains(ToSearch) || d.Value.data_inizio.ToString().Contains(ToSearch) || d.Value.data_fine.ToString().Contains(ToSearch) || d.Value.tempo_mancante.ToString().Contains(ToSearch)
                         select d.Value;

            List<Prestito> tmp = Result.ToList();

            dgwPrestiti.DataSource = tmp;
        }


        //Aggiungere una Prenotazione
        private void btnPrenota_Click(object sender, EventArgs e)//evento scatenato al click del btn Prenota che permette di visualizzare la schermata di prenotazione
        {
            prenotazione.BringToFront();
        }

        private void Prenotazione_Close(object sender, EventArgs e)//evento scatenato al click del btn Close che chiude la schermata di prenotazione
        {
            prenotazione.SendToBack();
        }

        private void Prenotazione_AddPrestito(object sender, EventArgs e)//evento scatenato al click del btn Prenota nello usercontrol prenotazione che aggiunge un prestito
        {

            if (Dictionary_Utenti.ContainsKey(((Dati)e).prestito.code))//verifica che l'utente esista
            {
                if (Dictionary_Utenti[((Dati)e).prestito.code].libri_prenotati >= 3)//verifica che l'utente non abbia già 3 prestiti in corso, se ne ha 3 o di più annulla la prenotazione
                {

                    MessageBox.Show("L'utente ha già 3 prenotazioni in corso");

                }
                else if (Dictionary_Libri[((Dati)e).prestito.isbn].prestati == Dictionary_Libri[((Dati)e).prestito.isbn].qta) //tutti le copie sono già state prestate
                {
                    MessageBox.Show("Tutte le copie del libro sono già state prestate");
                }
                else //se l'utente può chiedere un libro in prestito
                {
                    Dictionary_Utenti[((Dati)e).prestito.code].libri_prenotati += 1;//aggiunge un libro al numero di libri preso in prestito dall'utente
                    Dictionary_Utenti[((Dati)e).prestito.code].libri_richiesti += 1;//aggiunge un libro al numero di libri preso in prestito dall'utente in totale

                    Dictionary_Libri[((Dati)e).prestito.isbn].prestati += 1;//aggiunge un libro ai libri prestati
                    Dictionary_Libri[((Dati)e).prestito.isbn].prestiti_totali += 1;//aggiunge un libro ai libri prestati in totale

                    Dictionary_Prestiti.Add(((Dati)e).prestito.codice_prestito, ((Dati)e).prestito);//aggiunge la prestito alla dictionary dei prestiti

                    //carico i dati nei rispettivi file per salvarli
                    ListToJSON_Prestiti();
                    ListToJSON_Users();
                    //aggiorno i dati del form
                    BindData();
                }
            }
        }


        //Visualizzare profilo dell'Utente selezionato e dono fedeltà
        private void btnViewUser_Click(object sender, EventArgs e)//evento scatenato al click del btn ViewUser che permette di visualizzare lo usercontrol con i dati relativi all'utente corrente
        {
            int rowindex = dgwUtenti.CurrentCell.RowIndex;

            visualizza_profilo.CurrentUser = Dictionary_Utenti[dgwUtenti.Rows[rowindex].Cells[6].Value.ToString()]; //ottengo l'utente che si trova nella riga selezionata
            visualizza_profilo.LoadUser();

            visualizza_profilo.BringToFront();
        }

        private void visualizza_profilo_DonoFedelta(object sender, EventArgs e)
        {
            string to, from, pass, mail, oggetto;

            //inserire qui i dati per testare il funzionamento della funzionalità d'invio mail
            to = "6189921@itisrossi.vi.it"; //la mail di chi deve ricevere
            from = "joeyg20040114@gmail.com"; //la mail di chi invia
            pass = "Aa.Bb_Cc/123456789$"; //la password di chi invia

            //i seguenti dati sarebbero commentati sono quelli che dovrebbero essere utilizzati. Per poter verificare al meglio il funzionamento di questa funzionalità utilizzare due mail proprie inserendole sopra
            //to = Dictionary_Utenti[((Dati)e).utente.code].email;
            //from = CurrentUser.email;
            //pass = CurrentUser.password;
            mail = "Gentile " + Dictionary_Utenti[((Dati)e).utente.code].first_name + ".\nHa diritto a ricevere un premio fedeltà per aver letto più di 10 libri. \nCordiali Saluti";
            oggetto = "Dono Fedeltà";

            SendEmail(to, from, pass, mail, oggetto);
        }
        
        private void visualizza_profilo_Close(object sender, EventArgs e)//evento scatenato al click del btn Close che chiude la schermata utente
        {
            visualizza_profilo.SendToBack();
        }
        
        //Visualizzare libro selezionato nella dgwLibri
        private void BtnViewBook_Click(object sender, EventArgs e)
        {
            if (tbc.SelectedIndex == 1 && CurrentUser.role == "admin")
            {
                ViewBook();
            }
            else if (tbc.SelectedIndex == 1 && CurrentUser.role == "user")
            {
                ViewBook();
            }
        }
        
        public void ViewBook()//evento scatenato al click del btn ViewBook che apre la schermata libro
        {
            int rowindex = dgwLibri.CurrentCell.RowIndex;

            visualizza_libro.Book = Dictionary_Libri[dgwLibri.Rows[rowindex].Cells[8].Value.ToString()]; //ottengo il libro che si trova nella riga selezionata
            visualizza_libro.LoadBook(); //Carico i dati relativi al libro selezionato nello usercontrol per la visione dei libri
            visualizza_libro.BringToFront();
        }

        private void visualizza_libro_Close(object sender, EventArgs e)//evento scatenato al click del btn Close che chiude la schermata libro
        {
            visualizza_libro.SendToBack();
        }


        //Rimozione di libri e utenti dalle dgw
        private void btnRemove_Click(object sender, EventArgs e)//funzione che permette di rimuovere utenti e libri cliccando la riga corrispondente sulla dgw e poi il btn Rimuovi
        {
            int rowindex = 0; //variabile che contiene l'indice della riga selezionata

            if (TbcIndex == 0)
            {
                rowindex = dgwUtenti.CurrentCell.RowIndex;

                if (Dictionary_Utenti[dgwUtenti.Rows[rowindex].Cells[6].Value.ToString()].libri_prenotati <= 0)
                {
                    Dictionary_Utenti.Remove(dgwUtenti.Rows[rowindex].Cells[6].Value.ToString()); //rimuovo l'utente che si trova nella riga selezionata

                    BindDataUtenti(); //aggiorno i dati relativi all'utente nel form

                    ListToJSON_Users(); //carico la lista senza l'utente rimosso nel file json
                }
            }

            else if (TbcIndex == 1)
            {
                rowindex = dgwLibri.CurrentCell.RowIndex;

                if (Dictionary_Libri[dgwLibri.Rows[rowindex].Cells[8].Value.ToString()].prestati <= 0)
                {
                    Dictionary_Libri.Remove(dgwLibri.Rows[rowindex].Cells[8].Value.ToString()); //rimuovo il libro che si trova nella riga selezionata

                    BindDataLibri(); //aggiorno i dati relativi ai libri nel form

                    ListToJSON_Books(); //carico la lista senza l'utente rimosso nel file json
                }
            }

            else if (TbcIndex == 2) { } //contiene l'intoccabile dgw prestiti, modificabile solo tramite l'apposito pulsante Valuta
        }


        //Aggiunta di libri e utenti
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBooksAndUsers.BringToFront();
        }
        
        private void AddBooksAndUsers_Close(object sender, EventArgs e)//evento scatenato al click del btn Close che chiude la schermata di aggiunta
        {
            AddBooksAndUsers.SendToBack();
        }

        private void AddBooksAndUsers_AddUser(object sender, EventArgs e)//evento che aggiunge il nuovo utente e carica nuovamente i dati
        {
            if (Dictionary_Utenti.ContainsKey(((Dati)e).utente.code))//se già esiste un utente con lo stesso code non potrà essere inserito quello nuovo
            {
                MessageBox.Show("Esiste già un utente con lo stesso code");
            }
            else
            {
                Dictionary_Utenti.Add(((Dati)e).utente.code, ((Dati)e).utente); //aggiungo l'utente alla dictionary degli utenti

                BindDataUtenti(); //aggiorno i dati relativi all'utente nel form

                ListToJSON_Users(); //carico la lista senza l'utente rimosso nel file json
            }
        }

        private void AddBooksAndUsers_AddBook(object sender, EventArgs e)//evento che aggiunge il nuovo libro e carica nuovamente i dati
        {
            if (Dictionary_Libri.ContainsKey(((Dati)e).libro.isbn))//se già esiste un libro con lo stesso isbn non potrà essere inserito quello nuovo
            {
                MessageBox.Show("Esiste già un libro con lo stesso isbn");
            }
            else
            {
                Dictionary_Libri.Add(((Dati)e).libro.isbn, ((Dati)e).libro); //aggiungo il libro alla dictionary dei libri

                BindDataLibri(); //aggiorno i dati relativi ai libri nel form

                ListToJSON_Books(); //carico la lista senza l'utente rimosso nel file json
            }
        }


        //modifica dei libri/users
        private void btnModify_Click(object sender, EventArgs e)
        {
            int rowindex = 0; //variabile che contiene l'indice della riga selezionata

            if (TbcIndex == 0)
            {
                rowindex = dgwUtenti.CurrentCell.RowIndex;

                ModifyBookUser.User = Dictionary_Utenti[dgwUtenti.Rows[rowindex].Cells[6].Value.ToString()]; //passo allo usercontrol per modificare gli utenti i dati relativi all'utente da modificare

                ModifyBookUser.LoadUser(); //carico i dati nello usercontrol
                ModifyBookUser.BringToFront(); //porto lo usercontrol in primo piano
            }

            else if (TbcIndex == 1)
            {
                rowindex = dgwLibri.CurrentCell.RowIndex;

                ModifyBookUser.Book = Dictionary_Libri[dgwLibri.Rows[rowindex].Cells[8].Value.ToString()]; //passo allo usercontrol per modificare i libru i dati relativi al libro da modificare

                ModifyBookUser.LoadBook(); //carico i dati nello usercontrol
                ModifyBookUser.BringToFront(); //porto lo usercontrol in primo piano
            }
        }

        private void ModifyBookUser_Close(object sender, EventArgs e)//evento scatenato al click del btn Close che chiude la schermata Modifica Libri e Utenti
        {
            ModifyBookUser.SendToBack();
        }

        private void ModifyBookUser_AddUser(object sender, EventArgs e)//evento che modifica un utente e carica nuovamente i dati
        {
            if (Dictionary_Utenti.ContainsKey(((Dati)e).utente.code))
            {
                Dictionary_Utenti[((Dati)e).utente.code] = ((Dati)e).utente;//sovrascrivo l'utente esistente

                BindDataUtenti(); //aggiorno i dati relativi all'utente nel form

                ListToJSON_Users(); //carico la lista senza l'utente rimosso nel file json
            }
            else { }
        }

        private void ModifyBookUser_AddBook(object sender, EventArgs e)//evento che modifica un libro e carica nuovamente i dati
        {
            if (Dictionary_Libri.ContainsKey(((Dati)e).libro.isbn))
            {
                Dictionary_Libri[((Dati)e).libro.isbn] = ((Dati)e).libro;//sovrascrivo il libro esistente

                BindDataLibri(); //aggiorno i dati relativi ai libri nel form

                ListToJSON_Books(); //carico la lista senza l'utente rimosso nel file json
            }
            else { }
        }


        //gestione dei prestiti e valutazione
        private void btnRating_Click(object sender, EventArgs e)
        {
            ValutazioneEPrestiti.BringToFront();
        }

        private void ValutazioneEPrestiti_Close(object sender, EventArgs e)//evento scatenato al click del btn Close che chiude la schermata Valutazione e Presiti
        {
            ValutazioneEPrestiti.SendToBack();
        }

        private void ValutazioneEPrestiti_FinePrestito(object sender, EventArgs e)//evento che esegue le operazioni di chiusura di un prestito
        {
            double SumVotes = (Dictionary_Libri[((Dati)e).prestito.isbn].average_rating / 100) * Dictionary_Libri[((Dati)e).prestito.isbn].ratings_count;

            SumVotes += ((Dati)e).valutazione; //aggiungo la valutazione al totale delle valutazioni calcolato sopra

            Dictionary_Libri[((Dati)e).prestito.isbn].ratings_count += 1; //aumento il counter dei rating

            Dictionary_Libri[((Dati)e).prestito.isbn].average_rating = Math.Round(((SumVotes / Dictionary_Libri[((Dati)e).prestito.isbn].ratings_count) * 100), 2); //calcolo la nuova media dei voti

            Dictionary_Libri[((Dati)e).prestito.isbn].prestati -= 1; //diminuisco il counter dei libri prestati 

            Dictionary_Utenti[((Dati)e).prestito.code].libri_prenotati -=1; //diminuisco il counter dei libri presi dall'utente

            Dictionary_Prestiti[((Dati)e).prestito.codice_prestito].tempo_mancante = "concluso";

            Dictionary_Utenti[((Dati)e).prestito.code].storico_prestiti.Add(Dictionary_Prestiti[((Dati)e).prestito.codice_prestito]);//aggiungo il prestito allo storico dei prestiti dell'user

            Dictionary_Prestiti.Remove(((Dati)e).prestito.codice_prestito); //rimuovo il prestito dalla dictionary e aggiorno i dati

            ListToJSON_Users();
            ListToJSON_Books();
            ListToJSON_Prestiti();

            BindData();
        }

        private void ValutazioneEPrestiti_SendEmail(object sender, EventArgs e)//evento che manda una mail per sollecitare gli utenti a restituire i libri
        {
            string to, from, pass, mail, oggetto;

            //inserire qui i dati per testare il funzionamento della funzionalità d'invio mail
            to = "6189921@itisrossi.vi.it"; //la mail di chi deve ricevere
            from = "joeyg20040114@gmail.com"; //la mail di chi invia
            pass = "Aa.Bb_Cc/123456789$"; //la password di chi invia

            //i seguenti dati sarebbero commentati sono quelli che dovrebbero essere utilizzati. Per poter verificare al meglio il funzionamento di questa funzionalità utilizzare due mail proprie inserendole sopra
            //to = Dictionary_Utenti[((Dati)e).prestito.code].email;
            //from = CurrentUser.email;
            //pass = CurrentUser.password;
            mail = "Gentile " + Dictionary_Utenti[((Dati)e).prestito.code].first_name + ". \nE' tenuto a restituire il libro: " + Dictionary_Libri[((Dati)e).prestito.isbn].title + ".  Tempo rimanente " + ((Dati)e).prestito.tempo_mancante + ". \nCordiali Saluti";
            oggetto = "Restituzione Libro";

            SendEmail(to, from, pass, mail, oggetto);
        }


        //Gestione delle statistiche
        private void btnStats_Click(object sender, EventArgs e)
        {
            Statistiche.CurrentUser = CurrentUser;
            Statistiche.BindData();
            Statistiche.BringToFront();
        }
        private void Statistiche_Close(object sender, EventArgs e)//evento scatenato al click del btn Close che chiude la schermata statistiche
        {
            Statistiche.SendToBack();
        }

        //Invio mail
        public void SendEmail(string to, string from, string pass, string mail, string oggetto)
        {

            //creo un nuovo oggetto MailMessage
            MailMessage message = new MailMessage();

            //aggiungo i dati ai campi di message
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail; //aggiungo il contenuto della mail
            message.Subject = oggetto; //aggiungo l'oggetto

            //creo un oggetto SmtpClient che consente di inviare messaggi tramite mail
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try { MessageBox.Show("Inviato con successo"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            //tool utilizzato per verificare il corretto invio delle mail
            //var client = new SmtpClient("smtp.mailtrap.io", 2525)
            //{
            //    Credentials = new NetworkCredential("13c78e4c6f7ffc", "b5492867732022"),
            //    EnableSsl = true
            //};
            //client.Send("from@example.com", "to@example.com", "Hello world", "testbody");
            //Console.WriteLine("Sent");
            //Console.ReadLine();
        }
    }
}
