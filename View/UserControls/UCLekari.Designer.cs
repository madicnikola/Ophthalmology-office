using System.Windows.Forms;

namespace View.UserControls
{
	partial class UCLekari
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
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtImePretraga = new System.Windows.Forms.TextBox();
			this.txtPrezimePretraga = new System.Windows.Forms.TextBox();
			this.btnPretrazi = new System.Windows.Forms.Button();
			this.btnObrisi = new System.Windows.Forms.Button();
			this.gbLekari = new System.Windows.Forms.GroupBox();
			this.dgvSviLekari = new System.Windows.Forms.DataGridView();
			this.btnPrikaziDetalje = new System.Windows.Forms.Button();
			this.gbLekari.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSviLekari)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOcisti
			// 
			this.btnOcisti.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOcisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOcisti.Location = new System.Drawing.Point(663, 187);
			this.btnOcisti.Margin = new System.Windows.Forms.Padding(4);
			this.btnOcisti.Name = "btnOcisti";
			this.btnOcisti.Size = new System.Drawing.Size(140, 30);
			this.btnOcisti.TabIndex = 79;
			this.btnOcisti.Text = "Ocisti";
			this.btnOcisti.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(154, 149);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 24);
			this.label7.TabIndex = 78;
			this.label7.Text = "Prezime:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(179, 108);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 24);
			this.label6.TabIndex = 77;
			this.label6.Text = "Ime:";
			// 
			// txtImePretraga
			// 
			this.txtImePretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImePretraga.Location = new System.Drawing.Point(251, 104);
			this.txtImePretraga.Margin = new System.Windows.Forms.Padding(4);
			this.txtImePretraga.Name = "txtImePretraga";
			this.txtImePretraga.Size = new System.Drawing.Size(380, 29);
			this.txtImePretraga.TabIndex = 75;
			// 
			// txtPrezimePretraga
			// 
			this.txtPrezimePretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrezimePretraga.Location = new System.Drawing.Point(251, 141);
			this.txtPrezimePretraga.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrezimePretraga.Name = "txtPrezimePretraga";
			this.txtPrezimePretraga.Size = new System.Drawing.Size(380, 29);
			this.txtPrezimePretraga.TabIndex = 74;
			// 
			// btnPretrazi
			// 
			this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPretrazi.Location = new System.Drawing.Point(663, 107);
			this.btnPretrazi.Margin = new System.Windows.Forms.Padding(4);
			this.btnPretrazi.Name = "btnPretrazi";
			this.btnPretrazi.Size = new System.Drawing.Size(140, 63);
			this.btnPretrazi.TabIndex = 73;
			this.btnPretrazi.Text = "Pretrazi";
			this.btnPretrazi.UseVisualStyleBackColor = true;
			this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
			// 
			// btnObrisi
			// 
			this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisi.Location = new System.Drawing.Point(426, 520);
			this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
			this.btnObrisi.Name = "btnObrisi";
			this.btnObrisi.Size = new System.Drawing.Size(228, 43);
			this.btnObrisi.TabIndex = 71;
			this.btnObrisi.Text = "Obrisi izabrane";
			this.btnObrisi.UseVisualStyleBackColor = true;
			this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
			// 
			// gbLekari
			// 
			this.gbLekari.Controls.Add(this.dgvSviLekari);
			this.gbLekari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbLekari.Location = new System.Drawing.Point(4, 225);
			this.gbLekari.Margin = new System.Windows.Forms.Padding(4);
			this.gbLekari.Name = "gbLekari";
			this.gbLekari.Padding = new System.Windows.Forms.Padding(4);
			this.gbLekari.Size = new System.Drawing.Size(1059, 241);
			this.gbLekari.TabIndex = 70;
			this.gbLekari.TabStop = false;
			this.gbLekari.Text = "Lekari";
			// 
			// dgvSviLekari
			// 
			this.dgvSviLekari.AllowUserToAddRows = false;
			this.dgvSviLekari.AllowUserToDeleteRows = false;
			this.dgvSviLekari.AllowUserToOrderColumns = true;
			this.dgvSviLekari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSviLekari.Location = new System.Drawing.Point(9, 30);
			this.dgvSviLekari.Margin = new System.Windows.Forms.Padding(4);
			this.dgvSviLekari.MultiSelect = false;
			this.dgvSviLekari.Name = "dgvSviLekari";
			this.dgvSviLekari.ReadOnly = true;
			this.dgvSviLekari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSviLekari.Size = new System.Drawing.Size(1041, 203);
			this.dgvSviLekari.TabIndex = 0;
			// 
			// btnPrikaziDetalje
			// 
			this.btnPrikaziDetalje.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrikaziDetalje.Location = new System.Drawing.Point(426, 469);
			this.btnPrikaziDetalje.Margin = new System.Windows.Forms.Padding(4);
			this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
			this.btnPrikaziDetalje.Size = new System.Drawing.Size(228, 43);
			this.btnPrikaziDetalje.TabIndex = 82;
			this.btnPrikaziDetalje.Text = "Prikazi detalje";
			this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
			this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
			// 
			// UCLekari
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnPrikaziDetalje);
			this.Controls.Add(this.btnOcisti);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtImePretraga);
			this.Controls.Add(this.txtPrezimePretraga);
			this.Controls.Add(this.btnPretrazi);
			this.Controls.Add(this.btnObrisi);
			this.Controls.Add(this.gbLekari);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UCLekari";
			this.Size = new System.Drawing.Size(1067, 622);
			this.gbLekari.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSviLekari)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOcisti;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtImePretraga;
		private System.Windows.Forms.TextBox txtPrezimePretraga;
		private System.Windows.Forms.Button btnPretrazi;
		private System.Windows.Forms.Button btnObrisi;
		private System.Windows.Forms.GroupBox gbLekari;
		private System.Windows.Forms.DataGridView dgvSviLekari;
		private Button btnPrikaziDetalje;

		public Button BtnOcisti { get => btnOcisti; set => btnOcisti = value; }
		public Label Label7 { get => label7; set => label7 = value; }
		public Label Label6 { get => label6; set => label6 = value; }
		public TextBox TxtImePretraga { get => txtImePretraga; set => txtImePretraga = value; }
		public TextBox TxtPrezimePretraga { get => txtPrezimePretraga; set => txtPrezimePretraga = value; }
		public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
		public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
		public GroupBox GbLekari { get => gbLekari; set => gbLekari = value; }
		public DataGridView DgvSviLekari { get => dgvSviLekari; set => dgvSviLekari = value; }
		public Button BtnPrikaziDetalje { get => btnPrikaziDetalje; set => btnPrikaziDetalje = value; }
	}
}
