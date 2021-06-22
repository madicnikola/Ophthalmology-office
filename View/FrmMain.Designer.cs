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
			this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unesiMestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manufacturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dGVManufacturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.obrisiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.obrisiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.unosToolStripMenuItem,
            this.productToolStripMenuItem,
            this.userToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// unosToolStripMenuItem
			// 
			this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiMestoToolStripMenuItem,
            this.manufacturersToolStripMenuItem,
            this.dGVManufacturersToolStripMenuItem,
            this.obrisiToolStripMenuItem1});
			this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
			this.unosToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
			this.unosToolStripMenuItem.Text = "Pacijent";
			// 
			// unesiMestoToolStripMenuItem
			// 
			this.unesiMestoToolStripMenuItem.Name = "unesiMestoToolStripMenuItem";
			this.unesiMestoToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
			this.unesiMestoToolStripMenuItem.Text = "Kreiraj";
			this.unesiMestoToolStripMenuItem.Click += new System.EventHandler(this.AddNewmanufacturerToolStripMenuItem_Click);
			// 
			// manufacturersToolStripMenuItem
			// 
			this.manufacturersToolStripMenuItem.Name = "manufacturersToolStripMenuItem";
			this.manufacturersToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
			this.manufacturersToolStripMenuItem.Text = "Pretraga";
			this.manufacturersToolStripMenuItem.Click += new System.EventHandler(this.manufacturersToolStripMenuItem_Click);
			// 
			// dGVManufacturersToolStripMenuItem
			// 
			this.dGVManufacturersToolStripMenuItem.Name = "dGVManufacturersToolStripMenuItem";
			this.dGVManufacturersToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
			this.dGVManufacturersToolStripMenuItem.Text = "Izmeni";
			this.dGVManufacturersToolStripMenuItem.Click += new System.EventHandler(this.dGVManufacturersToolStripMenuItem_Click);
			// 
			// obrisiToolStripMenuItem1
			// 
			this.obrisiToolStripMenuItem1.Name = "obrisiToolStripMenuItem1";
			this.obrisiToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
			this.obrisiToolStripMenuItem1.Text = "Obrisi";
			// 
			// productToolStripMenuItem
			// 
			this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.obrisiToolStripMenuItem});
			this.productToolStripMenuItem.Name = "productToolStripMenuItem";
			this.productToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
			this.productToolStripMenuItem.Text = "Lekar";
			// 
			// addNewProductToolStripMenuItem
			// 
			this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
			this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
			this.addNewProductToolStripMenuItem.Text = "Kreiraj";
			this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
			// 
			// obrisiToolStripMenuItem
			// 
			this.obrisiToolStripMenuItem.Name = "obrisiToolStripMenuItem";
			this.obrisiToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
			this.obrisiToolStripMenuItem.Text = "Obrisi";
			// 
			// userToolStripMenuItem
			// 
			this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem,
            this.pretragaToolStripMenuItem,
            this.obrisiToolStripMenuItem2});
			this.userToolStripMenuItem.Name = "userToolStripMenuItem";
			this.userToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
			this.userToolStripMenuItem.Text = "Pregled";
			// 
			// editProfileToolStripMenuItem
			// 
			this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
			this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
			this.editProfileToolStripMenuItem.Text = "Unesi novi";
			// 
			// pretragaToolStripMenuItem
			// 
			this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
			this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
			this.pretragaToolStripMenuItem.Text = "Pretraga";
			// 
			// obrisiToolStripMenuItem2
			// 
			this.obrisiToolStripMenuItem2.Name = "obrisiToolStripMenuItem2";
			this.obrisiToolStripMenuItem2.Size = new System.Drawing.Size(152, 26);
			this.obrisiToolStripMenuItem2.Text = "Obrisi";
			// 
			// pnlMainContainer
			// 
			this.pnlMainContainer.Controls.Add(this.lblKorisnik);
			this.pnlMainContainer.Controls.Add(this.lblPom);
			this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMainContainer.Location = new System.Drawing.Point(0, 28);
			this.pnlMainContainer.Margin = new System.Windows.Forms.Padding(4);
			this.pnlMainContainer.Name = "pnlMainContainer";
			this.pnlMainContainer.Size = new System.Drawing.Size(1067, 621);
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
			this.Text = "FrmGlavna";
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
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unesiMestoToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturersToolStripMenuItem;
        private System.Windows.Forms.Label lblPom;
        private System.Windows.Forms.ToolStripMenuItem dGVManufacturersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem2;
		public System.Windows.Forms.Label lblKorisnik;


	}
}