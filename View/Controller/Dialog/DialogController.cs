using System.Windows.Forms;
using View.Dialogs;

namespace View.Controller
{
	public class DialogController
	{
		FrmDialog frmDialog;
		UserControl userControl;

		MainController mainController;

		public DialogController(MainController mainController)
		{
			this.mainController = mainController;
		}

		public void openDialog(UserControl userControl)
		{
			this.userControl = userControl;
			frmDialog = new FrmDialog(this);
			frmDialog.SetPanel(userControl);
			frmDialog.ShowDialog(mainController.FrmMain);
		}
		internal void CloseDialog()
		{
			userControl.Dispose();
			frmDialog.Dispose();
		}
	}
}