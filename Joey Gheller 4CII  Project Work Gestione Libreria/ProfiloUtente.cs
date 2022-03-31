using System;
using System.Windows.Forms;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public partial class ProfiloUtente : UserControl
    {
        public event EventHandler Close;
        public event EventHandler DonoFedelta;
        public Utente CurrentUser { get; set; }

        public ProfiloUtente()
        {
            InitializeComponent();

            CurrentUser = new Utente();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close.Invoke(null, null);
        }

        public void LoadUser()
        {
            txbNomeCognome.Text = CurrentUser.first_name + " " + CurrentUser.last_name;
            txbCode.Text = CurrentUser.code;
            txbEmail.Text = CurrentUser.email;
            txbCity.Text = CurrentUser.city;
            txbBirth.Text = CurrentUser.birth_date.ToString();
            txbLibriPresi.Text = CurrentUser.libri_richiesti.ToString();
            if (CurrentUser.libri_richiesti > 10)
            {
                btnSendMail.Enabled = true;
            }
            txbNLibri.Text = CurrentUser.libri_prenotati.ToString() + " libri prenotati";
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            if (CurrentUser.libri_richiesti >= 10)
            {
                DonoFedelta.Invoke(null, new Dati(CurrentUser));
            }
        }
    }
}
