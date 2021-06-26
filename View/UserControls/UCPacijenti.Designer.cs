using System.Windows.Forms;

namespace View.UserControls
{
	partial class UCPacijenti
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
			this.dgvSviPacijenti = new System.Windows.Forms.DataGridView();
			this.btnOcisti = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtImePretraga = new System.Windows.Forms.TextBox();
			this.txtPrezimePretraga = new System.Windows.Forms.TextBox();
			this.btnPretrazi = new System.Windows.Forms.Button();
			this.btnObrisi = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnPrikaziDetalje = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvSviPacijenti)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvSviPacijenti
			// 
			this.dgvSviPacijenti.AllowUserToAddRows = false;
			this.dgvSviPacijenti.AllowUserToDeleteRows = false;
			this.dgvSviPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSviPacijenti.Location = new System.Drawing.Point(9, 30);
			this.dgvSviPacijenti.Margin = new System.Windows.Forms.Padding(4);
			this.dgvSviPacijenti.Name = "dgvSviPacijenti";
			this.dgvSviPacijenti.ReadOnly = true;
			this.dgvSviPacijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSviPacijenti.Size = new System.Drawing.Size(1045, 203);
			this.dgvSviPacijenti.StandardTab = true;
			this.dgvSviPacijenti.TabIndex = 0;
			// 
			// btnOcisti
			// 
			this.btnOcisti.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOcisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOcisti.Location = new System.Drawing.Point(667, 187);
			this.btnOcisti.Margin = new System.Windows.Forms.Padding(4);
			this.btnOcisti.Name = "btnOcisti";
			this.btnOcisti.Size = new System.Drawing.Size(140, 30);
			this.btnOcisti.TabIndex = 69;
			this.btnOcisti.Text = "Ocisti";
			this.btnOcisti.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(151, 149);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 24);
			this.label7.TabIndex = 68;
			this.label7.Text = "Prezime:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(177, 108);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 24);
			this.label6.TabIndex = 67;
			this.label6.Text = "Ime:";
			// 
			// txtImePretraga
			// 
			this.txtImePretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImePretraga.Location = new System.Drawing.Point(249, 104);
			this.txtImePretraga.Margin = new System.Windows.Forms.Padding(4);
			this.txtImePretraga.Name = "txtImePretraga";
			this.txtImePretraga.Size = new System.Drawing.Size(380, 29);
			this.txtImePretraga.TabIndex = 65;
			// 
			// txtPrezimePretraga
			// 
			this.txtPrezimePretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrezimePretraga.Location = new System.Drawing.Point(249, 141);
			this.txtPrezimePretraga.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrezimePretraga.Name = "txtPrezimePretraga";
			this.txtPrezimePretraga.Size = new System.Drawing.Size(380, 29);
			this.txtPrezimePretraga.TabIndex = 64;
			// 
			// btnPretrazi
			// 
			this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPretrazi.Location = new System.Drawing.Point(667, 104);
			this.btnPretrazi.Margin = new System.Windows.Forms.Padding(4);
			this.btnPretrazi.Name = "btnPretrazi";
			this.btnPretrazi.Size = new System.Drawing.Size(140, 63);
			this.btnPretrazi.TabIndex = 63;
			this.btnPretrazi.Text = "Pretrazi";
			this.btnPretrazi.UseVisualStyleBackColor = true;
			this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
			// 
			// btnObrisi
			// 
			this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisi.Location = new System.Drawing.Point(431, 525);
			this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
			this.btnObrisi.Name = "btnObrisi";
			this.btnObrisi.Size = new System.Drawing.Size(228, 43);
			this.btnObrisi.TabIndex = 61;
			this.btnObrisi.Text = "Obrisi izabrane";
			this.btnObrisi.UseVisualStyleBackColor = true;
			this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvSviPacijenti);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 225);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(1063, 241);
			this.groupBox1.TabIndex = 60;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pacijenti";
			// 
			// btnPrikaziDetalje
			// 
			this.btnPrikaziDetalje.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrikaziDetalje.Location = new System.Drawing.Point(431, 474);
			this.btnPrikaziDetalje.Margin = new System.Windows.Forms.Padding(4);
			this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
			this.btnPrikaziDetalje.Size = new System.Drawing.Size(228, 43);
			this.btnPrikaziDetalje.TabIndex = 70;
			this.btnPrikaziDetalje.Text = "Prikazi detalje";
			this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
			this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
			// 
			// UCPacijenti
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
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UCPacijenti";
			this.Size = new System.Drawing.Size(1067, 622);
			((System.ComponentModel.ISupportInitialize)(this.dgvSviPacijenti)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSviPacijenti;
		private System.Windows.Forms.Button btnOcisti;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtImePretraga;
		private System.Windows.Forms.TextBox txtPrezimePretraga;
		private System.Windows.Forms.Button btnPretrazi;
		private System.Windows.Forms.Button btnObrisi;
		private System.Windows.Forms.GroupBox groupBox1;
		private Button btnPrikaziDetalje;

		public DataGridView DgvPacijenti { get => dgvSviPacijenti; set => dgvSviPacijenti = value; }
		public Button BtnOcisti { get => btnOcisti; set => btnOcisti = value; }
		public Label Label7 { get => label7; set => label7 = value; }
		public Label Label6 { get => label6; set => label6 = value; }
		public TextBox TxtImePretraga { get => txtImePretraga; set => txtImePretraga = value; }
		public TextBox TxtPrezimePretraga { get => txtPrezimePretraga; set => txtPrezimePretraga = value; }
		public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
		public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
		public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
		public Button BtnPrikaziDetalje { get => btnPrikaziDetalje; set => btnPrikaziDetalje = value; }
	}
}
