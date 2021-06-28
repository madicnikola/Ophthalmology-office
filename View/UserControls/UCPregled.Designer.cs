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
			this.btnObrisiIzabrano = new System.Windows.Forms.Button();
			this.gbDodajStavku = new System.Windows.Forms.GroupBox();
			this.cbTipIntervencije = new System.Windows.Forms.ComboBox();
			this.btnUnesi = new System.Windows.Forms.Button();
			this.txtNaziv = new System.Windows.Forms.TextBox();
			this.lblTipIntervencije = new System.Windows.Forms.Label();
			this.lblNazivStavke = new System.Windows.Forms.Label();
			this.dgvStavke = new System.Windows.Forms.DataGridView();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.btnSacuvaj = new System.Windows.Forms.Button();
			this.btnNazad = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnOmoguciIzmene = new System.Windows.Forms.Button();
			this.btnSacuvajPromene = new System.Windows.Forms.Button();
			this.gbPregred.SuspendLayout();
			this.gbStavkaPregleda.SuspendLayout();
			this.gbDodajStavku.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
			this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(457, 53);
			this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePicker.MaxDate = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(400, 30);
			this.dateTimePicker.TabIndex = 24;
			this.dateTimePicker.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			// 
			// txtBrojPregleda
			// 
			this.txtBrojPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBrojPregleda.Location = new System.Drawing.Point(457, 90);
			this.txtBrojPregleda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBrojPregleda.Name = "txtBrojPregleda";
			this.txtBrojPregleda.Size = new System.Drawing.Size(400, 30);
			this.txtBrojPregleda.TabIndex = 23;
			// 
			// txtPregledId
			// 
			this.txtPregledId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPregledId.Location = new System.Drawing.Point(457, 16);
			this.txtPregledId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPregledId.Name = "txtPregledId";
			this.txtPregledId.Size = new System.Drawing.Size(100, 30);
			this.txtPregledId.TabIndex = 22;
			// 
			// lblTelefon
			// 
			this.lblTelefon.AutoSize = true;
			this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefon.Location = new System.Drawing.Point(310, 95);
			this.lblTelefon.Name = "lblTelefon";
			this.lblTelefon.Size = new System.Drawing.Size(133, 25);
			this.lblTelefon.TabIndex = 21;
			this.lblTelefon.Text = "Broj pregleda:";
			// 
			// lblDatum
			// 
			this.lblDatum.AutoSize = true;
			this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatum.Location = new System.Drawing.Point(287, 58);
			this.lblDatum.Name = "lblDatum";
			this.lblDatum.Size = new System.Drawing.Size(156, 25);
			this.lblDatum.TabIndex = 20;
			this.lblDatum.Text = "Datum pregleda:";
			// 
			// lblBrojKartonaId
			// 
			this.lblBrojKartonaId.AutoSize = true;
			this.lblBrojKartonaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBrojKartonaId.Location = new System.Drawing.Point(334, 21);
			this.lblBrojKartonaId.Name = "lblBrojKartonaId";
			this.lblBrojKartonaId.Size = new System.Drawing.Size(109, 25);
			this.lblBrojKartonaId.TabIndex = 19;
			this.lblBrojKartonaId.Text = "Pregled ID:";
			// 
			// lblPacijent
			// 
			this.lblPacijent.AutoSize = true;
			this.lblPacijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPacijent.Location = new System.Drawing.Point(353, 134);
			this.lblPacijent.Name = "lblPacijent";
			this.lblPacijent.Size = new System.Drawing.Size(87, 25);
			this.lblPacijent.TabIndex = 25;
			this.lblPacijent.Text = "Pacijent:";
			// 
			// cbPacijent
			// 
			this.cbPacijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPacijent.FormattingEnabled = true;
			this.cbPacijent.Location = new System.Drawing.Point(457, 126);
			this.cbPacijent.Margin = new System.Windows.Forms.Padding(4);
			this.cbPacijent.Name = "cbPacijent";
			this.cbPacijent.Size = new System.Drawing.Size(400, 33);
			this.cbPacijent.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(376, 175);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 25);
			this.label1.TabIndex = 27;
			this.label1.Text = "Lekar:";
			// 
			// cbLekar
			// 
			this.cbLekar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbLekar.FormattingEnabled = true;
			this.cbLekar.Location = new System.Drawing.Point(457, 167);
			this.cbLekar.Margin = new System.Windows.Forms.Padding(4);
			this.cbLekar.Name = "cbLekar";
			this.cbLekar.Size = new System.Drawing.Size(400, 33);
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
			this.gbPregred.Location = new System.Drawing.Point(5, 5);
			this.gbPregred.Margin = new System.Windows.Forms.Padding(4);
			this.gbPregred.Name = "gbPregred";
			this.gbPregred.Padding = new System.Windows.Forms.Padding(4);
			this.gbPregred.Size = new System.Drawing.Size(1057, 208);
			this.gbPregred.TabIndex = 29;
			this.gbPregred.TabStop = false;
			this.gbPregred.Text = "Pregled";
			// 
			// gbStavkaPregleda
			// 
			this.gbStavkaPregleda.Controls.Add(this.btnObrisiIzabrano);
			this.gbStavkaPregleda.Controls.Add(this.gbDodajStavku);
			this.gbStavkaPregleda.Controls.Add(this.dgvStavke);
			this.gbStavkaPregleda.Location = new System.Drawing.Point(5, 213);
			this.gbStavkaPregleda.Margin = new System.Windows.Forms.Padding(4);
			this.gbStavkaPregleda.Name = "gbStavkaPregleda";
			this.gbStavkaPregleda.Padding = new System.Windows.Forms.Padding(4);
			this.gbStavkaPregleda.Size = new System.Drawing.Size(1057, 332);
			this.gbStavkaPregleda.TabIndex = 30;
			this.gbStavkaPregleda.TabStop = false;
			this.gbStavkaPregleda.Text = "Stavke pregleda";
			// 
			// btnObrisiIzabrano
			// 
			this.btnObrisiIzabrano.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnObrisiIzabrano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisiIzabrano.Location = new System.Drawing.Point(573, 276);
			this.btnObrisiIzabrano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnObrisiIzabrano.Name = "btnObrisiIzabrano";
			this.btnObrisiIzabrano.Size = new System.Drawing.Size(156, 34);
			this.btnObrisiIzabrano.TabIndex = 33;
			this.btnObrisiIzabrano.Text = "Obrisi izabrano";
			this.btnObrisiIzabrano.UseVisualStyleBackColor = true;
			this.btnObrisiIzabrano.Click += new System.EventHandler(this.btnObrisiIzabrano_Click);
			// 
			// gbDodajStavku
			// 
			this.gbDodajStavku.Controls.Add(this.cbTipIntervencije);
			this.gbDodajStavku.Controls.Add(this.btnUnesi);
			this.gbDodajStavku.Controls.Add(this.txtNaziv);
			this.gbDodajStavku.Controls.Add(this.lblTipIntervencije);
			this.gbDodajStavku.Controls.Add(this.lblNazivStavke);
			this.gbDodajStavku.Location = new System.Drawing.Point(739, 23);
			this.gbDodajStavku.Margin = new System.Windows.Forms.Padding(4);
			this.gbDodajStavku.Name = "gbDodajStavku";
			this.gbDodajStavku.Padding = new System.Windows.Forms.Padding(4);
			this.gbDodajStavku.Size = new System.Drawing.Size(311, 246);
			this.gbDodajStavku.TabIndex = 1;
			this.gbDodajStavku.TabStop = false;
			this.gbDodajStavku.Text = "Stavka";
			// 
			// cbTipIntervencije
			// 
			this.cbTipIntervencije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTipIntervencije.FormattingEnabled = true;
			this.cbTipIntervencije.Location = new System.Drawing.Point(12, 163);
			this.cbTipIntervencije.Name = "cbTipIntervencije";
			this.cbTipIntervencije.Size = new System.Drawing.Size(289, 26);
			this.cbTipIntervencije.TabIndex = 33;
			// 
			// btnUnesi
			// 
			this.btnUnesi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUnesi.Location = new System.Drawing.Point(76, 206);
			this.btnUnesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUnesi.Name = "btnUnesi";
			this.btnUnesi.Size = new System.Drawing.Size(145, 34);
			this.btnUnesi.TabIndex = 32;
			this.btnUnesi.Text = "Unesi";
			this.btnUnesi.UseVisualStyleBackColor = true;
			this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
			// 
			// txtNaziv
			// 
			this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNaziv.Location = new System.Drawing.Point(12, 72);
			this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
			this.txtNaziv.Name = "txtNaziv";
			this.txtNaziv.Size = new System.Drawing.Size(289, 30);
			this.txtNaziv.TabIndex = 30;
			// 
			// lblTipIntervencije
			// 
			this.lblTipIntervencije.AutoSize = true;
			this.lblTipIntervencije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipIntervencije.Location = new System.Drawing.Point(71, 135);
			this.lblTipIntervencije.Name = "lblTipIntervencije";
			this.lblTipIntervencije.Size = new System.Drawing.Size(150, 25);
			this.lblTipIntervencije.TabIndex = 29;
			this.lblTipIntervencije.Text = "Tip Intervencije:";
			// 
			// lblNazivStavke
			// 
			this.lblNazivStavke.AutoSize = true;
			this.lblNazivStavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNazivStavke.Location = new System.Drawing.Point(124, 43);
			this.lblNazivStavke.Name = "lblNazivStavke";
			this.lblNazivStavke.Size = new System.Drawing.Size(67, 25);
			this.lblNazivStavke.TabIndex = 28;
			this.lblNazivStavke.Text = "Naziv:";
			// 
			// dgvStavke
			// 
			this.dgvStavke.AllowUserToOrderColumns = true;
			this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStavke.Location = new System.Drawing.Point(8, 23);
			this.dgvStavke.Margin = new System.Windows.Forms.Padding(4);
			this.dgvStavke.MaximumSize = new System.Drawing.Size(1057, 332);
			this.dgvStavke.Name = "dgvStavke";
			this.dgvStavke.ReadOnly = true;
			this.dgvStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStavke.Size = new System.Drawing.Size(721, 246);
			this.dgvStavke.TabIndex = 0;
			// 
			// btnSacuvaj
			// 
			this.btnSacuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSacuvaj.Location = new System.Drawing.Point(509, 2);
			this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSacuvaj.Name = "btnSacuvaj";
			this.btnSacuvaj.Size = new System.Drawing.Size(115, 34);
			this.btnSacuvaj.TabIndex = 33;
			this.btnSacuvaj.Text = "Sacuvaj";
			this.btnSacuvaj.UseVisualStyleBackColor = true;
			this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
			// 
			// btnNazad
			// 
			this.btnNazad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNazad.Location = new System.Drawing.Point(76, 2);
			this.btnNazad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNazad.Name = "btnNazad";
			this.btnNazad.Size = new System.Drawing.Size(115, 34);
			this.btnNazad.TabIndex = 34;
			this.btnNazad.Text = "Nazad";
			this.btnNazad.UseVisualStyleBackColor = true;
			this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnSacuvaj);
			this.flowLayoutPanel1.Controls.Add(this.btnOmoguciIzmene);
			this.flowLayoutPanel1.Controls.Add(this.btnSacuvajPromene);
			this.flowLayoutPanel1.Controls.Add(this.btnNazad);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(428, 566);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(627, 40);
			this.flowLayoutPanel1.TabIndex = 35;
			// 
			// btnOmoguciIzmene
			// 
			this.btnOmoguciIzmene.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOmoguciIzmene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOmoguciIzmene.Location = new System.Drawing.Point(353, 2);
			this.btnOmoguciIzmene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOmoguciIzmene.Name = "btnOmoguciIzmene";
			this.btnOmoguciIzmene.Size = new System.Drawing.Size(150, 34);
			this.btnOmoguciIzmene.TabIndex = 35;
			this.btnOmoguciIzmene.Text = "Omoguci izmene";
			this.btnOmoguciIzmene.UseVisualStyleBackColor = true;
			this.btnOmoguciIzmene.Click += new System.EventHandler(this.btnOmoguciIzmene_Click);
			// 
			// btnSacuvajPromene
			// 
			this.btnSacuvajPromene.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSacuvajPromene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSacuvajPromene.Location = new System.Drawing.Point(197, 2);
			this.btnSacuvajPromene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSacuvajPromene.Name = "btnSacuvajPromene";
			this.btnSacuvajPromene.Size = new System.Drawing.Size(150, 34);
			this.btnSacuvajPromene.TabIndex = 36;
			this.btnSacuvajPromene.Text = "Sacuvaj promene";
			this.btnSacuvajPromene.UseVisualStyleBackColor = true;
			this.btnSacuvajPromene.Click += new System.EventHandler(this.btnSacuvajPromene_Click);
			// 
			// UCPregled
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gbStavkaPregleda);
			this.Controls.Add(this.gbPregred);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UCPregled";
			this.Size = new System.Drawing.Size(1067, 622);
			this.gbPregred.ResumeLayout(false);
			this.gbPregred.PerformLayout();
			this.gbStavkaPregleda.ResumeLayout(false);
			this.gbDodajStavku.ResumeLayout(false);
			this.gbDodajStavku.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
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
		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.Label lblTipIntervencije;
		private System.Windows.Forms.Label lblNazivStavke;
		private System.Windows.Forms.Button btnUnesi;
		private System.Windows.Forms.Button btnSacuvaj;
		private System.Windows.Forms.Button btnNazad;
		private System.Windows.Forms.Button btnObrisiIzabrano;
		private ComboBox cbTipIntervencije;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button btnOmoguciIzmene;
		private Button btnSacuvajPromene;

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
		public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
		public Label LblTipIntervencije { get => lblTipIntervencije; set => lblTipIntervencije = value; }
		public Label LblNazivStavke { get => lblNazivStavke; set => lblNazivStavke = value; }
		public Button BtnUnesi { get => btnUnesi; set => btnUnesi = value; }
		public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
		public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
		public Button BtnObrisiIzabrano { get => btnObrisiIzabrano; set => btnObrisiIzabrano = value; }
		public ComboBox CbTipIntervencije { get => cbTipIntervencije; set => cbTipIntervencije = value; }
		public Button BtnOmoguciIzmene { get => btnOmoguciIzmene; set => btnOmoguciIzmene = value; }
		public Button BtnSacuvajPromene { get => btnSacuvajPromene; set => btnSacuvajPromene = value; }
	}
}
