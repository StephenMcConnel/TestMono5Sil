using System.Windows.Forms;

namespace TestMono5Sil
{
	public partial class LanguageLocationControl : UserControl, IPageControl
	{
		private NewCollectionSettings _collectionInfo;

		public LanguageLocationControl()
		{
			InitializeComponent();
		}

		public void NowVisible()
		{
			_countryText.Text = _collectionInfo.Country;
		}

		public void Init(NewCollectionSettings collectionInfo)
		{
			_collectionInfo = collectionInfo;
		}

		private void LanguageLocationControl_Leave(object sender, System.EventArgs e)
		{
			_collectionInfo.Country = _countryText.Text.Trim();
			_collectionInfo.Province = _provinceText.Text.Trim();
			_collectionInfo.District = _districtText.Text.Trim();
		}
	}
}
