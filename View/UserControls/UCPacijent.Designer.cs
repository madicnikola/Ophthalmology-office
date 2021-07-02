using System.Windows.Forms;

namespace View.UserControls
{
	partial class UCPacijent: UserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblBrojKartonaId = new System.Windows.Forms.Label();
			this.lblIme = new System.Windows.Forms.Label();
			this.lblPrezime = new System.Windows.Forms.Label();
			this.lblDatum = new System.Windows.Forms.Label();
			this.lblTelefon = new System.Windows.Forms.Label();
			this.lblOboljenja = new System.Windows.Forms.Label();
			this.lblDioptrija = new System.Windows.Forms.Label();
			this.lblOpis = new System.Windows.Forms.Label();
			this.txtBrojKartonaId = new System.Windows.Forms.TextBox();
			this.txtIme = new System.Windows.Forms.TextBox();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.txtTelefon = new System.Windows.Forms.TextBox();
			this.cbDioptrija = new System.Windows.Forms.CheckBox();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.txtROboljenja = new System.Windows.Forms.RichTextBox();
			this.txtROpis = new System.Windows.Forms.RichTextBox();
			this.btnSacuvaj = new System.Windows.Forms.Button();
			this.btnOmoguciIzmenu = new System.Windows.Forms.Button();
			this.btnSacuvajPromene = new System.Windows.Forms.Button();
			this.btnNazad = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnKartonPacijenta = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblBrojKartonaId
			// 
			this.lblBrojKartonaId.AutoSize = true;
			this.lblBrojKartonaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBrojKartonaId.Location = new System.Drawing.Point(296, 34);
			this.lblBrojKartonaId.Name = "lblBrojKartonaId";
			this.lblBrojKartonaId.Size = new System.Drawing.Size(121, 25);
			this.lblBrojKartonaId.TabIndex = 0;
			this.lblBrojKartonaId.Text = "BrojKartona:";
			// 
			// lblIme
			// 
			this.lblIme.AutoSize = true;
			this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIme.Location = new System.Drawing.Point(367, 107);
			this.lblIme.Name = "lblIme";
			this.lblIme.Size = new System.Drawing.Size(50, 25);
			this.lblIme.TabIndex = 1;
			this.lblIme.Text = "Ime:";
			// 
			// lblPrezime
			// 
			this.lblPrezime.AutoSize = true;
			this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrezime.Location = new System.Drawing.Point(328, 143);
			this.lblPrezime.Name = "lblPrezime";
			this.lblPrezime.Size = new System.Drawing.Size(89, 25);
			this.lblPrezime.TabIndex = 2;
			this.lblPrezime.Text = "Prezime:";
			// 
			// lblDatum
			// 
			this.lblDatum.AutoSize = true;
			this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatum.Location = new System.Drawing.Point(259, 199);
			this.lblDatum.Name = "lblDatum";
			this.lblDatum.Size = new System.Drawing.Size(149, 25);
			this.lblDatum.TabIndex = 3;
			this.lblDatum.Text = "Datum rodjenja:";
			// 
			// lblTelefon
			// 
			this.lblTelefon.AutoSize = true;
			this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefon.Location = new System.Drawing.Point(333, 234);
			this.lblTelefon.Name = "lblTelefon";
			this.lblTelefon.Size = new System.Drawing.Size(84, 25);
			this.lblTelefon.TabIndex = 4;
			this.lblTelefon.Text = "Telefon:";
			// 
			// lblOboljenja
			// 
			this.lblOboljenja.AutoSize = true;
			this.lblOboljenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOboljenja.Location = new System.Drawing.Point(316, 282);
			this.lblOboljenja.Name = "lblOboljenja";
			this.lblOboljenja.Size = new System.Drawing.Size(101, 25);
			this.lblOboljenja.TabIndex = 5;
			this.lblOboljenja.Text = "Oboljenja:";
			// 
			// lblDioptrija
			// 
			this.lblDioptrija.AutoSize = true;
			this.lblDioptrija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDioptrija.Location = new System.Drawing.Point(329, 486);
			this.lblDioptrija.Name = "lblDioptrija";
			this.lblDioptrija.Size = new System.Drawing.Size(88, 25);
			this.lblDioptrija.TabIndex = 6;
			this.lblDioptrija.Text = "Dioptrija:";
			// 
			// lblOpis
			// 
			this.lblOpis.AutoSize = true;
			this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOpis.Location = new System.Drawing.Point(339, 386);
			this.lblOpis.Name = "lblOpis";
			this.lblOpis.Size = new System.Drawing.Size(78, 25);
			this.lblOpis.TabIndex = 7;
			this.lblOpis.Text = "lblOpis:";
			// 
			// txtBrojKartonaId
			// 
			this.txtBrojKartonaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBrojKartonaId.Location = new System.Drawing.Point(423, 32);
			this.txtBrojKartonaId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBrojKartonaId.Name = "txtBrojKartonaId";
			this.txtBrojKartonaId.Size = new System.Drawing.Size(100, 30);
			this.txtBrojKartonaId.TabIndex = 8;
			// 
			// txtIme
			// 
			this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIme.Location = new System.Drawing.Point(423, 102);
			this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(400, 30);
			this.txtIme.TabIndex = 10;
			// 
			// txtPrezime
			// 
			this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrezime.Location = new System.Drawing.Point(423, 138);
			this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(400, 30);
			this.txtPrezime.TabIndex = 11;
			// 
			// txtTelefon
			// 
			this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefon.Location = new System.Drawing.Point(423, 229);
			this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(400, 30);
			this.txtTelefon.TabIndex = 13;
			// 
			// cbDioptrija
			// 
			this.cbDioptrija.AutoSize = true;
			this.cbDioptrija.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbDioptrija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDioptrija.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.cbDioptrija.Location = new System.Drawing.Point(805, 494);
			this.cbDioptrija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbDioptrija.Name = "cbDioptrija";
			this.cbDioptrija.Size = new System.Drawing.Size(18, 17);
			this.cbDioptrija.TabIndex = 17;
			this.cbDioptrija.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
			this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(423, 193);
			this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePicker.MaxDate = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(400, 30);
			this.dateTimePicker.TabIndex = 18;
			this.dateTimePicker.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			// 
			// txtROboljenja
			// 
			this.txtROboljenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtROboljenja.Location = new System.Drawing.Point(423, 286);
			this.txtROboljenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtROboljenja.Name = "txtROboljenja";
			this.txtROboljenja.Size = new System.Drawing.Size(400, 96);
			this.txtROboljenja.TabIndex = 20;
			this.txtROboljenja.Text = "";
			// 
			// txtROpis
			// 
			this.txtROpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtROpis.Location = new System.Drawing.Point(423, 386);
			this.txtROpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtROpis.Name = "txtROpis";
			this.txtROpis.Size = new System.Drawing.Size(400, 96);
			this.txtROpis.TabIndex = 21;
			this.txtROpis.Text = "";
			// 
			// btnSacuvaj
			// 
			this.btnSacuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSacuvaj.Location = new System.Drawing.Point(609, 2);
			this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSacuvaj.Name = "btnSacuvaj";
			this.btnSacuvaj.Size = new System.Drawing.Size(115, 34);
			this.btnSacuvaj.TabIndex = 22;
			this.btnSacuvaj.Text = "Sacuvaj";
			this.btnSacuvaj.UseVisualStyleBackColor = true;
			this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
			// 
			// btnOmoguciIzmenu
			// 
			this.btnOmoguciIzmenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOmoguciIzmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOmoguciIzmenu.Location = new System.Drawing.Point(456, 2);
			this.btnOmoguciIzmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOmoguciIzmenu.Name = "btnOmoguciIzmenu";
			this.btnOmoguciIzmenu.Size = new System.Drawing.Size(147, 34);
			this.btnOmoguciIzmenu.TabIndex = 23;
			this.btnOmoguciIzmenu.Text = "Omoguci izmenu";
			this.btnOmoguciIzmenu.UseVisualStyleBackColor = true;
			this.btnOmoguciIzmenu.Click += new System.EventHandler(this.btnOmoguciIzmenu_Click);
			// 
			// btnSacuvajPromene
			// 
			this.btnSacuvajPromene.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSacuvajPromene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSacuvajPromene.Location = new System.Drawing.Point(293, 2);
			this.btnSacuvajPromene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSacuvajPromene.Name = "btnSacuvajPromene";
			this.btnSacuvajPromene.Size = new System.Drawing.Size(157, 34);
			this.btnSacuvajPromene.TabIndex = 24;
			this.btnSacuvajPromene.Text = "Sacuvaj promene";
			this.btnSacuvajPromene.UseVisualStyleBackColor = true;
			this.btnSacuvajPromene.Click += new System.EventHandler(this.btnSacuvajPromene_Click);
			// 
			// btnNazad
			// 
			this.btnNazad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNazad.Location = new System.Drawing.Point(3, 2);
			this.btnNazad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNazad.Name = "btnNazad";
			this.btnNazad.Size = new System.Drawing.Size(115, 34);
			this.btnNazad.TabIndex = 26;
			this.btnNazad.Text = "Nazad";
			this.btnNazad.UseVisualStyleBackColor = true;
			this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.btnSacuvaj);
			this.flowLayoutPanel1.Controls.Add(this.btnOmoguciIzmenu);
			this.flowLayoutPanel1.Controls.Add(this.btnSacuvajPromene);
			this.flowLayoutPanel1.Controls.Add(this.btnKartonPacijenta);
			this.flowLayoutPanel1.Controls.Add(this.btnNazad);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(96, 532);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(727, 47);
			this.flowLayoutPanel1.TabIndex = 27;
			// 
			// btnKartonPacijenta
			// 
			this.btnKartonPacijenta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKartonPacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKartonPacijenta.Location = new System.Drawing.Point(124, 2);
			this.btnKartonPacijenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKartonPacijenta.Name = "btnKartonPacijenta";
			this.btnKartonPacijenta.Size = new System.Drawing.Size(163, 34);
			this.btnKartonPacijenta.TabIndex = 28;
			this.btnKartonPacijenta.Text = "Karton Pacijenta";
			this.btnKartonPacijenta.UseVisualStyleBackColor = true;
			this.btnKartonPacijenta.Click += new System.EventHandler(this.button2_Click);
			// 
			// UCPacijent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.txtROpis);
			this.Controls.Add(this.txtROboljenja);
			this.Controls.Add(this.cbDioptrija);
			this.Controls.Add(this.txtTelefon);
			this.Controls.Add(this.txtPrezime);
			this.Controls.Add(this.txtIme);
			this.Controls.Add(this.txtBrojKartonaId);
			this.Controls.Add(this.lblOpis);
			this.Controls.Add(this.lblDioptrija);
			this.Controls.Add(this.lblOboljenja);
			this.Controls.Add(this.lblTelefon);
			this.Controls.Add(this.lblDatum);
			this.Controls.Add(this.lblPrezime);
			this.Controls.Add(this.lblIme);
			this.Controls.Add(this.lblBrojKartonaId);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "UCPacijent";
			this.Size = new System.Drawing.Size(1067, 622);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblBrojKartonaId;
		private Label lblIme;
		private Label lblPrezime;
		private Label lblDatum;
		private Label lblTelefon;
		private Label lblOboljenja;
		private Label lblDioptrija;
		private Label lblOpis;
		private TextBox txtBrojKartonaId;
		private TextBox txtIme;
		private TextBox txtPrezime;
		private TextBox txtTelefon;
		private CheckBox cbDioptrija;
		private DateTimePicker dateTimePicker;
		private RichTextBox txtROboljenja;
		private RichTextBox txtROpis;
		private Button btnSacuvaj;
		private Button btnOmoguciIzmenu;
		private Button btnSacuvajPromene;
		private Button btnNazad;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button btnKartonPacijenta;

		public Label LblBrojKartonaId { get => lblBrojKartonaId; set => lblBrojKartonaId = value; }
		public Label LblIme { get => lblIme; set => lblIme = value; }
		public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
		public Label LblDatum { get => lblDatum; set => lblDatum = value; }
		public Label LblTelefon { get => lblTelefon; set => lblTelefon = value; }
		public Label LblOboljenja { get => lblOboljenja; set => lblOboljenja = value; }
		public Label LblDioptrija { get => lblDioptrija; set => lblDioptrija = value; }
		public Label LblOpis { get => lblOpis; set => lblOpis = value; }
		public TextBox TxtBrojKartonaId { get => txtBrojKartonaId; set => txtBrojKartonaId = value; }
		public TextBox TxtIme { get => txtIme; set => txtIme = value; }
		public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
		public TextBox TxtTelefon { get => txtTelefon; set => txtTelefon = value; }
		public CheckBox CbDioptrija { get => cbDioptrija; set => cbDioptrija = value; }
		public DateTimePicker DateTimePicker { get => dateTimePicker; set => dateTimePicker = value; }
		public RichTextBox TxtROboljenja { get => txtROboljenja; set => txtROboljenja = value; }
		public RichTextBox TxtROpis { get => txtROpis; set => txtROpis = value; }
		public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
		public Button BtnOmoguciIzmenu { get => btnOmoguciIzmenu; set => btnOmoguciIzmenu = value; }
		public Button BtnSacuvajPromene { get => btnSacuvajPromene; set => btnSacuvajPromene = value; }
		public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public Button BtnKartonPacijenta { get => btnKartonPacijenta; set => btnKartonPacijenta = value; }
    }
}
