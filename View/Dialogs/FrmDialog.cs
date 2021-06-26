using System.Windows.Forms;
using View.Controller;

namespace View.Dialogs
{
	public partial class FrmDialog : Form
	{
		private DialogController dialogController;
		public FrmDialog(DialogController dialogController)
		{
			InitializeComponent();
			this.dialogController = dialogController;
		}

		public void SetPanel(UserControl userControl)
		{
			pnlMainContainer.Controls.Clear();
			userControl.Parent = pnlMainContainer;
			userControl.Dock = DockStyle.Fill;
		}
		private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			//Environment.Exit(0);
			dialogController.CloseDialog();

		}
	}
}
