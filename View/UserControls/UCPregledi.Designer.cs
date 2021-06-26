using System.Windows.Forms;

namespace View.UserControls
{
	partial class UCPregledi
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
			this.btnOcisti = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnPretrazi = new System.Windows.Forms.Button();
			this.txtPregledId = new System.Windows.Forms.TextBox();
			this.btnObrisi = new System.Windows.Forms.Button();
			this.gbPregledi = new System.Windows.Forms.GroupBox();
			this.dgvSviPregledi = new System.Windows.Forms.DataGridView();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.btnPrikaziDetalje = new System.Windows.Forms.Button();
			this.gbPregledi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSviPregledi)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOcisti
			// 
			this.btnOcisti.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOcisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOcisti.Location = new System.Drawing.Point(656, 110);
			this.btnOcisti.Margin = new System.Windows.Forms.Padding(4);
			this.btnOcisti.Name = "btnOcisti";
			this.btnOcisti.Size = new System.Drawing.Size(140, 30);
			this.btnOcisti.TabIndex = 79;
			this.btnOcisti.Text = "Ocisti";
			this.btnOcisti.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(157, 192);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 24);
			this.label6.TabIndex = 77;
			this.label6.Text = "Datum:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(125, 113);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 24);
			this.label5.TabIndex = 76;
			this.label5.Text = "Pregled ID:";
			// 
			// btnPretrazi
			// 
			this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPretrazi.Location = new System.Drawing.Point(656, 159);
			this.btnPretrazi.Margin = new System.Windows.Forms.Padding(4);
			this.btnPretrazi.Name = "btnPretrazi";
			this.btnPretrazi.Size = new System.Drawing.Size(140, 63);
			this.btnPretrazi.TabIndex = 73;
			this.btnPretrazi.Text = "Pretrazi";
			this.btnPretrazi.UseVisualStyleBackColor = true;
			this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
			// 
			// txtPregledId
			// 
			this.txtPregledId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPregledId.Location = new System.Drawing.Point(244, 110);
			this.txtPregledId.Margin = new System.Windows.Forms.Padding(4);
			this.txtPregledId.Name = "txtPregledId";
			this.txtPregledId.Size = new System.Drawing.Size(380, 29);
			this.txtPregledId.TabIndex = 72;
			// 
			// btnObrisi
			// 
			this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisi.Location = new System.Drawing.Point(419, 517);
			this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
			this.btnObrisi.Name = "btnObrisi";
			this.btnObrisi.Size = new System.Drawing.Size(228, 43);
			this.btnObrisi.TabIndex = 71;
			this.btnObrisi.Text = "Obrisi izabrano";
			this.btnObrisi.UseVisualStyleBackColor = true;
			this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
			// 
			// gbPregledi
			// 
			this.gbPregledi.Controls.Add(this.dgvSviPregledi);
			this.gbPregledi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbPregledi.Location = new System.Drawing.Point(4, 225);
			this.gbPregledi.Margin = new System.Windows.Forms.Padding(4);
			this.gbPregledi.Name = "gbPregledi";
			this.gbPregledi.Padding = new System.Windows.Forms.Padding(4);
			this.gbPregledi.Size = new System.Drawing.Size(1059, 241);
			this.gbPregledi.TabIndex = 70;
			this.gbPregledi.TabStop = false;
			this.gbPregledi.Text = "Pregledi";
			// 
			// dgvSviPregledi
			// 
			this.dgvSviPregledi.AllowUserToAddRows = false;
			this.dgvSviPregledi.AllowUserToDeleteRows = false;
			this.dgvSviPregledi.AllowUserToOrderColumns = true;
			this.dgvSviPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSviPregledi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dgvSviPregledi.Location = new System.Drawing.Point(9, 30);
			this.dgvSviPregledi.Margin = new System.Windows.Forms.Padding(4);
			this.dgvSviPregledi.MultiSelect = false;
			this.dgvSviPregledi.Name = "dgvSviPregledi";
			this.dgvSviPregledi.ReadOnly = true;
			this.dgvSviPregledi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSviPregledi.Size = new System.Drawing.Size(1041, 203);
			this.dgvSviPregledi.StandardTab = true;
			this.dgvSviPregledi.TabIndex = 0;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
			this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(244, 187);
			this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePicker.MaxDate = new System.DateTime(2021, 6, 25, 22, 57, 47, 0);
			this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(380, 30);
			this.dateTimePicker.TabIndex = 80;
			this.dateTimePicker.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			// 
			// btnPrikaziDetalje
			// 
			this.btnPrikaziDetalje.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrikaziDetalje.Location = new System.Drawing.Point(419, 466);
			this.btnPrikaziDetalje.Margin = new System.Windows.Forms.Padding(4);
			this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
			this.btnPrikaziDetalje.Size = new System.Drawing.Size(228, 43);
			this.btnPrikaziDetalje.TabIndex = 81;
			this.btnPrikaziDetalje.Text = "Prikazi detalje";
			this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
			this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
			// 
			// UCPregledi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnPrikaziDetalje);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.btnOcisti);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnPretrazi);
			this.Controls.Add(this.txtPregledId);
			this.Controls.Add(this.btnObrisi);
			this.Controls.Add(this.gbPregledi);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UCPregledi";
			this.Size = new System.Drawing.Size(1067, 622);
			this.gbPregledi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSviPregledi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOcisti;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnPretrazi;
		private System.Windows.Forms.TextBox txtPregledId;
		private System.Windows.Forms.Button btnObrisi;
		private System.Windows.Forms.GroupBox gbPregledi;
		private System.Windows.Forms.DataGridView dgvSviPregledi;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private Button btnPrikaziDetalje;

		public Button BtnOcisti { get => btnOcisti; set => btnOcisti = value; }
		public Label Label6 { get => label6; set => label6 = value; }
		public Label Label5 { get => label5; set => label5 = value; }
		public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
		public TextBox TxtPregledId { get => txtPregledId; set => txtPregledId = value; }
		public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
		public GroupBox GbPregledi { get => gbPregledi; set => gbPregledi = value; }
		public DataGridView DgvSviPregledi { get => dgvSviPregledi; set => dgvSviPregledi = value; }
		public DateTimePicker DateTimePicker { get => dateTimePicker; set => dateTimePicker = value; }
		public Button BtnPrikaziDetalje { get => btnPrikaziDetalje; set => btnPrikaziDetalje = value; }
	}
}
