using System.Windows.Forms;

namespace View.UserControls
{
	public partial class UCPacijenti : UserControl
	{
		public UCPacijenti()
		{
			InitializeComponent();
		}

		public DataGridView DgvPacijenti { get => dvgSviPacijenti; }


	}
}
