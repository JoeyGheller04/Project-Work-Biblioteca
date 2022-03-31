using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public partial class AddBookUser : UserControl
    {
        public event EventHandler AddUser;
        public event EventHandler AddBook;
        public event EventHandler Close;

        public Utente User { get; set; }
        public Libro Book { get; set; }


        public AddBookUser()
        {
            InitializeComponent();

            User = new Utente();
            Book = new Libro();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txbNome.Text != "" && txbCognome.Text != "" && txbEmail.Text != "" && txbRole.Text != "" && txbCitta.Text != "" && txbPwd.Text != "" && txbDataNascita.Text != "" && GetEmail() == true)
            {
                AddUser.Invoke(null, new Dati(new Utente(txbNome.Text, txbCognome.Text, txbEmail.Text, txbRole.Text, txbCitta.Text, GetCode(), txbPwd.Text, txbDataNascita.Text)));

                CleanUsers();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            if (txbIsbn.Text != "" && txbTitolo.Text != "" && txbAutori.Text != "" && txbCategorie.Text != "" && txbDescrizione.Text != "" && txbAnno.Text != "" && txbPagine.Text != "" && txbQTA.Text != "")
            {
                AddBook.Invoke(null, new Dati(new Libro(txbIsbn.Text, txbTitolo.Text, txbAutori.Text, txbTitolo2.Text, txbCategorie.Text, txbThumbnail.Text, txbDescrizione.Text, Convert.ToDouble(txbAnno.Text), 0, Convert.ToDouble(txbPagine.Text), 0, Convert.ToDouble(txbQTA.Text), 0, 0))); ;

                CleanBooks();
            }
        }

        public string GetCode()//funzione che genera il codice fiscale
        {
            string code = "";

            List<char> lettere = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            List<char> numeri = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            List<char> simboli = new List<char>() { '_', '.', '/', '*'};
            Random rnd = new Random();
            int pos = rnd.Next(0, 25);

            code += txbNome.Text[0];                      //1° cifra

            code += lettere[rnd.Next(0, 25)];             //2° cifra

            code += txbDataNascita.Text[0];               //3° cifra

            code += numeri[rnd.Next(0, 9)];              //4° cifra

            code += txbCognome.Text[0];                   //5° cifra

            code += lettere[rnd.Next(0, 25)];             //6° cifra

            code += txbCitta.Text[0];                     //7° cifra

            code += numeri[rnd.Next(0, 9)];              //8° cifra

            code += txbEmail.Text[0];                     //9° cifra

            code += lettere[rnd.Next(0, 25)];             //10° cifra

            code += txbPwd.Text[0];                       //11° cifra

            code += lettere[rnd.Next(0, 25)];             //12° cifra

            code += numeri[rnd.Next(0, 9)];              //13° cifra

            code += simboli[rnd.Next(0, 4)];             //14° cifra

            code += simboli[rnd.Next(0, 4)];             //15° cifra

            code += simboli[rnd.Next(0, 4)];             //16° cifra

            if (code.Length == 16)
            {
                return code.ToUpper();
            }
            else
            {
                for(int i = code.Length; i<16; i++)
                {
                    code += "*";
                }
            }

            return code.ToUpper();
        }

        public bool GetEmail() //funzione che controlla che la @ non sia alla fine della mail perchè altrimenti non sarebbe una mail
        {
            if (txbEmail.Text.EndsWith("@"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnResetUser_Click(object sender, EventArgs e)
        {
            CleanUsers();
        }

        private void btnResetBook_Click(object sender, EventArgs e)
        {
            CleanBooks();
        }

        public void CleanUsers()
        {
            txbNome.Text = "";
            txbCognome.Text= "";
            txbEmail.Text= "";
            txbRole.Text= "";
            txbCitta.Text= "";
            txbPwd.Text= "";
            txbDataNascita.Text = "";
        }

        public void CleanBooks()
        {
            txbIsbn.Text = "";
            txbTitolo.Text = "";
            txbAutori.Text = "";
            txbTitolo2.Text = "";
            txbCategorie.Text = "";
            txbDescrizione.Text = "";
            txbAnno.Text = "";
            txbPagine.Text = "";
            txbQTA.Text = "";
            txbThumbnail.Text = "";
        }

        public void LoadUser()
        {
            CleanUsers();
            CleanBooks();

            txbNome.Text = User.first_name;
            txbCognome.Text = User.last_name;
            txbEmail.Text = User.email;
            txbRole.Text = User.role;
            txbCitta.Text = User.city;
            txbPwd.Text = User.password;
            txbDataNascita.Text = User.birth_date.ToString();
        }

        public void LoadBook()
        {
            CleanUsers();
            CleanBooks();

            txbIsbn.Text = Book.isbn;
            txbTitolo.Text = Book.title;
            txbAutori.Text = Book.authors;
            txbTitolo2.Text = Book.subtitle;
            txbCategorie.Text = Book.categories;
            txbDescrizione.Text = Book.description;
            txbAnno.Text = Book.published_year.ToString();
            txbPagine.Text = Book.num_pages.ToString();
            txbQTA.Text = Book.qta.ToString();
            txbThumbnail.Text = Book.thumbnail;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close.Invoke(null, null);
        }
    }
}
