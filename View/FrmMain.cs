using View.UserControls.mode;
using System;
using System.Windows.Forms;
using View.Controller;

namespace View
{
	public partial class FrmMain : Form
	{
		private readonly MainController mainController;

		public FrmMain(MainController mainController)
		{
			InitializeComponent();
			this.mainController = mainController;
		}

		private void AddNewPacijentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			mainController.openUCPacijent(this, UCMode.ADD);
		}

		private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			//Environment.Exit(0);
			mainController.CloseMainForm();

		}

		private void mnItemPretragaPacijenata_Click(object sender, EventArgs e)
		{
			mainController.OpenUCAllPacients(this, UCMode.VIEW);
		}

		private void mnItemIzmeniPacijenta_Click(object sender, EventArgs e)
		{
			mainController.OpenUCAllPacients(this, UCMode.UPDATE);

		}

		private void mnItemObrisiPacijenta_Click(object sender, EventArgs e)
		{
			mainController.OpenUCAllPacients(this, UCMode.VIEW);

		}

		public void SetPanel(UserControl userControl)
		{
			pnlMainContainer.Controls.Clear();
			userControl.Parent = pnlMainContainer;
			userControl.Dock = DockStyle.Fill;
		}

		private void mnItemUnesiNoviPregled_Click(object sender, EventArgs e)
		{
			mainController.OpenUCPregled(this, UCMode.ADD);

		}

		private void mnItemPretragePregleda_Click(object sender, EventArgs e)
		{
			mainController.OpenUCPregledi(this, UCMode.VIEW);

		}

		private void mnItemObrisiPregled_Click(object sender, EventArgs e)
		{
			mainController.OpenUCPregledi(this, UCMode.VIEW);
		}
		private void mnItemKreirajLekara_Click(object sender, EventArgs e)
		{
			mainController.OpenUCLekar(this, UCMode.ADD);

		}

		private void mnItemPretregaLekara_Click(object sender, EventArgs e)
		{
			mainController.OpenUCLekari(this, UCMode.VIEW);
		}

		private void mnItemIzmeniLekara_Click(object sender, EventArgs e)
		{
			mainController.OpenUCLekari(this, UCMode.VIEW);
		}
		private void mnItemObrisiLekara_Click(object sender, EventArgs e)
		{
			mainController.OpenUCLekari(this, UCMode.VIEW);

		}

		private void izmeniToolStripMenuItem_Click(object sender, EventArgs e)
		{
			mainController.OpenUCPregledi(this, UCMode.VIEW);

		}
	}
}
