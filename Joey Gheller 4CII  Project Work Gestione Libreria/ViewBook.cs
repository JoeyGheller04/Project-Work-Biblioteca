using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public partial class ViewBook : UserControl
    {
        public event EventHandler Close;
        public Libro Book { get; set; }

        public ViewBook()
        {
            InitializeComponent();
        }

        public void LoadBook()
        {
            txbTitolo.Text = Book.title;
            txbAutori.Text = Book.authors;
            txbCategories.Text = Book.categories;
            txbRating.Text = Convert.ToString(Book.average_rating / 100);
            txbDescrizione.Text = Book.description;

            if (Book.thumbnail != "")
            {
                picBook.Load(@Book.thumbnail);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Close.Invoke(null, null);
        }
    }
}
