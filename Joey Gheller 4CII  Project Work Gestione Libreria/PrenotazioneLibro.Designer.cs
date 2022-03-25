
namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    partial class PrenotazioneLibro
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
            this.btnAddPrenotation = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindBook = new FontAwesome.Sharp.IconButton();
            this.btnFindUser = new FontAwesome.Sharp.IconButton();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTitolo = new System.Windows.Forms.TextBox();
            this.txbIsbn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbDa = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPrenotation
            // 
            this.btnAddPrenotation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddPrenotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPrenotation.FlatAppearance.BorderSize = 0;
            this.btnAddPrenotation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddPrenotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPrenotation.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrenotation.ForeColor = System.Drawing.Color.White;
            this.btnAddPrenotation.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddPrenotation.IconColor = System.Drawing.Color.White;
            this.btnAddPrenotation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPrenotation.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAddPrenotation.Location = new System.Drawing.Point(628, 444);
            this.btnAddPrenotation.Name = "btnAddPrenotation";
            this.btnAddPrenotation.Size = new System.Drawing.Size(312, 57);
            this.btnAddPrenotation.TabIndex = 17;
            this.btnAddPrenotation.Text = "Aggiungi Prenotazione";
            this.btnAddPrenotation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPrenotation.UseVisualStyleBackColor = false;
            this.btnAddPrenotation.Click += new System.EventHandler(this.btnAddPrenotation_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.panel1.Location = new System.Drawing.Point(56, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 57);
            this.panel1.TabIndex = 10;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(81, 14);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(169, 31);
            this.cmbUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utente";
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
            this.btnLogout.Location = new System.Drawing.Point(953, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 77);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindBook);
            this.groupBox1.Controls.Add(this.btnFindUser);
            this.groupBox1.Controls.Add(this.txbSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(628, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 246);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ricerca";
            // 
            // btnFindBook
            // 
            this.btnFindBook.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFindBook.FlatAppearance.BorderSize = 0;
            this.btnFindBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindBook.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindBook.ForeColor = System.Drawing.Color.White;
            this.btnFindBook.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindBook.IconColor = System.Drawing.Color.White;
            this.btnFindBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindBook.Location = new System.Drawing.Point(17, 169);
            this.btnFindBook.Name = "btnFindBook";
            this.btnFindBook.Size = new System.Drawing.Size(278, 68);
            this.btnFindBook.TabIndex = 9;
            this.btnFindBook.Text = "Trova Libro";
            this.btnFindBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindBook.UseVisualStyleBackColor = false;
            // 
            // btnFindUser
            // 
            this.btnFindUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFindUser.FlatAppearance.BorderSize = 0;
            this.btnFindUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUser.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.ForeColor = System.Drawing.Color.White;
            this.btnFindUser.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindUser.IconColor = System.Drawing.Color.White;
            this.btnFindUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.Location = new System.Drawing.Point(17, 95);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(278, 68);
            this.btnFindUser.TabIndex = 8;
            this.btnFindUser.Text = "Trova Utente";
            this.btnFindUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindUser.UseVisualStyleBackColor = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearch.Location = new System.Drawing.Point(17, 49);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(278, 31);
            this.txbSearch.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label12);
            this.panel12.Controls.Add(this.cmbBook);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(342, 129);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(280, 57);
            this.panel12.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(3, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Libro";
            // 
            // cmbBook
            // 
            this.cmbBook.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(68, 14);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(182, 31);
            this.cmbBook.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbTitolo);
            this.groupBox2.Controls.Add(this.txbIsbn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(342, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 246);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Isbn";
            // 
            // txbTitolo
            // 
            this.txbTitolo.Location = new System.Drawing.Point(84, 92);
            this.txbTitolo.Name = "txbTitolo";
            this.txbTitolo.ReadOnly = true;
            this.txbTitolo.Size = new System.Drawing.Size(166, 31);
            this.txbTitolo.TabIndex = 5;
            // 
            // txbIsbn
            // 
            this.txbIsbn.Location = new System.Drawing.Point(84, 138);
            this.txbIsbn.Name = "txbIsbn";
            this.txbIsbn.ReadOnly = true;
            this.txbIsbn.Size = new System.Drawing.Size(166, 31);
            this.txbIsbn.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Titolo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txbCode);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txbNome);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(56, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 246);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Utente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Code";
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(81, 138);
            this.txbCode.Name = "txbCode";
            this.txbCode.ReadOnly = true;
            this.txbCode.Size = new System.Drawing.Size(166, 31);
            this.txbCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(81, 92);
            this.txbNome.Name = "txbNome";
            this.txbNome.ReadOnly = true;
            this.txbNome.Size = new System.Drawing.Size(166, 31);
            this.txbNome.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbDa);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.panel2.Location = new System.Drawing.Point(56, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 57);
            this.panel2.TabIndex = 20;
            // 
            // txbDa
            // 
            this.txbDa.Location = new System.Drawing.Point(80, 11);
            this.txbDa.Name = "txbDa";
            this.txbDa.Size = new System.Drawing.Size(200, 31);
            this.txbDa.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(39, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Da";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbA);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.panel3.Location = new System.Drawing.Point(342, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 57);
            this.panel3.TabIndex = 21;
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(84, 11);
            this.txbA.Name = "txbA";
            this.txbA.ReadOnly = true;
            this.txbA.Size = new System.Drawing.Size(166, 31);
            this.txbA.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(51, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "A";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.050505F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.30303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLogout, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddPrenotation, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 632);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PrenotazioneLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PrenotazioneLibro";
            this.Size = new System.Drawing.Size(1051, 632);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddPrenotation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnFindBook;
        private FontAwesome.Sharp.IconButton btnFindUser;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTitolo;
        private System.Windows.Forms.TextBox txbIsbn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker txbDa;
        private System.Windows.Forms.TextBox txbA;
    }
}
