using System.Windows.Forms;

namespace View.UserControls
{
	partial class UCHome
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
			this.pnlMainContainer = new System.Windows.Forms.Panel();
			this.lblKorisnik = new System.Windows.Forms.Label();
			this.lblPom = new System.Windows.Forms.Label();
			this.pnlMainContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMainContainer
			// 
			this.pnlMainContainer.Controls.Add(this.lblKorisnik);
			this.pnlMainContainer.Controls.Add(this.lblPom);
			this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMainContainer.Location = new System.Drawing.Point(0, 0);
			this.pnlMainContainer.Margin = new System.Windows.Forms.Padding(4);
			this.pnlMainContainer.Name = "pnlMainContainer";
			this.pnlMainContainer.Size = new System.Drawing.Size(1067, 622);
			this.pnlMainContainer.TabIndex = 2;
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
			// UCHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlMainContainer);
			this.Name = "UCHome";
			this.Size = new System.Drawing.Size(1067, 622);
			this.pnlMainContainer.ResumeLayout(false);
			this.pnlMainContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMainContainer;
		private System.Windows.Forms.Label lblKorisnik;
		private System.Windows.Forms.Label lblPom;

		public Panel PnlMainContainer { get => pnlMainContainer; set => pnlMainContainer = value; }
		public Label LblKorisnik { get => lblKorisnik; set => lblKorisnik = value; }
		public Label LblPom { get => lblPom; set => lblPom = value; }
	}
}
