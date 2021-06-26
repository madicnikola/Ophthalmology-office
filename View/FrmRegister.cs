using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View
{
	public partial class FrmRegister : Form
	{
		public LoginController loginController { get; set; }
		public FrmRegister(LoginController loginController)
		{
			this.loginController = loginController;
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{

			loginController.Register(txtUsername, txtPassword,txtIme,txtPrezime, this);

		}
	}
}
