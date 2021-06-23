using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.UserControls
{
	public partial class UCLekari : UserControl
	{
		public UCLekari()
		{
			InitializeComponent();
		}

		public DataGridView DgvLekari { get =>dgvSviLekari;}
	}
}
