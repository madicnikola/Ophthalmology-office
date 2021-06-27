using Domen;
using System;
using System.Net.Sockets;
using System.Windows.Forms;
using View.Helpers;

namespace View.Controller
{
	public class LoginController
	{
		public FrmLogin FrmLogin { get; set; }
		public FrmRegister FrmRegister { get; set; }
		internal void Login(TextBox txtUsername, TextBox txtPassword, FrmLogin frmLogin)
		{
			if (!UserControlHelpers.
				EmptyFieldValidation(txtUsername)
				| !UserControlHelpers.EmptyFieldValidation(txtPassword))
			{
				return;
			}
			try
			{
				KorisnikSistema k = Communication.Communication.Instance.Login(txtUsername.Text, txtPassword.Text);
				MainCoordinator.Instance.Korisnik = k;
				if(k == null)
				{
					throw new Exception("Sistem ne može da nađe korisnika na osnovu unetih vrednosti");
				}
				MessageBox.Show($"Korisnik {k.Ime} {k.Prezime} se uspesno prijavio!");
				MainCoordinator.Instance.OpenMainForm(k);
				frmLogin.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		internal void Register(TextBox txtUsername, TextBox txtPassword,TextBox txtIme ,TextBox txtPrezime,FrmRegister frmLogin)
		{
			if (Connect())
			if (!UserControlHelpers.
				EmptyFieldValidation(txtUsername)
				| !UserControlHelpers.EmptyFieldValidation(txtPassword))
			{
				return;
			}
			try
			{
				KorisnikSistema k = Communication.Communication.Instance.Register(txtIme.Text,txtPrezime.Text,txtUsername.Text, txtPassword.Text);
				MainCoordinator.Instance.Korisnik = k;
				if(k == null)
				{
					throw new Exception("Sistem ne može da zapamti novog korisnika");
				}
				MessageBox.Show($"Korisnik {k.Ime} {k.Prezime} se uspesno registrovao!");
				MainCoordinator.Instance.OpenLoginForm(txtUsername.Text, txtPassword.Text);
				frmLogin.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		internal bool Connect()
		{
			try
			{
				Communication.Communication.Instance.Connect();
				return true;
			}
			catch (SocketException)
			{
				MessageBox.Show("Greska pri povezivanju sa serverom!");
				return false;
			}
		}

		internal void otvoriFrmRegister()
		{
				
				FrmRegister = new FrmRegister(this);
				FrmLogin.Dispose();
				FrmRegister.Show();
			
		}

		internal void otvoriFrmLogin(string username,string password)
		{
			FrmLogin = new FrmLogin(this);
			FrmLogin.TxtUsername.Text = username;
			FrmLogin.TxtPassword.Text = password;
			FrmLogin.Show();
		}
	}
}
