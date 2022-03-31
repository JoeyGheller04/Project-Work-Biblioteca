namespace Joey_Gheller_4CII__Project_Work_Gestione_Libreria
{
    partial class ViewBook
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
            this.components = new System.ComponentModel.Container();
            this.txbRating = new System.Windows.Forms.TextBox();
            this.txbCategories = new System.Windows.Forms.TextBox();
            this.txbAutori = new System.Windows.Forms.TextBox();
            this.txbTitolo = new System.Windows.Forms.TextBox();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.txbDescrizione = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.SuspendLayout();
            // 
            // txbRating
            // 
            this.txbRating.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRating.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRating.Location = new System.Drawing.Point(19, 285);
            this.txbRating.Name = "txbRating";
            this.txbRating.ReadOnly = true;
            this.txbRating.Size = new System.Drawing.Size(290, 31);
            this.txbRating.TabIndex = 16;
            // 
            // txbCategories
            // 
            this.txbCategories.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCategories.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategories.Location = new System.Drawing.Point(19, 249);
            this.txbCategories.Name = "txbCategories";
            this.txbCategories.ReadOnly = true;
            this.txbCategories.Size = new System.Drawing.Size(290, 31);
            this.txbCategories.TabIndex = 15;
            // 
            // txbAutori
            // 
            this.txbAutori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAutori.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAutori.Location = new System.Drawing.Point(19, 212);
            this.txbAutori.Name = "txbAutori";
            this.txbAutori.ReadOnly = true;
            this.txbAutori.Size = new System.Drawing.Size(290, 31);
            this.txbAutori.TabIndex = 14;
            // 
            // txbTitolo
            // 
            this.txbTitolo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTitolo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitolo.Location = new System.Drawing.Point(19, 172);
            this.txbTitolo.Name = "txbTitolo";
            this.txbTitolo.ReadOnly = true;
            this.txbTitolo.Size = new System.Drawing.Size(290, 31);
            this.txbTitolo.TabIndex = 13;
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
            this.btnLogout.Location = new System.Drawing.Point(239, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 77);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // picBook
            // 
            this.picBook.Location = new System.Drawing.Point(19, 10);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(139, 145);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBook.TabIndex = 21;
            this.picBook.TabStop = false;
            // 
            // txbDescrizione
            // 
            this.txbDescrizione.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescrizione.Location = new System.Drawing.Point(19, 324);
            this.txbDescrizione.Name = "txbDescrizione";
            this.txbDescrizione.ReadOnly = true;
            this.txbDescrizione.Size = new System.Drawing.Size(290, 177);
            this.txbDescrizione.TabIndex = 22;
            this.txbDescrizione.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbDescrizione);
            this.Controls.Add(this.picBook);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txbRating);
            this.Controls.Add(this.txbCategories);
            this.Controls.Add(this.txbAutori);
            this.Controls.Add(this.txbTitolo);
            this.Name = "ViewBook";
            this.Size = new System.Drawing.Size(334, 527);
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbRating;
        private System.Windows.Forms.TextBox txbCategories;
        private System.Windows.Forms.TextBox txbAutori;
        private System.Windows.Forms.TextBox txbTitolo;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.RichTextBox txbDescrizione;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
