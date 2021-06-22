	using Forme.Controller;
using System;
using System.Windows.Forms;

namespace View
{
	public partial class FrmLogin : Form
    {
        public LoginController loginController;

        // private ControllerBL.Controller kontroler;
        public FrmLogin()
        {
            // kontroler = new ControllerBL.Controller();
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
    }
}
