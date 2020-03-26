using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Gecko;
using SIL.Extensions;
using SIL.Windows.Forms.HtmlBrowser;

namespace TestMono5Sil
{
	public partial class TestWizard : Form
	{
		public Action UiLanguageChanged;

		private NewCollectionSettings _collectionInfo;

		public static string CreateNewCollection(Action uiLanguageChangedAction)
		{
			bool showTestWizard = false;
			using (var dlg = new TestWizard(showTestWizard))
			{
				dlg.UiLanguageChanged = uiLanguageChangedAction;
				dlg.ShowInTaskbar = showTestWizard;//if we're at this stage, there isn't a bloom icon there already.
				if (DialogResult.OK != dlg.ShowDialog())
				{
					return null;
				}
				//review: this is a bit weird... we clone it instead of just using it just because this code path
				//can handle creating the path from scratch
				return new CollectionSettings(dlg.GetNewCollectionSettings()).SettingsFilePath;
			}
		}

		public static string DefaultParentDirectoryForCollections
		{
			get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Bloom"); }
		}

		public TestWizard()
		{
			SetUpXulRunner();
			XWebBrowser.DefaultBrowserType = XWebBrowser.BrowserType.GeckoFx;
		}

		public TestWizard(bool showWelcome) : this()
		{
			InitializeComponent();

			if (ReallyDesignMode)
				return;

			_collectionInfo = new NewCollectionSettings();
			_kindOfCollectionPage.Tag = kindOfCollectionControl1;
			kindOfCollectionControl1.Init(SetNextButtonState, _collectionInfo);

			_languageLocationPage.Tag = _languageLocationControl;
			_languageLocationControl.Init(_collectionInfo);

			_collectionNamePage.Tag = _collectionNameControl;
			_collectionNameControl.Init(SetNextButtonState, _collectionInfo, DefaultParentDirectoryForCollections);

			_vernacularLanguagePage.Tag = _vernacularLanguageIdControl;
			_vernacularLanguageIdControl.Init(SetNextButtonState, _collectionInfo);

			_welcomePage.Suppress = !showWelcome;

			SetLocalizedStrings();

			_wizardControl.AfterInitialization();
		}

		public void ChangeLocalization()
		{
			SetLocalizedStrings();
			if (UiLanguageChanged != null)
				UiLanguageChanged();
		}

		private void SetLocalizedStrings()
		{
			Text = "Create New Bloom Collection";
			_welcomePage.Text = "Welcome To Bloom!";
			_kindOfCollectionPage.Text = "Choose the collection type.";
			_collectionNamePage.Text = "Project Name";
			_collectionNameProblemPage.Text = "Collection Name Problem";
			_languageLocationPage.Text = "Give Language Location";
			_languageFontPage.Text = "Font and Script";
			_vernacularLanguagePage.Text = "Choose the main language for this collection.";
			_finishPage.Text = "Ready To Create New Collection";
			_wizardControl.NextButtonText = "&Next";
			_wizardControl.FinishButtonText = "&Finish";
			_wizardControl.UpdateNextAndFinishButtonText();
			_wizardControl.CancelButtonText = "&Cancel";

			var one = "You are almost ready to start making books.";
			var two = "In order to keep things simple and organized, Bloom keeps all the books you make in one or more <i>Collections</i>. The first thing we need to do is make one for you.";
			var three = "Click 'Next' to get started.";
			_welcomeHtml.HTML = one + "<br/>" + two + "<br/>" + three;
		}

		protected bool ReallyDesignMode
		{
			get
			{
				return (base.DesignMode || GetService(typeof(IDesignerHost)) != null) ||
					(LicenseManager.UsageMode == LicenseUsageMode.Designtime);
			}
		}

		public void SetNextButtonState(UserControl caller, bool enabled)
		{
			_wizardControl.SelectedPage.AllowNext = enabled;

			if (caller is KindOfCollectionControl)
			{
				_kindOfCollectionPage.NextPage = _collectionInfo.IsSourceCollection
													? _collectionNamePage
													: _vernacularLanguagePage;

				if(_collectionInfo.IsSourceCollection)
				{
					_collectionInfo.Language1.Iso639Code = "en";
				}
			}

			if (caller is LanguageIdControl)
			{
				var pattern = "{0} Books";
				// GetPathForNewSettings uses Path.Combine which can fail with certain characters that are illegal in paths, but not in language names.
				// The characters we ran into were two pipe characters ("|") at the front of the language name.
				var tentativeCollectionName = string.Format(pattern, _collectionInfo.Language1.Name);
				var sanitizedCollectionName = tentativeCollectionName.SanitizePath('.');
				_collectionInfo.PathToSettingsFile = CollectionSettings.GetPathForNewSettings(DefaultParentDirectoryForCollections, sanitizedCollectionName);

				// An earlier version went direct to finish if the proposed name was OK (unless DefaultCollectionPathWouldHaveProblems || (tentativeCollectionName != sanitizedCollectionName))
				// but per BL-2649 we now want to always let the user check the name.
				_languageLocationPage.NextPage = _collectionNamePage;
			}
		}

		private bool DefaultCollectionPathWouldHaveProblems
		{
			get
			{
				try
				{
					return Path.GetFileName(_collectionInfo.PathToSettingsFile).IndexOfAny(Path.GetInvalidFileNameChars()) > -1
						|| Directory.Exists(_collectionInfo.PathToSettingsFile)
						|| File.Exists(_collectionInfo.PathToSettingsFile);
				}
				catch (Exception)
				{
					return true;
				}
			}
		}

		public NewCollectionSettings GetNewCollectionSettings()
		{
			return _collectionInfo;
		}

		private void OnSelectedPageChanged(object sender, EventArgs e)
		{
			IPageControl control = _wizardControl.SelectedPage.Tag as IPageControl;
			if(control!=null)
				control.NowVisible();
		}

		private void OnFinish(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;

			// Collect the data from the Font and Script page.
			_collectionInfo.Language1.FontName = _fontDetails.SelectedFont;
			// refactoring note: this is not needed, this will be set to zero by default:_collectionInfo.Language1LineHeight = new decimal(0);
			if (_fontDetails.ExtraLineHeight)
			{
				// The LineHeight settings from the LanguageFontDetails control are in the current culture,
				// so we don't need to specify a culture in the TryParse.
				double height;
				if (double.TryParse(_fontDetails.LineHeight, out height))
					_collectionInfo.Language1.LineHeight = new decimal(height);
			}
			_collectionInfo.Language1.IsRightToLeft = _fontDetails.RightToLeft;
			_collectionInfo.Language1.BreaksLinesOnlyAtSpaces = false;

			//this both saves a step for the country with the most languages, but also helps get the order between en and tpi to what will be most useful
			if (_collectionInfo.Country == "Papua New Guinea")
			{
				_collectionInfo.Language2.Iso639Code = "en";
				_collectionInfo.Language3.Iso639Code = "tpi";
			}

			Close();
		}

		private void OnCancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
			_collectionInfo = null;
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Escape)
			{
				OnCancel(this, null);
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void _languageLocationControl_Load(object sender, EventArgs e)
		{

		}

		private void _finishPage_Initialize(object sender, EventArgs e)
		{
			var pattern = 
				"OK, that's all we need to get started with your new '{0}' collection.\r\nClick on the 'Finish' button.";
			betterLabel1.Text = String.Format(pattern, Path.GetFileNameWithoutExtension(_collectionInfo.PathToSettingsFile));
		}

		public static void SetUpXulRunner()
		{
			if (Xpcom.IsInitialized)
				return;
			string xulRunnerPath = Environment.GetEnvironmentVariable("XULRUNNER");
			if (String.IsNullOrEmpty(xulRunnerPath) || !Directory.Exists(xulRunnerPath))
			{
				var asm = Assembly.GetExecutingAssembly();
				var file = asm.CodeBase.Replace("file://", String.Empty);
				if (SIL.PlatformUtilities.Platform.IsWindows)
					file = file.TrimStart('/');
				var folder = Path.GetDirectoryName(file);
				xulRunnerPath = Path.Combine(folder, "Firefox");
			}
			Xpcom.Initialize(xulRunnerPath);

			GeckoPreferences.User["network.proxy.http"] = string.Empty;
			GeckoPreferences.User["network.proxy.http_port"] = 80;
			GeckoPreferences.User["network.proxy.type"] = 1; // 0 = direct (uses system settings on Windows), 1 = manual configuration
			GeckoPreferences.User["memory.free_dirty_pages"] = true;
			GeckoPreferences.User["browser.sessionhistory.max_entries"] = 1;
			GeckoPreferences.User["browser.sessionhistory.max_total_viewers"] = 0;
			GeckoPreferences.User["browser.cache.memory.enable"] = false;
			GeckoPreferences.User["image.mem.max_decoded_image_kb"] = 40960;        // 40MB (default = 256000 == 250MB)
			GeckoPreferences.User["javascript.options.mem.max"] = 40960;            // 40MB (default = -1 == automatic)
			GeckoPreferences.User["javascript.options.mem.high_water_mark"] = 20;   // 20MB (default = 128 == 128MB)
			GeckoPreferences.User["image.mem.surfacecache.max_size_kb"] = 102400;   // 100MB
			GeckoPreferences.User["image.mem.surfacecache.min_expiration_ms"] = 500;    // 500ms (default = 60000 == 60sec)
			GeckoPreferences.User["browser.cache.memory.capacity"] = 0;             // 0 disables feature
			GeckoPreferences.User["network.http.max-persistent-connections-per-server"] = 200;
			GeckoPreferences.User["network.http.pipelining.maxrequests"] = 200;
			GeckoPreferences.User["network.http.pipelining.max-optimistic-requests"] = 200;
			GeckoPreferences.User["gfx.font_rendering.graphite.enabled"] = true;
			GeckoPreferences.User["mousewheel.with_control.action"] = 0;
			GeckoPreferences.User["media.navigator.enabled"] = true;
			GeckoPreferences.User["media.navigator.permission.disabled"] = true;
		}
	}

	internal interface IPageControl
	{
		void NowVisible();
	}
}
