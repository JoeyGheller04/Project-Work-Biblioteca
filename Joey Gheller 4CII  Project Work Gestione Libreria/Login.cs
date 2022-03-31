using System;
using System.Windows.Forms;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public partial class Login : UserControl
    {
        public event EventHandler AccessoEffettuato; //evento che si scatena quandp viene effettuato l'accesso

        public Login()
        {
            InitializeComponent();
        }

        private void btnAccedi_Click(object sender, EventArgs e)//funzione scatenata al click del btn accesso che scatena l'evento AccessoEffettuato
        {
            AccessoEffettuato?.Invoke(null, new Dati(txbCodice.Text, txbPwd.Text));

            Clean();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clean();
        }

        public void Clean() //funzione che permette di resettare i dati nelle txb
        {
            txbCodice.Text = "";
            txbPwd.Text = "";
        }

        private void btnVievChar_Click(object sender, EventArgs e)
        {
            if (txbPwd.UseSystemPasswordChar == false)
            {
                txbPwd.UseSystemPasswordChar = true;
            }
            else
            {
                txbPwd.UseSystemPasswordChar = false;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)//dati preimpostati user
        {
            txbCodice.Text = textBox1.Text;
            txbPwd.Text = textBox2.Text;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)//dati preimpostati admin
        {
            txbCodice.Text = textBox3.Text;
            txbPwd.Text = textBox4.Text;
        }
    }
}
