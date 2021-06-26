	using View.Controller;
using System;
using System.Windows.Forms;

namespace View
{
	public partial class FrmLogin : Form
    {
        public LoginController loginController;

        public FrmLogin()
        {
            InitializeComponent();
            txtUsername.Text = "Pera";
            txtPassword.Text = "Pera";

        }

        public FrmLogin(LoginController loginController):this()
        {
			this.loginController = loginController;

		}

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            if(loginController.Connect())
            loginController.Login(txtUsername, txtPassword, this);
            
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MainCoordinator.Instance.OpenRegisterForm();
		}
	}
}
