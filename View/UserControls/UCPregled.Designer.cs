using System.ComponentModel;
using System.Windows.Forms;

namespace View.UserControls
{
	partial class UCPregled
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
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.txtBrojPregleda = new System.Windows.Forms.TextBox();
			this.txtPregledId = new System.Windows.Forms.TextBox();
			this.lblTelefon = new System.Windows.Forms.Label();
			this.lblDatum = new System.Windows.Forms.Label();
			this.lblBrojKartonaId = new System.Windows.Forms.Label();
			this.lblPacijent = new System.Windows.Forms.Label();
			this.cbPacijent = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbLekar = new System.Windows.Forms.ComboBox();
			this.gbPregred = new System.Windows.Forms.GroupBox();
			this.gbStavkaPregleda = new System.Windows.Forms.GroupBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.dgvStavke = new System.Windows.Forms.DataGridView();
			this.gbDodajStavku = new System.Windows.Forms.GroupBox();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.lblNazivStavke = new System.Windows.Forms.Label();
			this.lblTipIntervencije = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtRTipIntervencije = new System.Windows.Forms.RichTextBox();
			this.btnUnesi = new System.Windows.Forms.Button();
			this.btnSacuvaj = new System.Windows.Forms.Button();
			this.btnNazad = new System.Windows.Forms.Button();
			this.btnObrisiIzabrano = new System.Windows.Forms.Button();
			this.gbPregred.SuspendLayout();
			this.gbStavkaPregleda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
			this.gbDodajStavku.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
			this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(343, 43);
			this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePicker.MaxDate = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(301, 26);
			this.dateTimePicker.TabIndex = 24;
			this.dateTimePicker.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			// 
			// txtBrojPregleda
			// 
			this.txtBrojPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBrojPregleda.Location = new System.Drawing.Point(343, 73);
			this.txtBrojPregleda.Margin = new System.Windows.Forms.Padding(2);
			this.txtBrojPregleda.Name = "txtBrojPregleda";
			this.txtBrojPregleda.Size = new System.Drawing.Size(301, 26);
			this.txtBrojPregleda.TabIndex = 23;
			// 
			// txtPregledId
			// 
			this.txtPregledId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPregledId.Location = new System.Drawing.Point(343, 13);
			this.txtPregledId.Margin = new System.Windows.Forms.Padding(2);
			this.txtPregledId.Name = "txtPregledId";
			this.txtPregledId.Size = new System.Drawing.Size(76, 26);
			this.txtPregledId.TabIndex = 22;
			// 
			// lblTelefon
			// 
			this.lblTelefon.AutoSize = true;
			this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefon.Location = new System.Drawing.Point(229, 79);
			this.lblTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTelefon.Name = "lblTelefon";
			this.lblTelefon.Size = new System.Drawing.Size(107, 20);
			this.lblTelefon.TabIndex = 21;
			this.lblTelefon.Text = "Broj pregleda:";
			// 
			// lblDatum
			// 
			this.lblDatum.AutoSize = true;
			this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatum.Location = new System.Drawing.Point(209, 49);
			this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDatum.Name = "lblDatum";
			this.lblDatum.Size = new System.Drawing.Size(127, 20);
			this.lblDatum.TabIndex = 20;
			this.lblDatum.Text = "Datum pregleda:";
			// 
			// lblBrojKartonaId
			// 
			this.lblBrojKartonaId.AutoSize = true;
			this.lblBrojKartonaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBrojKartonaId.Location = new System.Drawing.Point(248, 19);
			this.lblBrojKartonaId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblBrojKartonaId.Name = "lblBrojKartonaId";
			this.lblBrojKartonaId.Size = new System.Drawing.Size(88, 20);
			this.lblBrojKartonaId.TabIndex = 19;
			this.lblBrojKartonaId.Text = "Pregled ID:";
			// 
			// lblPacijent
			// 
			this.lblPacijent.AutoSize = true;
			this.lblPacijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPacijent.Location = new System.Drawing.Point(267, 105);
			this.lblPacijent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPacijent.Name = "lblPacijent";
			this.lblPacijent.Size = new System.Drawing.Size(69, 20);
			this.lblPacijent.TabIndex = 25;
			this.lblPacijent.Text = "Pacijent:";
			// 
			// cbPacijent
			// 
			this.cbPacijent.FormattingEnabled = true;
			this.cbPacijent.Location = new System.Drawing.Point(343, 104);
			this.cbPacijent.Name = "cbPacijent";
			this.cbPacijent.Size = new System.Drawing.Size(301, 21);
			this.cbPacijent.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(283, 132);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 20);
			this.label1.TabIndex = 27;
			this.label1.Text = "Lekar:";
			// 
			// cbLekar
			// 
			this.cbLekar.FormattingEnabled = true;
			this.cbLekar.Location = new System.Drawing.Point(343, 131);
			this.cbLekar.Name = "cbLekar";
			this.cbLekar.Size = new System.Drawing.Size(301, 21);
			this.cbLekar.TabIndex = 28;
			// 
			// gbPregred
			// 
			this.gbPregred.Controls.Add(this.lblBrojKartonaId);
			this.gbPregred.Controls.Add(this.cbLekar);
			this.gbPregred.Controls.Add(this.lblDatum);
			this.gbPregred.Controls.Add(this.label1);
			this.gbPregred.Controls.Add(this.lblTelefon);
			this.gbPregred.Controls.Add(this.cbPacijent);
			this.gbPregred.Controls.Add(this.txtPregledId);
			this.gbPregred.Controls.Add(this.lblPacijent);
			this.gbPregred.Controls.Add(this.txtBrojPregleda);
			this.gbPregred.Controls.Add(this.dateTimePicker);
			this.gbPregred.Location = new System.Drawing.Point(4, 4);
			this.gbPregred.Name = "gbPregred";
			this.gbPregred.Size = new System.Drawing.Size(793, 160);
			this.gbPregred.TabIndex = 29;
			this.gbPregred.TabStop = false;
			this.gbPregred.Text = "Pregled";
			// 
			// gbStavkaPregleda
			// 
			this.gbStavkaPregleda.Controls.Add(this.btnObrisiIzabrano);
			this.gbStavkaPregleda.Controls.Add(this.gbDodajStavku);
			this.gbStavkaPregleda.Controls.Add(this.dgvStavke);
			this.gbStavkaPregleda.Location = new System.Drawing.Point(4, 170);
			this.gbStavkaPregleda.Name = "gbStavkaPregleda";
			this.gbStavkaPregleda.Size = new System.Drawing.Size(793, 273);
			this.gbStavkaPregleda.TabIndex = 30;
			this.gbStavkaPregleda.TabStop = false;
			this.gbStavkaPregleda.Text = "Stavke";
			// 
			// dgvStavke
			// 
			this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStavke.Location = new System.Drawing.Point(6, 19);
			this.dgvStavke.Name = "dgvStavke";
			this.dgvStavke.Size = new System.Drawing.Size(541, 200);
			this.dgvStavke.TabIndex = 0;
			// 
			// gbDodajStavku
			// 
			this.gbDodajStavku.Controls.Add(this.btnUnesi);
			this.gbDodajStavku.Controls.Add(this.txtRTipIntervencije);
			this.gbDodajStavku.Controls.Add(this.textBox1);
			this.gbDodajStavku.Controls.Add(this.lblTipIntervencije);
			this.gbDodajStavku.Controls.Add(this.lblNazivStavke);
			this.gbDodajStavku.Location = new System.Drawing.Point(554, 19);
			this.gbDodajStavku.Name = "gbDodajStavku";
			this.gbDodajStavku.Size = new System.Drawing.Size(233, 246);
			this.gbDodajStavku.TabIndex = 1;
			this.gbDodajStavku.TabStop = false;
			// 
			// lblNazivStavke
			// 
			this.lblNazivStavke.AutoSize = true;
			this.lblNazivStavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNazivStavke.Location = new System.Drawing.Point(5, 21);
			this.lblNazivStavke.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNazivStavke.Name = "lblNazivStavke";
			this.lblNazivStavke.Size = new System.Drawing.Size(51, 20);
			this.lblNazivStavke.TabIndex = 28;
			this.lblNazivStavke.Text = "Naziv:";
			// 
			// lblTipIntervencije
			// 
			this.lblTipIntervencije.AutoSize = true;
			this.lblTipIntervencije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipIntervencije.Location = new System.Drawing.Point(57, 66);
			this.lblTipIntervencije.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTipIntervencije.Name = "lblTipIntervencije";
			this.lblTipIntervencije.Size = new System.Drawing.Size(119, 20);
			this.lblTipIntervencije.TabIndex = 29;
			this.lblTipIntervencije.Text = "Tip Intervencije:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(61, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(166, 26);
			this.textBox1.TabIndex = 30;
			// 
			// txtRTipIntervencije
			// 
			this.txtRTipIntervencije.Location = new System.Drawing.Point(7, 89);
			this.txtRTipIntervencije.Name = "txtRTipIntervencije";
			this.txtRTipIntervencije.Size = new System.Drawing.Size(220, 111);
			this.txtRTipIntervencije.TabIndex = 31;
			this.txtRTipIntervencije.Text = "";
			// 
			// btnUnesi
			// 
			this.btnUnesi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUnesi.Location = new System.Drawing.Point(141, 205);
			this.btnUnesi.Margin = new System.Windows.Forms.Padding(2);
			this.btnUnesi.Name = "btnUnesi";
			this.btnUnesi.Size = new System.Drawing.Size(86, 28);
			this.btnUnesi.TabIndex = 32;
			this.btnUnesi.Text = "Unesi";
			this.btnUnesi.UseVisualStyleBackColor = true;
			// 
			// btnSacuvaj
			// 
			this.btnSacuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSacuvaj.Location = new System.Drawing.Point(705, 465);
			this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2);
			this.btnSacuvaj.Name = "btnSacuvaj";
			this.btnSacuvaj.Size = new System.Drawing.Size(86, 28);
			this.btnSacuvaj.TabIndex = 33;
			this.btnSacuvaj.Text = "Sacuvaj";
			this.btnSacuvaj.UseVisualStyleBackColor = true;
			// 
			// btnNazad
			// 
			this.btnNazad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNazad.Location = new System.Drawing.Point(615, 465);
			this.btnNazad.Margin = new System.Windows.Forms.Padding(2);
			this.btnNazad.Name = "btnNazad";
			this.btnNazad.Size = new System.Drawing.Size(86, 28);
			this.btnNazad.TabIndex = 34;
			this.btnNazad.Text = "Nazad";
			this.btnNazad.UseVisualStyleBackColor = true;
			// 
			// btnObrisiIzabrano
			// 
			this.btnObrisiIzabrano.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnObrisiIzabrano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisiIzabrano.Location = new System.Drawing.Point(430, 224);
			this.btnObrisiIzabrano.Margin = new System.Windows.Forms.Padding(2);
			this.btnObrisiIzabrano.Name = "btnObrisiIzabrano";
			this.btnObrisiIzabrano.Size = new System.Drawing.Size(117, 28);
			this.btnObrisiIzabrano.TabIndex = 33;
			this.btnObrisiIzabrano.Text = "Obrisi izabrano";
			this.btnObrisiIzabrano.UseVisualStyleBackColor = true;
			// 
			// UCPregled
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnNazad);
			this.Controls.Add(this.btnSacuvaj);
			this.Controls.Add(this.gbStavkaPregleda);
			this.Controls.Add(this.gbPregred);
			this.Name = "UCPregled";
			this.Size = new System.Drawing.Size(800, 505);
			this.gbPregred.ResumeLayout(false);
			this.gbPregred.PerformLayout();
			this.gbStavkaPregleda.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
			this.gbDodajStavku.ResumeLayout(false);
			this.gbDodajStavku.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.TextBox txtBrojPregleda;
		private System.Windows.Forms.TextBox txtPregledId;
		private System.Windows.Forms.Label lblTelefon;
		private System.Windows.Forms.Label lblDatum;
		private System.Windows.Forms.Label lblBrojKartonaId;
		private System.Windows.Forms.Label lblPacijent;
		private System.Windows.Forms.ComboBox cbPacijent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbLekar;
		private System.Windows.Forms.GroupBox gbPregred;
		private System.Windows.Forms.GroupBox gbStavkaPregleda;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.GroupBox gbDodajStavku;
		private System.Windows.Forms.DataGridView dgvStavke;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblTipIntervencije;
		private System.Windows.Forms.Label lblNazivStavke;
		private System.Windows.Forms.RichTextBox txtRTipIntervencije;
		private System.Windows.Forms.Button btnUnesi;
		private System.Windows.Forms.Button btnSacuvaj;
		private System.Windows.Forms.Button btnNazad;
		private System.Windows.Forms.Button btnObrisiIzabrano;

		public DateTimePicker DateTimePicker { get => dateTimePicker; set => dateTimePicker = value; }
		public TextBox TxtBrojPregleda { get => txtBrojPregleda; set => txtBrojPregleda = value; }
		public TextBox TxtPregledId { get => txtPregledId; set => txtPregledId = value; }
		public Label LblTelefon { get => lblTelefon; set => lblTelefon = value; }
		public Label LblDatum { get => lblDatum; set => lblDatum = value; }
		public Label LblPregledId { get => lblBrojKartonaId; set => lblBrojKartonaId = value; }
		public Label LblPacijent { get => lblPacijent; set => lblPacijent = value; }
		public ComboBox CbPacijent { get => cbPacijent; set => cbPacijent = value; }
		public Label Label1 { get => label1; set => label1 = value; }
		public ComboBox CbLekar { get => cbLekar; set => cbLekar = value; }
		public GroupBox GbPregred { get => gbPregred; set => gbPregred = value; }
		public GroupBox GbStavkaPregleda { get => gbStavkaPregleda; set => gbStavkaPregleda = value; }
		public BackgroundWorker BackgroundWorker1 { get => backgroundWorker1; set => backgroundWorker1 = value; }
		public GroupBox GbDodajStavku { get => gbDodajStavku; set => gbDodajStavku = value; }
		public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
		public BackgroundWorker BackgroundWorker2 { get => backgroundWorker2; set => backgroundWorker2 = value; }
		public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }
		public Label LblTipIntervencije { get => lblTipIntervencije; set => lblTipIntervencije = value; }
		public Label LblNazivStavke { get => lblNazivStavke; set => lblNazivStavke = value; }
		public RichTextBox TxtRTipIntervencije { get => txtRTipIntervencije; set => txtRTipIntervencije = value; }
		public Button BtnUnesi { get => btnUnesi; set => btnUnesi = value; }
		public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
		public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
		public Button BtnObrisiIzabrano { get => btnObrisiIzabrano; set => btnObrisiIzabrano = value; }
	}
}
