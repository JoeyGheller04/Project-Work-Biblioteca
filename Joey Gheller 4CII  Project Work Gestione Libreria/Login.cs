using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public partial class Login : UserControl
    {
        public event EventHandler AccessoEffettuato;

        public Login()
        {
            InitializeComponent();
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            AccessoEffettuato?.Invoke(null, new Dati(txbCodice.Text, txbPwd.Text));

            Clean();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clean();
        }
    
        public void Clean()
        {
            txbCodice.Text = "";
            txbPwd.Text = "";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            txbCodice.Text = textBox1.Text;
            txbPwd.Text = textBox2.Text;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            txbCodice.Text = textBox3.Text;
            txbPwd.Text = textBox4.Text;
        }
    }
}
