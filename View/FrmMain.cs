using System;
using System.Windows.Forms;

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

        private void AddNewmanufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCManufacturer(this);
        }

        private void EditProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // SetPanel(new UCUser(mainController));
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Environment.Exit(0);
            mainController.CloseMainForm();
           
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCProduct(this);
        }

        private void manufacturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAllManufacturers(this);
            
        }

        public void SetPanel(UserControl userControl)
        {
            pnlMainContainer.Controls.Clear();
            userControl.Parent = pnlMainContainer;
            userControl.Dock = DockStyle.Fill;
        }

        private void dGVManufacturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCDataGridViewManufacturer(this);
        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAddInvoice(this);
            
        }

	}
}
