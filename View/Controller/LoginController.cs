using Domen;
using Forme.Exceptions;
using System;
using System.Net.Sockets;
using System.Windows.Forms;
using View;
using View.Communication;
using View.Helpers;

namespace Forme.Controller
{
	public class LoginController
	{
		public FrmLogin FrmLogin { get; set; }
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
				KorisnikSistema k = Communication.Instance.Login(txtUsername.Text, txtPassword.Text);
				MainCoordinator.Instance.Korisnik = k;
				MessageBox.Show($"Korisnik {k.Ime} {k.Prezime} se uspesno prijavio!");
				MainCoordinator.Instance.OpenMainForm(k);
				frmLogin.Dispose();
			}
			catch (SystemOperationException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		internal bool Connect()
		{
			try
			{
				Communication.Instance.Connect();
				return true;
			}
			catch (SocketException)
			{
				MessageBox.Show("Greska pri povezivanju sa serverom!");
				return false;
			}
		}

		internal void otvoriFrmLogin()
		{
			FrmLogin = new FrmLogin(this);
			FrmLogin.Show();
		}
	}
}
