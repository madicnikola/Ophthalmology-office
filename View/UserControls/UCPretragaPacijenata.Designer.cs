using View;

namespace View.UserControls
{
	partial class UCPretragaPacijenata
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
			this.components = new System.ComponentModel.Container();
			this.gbKriterijumPretrage = new System.Windows.Forms.GroupBox();
			this.btnPrikaziDetalje = new System.Windows.Forms.Button();
			this.btnObrisi = new System.Windows.Forms.Button();
			this.btnIzmeni = new System.Windows.Forms.Button();
			this.btnPretrazi = new System.Windows.Forms.Button();
			this.txtKriterijumPretrage = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.dataPacijenti = new System.Windows.Forms.DataGridView();
			this.gbKriterijumPretrage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataPacijenti)).BeginInit();
			this.SuspendLayout();
			// 
			// gbKriterijumPretrage
			// 
			this.gbKriterijumPretrage.Controls.Add(this.btnPrikaziDetalje);
			this.gbKriterijumPretrage.Controls.Add(this.btnObrisi);
			this.gbKriterijumPretrage.Controls.Add(this.btnIzmeni);
			this.gbKriterijumPretrage.Controls.Add(this.btnPretrazi);
			this.gbKriterijumPretrage.Controls.Add(this.txtKriterijumPretrage);
			this.gbKriterijumPretrage.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.gbKriterijumPretrage.Location = new System.Drawing.Point(3, 3);
			this.gbKriterijumPretrage.Name = "gbKriterijumPretrage";
			this.gbKriterijumPretrage.Size = new System.Drawing.Size(794, 100);
			this.gbKriterijumPretrage.TabIndex = 0;
			this.gbKriterijumPretrage.TabStop = false;
			this.gbKriterijumPretrage.Text = "Kriterijum pretrage";
			// 
			// btnPrikaziDetalje
			// 
			this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrikaziDetalje.Location = new System.Drawing.Point(418, 42);
			this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
			this.btnPrikaziDetalje.Size = new System.Drawing.Size(100, 23);
			this.btnPrikaziDetalje.TabIndex = 4;
			this.btnPrikaziDetalje.TabStop = false;
			this.btnPrikaziDetalje.Text = "Prikazi detalje";
			this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
			// 
			// btnObrisi
			// 
			this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisi.Location = new System.Drawing.Point(688, 42);
			this.btnObrisi.Name = "btnObrisi";
			this.btnObrisi.Size = new System.Drawing.Size(100, 23);
			this.btnObrisi.TabIndex = 3;
			this.btnObrisi.Text = "Obrisi";
			this.btnObrisi.UseVisualStyleBackColor = true;
			// 
			// btnIzmeni
			// 
			this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIzmeni.Location = new System.Drawing.Point(582, 42);
			this.btnIzmeni.Name = "btnIzmeni";
			this.btnIzmeni.Size = new System.Drawing.Size(100, 23);
			this.btnIzmeni.TabIndex = 2;
			this.btnIzmeni.Text = "Izmeni";
			this.btnIzmeni.UseVisualStyleBackColor = true;
			// 
			// btnPretrazi
			// 
			this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPretrazi.Location = new System.Drawing.Point(312, 42);
			this.btnPretrazi.Name = "btnPretrazi";
			this.btnPretrazi.Size = new System.Drawing.Size(100, 23);
			this.btnPretrazi.TabIndex = 1;
			this.btnPretrazi.Text = "Pretrazi";
			this.btnPretrazi.UseVisualStyleBackColor = true;
			this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
			// 
			// txtKriterijumPretrage
			// 
			this.txtKriterijumPretrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKriterijumPretrage.Location = new System.Drawing.Point(7, 42);
			this.txtKriterijumPretrage.Name = "txtKriterijumPretrage";
			this.txtKriterijumPretrage.Size = new System.Drawing.Size(299, 22);
			this.txtKriterijumPretrage.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// dataPacijenti
			// 
			this.dataPacijenti.AllowUserToOrderColumns = true;
			this.dataPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPacijenti.Location = new System.Drawing.Point(9, 109);
			this.dataPacijenti.Name = "dataPacijenti";
			this.dataPacijenti.ReadOnly = true;
			this.dataPacijenti.Size = new System.Drawing.Size(788, 393);
			this.dataPacijenti.TabIndex = 2;
			// 
			// UCPretragaPacijenata
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataPacijenti);
			this.Controls.Add(this.gbKriterijumPretrage);
			this.Name = "UCPretragaPacijenata";
			this.Size = new System.Drawing.Size(800, 505);
			this.gbKriterijumPretrage.ResumeLayout(false);
			this.gbKriterijumPretrage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataPacijenti)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbKriterijumPretrage;
		public System.Windows.Forms.TextBox txtKriterijumPretrage;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button btnPrikaziDetalje;
		private System.Windows.Forms.Button btnObrisi;
		private System.Windows.Forms.Button btnIzmeni;
		private System.Windows.Forms.Button btnPretrazi;
		private System.Windows.Forms.DataGridView dataPacijenti;
		private System.Windows.Forms.DataGridViewTextBoxColumn brojKartonaIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datumRodjenjaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oboljenjaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dioptrijaDataGridViewCheckBoxColumn;
	}
}
