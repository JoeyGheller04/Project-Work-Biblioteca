
namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    partial class GestionePresitiValuta
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgwPrestiti = new System.Windows.Forms.DataGridView();
            this.columnIsbn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataInizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTempoMancante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCodicePrestito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbValutazione = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSendMail = new FontAwesome.Sharp.IconButton();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrestiti)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbValutazione)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.dgwPrestiti, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLogout, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1135, 673);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgwPrestiti
            // 
            this.dgwPrestiti.AllowUserToResizeColumns = false;
            this.dgwPrestiti.AllowUserToResizeRows = false;
            this.dgwPrestiti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPrestiti.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgwPrestiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrestiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIsbn1,
            this.columnCode1,
            this.columnDataInizio,
            this.columnDataFine,
            this.columnTempoMancante,
            this.columnCodicePrestito});
            this.dgwPrestiti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPrestiti.Location = new System.Drawing.Point(116, 136);
            this.dgwPrestiti.Name = "dgwPrestiti";
            this.dgwPrestiti.Size = new System.Drawing.Size(391, 498);
            this.dgwPrestiti.TabIndex = 10;
            // 
            // columnIsbn1
            // 
            this.columnIsbn1.DataPropertyName = "isbn";
            this.columnIsbn1.HeaderText = "Isbn";
            this.columnIsbn1.Name = "columnIsbn1";
            // 
            // columnCode1
            // 
            this.columnCode1.DataPropertyName = "code";
            this.columnCode1.HeaderText = "Code";
            this.columnCode1.Name = "columnCode1";
            // 
            // columnDataInizio
            // 
            this.columnDataInizio.DataPropertyName = "data_inizio";
            this.columnDataInizio.HeaderText = "Da";
            this.columnDataInizio.Name = "columnDataInizio";
            // 
            // columnDataFine
            // 
            this.columnDataFine.DataPropertyName = "data_fine";
            this.columnDataFine.HeaderText = "A";
            this.columnDataFine.Name = "columnDataFine";
            // 
            // columnTempoMancante
            // 
            this.columnTempoMancante.DataPropertyName = "tempo_mancante";
            this.columnTempoMancante.HeaderText = "Tempo mancante";
            this.columnTempoMancante.Name = "columnTempoMancante";
            // 
            // columnCodicePrestito
            // 
            this.columnCodicePrestito.DataPropertyName = "codice_prestito";
            this.columnCodicePrestito.HeaderText = "Codice Prestito";
            this.columnCodicePrestito.Name = "columnCodicePrestito";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 64;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.Location = new System.Drawing.Point(1030, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 73);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSendMail);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(626, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 498);
            this.panel1.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 222);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(391, 46);
            this.panel5.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbValutazione);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 122);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 100);
            this.panel3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Inserire Valutazione";
            // 
            // txbValutazione
            // 
            this.txbValutazione.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValutazione.Location = new System.Drawing.Point(215, 35);
            this.txbValutazione.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txbValutazione.Name = "txbValutazione";
            this.txbValutazione.Size = new System.Drawing.Size(72, 31);
            this.txbValutazione.TabIndex = 20;
            this.txbValutazione.ValueChanged += new System.EventHandler(this.txbValutazione_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 46);
            this.panel2.TabIndex = 21;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSendMail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSendMail.FlatAppearance.BorderSize = 0;
            this.btnSendMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnSendMail.IconColor = System.Drawing.Color.White;
            this.btnSendMail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSendMail.IconSize = 65;
            this.btnSendMail.Location = new System.Drawing.Point(0, 405);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(391, 93);
            this.btnSendMail.TabIndex = 20;
            this.btnSendMail.Text = "Invia Mail";
            this.btnSendMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnRemove.IconColor = System.Drawing.Color.White;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 64;
            this.btnRemove.Location = new System.Drawing.Point(0, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(391, 76);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Valuta Libro e Chiudi Prestito";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // GestionePresitiValuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GestionePresitiValuta";
            this.Size = new System.Drawing.Size(1135, 673);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrestiti)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbValutazione)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.DataGridView dgwPrestiti;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIsbn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataInizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTempoMancante;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCodicePrestito;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnSendMail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txbValutazione;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
    }
}
