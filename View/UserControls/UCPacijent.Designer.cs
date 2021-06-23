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
			this.btnObrisi = new System.Windows.Forms.Button();
			this.btnNazad = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblBrojKartonaId
			// 
			this.lblBrojKartonaId.AutoSize = true;
			this.lblBrojKartonaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBrojKartonaId.Location = new System.Drawing.Point(222, 28);
			this.lblBrojKartonaId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblBrojKartonaId.Name = "lblBrojKartonaId";
			this.lblBrojKartonaId.Size = new System.Drawing.Size(97, 20);
			this.lblBrojKartonaId.TabIndex = 0;
			this.lblBrojKartonaId.Text = "BrojKartona:";
			// 
			// lblIme
			// 
			this.lblIme.AutoSize = true;
			this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIme.Location = new System.Drawing.Point(275, 87);
			this.lblIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblIme.Name = "lblIme";
			this.lblIme.Size = new System.Drawing.Size(40, 20);
			this.lblIme.TabIndex = 1;
			this.lblIme.Text = "Ime:";
			// 
			// lblPrezime
			// 
			this.lblPrezime.AutoSize = true;
			this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrezime.Location = new System.Drawing.Point(246, 116);
			this.lblPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPrezime.Name = "lblPrezime";
			this.lblPrezime.Size = new System.Drawing.Size(70, 20);
			this.lblPrezime.TabIndex = 2;
			this.lblPrezime.Text = "Prezime:";
			// 
			// lblDatum
			// 
			this.lblDatum.AutoSize = true;
			this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatum.Location = new System.Drawing.Point(194, 162);
			this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDatum.Name = "lblDatum";
			this.lblDatum.Size = new System.Drawing.Size(121, 20);
			this.lblDatum.TabIndex = 3;
			this.lblDatum.Text = "Datum rodjenja:";
			// 
			// lblTelefon
			// 
			this.lblTelefon.AutoSize = true;
			this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefon.Location = new System.Drawing.Point(250, 190);
			this.lblTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTelefon.Name = "lblTelefon";
			this.lblTelefon.Size = new System.Drawing.Size(66, 20);
			this.lblTelefon.TabIndex = 4;
			this.lblTelefon.Text = "Telefon:";
			// 
			// lblOboljenja
			// 
			this.lblOboljenja.AutoSize = true;
			this.lblOboljenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOboljenja.Location = new System.Drawing.Point(237, 229);
			this.lblOboljenja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblOboljenja.Name = "lblOboljenja";
			this.lblOboljenja.Size = new System.Drawing.Size(79, 20);
			this.lblOboljenja.TabIndex = 5;
			this.lblOboljenja.Text = "Oboljenja:";
			// 
			// lblDioptrija
			// 
			this.lblDioptrija.AutoSize = true;
			this.lblDioptrija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDioptrija.Location = new System.Drawing.Point(247, 395);
			this.lblDioptrija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDioptrija.Name = "lblDioptrija";
			this.lblDioptrija.Size = new System.Drawing.Size(71, 20);
			this.lblDioptrija.TabIndex = 6;
			this.lblDioptrija.Text = "Dioptrija:";
			// 
			// lblOpis
			// 
			this.lblOpis.AutoSize = true;
			this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOpis.Location = new System.Drawing.Point(254, 314);
			this.lblOpis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblOpis.Name = "lblOpis";
			this.lblOpis.Size = new System.Drawing.Size(60, 20);
			this.lblOpis.TabIndex = 7;
			this.lblOpis.Text = "lblOpis:";
			// 
			// txtBrojKartonaId
			// 
			this.txtBrojKartonaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBrojKartonaId.Location = new System.Drawing.Point(317, 26);
			this.txtBrojKartonaId.Margin = new System.Windows.Forms.Padding(2);
			this.txtBrojKartonaId.Name = "txtBrojKartonaId";
			this.txtBrojKartonaId.Size = new System.Drawing.Size(76, 26);
			this.txtBrojKartonaId.TabIndex = 8;
			// 
			// txtIme
			// 
			this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIme.Location = new System.Drawing.Point(317, 83);
			this.txtIme.Margin = new System.Windows.Forms.Padding(2);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(301, 26);
			this.txtIme.TabIndex = 10;
			// 
			// txtPrezime
			// 
			this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrezime.Location = new System.Drawing.Point(317, 112);
			this.txtPrezime.Margin = new System.Windows.Forms.Padding(2);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(301, 26);
			this.txtPrezime.TabIndex = 11;
			// 
			// txtTelefon
			// 
			this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefon.Location = new System.Drawing.Point(317, 186);
			this.txtTelefon.Margin = new System.Windows.Forms.Padding(2);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(301, 26);
			this.txtTelefon.TabIndex = 13;
			// 
			// cbDioptrija
			// 
			this.cbDioptrija.AutoSize = true;
			this.cbDioptrija.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbDioptrija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDioptrija.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.cbDioptrija.Location = new System.Drawing.Point(604, 401);
			this.cbDioptrija.Margin = new System.Windows.Forms.Padding(2);
			this.cbDioptrija.Name = "cbDioptrija";
			this.cbDioptrija.Size = new System.Drawing.Size(15, 14);
			this.cbDioptrija.TabIndex = 17;
			this.cbDioptrija.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
			this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(317, 157);
			this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePicker.MaxDate = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(301, 26);
			this.dateTimePicker.TabIndex = 18;
			this.dateTimePicker.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			// 
			// txtROboljenja
			// 
			this.txtROboljenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtROboljenja.Location = new System.Drawing.Point(317, 232);
			this.txtROboljenja.Margin = new System.Windows.Forms.Padding(2);
			this.txtROboljenja.Name = "txtROboljenja";
			this.txtROboljenja.Size = new System.Drawing.Size(301, 79);
			this.txtROboljenja.TabIndex = 20;
			this.txtROboljenja.Text = "";
			// 
			// txtROpis
			// 
			this.txtROpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtROpis.Location = new System.Drawing.Point(317, 314);
			this.txtROpis.Margin = new System.Windows.Forms.Padding(2);
			this.txtROpis.Name = "txtROpis";
			this.txtROpis.Size = new System.Drawing.Size(301, 79);
			this.txtROpis.TabIndex = 21;
			this.txtROpis.Text = "";
			// 
			// btnSacuvaj
			// 
			this.btnSacuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSacuvaj.Location = new System.Drawing.Point(532, 436);
			this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2);
			this.btnSacuvaj.Name = "btnSacuvaj";
			this.btnSacuvaj.Size = new System.Drawing.Size(86, 28);
			this.btnSacuvaj.TabIndex = 22;
			this.btnSacuvaj.Text = "Sacuvaj";
			this.btnSacuvaj.UseVisualStyleBackColor = true;
			// 
			// btnOmoguciIzmenu
			// 
			this.btnOmoguciIzmenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOmoguciIzmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOmoguciIzmenu.Location = new System.Drawing.Point(417, 436);
			this.btnOmoguciIzmenu.Margin = new System.Windows.Forms.Padding(2);
			this.btnOmoguciIzmenu.Name = "btnOmoguciIzmenu";
			this.btnOmoguciIzmenu.Size = new System.Drawing.Size(110, 28);
			this.btnOmoguciIzmenu.TabIndex = 23;
			this.btnOmoguciIzmenu.Text = "Omoguci izmenu";
			this.btnOmoguciIzmenu.UseVisualStyleBackColor = true;
			// 
			// btnSacuvajPromene
			// 
			this.btnSacuvajPromene.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSacuvajPromene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSacuvajPromene.Location = new System.Drawing.Point(294, 436);
			this.btnSacuvajPromene.Margin = new System.Windows.Forms.Padding(2);
			this.btnSacuvajPromene.Name = "btnSacuvajPromene";
			this.btnSacuvajPromene.Size = new System.Drawing.Size(118, 28);
			this.btnSacuvajPromene.TabIndex = 24;
			this.btnSacuvajPromene.Text = "Sacuvaj promene";
			this.btnSacuvajPromene.UseVisualStyleBackColor = true;
			// 
			// btnObrisi
			// 
			this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisi.Location = new System.Drawing.Point(204, 436);
			this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
			this.btnObrisi.Name = "btnObrisi";
			this.btnObrisi.Size = new System.Drawing.Size(86, 28);
			this.btnObrisi.TabIndex = 25;
			this.btnObrisi.Text = "Obrisi";
			this.btnObrisi.UseVisualStyleBackColor = true;
			// 
			// btnNazad
			// 
			this.btnNazad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNazad.Location = new System.Drawing.Point(114, 436);
			this.btnNazad.Margin = new System.Windows.Forms.Padding(2);
			this.btnNazad.Name = "btnNazad";
			this.btnNazad.Size = new System.Drawing.Size(86, 28);
			this.btnNazad.TabIndex = 26;
			this.btnNazad.Text = "Nazad";
			this.btnNazad.UseVisualStyleBackColor = true;
			// 
			// UCPacijent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnNazad);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.btnObrisi);
			this.Controls.Add(this.btnSacuvajPromene);
			this.Controls.Add(this.btnOmoguciIzmenu);
			this.Controls.Add(this.btnSacuvaj);
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
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UCPacijent";
			this.Size = new System.Drawing.Size(800, 505);
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
		private Button btnObrisi;
		private Button btnNazad;

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
		public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
		public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
	}
}
