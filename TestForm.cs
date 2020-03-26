using System;
using System.Windows.Forms;

namespace TestMono5Sil
{
	public partial class TestForm : Form
	{
		public TestForm()
		{
			InitializeComponent();
		}

		private void _fileChooserButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				using (var dlg = new DialogAdapters.OpenFileDialogAdapter
				{
					Multiselect = false,
					CheckFileExists = true
				})
				{
					var result = dlg.ShowDialog();
					if (result == DialogResult.OK)
						_fileChosenLabel.Text = @"SELECTED FILE = " + dlg.FileName.Replace("\\", "/");
					else
						_fileChosenLabel.Text = @"NO FILE SELECTED";
				}
			}
			catch (Exception ex)
			{
				_fileChosenLabel.Text = @"CRASH! " + ex.Message;
				Console.WriteLine("CRASH: {0}", ex.Message);
				Console.WriteLine(ex.StackTrace);
			}
		}

		private void _wizardButton_Click(object sender, EventArgs e)
		{
			try
			{
				using (var dlg = new TestWizard(false))
				{
					var result = dlg.ShowDialog();
					if (result == DialogResult.OK)
					{
						var collection = dlg.GetNewCollectionSettings();
						_wizardOutputLabel.Text = String.Format("Wizard set project = {0}", collection.CollectionName);
					}
					else
					{
						_wizardOutputLabel.Text = @"WIZARD CANCELLED";
					}
				}
			}
			catch (Exception ex)
			{
				_wizardOutputLabel.Text = @"CRASH! " + ex.Message;
				Console.WriteLine("CRASH: {0}", ex.Message);
				Console.WriteLine(ex.StackTrace);
			}
		}
	}
}
