namespace View
{
	partial class FrmRegister
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnRegister = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIme = new System.Windows.Forms.TextBox();
			this.lblIme = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRegister
			// 
			this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegister.Location = new System.Drawing.Point(104, 155);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(278, 28);
			this.btnRegister.TabIndex = 5;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPassword.Location = new System.Drawing.Point(182, 125);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(200, 22);
			this.txtPassword.TabIndex = 4;
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUsername.Location = new System.Drawing.Point(181, 93);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(200, 22);
			this.txtUsername.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(105, 128);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(101, 93);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Username";
			// 
			// txtPrezime
			// 
			this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPrezime.Location = new System.Drawing.Point(181, 63);
			this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(200, 22);
			this.txtPrezime.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(114, 63);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Prezime";
			// 
			// txtIme
			// 
			this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtIme.Location = new System.Drawing.Point(181, 33);
			this.txtIme.Margin = new System.Windows.Forms.Padding(4);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(200, 22);
			this.txtIme.TabIndex = 1;
			// 
			// lblIme
			// 
			this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblIme.AutoSize = true;
			this.lblIme.Location = new System.Drawing.Point(139, 33);
			this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIme.Name = "lblIme";
			this.lblIme.Size = new System.Drawing.Size(30, 17);
			this.lblIme.TabIndex = 12;
			this.lblIme.Text = "Ime";
			// 
			// FrmRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 255);
			this.Controls.Add(this.txtIme);
			this.Controls.Add(this.lblIme);
			this.Controls.Add(this.txtPrezime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmRegister";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registracija";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPrezime;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIme;
		private System.Windows.Forms.Label lblIme;
	}
}