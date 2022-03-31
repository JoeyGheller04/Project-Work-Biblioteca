using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class Dashboard : UserControl
    {
        public event EventHandler Close;
       
        public Dictionary<string, Utente> Dictionary_Utenti { get; set; }
        public Dictionary<string, Libro> Dictionary_Libri { get; set; }
        public Utente CurrentUser { get; set; }

        public Dashboard()
        {
            InitializeComponent();

            dgwUtenti.AutoGenerateColumns = false;
            dgwLibri.AutoGenerateColumns = false;

            Dictionary_Utenti = new Dictionary<string, Utente>();
            Dictionary_Libri = new Dictionary<string, Libro>();

            tbc.Appearance = TabAppearance.FlatButtons;
            tbc.ItemSize = new Size(0, 1);
            tbc.SizeMode = TabSizeMode.Fixed;

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close.Invoke(null, null);
        }

        public void BindData()//funzione che richiama le altre funzioni bindData 
        {
            BindDataUtenti();
            BindDataLibri();

            if (CurrentUser.role == "admin")//se l'utente è un admin può accedere anche alla dgw utenti
            {
                tbc.TabPages.Remove(tbpUtenti);
                tbc.TabPages.Add(tbpUtenti);
                btnUtenti.Enabled = true;
            }

            else if (CurrentUser.role == "user")//se l'utente è uuser ha solo le funzionalità di base
            {
                tbc.TabPages.Remove(tbpUtenti);
                btnUtenti.Enabled = false;
            }
        }

        public void BindDataUtenti() //funzione che assegna alla dgw e al campo dictionary dello usercontrol prenotazione i valori della dictionary utenti
        {
            dgwUtenti.DataSource = null;
            dgwUtenti.DataSource = Dictionary_Utenti.Values.ToList();
        }

        public void BindDataLibri()//funzione che assegna alla dgw e al campo dictionary dello usercontrol prenotazione i valori della dictionary libri
        {
            dgwLibri.DataSource = null;
            dgwLibri.DataSource = Dictionary_Libri.Values.ToList();
        }

        //ricerche relative agli utenti
        private void btnMostReader_Click(object sender, EventArgs e)
        {
            //ricerca dei valori per chiave specifica ordinati in modo discendente
            var Result = from d in Dictionary_Utenti
                         orderby d.Value.libri_richiesti descending
                         select d.Value;

            List<Utente> tmp = Result.ToList();

            dgwUtenti.DataSource = tmp;

        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            //ricerca dei valori per chiave specifica ordinati in modo discendente
            var Result = from d in Dictionary_Utenti
                         orderby d.Value.libri_prenotati descending
                         select d.Value;

            List<Utente> tmp = Result.ToList();

            dgwUtenti.DataSource = tmp;
        }

        //ricerche relative ai libri
        private void btnVoto_Click(object sender, EventArgs e)
        {
            //ricerca dei valori per chiave specifica ordinati in modo discendente
            var Result = from d in Dictionary_Libri
                         orderby d.Value.average_rating descending
                         select d.Value;

            List<Libro> tmp = Result.ToList();

            dgwLibri.DataSource = tmp;
        }

        private void btnVotoNegativo_Click(object sender, EventArgs e)
        {
            //ricerca dei valori per chiave specifica ordinati in modo ascendente
            var Result = from d in Dictionary_Libri
                         orderby d.Value.average_rating ascending
                         select d.Value;

            List<Libro> tmp = Result.ToList();

            dgwLibri.DataSource = tmp;
        }

        private void btnPagine_Click(object sender, EventArgs e)
        {
            //ricerca dei valori per chiave specifica ordinati in modo discendente
            var Result = from d in Dictionary_Libri
                         orderby d.Value.num_pages descending
                         select d.Value;

            List<Libro> tmp = Result.ToList();

            dgwLibri.DataSource = tmp;
        }

        private void btnPrestitiTotali_Click(object sender, EventArgs e)
        {
            //ricerca dei valori per chiave specifica ordinati in modo discendente
            var Result = from d in Dictionary_Libri
                         orderby d.Value.prestiti_totali descending
                         select d.Value;

            List<Libro> tmp = Result.ToList();

            dgwLibri.DataSource = tmp;
        }

        private void btnLetti_Click(object sender, EventArgs e)
        {
            //ricerca dei valori per chiave specifica ordinati in modo discendente
            var Result = from d in Dictionary_Libri
                         orderby d.Value.ratings_count descending
                         select d.Value;

            List<Libro> tmp = Result.ToList();

            dgwLibri.DataSource = tmp;
        }

        private void btnQta_Click(object sender, EventArgs e)
        {
            //ricerca dei valori per chiave specifica ordinati in modo discendente
            var Result = from d in Dictionary_Libri
                         orderby d.Value.qta descending
                         select d.Value;

            List<Libro> tmp = Result.ToList();

            dgwLibri.DataSource = tmp;
        }

        private void btnUtenti_Click(object sender, EventArgs e)
        {
            tbpUtenti.Show();
            tbc.SelectedIndex = 1;
            btnPdfLibri.SendToBack();
        }

        private void btnLibri_Click(object sender, EventArgs e)
        {
            tbpUtenti.Show();
            tbc.SelectedIndex = 0;
            btnPdfUser.SendToBack();
        }


        private void btnPdfUser_Click(object sender, EventArgs e)
        {
            Export(dgwUtenti, "Utenti");
        }

        private void btnPdfLibri_Click(object sender, EventArgs e)
        {
            Export(dgwLibri, "Libri");
        }

        private void Export(DataGridView dgw, string filename)//funzione che permette di esportare i dati in formato pdf. I parametri sono la dgw a cui fare riferimento e il nome del file da creare
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count); //classe che permette di creare una tabella esportabile in formato pdf

            //formatto le proprietà della tabella
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            //Aggiunta degli header della dgw come header della tabella
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //caricamento dei dati nella tabella
            foreach (DataGridViewRow row in dgw.Rows)//scorrimento di singola riga
            {
                foreach (DataGridViewCell cell in row.Cells)//scorrimento di singola cella
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            //apro la finestra che permette di salvare i dati
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = filename; //assegno il nome al file
            saveFileDialog.DefaultExt = ".pdf"; //imposto l'estensione

            //salvo il file dove selezionato dall'utente
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDocument, stream);
                    pdfDocument.Open();
                    pdfDocument.Add(pdftable);
                    pdfDocument.Close();
                    stream.Close();
                }
            }
        }
    }
}
