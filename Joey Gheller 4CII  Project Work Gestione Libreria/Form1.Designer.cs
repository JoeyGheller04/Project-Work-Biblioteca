
namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    partial class frm1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new Joey_Gheller_4CII__Project_Work_Gestione_Libreria.Login();
            this.prenotazione = new Joey_Gheller_4CII__Project_Work_Gestione_Libreria.PrenotazioneLibro();
            this.tabPrincipale = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new FontAwesome.Sharp.IconButton();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnPrestiti = new FontAwesome.Sharp.IconButton();
            this.btnLibri = new FontAwesome.Sharp.IconButton();
            this.btnUtenti = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabComandi = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemovePrenota = new FontAwesome.Sharp.IconButton();
            this.btnPrenota = new FontAwesome.Sharp.IconButton();
            this.btnRemoveBook = new FontAwesome.Sharp.IconButton();
            this.btnRemoveUser = new FontAwesome.Sharp.IconButton();
            this.tabAccount = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnViewUser = new FontAwesome.Sharp.IconButton();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbpUtenti = new System.Windows.Forms.TabPage();
            this.dgwUtenti = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpLibri = new System.Windows.Forms.TabPage();
            this.dgwLibri = new System.Windows.Forms.DataGridView();
            this.columnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSubtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAuthors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPublishedyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpPrestiti = new System.Windows.Forms.TabPage();
            this.dgwPrestiti = new System.Windows.Forms.DataGridView();
            this.columnIsbn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataInizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTempoMancante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPrincipale.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabComandi.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tbc.SuspendLayout();
            this.tbpUtenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUtenti)).BeginInit();
            this.tbpLibri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibri)).BeginInit();
            this.tbpPrestiti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrestiti)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login.Location = new System.Drawing.Point(0, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(1251, 996);
            this.login.TabIndex = 4;
            // 
            // prenotazione
            // 
            this.prenotazione.BackColor = System.Drawing.SystemColors.ControlDark;
            this.prenotazione.Dictionary_Libri = null;
            this.prenotazione.Dictionary_Utenti = null;
            this.prenotazione.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prenotazione.Location = new System.Drawing.Point(0, 0);
            this.prenotazione.Name = "prenotazione";
            this.prenotazione.Size = new System.Drawing.Size(1251, 996);
            this.prenotazione.TabIndex = 5;
            // 
            // tabPrincipale
            // 
            this.tabPrincipale.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPrincipale.ColumnCount = 2;
            this.tabPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tabPrincipale.Controls.Add(this.panel1, 0, 0);
            this.tabPrincipale.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tabPrincipale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipale.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipale.Name = "tabPrincipale";
            this.tabPrincipale.RowCount = 1;
            this.tabPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabPrincipale.Size = new System.Drawing.Size(1251, 996);
            this.tabPrincipale.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.btnPrestiti);
            this.panel1.Controls.Add(this.btnLibri);
            this.panel1.Controls.Add(this.btnUtenti);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 990);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txbSearch);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(14, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 177);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ricerca";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFind.IconColor = System.Drawing.Color.White;
            this.btnFind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(17, 86);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(193, 68);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearch.Location = new System.Drawing.Point(17, 49);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(193, 31);
            this.txbSearch.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 142;
            this.iconPictureBox1.Location = new System.Drawing.Point(14, 9);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(210, 142);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnPrestiti
            // 
            this.btnPrestiti.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrestiti.FlatAppearance.BorderSize = 0;
            this.btnPrestiti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrestiti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestiti.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestiti.ForeColor = System.Drawing.Color.White;
            this.btnPrestiti.IconChar = FontAwesome.Sharp.IconChar.HandHolding;
            this.btnPrestiti.IconColor = System.Drawing.Color.White;
            this.btnPrestiti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrestiti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestiti.Location = new System.Drawing.Point(14, 305);
            this.btnPrestiti.Name = "btnPrestiti";
            this.btnPrestiti.Size = new System.Drawing.Size(227, 68);
            this.btnPrestiti.TabIndex = 5;
            this.btnPrestiti.Text = "Prestiti";
            this.btnPrestiti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrestiti.UseVisualStyleBackColor = false;
            this.btnPrestiti.Click += new System.EventHandler(this.btnPrestiti_Click);
            // 
            // btnLibri
            // 
            this.btnLibri.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLibri.FlatAppearance.BorderSize = 0;
            this.btnLibri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLibri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibri.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibri.ForeColor = System.Drawing.Color.White;
            this.btnLibri.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnLibri.IconColor = System.Drawing.Color.White;
            this.btnLibri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibri.Location = new System.Drawing.Point(14, 231);
            this.btnLibri.Name = "btnLibri";
            this.btnLibri.Size = new System.Drawing.Size(227, 68);
            this.btnLibri.TabIndex = 4;
            this.btnLibri.Text = "Libri";
            this.btnLibri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibri.UseVisualStyleBackColor = false;
            this.btnLibri.Click += new System.EventHandler(this.btnLibri_Click);
            // 
            // btnUtenti
            // 
            this.btnUtenti.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUtenti.FlatAppearance.BorderSize = 0;
            this.btnUtenti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUtenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtenti.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtenti.ForeColor = System.Drawing.Color.White;
            this.btnUtenti.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUtenti.IconColor = System.Drawing.Color.White;
            this.btnUtenti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUtenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtenti.Location = new System.Drawing.Point(14, 157);
            this.btnUtenti.Name = "btnUtenti";
            this.btnUtenti.Size = new System.Drawing.Size(227, 68);
            this.btnUtenti.TabIndex = 3;
            this.btnUtenti.Text = "Utenti";
            this.btnUtenti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUtenti.UseVisualStyleBackColor = false;
            this.btnUtenti.Click += new System.EventHandler(this.btnUtenti_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tabComandi, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tabAccount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbc, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(190, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1058, 990);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tabComandi
            // 
            this.tabComandi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabComandi.ColumnCount = 9;
            this.tabComandi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tabComandi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabComandi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tabComandi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabComandi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tabComandi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabComandi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tabComandi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabComandi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tabComandi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabComandi.Controls.Add(this.btnRemovePrenota, 7, 1);
            this.tabComandi.Controls.Add(this.btnPrenota, 5, 1);
            this.tabComandi.Controls.Add(this.btnRemoveBook, 3, 1);
            this.tabComandi.Controls.Add(this.btnRemoveUser, 1, 1);
            this.tabComandi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabComandi.Location = new System.Drawing.Point(3, 151);
            this.tabComandi.Name = "tabComandi";
            this.tabComandi.RowCount = 3;
            this.tabComandi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabComandi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabComandi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabComandi.Size = new System.Drawing.Size(1052, 142);
            this.tabComandi.TabIndex = 10;
            // 
            // btnRemovePrenota
            // 
            this.btnRemovePrenota.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemovePrenota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemovePrenota.FlatAppearance.BorderSize = 0;
            this.btnRemovePrenota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemovePrenota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePrenota.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePrenota.ForeColor = System.Drawing.Color.White;
            this.btnRemovePrenota.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnRemovePrenota.IconColor = System.Drawing.Color.White;
            this.btnRemovePrenota.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemovePrenota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovePrenota.Location = new System.Drawing.Point(810, 38);
            this.btnRemovePrenota.Name = "btnRemovePrenota";
            this.btnRemovePrenota.Size = new System.Drawing.Size(151, 65);
            this.btnRemovePrenota.TabIndex = 22;
            this.btnRemovePrenota.Text = "Rimuovi Prenota";
            this.btnRemovePrenota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemovePrenota.UseVisualStyleBackColor = false;
            // 
            // btnPrenota
            // 
            this.btnPrenota.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrenota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrenota.FlatAppearance.BorderSize = 0;
            this.btnPrenota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrenota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrenota.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrenota.ForeColor = System.Drawing.Color.White;
            this.btnPrenota.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnPrenota.IconColor = System.Drawing.Color.White;
            this.btnPrenota.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrenota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrenota.Location = new System.Drawing.Point(569, 38);
            this.btnPrenota.Name = "btnPrenota";
            this.btnPrenota.Size = new System.Drawing.Size(151, 65);
            this.btnPrenota.TabIndex = 20;
            this.btnPrenota.Text = "Prenota Libro";
            this.btnPrenota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrenota.UseVisualStyleBackColor = false;
            this.btnPrenota.Click += new System.EventHandler(this.btnPrenota_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveBook.FlatAppearance.BorderSize = 0;
            this.btnRemoveBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBook.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBook.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBook.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnRemoveBook.IconColor = System.Drawing.Color.White;
            this.btnRemoveBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveBook.Location = new System.Drawing.Point(328, 38);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(151, 65);
            this.btnRemoveBook.TabIndex = 18;
            this.btnRemoveBook.Text = "Rimuovi Libro";
            this.btnRemoveBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveBook.UseVisualStyleBackColor = false;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveUser.FlatAppearance.BorderSize = 0;
            this.btnRemoveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUser.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnRemoveUser.IconColor = System.Drawing.Color.White;
            this.btnRemoveUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveUser.Location = new System.Drawing.Point(87, 38);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(151, 65);
            this.btnRemoveUser.TabIndex = 16;
            this.btnRemoveUser.Text = "Rimuovi Utente";
            this.btnRemoveUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            // 
            // tabAccount
            // 
            this.tabAccount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabAccount.ColumnCount = 9;
            this.tabAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tabAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tabAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tabAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tabAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tabAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabAccount.Controls.Add(this.btnLogout, 3, 1);
            this.tabAccount.Controls.Add(this.btnViewUser, 1, 1);
            this.tabAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAccount.Location = new System.Drawing.Point(3, 3);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.RowCount = 3;
            this.tabAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabAccount.Size = new System.Drawing.Size(1052, 142);
            this.tabAccount.TabIndex = 9;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(328, 38);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(151, 65);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewUser.FlatAppearance.BorderSize = 0;
            this.btnViewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUser.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnViewUser.IconColor = System.Drawing.Color.White;
            this.btnViewUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewUser.Location = new System.Drawing.Point(87, 38);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(151, 65);
            this.btnViewUser.TabIndex = 4;
            this.btnViewUser.Text = "Utente";
            this.btnViewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewUser.UseVisualStyleBackColor = false;
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tbpUtenti);
            this.tbc.Controls.Add(this.tbpLibri);
            this.tbc.Controls.Add(this.tbpPrestiti);
            this.tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc.Location = new System.Drawing.Point(3, 299);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(1052, 688);
            this.tbc.TabIndex = 6;
            // 
            // tbpUtenti
            // 
            this.tbpUtenti.Controls.Add(this.dgwUtenti);
            this.tbpUtenti.Location = new System.Drawing.Point(4, 22);
            this.tbpUtenti.Name = "tbpUtenti";
            this.tbpUtenti.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUtenti.Size = new System.Drawing.Size(1044, 662);
            this.tbpUtenti.TabIndex = 0;
            this.tbpUtenti.Text = "Utenti";
            this.tbpUtenti.UseVisualStyleBackColor = true;
            // 
            // dgwUtenti
            // 
            this.dgwUtenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUtenti.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgwUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUtenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnSurname,
            this.columnEmail,
            this.columnCity,
            this.columnBirth,
            this.columnCode,
            this.columnPwd,
            this.columnRole});
            this.dgwUtenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUtenti.Location = new System.Drawing.Point(3, 3);
            this.dgwUtenti.Name = "dgwUtenti";
            this.dgwUtenti.Size = new System.Drawing.Size(1038, 656);
            this.dgwUtenti.TabIndex = 0;
            // 
            // columnName
            // 
            this.columnName.DataPropertyName = "first_name";
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            // 
            // columnSurname
            // 
            this.columnSurname.DataPropertyName = "last_name";
            this.columnSurname.HeaderText = "Surname";
            this.columnSurname.Name = "columnSurname";
            // 
            // columnEmail
            // 
            this.columnEmail.DataPropertyName = "email";
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.Name = "columnEmail";
            // 
            // columnCity
            // 
            this.columnCity.DataPropertyName = "city";
            this.columnCity.HeaderText = "City";
            this.columnCity.Name = "columnCity";
            // 
            // columnBirth
            // 
            this.columnBirth.DataPropertyName = "birth_date";
            this.columnBirth.HeaderText = "Birth Date";
            this.columnBirth.Name = "columnBirth";
            // 
            // columnCode
            // 
            this.columnCode.DataPropertyName = "code";
            this.columnCode.HeaderText = "Code";
            this.columnCode.Name = "columnCode";
            // 
            // columnPwd
            // 
            this.columnPwd.DataPropertyName = "password";
            this.columnPwd.HeaderText = "Password";
            this.columnPwd.Name = "columnPwd";
            // 
            // columnRole
            // 
            this.columnRole.DataPropertyName = "role";
            this.columnRole.HeaderText = "Role";
            this.columnRole.Name = "columnRole";
            // 
            // tbpLibri
            // 
            this.tbpLibri.Controls.Add(this.dgwLibri);
            this.tbpLibri.Location = new System.Drawing.Point(4, 22);
            this.tbpLibri.Name = "tbpLibri";
            this.tbpLibri.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLibri.Size = new System.Drawing.Size(1044, 662);
            this.tbpLibri.TabIndex = 1;
            this.tbpLibri.Text = "Libri";
            this.tbpLibri.UseVisualStyleBackColor = true;
            // 
            // dgwLibri
            // 
            this.dgwLibri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLibri.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgwLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLibri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTitle,
            this.columnSubtitle,
            this.columnAuthors,
            this.columnCategories,
            this.columnPublishedyear,
            this.columnRating,
            this.columnNPage,
            this.columnQta,
            this.columnIsbn});
            this.dgwLibri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwLibri.Location = new System.Drawing.Point(3, 3);
            this.dgwLibri.Name = "dgwLibri";
            this.dgwLibri.Size = new System.Drawing.Size(1038, 656);
            this.dgwLibri.TabIndex = 1;
            // 
            // columnTitle
            // 
            this.columnTitle.DataPropertyName = "title";
            this.columnTitle.HeaderText = "Title";
            this.columnTitle.Name = "columnTitle";
            // 
            // columnSubtitle
            // 
            this.columnSubtitle.DataPropertyName = "subtitle";
            this.columnSubtitle.HeaderText = "Subtitle";
            this.columnSubtitle.Name = "columnSubtitle";
            // 
            // columnAuthors
            // 
            this.columnAuthors.DataPropertyName = "authors";
            this.columnAuthors.HeaderText = "Authors";
            this.columnAuthors.Name = "columnAuthors";
            // 
            // columnCategories
            // 
            this.columnCategories.DataPropertyName = "categories";
            this.columnCategories.HeaderText = "Categories";
            this.columnCategories.Name = "columnCategories";
            // 
            // columnPublishedyear
            // 
            this.columnPublishedyear.DataPropertyName = "published_year";
            this.columnPublishedyear.HeaderText = "Pubblication Year";
            this.columnPublishedyear.Name = "columnPublishedyear";
            // 
            // columnRating
            // 
            this.columnRating.DataPropertyName = "average_rating";
            this.columnRating.HeaderText = "Rating";
            this.columnRating.Name = "columnRating";
            // 
            // columnNPage
            // 
            this.columnNPage.DataPropertyName = "num_pages";
            this.columnNPage.HeaderText = "Pages";
            this.columnNPage.Name = "columnNPage";
            // 
            // columnQta
            // 
            this.columnQta.DataPropertyName = "qta";
            this.columnQta.HeaderText = "Quantity";
            this.columnQta.Name = "columnQta";
            // 
            // columnIsbn
            // 
            this.columnIsbn.DataPropertyName = "Isbn";
            this.columnIsbn.HeaderText = "Isbn";
            this.columnIsbn.Name = "columnIsbn";
            // 
            // tbpPrestiti
            // 
            this.tbpPrestiti.Controls.Add(this.dgwPrestiti);
            this.tbpPrestiti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbpPrestiti.Location = new System.Drawing.Point(4, 22);
            this.tbpPrestiti.Name = "tbpPrestiti";
            this.tbpPrestiti.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPrestiti.Size = new System.Drawing.Size(1044, 662);
            this.tbpPrestiti.TabIndex = 2;
            this.tbpPrestiti.Text = "Prestiti";
            this.tbpPrestiti.UseVisualStyleBackColor = true;
            // 
            // dgwPrestiti
            // 
            this.dgwPrestiti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPrestiti.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgwPrestiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrestiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIsbn1,
            this.columnCode1,
            this.columnDataInizio,
            this.columnDataFine,
            this.columnTempoMancante});
            this.dgwPrestiti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPrestiti.Location = new System.Drawing.Point(3, 3);
            this.dgwPrestiti.Name = "dgwPrestiti";
            this.dgwPrestiti.Size = new System.Drawing.Size(1038, 656);
            this.dgwPrestiti.TabIndex = 2;
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
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1251, 996);
            this.Controls.Add(this.tabPrincipale);
            this.Controls.Add(this.prenotazione);
            this.Controls.Add(this.login);
            this.MaximizeBox = false;
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libreria Gheller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPrincipale.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabComandi.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.tbc.ResumeLayout(false);
            this.tbpUtenti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUtenti)).EndInit();
            this.tbpLibri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibri)).EndInit();
            this.tbpPrestiti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrestiti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Login login;
        private PrenotazioneLibro prenotazione;
        private System.Windows.Forms.TableLayoutPanel tabPrincipale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnFind;
        private System.Windows.Forms.TextBox txbSearch;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnPrestiti;
        private FontAwesome.Sharp.IconButton btnLibri;
        private FontAwesome.Sharp.IconButton btnUtenti;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tabComandi;
        private FontAwesome.Sharp.IconButton btnRemovePrenota;
        private FontAwesome.Sharp.IconButton btnPrenota;
        private FontAwesome.Sharp.IconButton btnRemoveBook;
        private FontAwesome.Sharp.IconButton btnRemoveUser;
        private System.Windows.Forms.TableLayoutPanel tabAccount;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnViewUser;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tbpUtenti;
        private System.Windows.Forms.DataGridView dgwUtenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRole;
        private System.Windows.Forms.TabPage tbpLibri;
        private System.Windows.Forms.DataGridView dgwLibri;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSubtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPublishedyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIsbn;
        private System.Windows.Forms.TabPage tbpPrestiti;
        private System.Windows.Forms.DataGridView dgwPrestiti;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIsbn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataInizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTempoMancante;
    }
}

