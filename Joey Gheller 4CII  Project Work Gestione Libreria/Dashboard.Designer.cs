
namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    partial class Dashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPdfLibri = new FontAwesome.Sharp.IconButton();
            this.btnLibri = new FontAwesome.Sharp.IconButton();
            this.btnUtenti = new FontAwesome.Sharp.IconButton();
            this.btnPdfUser = new FontAwesome.Sharp.IconButton();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbpLibri = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLetti = new FontAwesome.Sharp.IconButton();
            this.btnVotoNegativo = new FontAwesome.Sharp.IconButton();
            this.btnQta = new FontAwesome.Sharp.IconButton();
            this.btnPrestitiTotali = new FontAwesome.Sharp.IconButton();
            this.btnPagine = new FontAwesome.Sharp.IconButton();
            this.btnVoto = new FontAwesome.Sharp.IconButton();
            this.dgwLibri = new System.Windows.Forms.DataGridView();
            this.columnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAuthors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrestitiTotali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLetti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpUtenti = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgwUtenti = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnlibri_richiesti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNLibri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostReader = new FontAwesome.Sharp.IconButton();
            this.btnActive = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbc.SuspendLayout();
            this.tbpLibri.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibri)).BeginInit();
            this.tbpUtenti.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUtenti)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 100);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.btnLogout, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1064, 100);
            this.tableLayoutPanel3.TabIndex = 1;
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
            this.btnLogout.Location = new System.Drawing.Point(967, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 77);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 94);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(287, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "statistiche";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.btnPdfLibri);
            this.panel3.Controls.Add(this.btnLibri);
            this.panel3.Controls.Add(this.btnUtenti);
            this.panel3.Controls.Add(this.btnPdfUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 546);
            this.panel3.TabIndex = 2;
            // 
            // btnPdfLibri
            // 
            this.btnPdfLibri.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPdfLibri.FlatAppearance.BorderSize = 0;
            this.btnPdfLibri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPdfLibri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfLibri.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdfLibri.ForeColor = System.Drawing.Color.White;
            this.btnPdfLibri.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnPdfLibri.IconColor = System.Drawing.Color.White;
            this.btnPdfLibri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPdfLibri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPdfLibri.Location = new System.Drawing.Point(17, 176);
            this.btnPdfLibri.Name = "btnPdfLibri";
            this.btnPdfLibri.Size = new System.Drawing.Size(227, 68);
            this.btnPdfLibri.TabIndex = 7;
            this.btnPdfLibri.Text = "Export Libri";
            this.btnPdfLibri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPdfLibri.UseVisualStyleBackColor = false;
            this.btnPdfLibri.Click += new System.EventHandler(this.btnPdfLibri_Click);
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
            this.btnLibri.Location = new System.Drawing.Point(13, 28);
            this.btnLibri.Name = "btnLibri";
            this.btnLibri.Size = new System.Drawing.Size(227, 68);
            this.btnLibri.TabIndex = 6;
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
            this.btnUtenti.Location = new System.Drawing.Point(17, 102);
            this.btnUtenti.Name = "btnUtenti";
            this.btnUtenti.Size = new System.Drawing.Size(227, 68);
            this.btnUtenti.TabIndex = 5;
            this.btnUtenti.Text = "Utenti";
            this.btnUtenti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUtenti.UseVisualStyleBackColor = false;
            this.btnUtenti.Click += new System.EventHandler(this.btnUtenti_Click);
            // 
            // btnPdfUser
            // 
            this.btnPdfUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPdfUser.FlatAppearance.BorderSize = 0;
            this.btnPdfUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPdfUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfUser.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdfUser.ForeColor = System.Drawing.Color.White;
            this.btnPdfUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnPdfUser.IconColor = System.Drawing.Color.White;
            this.btnPdfUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPdfUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPdfUser.Location = new System.Drawing.Point(17, 176);
            this.btnPdfUser.Name = "btnPdfUser";
            this.btnPdfUser.Size = new System.Drawing.Size(227, 68);
            this.btnPdfUser.TabIndex = 8;
            this.btnPdfUser.Text = "Export Utenti";
            this.btnPdfUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPdfUser.UseVisualStyleBackColor = false;
            this.btnPdfUser.Click += new System.EventHandler(this.btnPdfUser_Click);
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tbpLibri);
            this.tbc.Controls.Add(this.tbpUtenti);
            this.tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc.Location = new System.Drawing.Point(246, 100);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(818, 546);
            this.tbc.TabIndex = 3;
            // 
            // tbpLibri
            // 
            this.tbpLibri.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbpLibri.Controls.Add(this.tableLayoutPanel2);
            this.tbpLibri.Location = new System.Drawing.Point(4, 22);
            this.tbpLibri.Name = "tbpLibri";
            this.tbpLibri.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLibri.Size = new System.Drawing.Size(810, 520);
            this.tbpLibri.TabIndex = 1;
            this.tbpLibri.Text = "Libri";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgwLibri, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(804, 514);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnLetti);
            this.groupBox3.Controls.Add(this.btnVotoNegativo);
            this.groupBox3.Controls.Add(this.btnQta);
            this.groupBox3.Controls.Add(this.btnPrestitiTotali);
            this.groupBox3.Controls.Add(this.btnPagine);
            this.groupBox3.Controls.Add(this.btnVoto);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 475);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criteri Libri";
            // 
            // btnLetti
            // 
            this.btnLetti.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLetti.FlatAppearance.BorderSize = 0;
            this.btnLetti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLetti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetti.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetti.ForeColor = System.Drawing.Color.White;
            this.btnLetti.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnLetti.IconColor = System.Drawing.Color.White;
            this.btnLetti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLetti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLetti.Location = new System.Drawing.Point(17, 326);
            this.btnLetti.Name = "btnLetti";
            this.btnLetti.Size = new System.Drawing.Size(193, 68);
            this.btnLetti.TabIndex = 13;
            this.btnLetti.Text = "Più Letti";
            this.btnLetti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLetti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLetti.UseVisualStyleBackColor = false;
            this.btnLetti.Click += new System.EventHandler(this.btnLetti_Click);
            // 
            // btnVotoNegativo
            // 
            this.btnVotoNegativo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVotoNegativo.FlatAppearance.BorderSize = 0;
            this.btnVotoNegativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVotoNegativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotoNegativo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotoNegativo.ForeColor = System.Drawing.Color.White;
            this.btnVotoNegativo.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnVotoNegativo.IconColor = System.Drawing.Color.White;
            this.btnVotoNegativo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVotoNegativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVotoNegativo.Location = new System.Drawing.Point(17, 104);
            this.btnVotoNegativo.Name = "btnVotoNegativo";
            this.btnVotoNegativo.Size = new System.Drawing.Size(193, 68);
            this.btnVotoNegativo.TabIndex = 12;
            this.btnVotoNegativo.Text = "Meno Piaciuti";
            this.btnVotoNegativo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVotoNegativo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVotoNegativo.UseVisualStyleBackColor = false;
            this.btnVotoNegativo.Click += new System.EventHandler(this.btnVotoNegativo_Click);
            // 
            // btnQta
            // 
            this.btnQta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQta.FlatAppearance.BorderSize = 0;
            this.btnQta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQta.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQta.ForeColor = System.Drawing.Color.White;
            this.btnQta.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnQta.IconColor = System.Drawing.Color.White;
            this.btnQta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQta.Location = new System.Drawing.Point(17, 400);
            this.btnQta.Name = "btnQta";
            this.btnQta.Size = new System.Drawing.Size(193, 68);
            this.btnQta.TabIndex = 11;
            this.btnQta.Text = "Numero Maggiore";
            this.btnQta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQta.UseVisualStyleBackColor = false;
            this.btnQta.Click += new System.EventHandler(this.btnQta_Click);
            // 
            // btnPrestitiTotali
            // 
            this.btnPrestitiTotali.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrestitiTotali.FlatAppearance.BorderSize = 0;
            this.btnPrestitiTotali.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrestitiTotali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestitiTotali.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestitiTotali.ForeColor = System.Drawing.Color.White;
            this.btnPrestitiTotali.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPrestitiTotali.IconColor = System.Drawing.Color.White;
            this.btnPrestitiTotali.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrestitiTotali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestitiTotali.Location = new System.Drawing.Point(17, 252);
            this.btnPrestitiTotali.Name = "btnPrestitiTotali";
            this.btnPrestitiTotali.Size = new System.Drawing.Size(193, 68);
            this.btnPrestitiTotali.TabIndex = 10;
            this.btnPrestitiTotali.Text = "Più Richiesti";
            this.btnPrestitiTotali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestitiTotali.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrestitiTotali.UseVisualStyleBackColor = false;
            this.btnPrestitiTotali.Click += new System.EventHandler(this.btnPrestitiTotali_Click);
            // 
            // btnPagine
            // 
            this.btnPagine.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPagine.FlatAppearance.BorderSize = 0;
            this.btnPagine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPagine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagine.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagine.ForeColor = System.Drawing.Color.White;
            this.btnPagine.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPagine.IconColor = System.Drawing.Color.White;
            this.btnPagine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagine.Location = new System.Drawing.Point(17, 178);
            this.btnPagine.Name = "btnPagine";
            this.btnPagine.Size = new System.Drawing.Size(193, 68);
            this.btnPagine.TabIndex = 9;
            this.btnPagine.Text = "Più Lunghi";
            this.btnPagine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagine.UseVisualStyleBackColor = false;
            this.btnPagine.Click += new System.EventHandler(this.btnPagine_Click);
            // 
            // btnVoto
            // 
            this.btnVoto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVoto.FlatAppearance.BorderSize = 0;
            this.btnVoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoto.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoto.ForeColor = System.Drawing.Color.White;
            this.btnVoto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnVoto.IconColor = System.Drawing.Color.White;
            this.btnVoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoto.Location = new System.Drawing.Point(17, 30);
            this.btnVoto.Name = "btnVoto";
            this.btnVoto.Size = new System.Drawing.Size(193, 68);
            this.btnVoto.TabIndex = 8;
            this.btnVoto.Text = "Più Piaciuti";
            this.btnVoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoto.UseVisualStyleBackColor = false;
            this.btnVoto.Click += new System.EventHandler(this.btnVoto_Click);
            // 
            // dgwLibri
            // 
            this.dgwLibri.AllowUserToResizeColumns = false;
            this.dgwLibri.AllowUserToResizeRows = false;
            this.dgwLibri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLibri.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgwLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLibri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTitle,
            this.columnAuthors,
            this.columnCategories,
            this.columnRating,
            this.columnNPage,
            this.columnPrestitiTotali,
            this.columnLetti,
            this.columnQta});
            this.dgwLibri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwLibri.Location = new System.Drawing.Point(179, 3);
            this.dgwLibri.Name = "dgwLibri";
            this.dgwLibri.Size = new System.Drawing.Size(622, 508);
            this.dgwLibri.TabIndex = 1;
            // 
            // columnTitle
            // 
            this.columnTitle.DataPropertyName = "title";
            this.columnTitle.HeaderText = "Titolo";
            this.columnTitle.Name = "columnTitle";
            // 
            // columnAuthors
            // 
            this.columnAuthors.DataPropertyName = "authors";
            this.columnAuthors.HeaderText = "Autori";
            this.columnAuthors.Name = "columnAuthors";
            // 
            // columnCategories
            // 
            this.columnCategories.DataPropertyName = "categories";
            this.columnCategories.HeaderText = "Categorie";
            this.columnCategories.Name = "columnCategories";
            // 
            // columnRating
            // 
            this.columnRating.DataPropertyName = "average_rating";
            this.columnRating.HeaderText = "Voto";
            this.columnRating.Name = "columnRating";
            // 
            // columnNPage
            // 
            this.columnNPage.DataPropertyName = "num_pages";
            this.columnNPage.HeaderText = "Pagine";
            this.columnNPage.Name = "columnNPage";
            // 
            // columnPrestitiTotali
            // 
            this.columnPrestitiTotali.DataPropertyName = "prestiti_totali";
            this.columnPrestitiTotali.HeaderText = "Prestiti Totali";
            this.columnPrestitiTotali.Name = "columnPrestitiTotali";
            // 
            // columnLetti
            // 
            this.columnLetti.DataPropertyName = "ratings_count";
            this.columnLetti.HeaderText = "Letture";
            this.columnLetti.Name = "columnLetti";
            // 
            // columnQta
            // 
            this.columnQta.DataPropertyName = "qta";
            this.columnQta.HeaderText = "Quantità";
            this.columnQta.Name = "columnQta";
            // 
            // tbpUtenti
            // 
            this.tbpUtenti.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbpUtenti.Controls.Add(this.tableLayoutPanel1);
            this.tbpUtenti.Location = new System.Drawing.Point(4, 22);
            this.tbpUtenti.Name = "tbpUtenti";
            this.tbpUtenti.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUtenti.Size = new System.Drawing.Size(810, 520);
            this.tbpUtenti.TabIndex = 0;
            this.tbpUtenti.Text = "Utenti";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel1.Controls.Add(this.dgwUtenti, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 514);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dgwUtenti
            // 
            this.dgwUtenti.AllowUserToResizeColumns = false;
            this.dgwUtenti.AllowUserToResizeRows = false;
            this.dgwUtenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUtenti.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgwUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUtenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnSurname,
            this.columnlibri_richiesti,
            this.columnNLibri,
            this.columnCode});
            this.dgwUtenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUtenti.Location = new System.Drawing.Point(179, 3);
            this.dgwUtenti.Name = "dgwUtenti";
            this.dgwUtenti.Size = new System.Drawing.Size(622, 508);
            this.dgwUtenti.TabIndex = 11;
            // 
            // columnName
            // 
            this.columnName.DataPropertyName = "first_name";
            this.columnName.HeaderText = "Nome";
            this.columnName.Name = "columnName";
            // 
            // columnSurname
            // 
            this.columnSurname.DataPropertyName = "last_name";
            this.columnSurname.HeaderText = "Cognome";
            this.columnSurname.Name = "columnSurname";
            // 
            // columnlibri_richiesti
            // 
            this.columnlibri_richiesti.DataPropertyName = "libri_richiesti";
            this.columnlibri_richiesti.HeaderText = "Libri letti";
            this.columnlibri_richiesti.Name = "columnlibri_richiesti";
            // 
            // columnNLibri
            // 
            this.columnNLibri.DataPropertyName = "libri_prenotati";
            this.columnNLibri.HeaderText = "Libri Prenotati";
            this.columnNLibri.Name = "columnNLibri";
            // 
            // columnCode
            // 
            this.columnCode.DataPropertyName = "code";
            this.columnCode.HeaderText = "Code";
            this.columnCode.Name = "columnCode";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.btnMostReader);
            this.groupBox2.Controls.Add(this.btnActive);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 195);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criteri Utenti";
            // 
            // btnMostReader
            // 
            this.btnMostReader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMostReader.FlatAppearance.BorderSize = 0;
            this.btnMostReader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMostReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostReader.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostReader.ForeColor = System.Drawing.Color.White;
            this.btnMostReader.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnMostReader.IconColor = System.Drawing.Color.White;
            this.btnMostReader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostReader.Location = new System.Drawing.Point(17, 104);
            this.btnMostReader.Name = "btnMostReader";
            this.btnMostReader.Size = new System.Drawing.Size(193, 68);
            this.btnMostReader.TabIndex = 9;
            this.btnMostReader.Text = "Gran Lettori";
            this.btnMostReader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostReader.UseVisualStyleBackColor = false;
            this.btnMostReader.Click += new System.EventHandler(this.btnMostReader_Click);
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnActive.IconColor = System.Drawing.Color.White;
            this.btnActive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActive.Location = new System.Drawing.Point(17, 30);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(193, 68);
            this.btnActive.TabIndex = 8;
            this.btnActive.Text = "Più Attivi";
            this.btnActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1064, 646);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tbc.ResumeLayout(false);
            this.tbpLibri.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibri)).EndInit();
            this.tbpUtenti.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUtenti)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tbpLibri;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnLetti;
        private FontAwesome.Sharp.IconButton btnVotoNegativo;
        private FontAwesome.Sharp.IconButton btnQta;
        private FontAwesome.Sharp.IconButton btnPrestitiTotali;
        private FontAwesome.Sharp.IconButton btnPagine;
        private FontAwesome.Sharp.IconButton btnVoto;
        private System.Windows.Forms.DataGridView dgwLibri;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrestitiTotali;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLetti;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQta;
        private System.Windows.Forms.TabPage tbpUtenti;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgwUtenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnlibri_richiesti;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNLibri;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnMostReader;
        private FontAwesome.Sharp.IconButton btnActive;
        private FontAwesome.Sharp.IconButton btnLibri;
        private FontAwesome.Sharp.IconButton btnUtenti;
        private FontAwesome.Sharp.IconButton btnPdfUser;
        private FontAwesome.Sharp.IconButton btnPdfLibri;
    }
}
