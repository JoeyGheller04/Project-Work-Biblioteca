using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    public partial class GestionePresitiValuta : UserControl
    {
        public Dictionary<string, Prestito> Dictionary_Prestiti { get; set; }

        public event EventHandler Close;
        public event EventHandler FinePrestito;
        public event EventHandler SendEmail;

        public GestionePresitiValuta()
        {
            InitializeComponent();

            Dictionary_Prestiti = new Dictionary<string, Prestito>();
        }
        
        public void BindData()
        {

            var Result = from d in Dictionary_Prestiti
                         orderby d.Value.tempo_mancante ascending
                         select d.Value;

            List<Prestito> tmp = Result.ToList();

            dgwPrestiti.DataSource = null;
            dgwPrestiti.DataSource = tmp;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close.Invoke(null, null);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int rowindex = dgwPrestiti.CurrentCell.RowIndex;
    
            FinePrestito.Invoke(null, new Dati(Dictionary_Prestiti[dgwPrestiti.Rows[rowindex].Cells[5].Value.ToString()], Convert.ToDouble(txbValutazione.Text)));

            txbValutazione.Value = 0;
            btnRemove.Enabled = false;
        }

        private void txbValutazione_ValueChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            int rowindex = dgwPrestiti.CurrentCell.RowIndex;

            SendEmail.Invoke(null, new Dati(Dictionary_Prestiti[dgwPrestiti.Rows[rowindex].Cells[5].Value.ToString()]));
        }
    }
}
