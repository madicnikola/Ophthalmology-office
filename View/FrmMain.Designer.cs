﻿using System.Windows.Forms;

namespace View
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnPacijent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemKreirajPacijenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemPretragaPacijenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemIzmeniPacijenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemObrisiPacijenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLekar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemKreirajLekara = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemPretrega = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemIzmeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemObrisiLekara = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemUnesiNoviPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemPretragePregleda = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemObrisiPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.lblPom = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPacijent,
            this.mnLekar,
            this.mnPregled});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnPacijent
            // 
            this.mnPacijent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemKreirajPacijenta,
            this.mnItemPretragaPacijenta,
            this.mnItemIzmeniPacijenta,
            this.mnItemObrisiPacijenta});
            this.mnPacijent.Name = "mnPacijent";
            this.mnPacijent.Size = new System.Drawing.Size(74, 26);
            this.mnPacijent.Text = "Pacijent";
            // 
            // mnItemKreirajPacijenta
            // 
            this.mnItemKreirajPacijenta.Name = "mnItemKreirajPacijenta";
            this.mnItemKreirajPacijenta.Size = new System.Drawing.Size(224, 26);
            this.mnItemKreirajPacijenta.Text = "Kreiraj";
            this.mnItemKreirajPacijenta.Click += new System.EventHandler(this.AddNewPacijentToolStripMenuItem_Click);
            // 
            // mnItemPretragaPacijenta
            // 
            this.mnItemPretragaPacijenta.Name = "mnItemPretragaPacijenta";
            this.mnItemPretragaPacijenta.Size = new System.Drawing.Size(224, 26);
            this.mnItemPretragaPacijenta.Text = "Pretraga";
            this.mnItemPretragaPacijenta.Click += new System.EventHandler(this.mnItemPretragaPacijenata_Click);
            // 
            // mnItemIzmeniPacijenta
            // 
            this.mnItemIzmeniPacijenta.Name = "mnItemIzmeniPacijenta";
            this.mnItemIzmeniPacijenta.Size = new System.Drawing.Size(224, 26);
            this.mnItemIzmeniPacijenta.Text = "Izmeni";
            this.mnItemIzmeniPacijenta.Click += new System.EventHandler(this.mnItemIzmeniPacijenta_Click);
            // 
            // mnItemObrisiPacijenta
            // 
            this.mnItemObrisiPacijenta.Name = "mnItemObrisiPacijenta";
            this.mnItemObrisiPacijenta.Size = new System.Drawing.Size(224, 26);
            this.mnItemObrisiPacijenta.Text = "Obrisi";
            this.mnItemObrisiPacijenta.Click += new System.EventHandler(this.mnItemObrisiPacijenta_Click);
            // 
            // mnLekar
            // 
            this.mnLekar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemKreirajLekara,
            this.mnItemPretrega,
            this.mnItemIzmeni,
            this.mnItemObrisiLekara});
            this.mnLekar.Name = "mnLekar";
            this.mnLekar.Size = new System.Drawing.Size(58, 26);
            this.mnLekar.Text = "Lekar";
            // 
            // mnItemKreirajLekara
            // 
            this.mnItemKreirajLekara.Name = "mnItemKreirajLekara";
            this.mnItemKreirajLekara.Size = new System.Drawing.Size(148, 26);
            this.mnItemKreirajLekara.Text = "Kreiraj";
            this.mnItemKreirajLekara.Click += new System.EventHandler(this.mnItemKreirajLekara_Click);
            // 
            // mnItemPretrega
            // 
            this.mnItemPretrega.Name = "mnItemPretrega";
            this.mnItemPretrega.Size = new System.Drawing.Size(148, 26);
            this.mnItemPretrega.Text = "Pretraga";
            this.mnItemPretrega.Click += new System.EventHandler(this.mnItemPretregaLekara_Click);
            // 
            // mnItemIzmeni
            // 
            this.mnItemIzmeni.Name = "mnItemIzmeni";
            this.mnItemIzmeni.Size = new System.Drawing.Size(148, 26);
            this.mnItemIzmeni.Text = "Izmeni";
            this.mnItemIzmeni.Click += new System.EventHandler(this.mnItemIzmeniLekara_Click);
            // 
            // mnItemObrisiLekara
            // 
            this.mnItemObrisiLekara.Name = "mnItemObrisiLekara";
            this.mnItemObrisiLekara.Size = new System.Drawing.Size(148, 26);
            this.mnItemObrisiLekara.Text = "Obrisi";
            this.mnItemObrisiLekara.Click += new System.EventHandler(this.mnItemObrisiLekara_Click);
            // 
            // mnPregled
            // 
            this.mnPregled.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemUnesiNoviPregled,
            this.mnItemPretragePregleda,
            this.izmeniToolStripMenuItem,
            this.mnItemObrisiPregled});
            this.mnPregled.Name = "mnPregled";
            this.mnPregled.Size = new System.Drawing.Size(74, 26);
            this.mnPregled.Text = "Pregled";
            // 
            // mnItemUnesiNoviPregled
            // 
            this.mnItemUnesiNoviPregled.Name = "mnItemUnesiNoviPregled";
            this.mnItemUnesiNoviPregled.Size = new System.Drawing.Size(224, 26);
            this.mnItemUnesiNoviPregled.Text = "Unesi novi";
            this.mnItemUnesiNoviPregled.Click += new System.EventHandler(this.mnItemUnesiNoviPregled_Click);
            // 
            // mnItemPretragePregleda
            // 
            this.mnItemPretragePregleda.Name = "mnItemPretragePregleda";
            this.mnItemPretragePregleda.Size = new System.Drawing.Size(224, 26);
            this.mnItemPretragePregleda.Text = "Pretraga";
            this.mnItemPretragePregleda.Click += new System.EventHandler(this.mnItemPretragePregleda_Click);
            // 
            // izmeniToolStripMenuItem
            // 
            this.izmeniToolStripMenuItem.Name = "izmeniToolStripMenuItem";
            this.izmeniToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmeniToolStripMenuItem.Text = "Izmeni";
            this.izmeniToolStripMenuItem.Click += new System.EventHandler(this.izmeniToolStripMenuItem_Click);
            // 
            // mnItemObrisiPregled
            // 
            this.mnItemObrisiPregled.Name = "mnItemObrisiPregled";
            this.mnItemObrisiPregled.Size = new System.Drawing.Size(224, 26);
            this.mnItemObrisiPregled.Text = "Obrisi";
            this.mnItemObrisiPregled.Click += new System.EventHandler(this.mnItemObrisiPregled_Click);
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.lblKorisnik);
            this.pnlMainContainer.Controls.Add(this.lblPom);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 30);
            this.pnlMainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1067, 619);
            this.pnlMainContainer.TabIndex = 1;
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnik.Location = new System.Drawing.Point(151, 17);
            this.lblKorisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(0, 29);
            this.lblKorisnik.TabIndex = 1;
            // 
            // lblPom
            // 
            this.lblPom.AutoSize = true;
            this.lblPom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPom.Location = new System.Drawing.Point(4, 17);
            this.lblPom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPom.Name = "lblPom";
            this.lblPom.Size = new System.Drawing.Size(122, 29);
            this.lblPom.TabIndex = 0;
            this.lblPom.Text = "Korisnik: ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 649);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavna Forma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlMainContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnPacijent;
        private System.Windows.Forms.ToolStripMenuItem mnItemKreirajPacijenta;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.ToolStripMenuItem mnLekar;
        private System.Windows.Forms.ToolStripMenuItem mnItemKreirajLekara;
        private System.Windows.Forms.ToolStripMenuItem mnPregled;
        private System.Windows.Forms.ToolStripMenuItem mnItemUnesiNoviPregled;
        private System.Windows.Forms.ToolStripMenuItem mnItemPretragaPacijenta;
        private System.Windows.Forms.Label lblPom;
        private System.Windows.Forms.ToolStripMenuItem mnItemIzmeniPacijenta;
		private System.Windows.Forms.ToolStripMenuItem mnItemObrisiPacijenta;
		private System.Windows.Forms.ToolStripMenuItem mnItemObrisiLekara;
		private System.Windows.Forms.ToolStripMenuItem mnItemPretragePregleda;
		private System.Windows.Forms.ToolStripMenuItem mnItemObrisiPregled;
		private System.Windows.Forms.Label lblKorisnik;
		private ToolStripMenuItem mnItemPretrega;
		private ToolStripMenuItem mnItemIzmeni;
		private ToolStripMenuItem izmeniToolStripMenuItem;

		public MenuStrip MenuStrip1 { get => menuStrip1; set => menuStrip1 = value; }
		public ToolStripMenuItem MnPacijent { get => mnPacijent; set => mnPacijent = value; }
		public ToolStripMenuItem MnItemKreirajPacijenta { get => mnItemKreirajPacijenta; set => mnItemKreirajPacijenta = value; }
		public Panel PnlMainContainer { get => pnlMainContainer; set => pnlMainContainer = value; }
		public ToolStripMenuItem MnLekar { get => mnLekar; set => mnLekar = value; }
		public ToolStripMenuItem MnItemKreirajLekara { get => mnItemKreirajLekara; set => mnItemKreirajLekara = value; }
		public ToolStripMenuItem MnPregled { get => mnPregled; set => mnPregled = value; }
		public ToolStripMenuItem MnItemUnesiNoviPregled { get => mnItemUnesiNoviPregled; set => mnItemUnesiNoviPregled = value; }
		public ToolStripMenuItem MnItemPretragaPacijenta { get => mnItemPretragaPacijenta; set => mnItemPretragaPacijenta = value; }
		public Label LblPom { get => lblPom; set => lblPom = value; }
		public ToolStripMenuItem MnItemIzmeniPacijenta { get => mnItemIzmeniPacijenta; set => mnItemIzmeniPacijenta = value; }
		public ToolStripMenuItem MnItemObrisiPacijenta { get => mnItemObrisiPacijenta; set => mnItemObrisiPacijenta = value; }
		public ToolStripMenuItem MnItemObrisiLekara { get => mnItemObrisiLekara; set => mnItemObrisiLekara = value; }
		public ToolStripMenuItem MnItemPretragePregleda { get => mnItemPretragePregleda; set => mnItemPretragePregleda = value; }
		public ToolStripMenuItem MnItemObrisiPregled { get => mnItemObrisiPregled; set => mnItemObrisiPregled = value; }
		public Label LblKorisnik { get => lblKorisnik; set => lblKorisnik = value; }
	}
}