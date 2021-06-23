using System.Windows.Forms;

namespace View.UserControls
{
	partial class UCLekar
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
			this.btnNazad = new System.Windows.Forms.Button();
			this.btnObrisi = new System.Windows.Forms.Button();
			this.btnSacuvajPromene = new System.Windows.Forms.Button();
			this.btnOmoguciIzmenu = new System.Windows.Forms.Button();
			this.btnSacuvaj = new System.Windows.Forms.Button();
			this.txtSpecijalizacija = new System.Windows.Forms.TextBox();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.txtIme = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.lblSpecijalizacija = new System.Windows.Forms.Label();
			this.lblPrezime = new System.Windows.Forms.Label();
			this.lblIme = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnNazad
			// 
			this.btnNazad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNazad.Location = new System.Drawing.Point(155, 286);
			this.btnNazad.Margin = new System.Windows.Forms.Padding(2);
			this.btnNazad.Name = "btnNazad";
			this.btnNazad.Size = new System.Drawing.Size(86, 28);
			this.btnNazad.TabIndex = 39;
			this.btnNazad.Text = "Nazad";
			this.btnNazad.UseVisualStyleBackColor = true;
			// 
			// btnObrisi
			// 
			this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisi.Location = new System.Drawing.Point(245, 286);
			this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
			this.btnObrisi.Name = "btnObrisi";
			this.btnObrisi.Size = new System.Drawing.Size(86, 28);
			this.btnObrisi.TabIndex = 38;
			this.btnObrisi.Text = "Obrisi";
			this.btnObrisi.UseVisualStyleBackColor = true;
			// 
			// btnSacuvajPromene
			// 
			this.btnSacuvajPromene.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSacuvajPromene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSacuvajPromene.Location = new System.Drawing.Point(335, 286);
			this.btnSacuvajPromene.Margin = new System.Windows.Forms.Padding(2);
			this.btnSacuvajPromene.Name = "btnSacuvajPromene";
			this.btnSacuvajPromene.Size = new System.Drawing.Size(118, 28);
			this.btnSacuvajPromene.TabIndex = 37;
			this.btnSacuvajPromene.Text = "Sacuvaj promene";
			this.btnSacuvajPromene.UseVisualStyleBackColor = true;
			// 
			// btnOmoguciIzmenu
			// 
			this.btnOmoguciIzmenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOmoguciIzmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOmoguciIzmenu.Location = new System.Drawing.Point(458, 286);
			this.btnOmoguciIzmenu.Margin = new System.Windows.Forms.Padding(2);
			this.btnOmoguciIzmenu.Name = "btnOmoguciIzmenu";
			this.btnOmoguciIzmenu.Size = new System.Drawing.Size(110, 28);
			this.btnOmoguciIzmenu.TabIndex = 36;
			this.btnOmoguciIzmenu.Text = "Omoguci izmenu";
			this.btnOmoguciIzmenu.UseVisualStyleBackColor = true;
			// 
			// btnSacuvaj
			// 
			this.btnSacuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSacuvaj.Location = new System.Drawing.Point(573, 286);
			this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2);
			this.btnSacuvaj.Name = "btnSacuvaj";
			this.btnSacuvaj.Size = new System.Drawing.Size(86, 28);
			this.btnSacuvaj.TabIndex = 35;
			this.btnSacuvaj.Text = "Sacuvaj";
			this.btnSacuvaj.UseVisualStyleBackColor = true;
			// 
			// txtSpecijalizacija
			// 
			this.txtSpecijalizacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSpecijalizacija.Location = new System.Drawing.Point(312, 256);
			this.txtSpecijalizacija.Margin = new System.Windows.Forms.Padding(2);
			this.txtSpecijalizacija.Name = "txtSpecijalizacija";
			this.txtSpecijalizacija.Size = new System.Drawing.Size(301, 26);
			this.txtSpecijalizacija.TabIndex = 34;
			// 
			// txtPrezime
			// 
			this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrezime.Location = new System.Drawing.Point(312, 182);
			this.txtPrezime.Margin = new System.Windows.Forms.Padding(2);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(301, 26);
			this.txtPrezime.TabIndex = 33;
			// 
			// txtIme
			// 
			this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIme.Location = new System.Drawing.Point(312, 153);
			this.txtIme.Margin = new System.Windows.Forms.Padding(2);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(301, 26);
			this.txtIme.TabIndex = 32;
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(312, 96);
			this.txtId.Margin = new System.Windows.Forms.Padding(2);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(76, 26);
			this.txtId.TabIndex = 31;
			// 
			// lblSpecijalizacija
			// 
			this.lblSpecijalizacija.AutoSize = true;
			this.lblSpecijalizacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpecijalizacija.Location = new System.Drawing.Point(198, 256);
			this.lblSpecijalizacija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSpecijalizacija.Name = "lblSpecijalizacija";
			this.lblSpecijalizacija.Size = new System.Drawing.Size(111, 20);
			this.lblSpecijalizacija.TabIndex = 30;
			this.lblSpecijalizacija.Text = "Specijalizacija:";
			// 
			// lblPrezime
			// 
			this.lblPrezime.AutoSize = true;
			this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrezime.Location = new System.Drawing.Point(239, 185);
			this.lblPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPrezime.Name = "lblPrezime";
			this.lblPrezime.Size = new System.Drawing.Size(70, 20);
			this.lblPrezime.TabIndex = 29;
			this.lblPrezime.Text = "Prezime:";
			// 
			// lblIme
			// 
			this.lblIme.AutoSize = true;
			this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIme.Location = new System.Drawing.Point(268, 156);
			this.lblIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblIme.Name = "lblIme";
			this.lblIme.Size = new System.Drawing.Size(40, 20);
			this.lblIme.TabIndex = 28;
			this.lblIme.Text = "Ime:";
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblId.Location = new System.Drawing.Point(268, 96);
			this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(30, 20);
			this.lblId.TabIndex = 27;
			this.lblId.Text = "ID:";
			// 
			// UCLekar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnNazad);
			this.Controls.Add(this.btnObrisi);
			this.Controls.Add(this.btnSacuvajPromene);
			this.Controls.Add(this.btnOmoguciIzmenu);
			this.Controls.Add(this.btnSacuvaj);
			this.Controls.Add(this.txtSpecijalizacija);
			this.Controls.Add(this.txtPrezime);
			this.Controls.Add(this.txtIme);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.lblSpecijalizacija);
			this.Controls.Add(this.lblPrezime);
			this.Controls.Add(this.lblIme);
			this.Controls.Add(this.lblId);
			this.Name = "UCLekar";
			this.Size = new System.Drawing.Size(800, 505);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnNazad;
		private System.Windows.Forms.Button btnObrisi;
		private System.Windows.Forms.Button btnSacuvajPromene;
		private System.Windows.Forms.Button btnOmoguciIzmenu;
		private System.Windows.Forms.Button btnSacuvaj;
		private System.Windows.Forms.TextBox txtSpecijalizacija;
		private System.Windows.Forms.TextBox txtPrezime;
		private System.Windows.Forms.TextBox txtIme;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label lblSpecijalizacija;
		private System.Windows.Forms.Label lblPrezime;
		private System.Windows.Forms.Label lblIme;
		private System.Windows.Forms.Label lblId;

		public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
		public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
		public Button BtnSacuvajPromene { get => btnSacuvajPromene; set => btnSacuvajPromene = value; }
		public Button BtnOmoguciIzmenu { get => btnOmoguciIzmenu; set => btnOmoguciIzmenu = value; }
		public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
		public TextBox TxtSpecijalizacija { get => txtSpecijalizacija; set => txtSpecijalizacija = value; }
		public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
		public TextBox TxtIme { get => txtIme; set => txtIme = value; }
		public TextBox TxtId { get => txtId; set => txtId = value; }
		public Label LblSpecijalizacija { get => lblSpecijalizacija; set => lblSpecijalizacija = value; }
		public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
		public Label LblIme { get => lblIme; set => lblIme = value; }
		public Label LblId { get => lblId; set => lblId = value; }
	}
}
