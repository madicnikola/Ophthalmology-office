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
			this.txtJmbgPretraga = new System.Windows.Forms.TextBox();
			this.btnObrisi = new System.Windows.Forms.Button();
			this.gbPregledi = new System.Windows.Forms.GroupBox();
			this.dgvSviPregledi = new System.Windows.Forms.DataGridView();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.gbPregledi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSviPregledi)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOcisti
			// 
			this.btnOcisti.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOcisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOcisti.Location = new System.Drawing.Point(492, 89);
			this.btnOcisti.Name = "btnOcisti";
			this.btnOcisti.Size = new System.Drawing.Size(105, 24);
			this.btnOcisti.TabIndex = 79;
			this.btnOcisti.Text = "Ocisti";
			this.btnOcisti.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(118, 156);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 18);
			this.label6.TabIndex = 77;
			this.label6.Text = "Datum:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(94, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 18);
			this.label5.TabIndex = 76;
			this.label5.Text = "Pregled ID:";
			// 
			// btnPretrazi
			// 
			this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPretrazi.Location = new System.Drawing.Point(492, 129);
			this.btnPretrazi.Name = "btnPretrazi";
			this.btnPretrazi.Size = new System.Drawing.Size(105, 51);
			this.btnPretrazi.TabIndex = 73;
			this.btnPretrazi.Text = "Pretrazi";
			this.btnPretrazi.UseVisualStyleBackColor = true;
			// 
			// txtJmbgPretraga
			// 
			this.txtJmbgPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJmbgPretraga.Location = new System.Drawing.Point(183, 89);
			this.txtJmbgPretraga.Name = "txtJmbgPretraga";
			this.txtJmbgPretraga.Size = new System.Drawing.Size(286, 24);
			this.txtJmbgPretraga.TabIndex = 72;
			// 
			// btnObrisi
			// 
			this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisi.Location = new System.Drawing.Point(315, 385);
			this.btnObrisi.Name = "btnObrisi";
			this.btnObrisi.Size = new System.Drawing.Size(171, 35);
			this.btnObrisi.TabIndex = 71;
			this.btnObrisi.Text = "Obrisi izabrane";
			this.btnObrisi.UseVisualStyleBackColor = true;
			// 
			// gbPregledi
			// 
			this.gbPregledi.Controls.Add(this.dgvSviPregledi);
			this.gbPregledi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbPregledi.Location = new System.Drawing.Point(3, 183);
			this.gbPregledi.Name = "gbPregledi";
			this.gbPregledi.Size = new System.Drawing.Size(794, 196);
			this.gbPregledi.TabIndex = 70;
			this.gbPregledi.TabStop = false;
			this.gbPregledi.Text = "Pregledi";
			// 
			// dgvSviPregledi
			// 
			this.dgvSviPregledi.AllowUserToAddRows = false;
			this.dgvSviPregledi.AllowUserToDeleteRows = false;
			this.dgvSviPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSviPregledi.Location = new System.Drawing.Point(7, 24);
			this.dgvSviPregledi.Name = "dgvSviPregledi";
			this.dgvSviPregledi.ReadOnly = true;
			this.dgvSviPregledi.Size = new System.Drawing.Size(781, 165);
			this.dgvSviPregledi.TabIndex = 0;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
			this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(183, 152);
			this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePicker.MaxDate = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(286, 26);
			this.dateTimePicker.TabIndex = 80;
			this.dateTimePicker.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			// 
			// UCPregledi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.btnOcisti);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnPretrazi);
			this.Controls.Add(this.txtJmbgPretraga);
			this.Controls.Add(this.btnObrisi);
			this.Controls.Add(this.gbPregledi);
			this.Name = "UCPregledi";
			this.Size = new System.Drawing.Size(800, 505);
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
		private System.Windows.Forms.TextBox txtJmbgPretraga;
		private System.Windows.Forms.Button btnObrisi;
		private System.Windows.Forms.GroupBox gbPregledi;
		private System.Windows.Forms.DataGridView dgvSviPregledi;
		private System.Windows.Forms.DateTimePicker dateTimePicker;

		public Button BtnOcisti { get => btnOcisti; set => btnOcisti = value; }
		public Label Label6 { get => label6; set => label6 = value; }
		public Label Label5 { get => label5; set => label5 = value; }
		public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
		public TextBox TxtJmbgPretraga { get => txtJmbgPretraga; set => txtJmbgPretraga = value; }
		public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
		public GroupBox GbPregledi { get => gbPregledi; set => gbPregledi = value; }
		public DataGridView DgvSviPregledi { get => dgvSviPregledi; set => dgvSviPregledi = value; }
		public DateTimePicker DateTimePicker { get => dateTimePicker; set => dateTimePicker = value; }
	}
}
