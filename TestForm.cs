using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMono5Sil
{
	public partial class TestForm : Form
	{
		public TestForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			var dlg = new DialogAdapters.OpenFileDialogAdapter
			{
				Multiselect = false,
				CheckFileExists = true
			};
			var result = dlg.ShowDialog();
			if (result == DialogResult.OK)
				label1.Text = dlg.FileName.Replace("\\", "/");
			else
				label1.Text = @"NO FILE SELECTED";
		}
	}
}
