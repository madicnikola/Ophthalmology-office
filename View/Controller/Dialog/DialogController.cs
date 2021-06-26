using System;
using System.Windows.Forms;
using View.Dialogs;
using View.UserControls.mode;

namespace View.Controller
{
	public class DialogController
	{
		FrmDialog frmDialog;

		MainController mainController;

		public DialogController(MainController mainController)
		{
			this.mainController = mainController;
		}

		public void openDialog(UserControl userControl)
		{
			frmDialog = new FrmDialog(this);
			frmDialog.Show();
			frmDialog.SetPanel(userControl);
		}
		internal void CloseDialog()
		{
			frmDialog.Dispose();
		}
	}
}