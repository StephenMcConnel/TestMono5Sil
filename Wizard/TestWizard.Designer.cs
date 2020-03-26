using System.Windows.Forms;

namespace TestMono5Sil
{
	partial class TestWizard
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			if (disposing)
				_wizardControl.Dispose();
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestWizard));
			this._wizardControl = new TestMono5Sil.WizardAdapterControl();
            this._welcomePage = new TestMono5Sil.WizardAdapterPage();
            this._kindOfCollectionPage = new TestMono5Sil.WizardAdapterPage();
            this._vernacularLanguagePage = new TestMono5Sil.WizardAdapterPage();
            this._languageLocationPage = new TestMono5Sil.WizardAdapterPage();
			this._languageFontPage = new TestMono5Sil.WizardAdapterPage();
            this._finishPage = new TestMono5Sil.WizardAdapterPage();
			this.betterLabel1 = new SIL.Windows.Forms.Widgets.BetterLabel();
            this._collectionNamePage = new TestMono5Sil.WizardAdapterPage();
            this._collectionNameProblemPage = new TestMono5Sil.WizardAdapterPage();
			this._welcomeHtml = new SIL.Windows.Forms.Widgets.HtmlLabel();
			this.kindOfCollectionControl1 = new TestMono5Sil.KindOfCollectionControl();
			this._vernacularLanguageIdControl = new TestMono5Sil.LanguageIdControl();
			this._fontDetails = new TestMono5Sil.LanguageFontDetails();
			this._languageLocationControl = new TestMono5Sil.LanguageLocationControl();
			this._collectionNameControl = new TestMono5Sil.CollectionNameControl();
			((System.ComponentModel.ISupportInitialize)(this._wizardControl)).BeginInit();
			this._welcomePage.SuspendLayout();
			this._kindOfCollectionPage.SuspendLayout();
			this._vernacularLanguagePage.SuspendLayout();
			this._languageLocationPage.SuspendLayout();
			this._languageFontPage.SuspendLayout();
			this._finishPage.SuspendLayout();
			this._collectionNamePage.SuspendLayout();
			this.SuspendLayout();
			//
			// _wizardControl
			//
			this._wizardControl.Location = new System.Drawing.Point(0, 0);
			this._wizardControl.Name = "_wizardControl";
			this._wizardControl.Pages.Add(this._welcomePage);
			this._wizardControl.Pages.Add(this._kindOfCollectionPage);
			this._wizardControl.Pages.Add(this._vernacularLanguagePage);
			this._wizardControl.Pages.Add(this._languageLocationPage);
			this._wizardControl.Pages.Add(this._languageFontPage);
			this._wizardControl.Pages.Add(this._collectionNamePage);
			this._wizardControl.Pages.Add(this._finishPage);
			this._wizardControl.Pages.Add(this._collectionNameProblemPage);
			this._wizardControl.Size = new System.Drawing.Size(759, 464);
			this._wizardControl.TabIndex = 0;
			this._wizardControl.Title = "Create New Bloom Collection";
			this._wizardControl.TitleIcon = ((System.Drawing.Icon)(resources.GetObject("_wizardControl.TitleIcon")));
			this._wizardControl.Cancelled += new System.EventHandler(this.OnCancel);
			this._wizardControl.Finished += new System.EventHandler(this.OnFinish);
			this._wizardControl.SelectedPageChanged += new System.EventHandler(this.OnSelectedPageChanged);
			//
			// _welcomePage
			//
			this._welcomePage.Controls.Add(this._welcomeHtml);
			this._welcomePage.Name = "_welcomePage";
			this._welcomePage.Size = new System.Drawing.Size(846, 309);
			this._welcomePage.TabIndex = 6;
			this._welcomePage.Text = "Welcome To Bloom!";
			//
			// _kindOfCollectionPage
			//
			this._kindOfCollectionPage.Controls.Add(this.kindOfCollectionControl1);
			this._kindOfCollectionPage.Name = "_kindOfCollectionPage";
			this._kindOfCollectionPage.NextPage = this._vernacularLanguagePage;
			this._kindOfCollectionPage.Size = new System.Drawing.Size(702, 310);
			this._kindOfCollectionPage.TabIndex = 0;
			this._kindOfCollectionPage.Text = "Choose the collection type.";
			//
			// _vernacularLanguagePage
			//
			this._vernacularLanguagePage.Controls.Add(this._vernacularLanguageIdControl);
			this._vernacularLanguagePage.Name = "_vernacularLanguagePage";
			this._vernacularLanguagePage.NextPage = this._languageFontPage;
			this._vernacularLanguagePage.Size = new System.Drawing.Size(712, 309);
			this._vernacularLanguagePage.TabIndex = 1;
			this._vernacularLanguagePage.Text = "Choose the main language for this collection.";
			//
			// _languageFontPage
			//
			this._languageFontPage.Controls.Add(this._fontDetails);
			this._languageFontPage.Name = "_languageFontPage";
			this._languageFontPage.NextPage = this._languageLocationPage;
			this._languageFontPage.Size = new System.Drawing.Size(637, 310);
			this._languageFontPage.TabIndex = 7;
			this._languageFontPage.Text = "Font and Script";
			//
			// _languageLocationPage
			//
			this._languageLocationPage.Controls.Add(this._languageLocationControl);
			this._languageLocationPage.Name = "_languageLocationPage";
			this._languageLocationPage.NextPage = this._finishPage;
			this._languageLocationPage.Size = new System.Drawing.Size(637, 310);
			this._languageLocationPage.TabIndex = 5;
			this._languageLocationPage.Text = "Give Language Location";
			//
			// _finishPage
			//
			this._finishPage.Controls.Add(this.betterLabel1);
			this._finishPage.IsFinishPage = true;
			this._finishPage.Name = "_finishPage";
			this._finishPage.Size = new System.Drawing.Size(637, 310);
			this._finishPage.TabIndex = 3;
			this._finishPage.Text = "Ready To Create New Collection";
			this._finishPage.Initialize += this._finishPage_Initialize;
			//
			// betterLabel1
			//
			this.betterLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
			this.betterLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.betterLabel1.Enabled = false;
			this.betterLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.betterLabel1.Location = new System.Drawing.Point(120, 60);
			this.betterLabel1.Multiline = true;
			this.betterLabel1.Name = "betterLabel1";
			this.betterLabel1.ReadOnly = true;
			this.betterLabel1.Size = new System.Drawing.Size(631, 23);
			this.betterLabel1.TabIndex = 0;
			this.betterLabel1.TabStop = false;
			this.betterLabel1.Text = "<Text>";
			//
			// _collectionNamePage
			//
			this._collectionNamePage.Controls.Add(this._collectionNameControl);
			this._collectionNamePage.Name = "_collectionNamePage";
			this._collectionNamePage.NextPage = this._finishPage;
			this._collectionNamePage.Size = new System.Drawing.Size(637, 310);
			this._collectionNamePage.TabIndex = 2;
			this._collectionNamePage.Text = "Project Name";
			//
			// _collectionNameProblemPage
			//
			this._collectionNameProblemPage.Name = "_collectionNameProblemPage";
			this._collectionNameProblemPage.NextPage = this._finishPage;
			this._collectionNameProblemPage.Size = new System.Drawing.Size(637, 310);
			this._collectionNameProblemPage.TabIndex = 4;
			this._collectionNameProblemPage.Text = "Collection Name Problem";
			//
			// _welcomeHtml
			//
			this._welcomeHtml.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._welcomeHtml.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._welcomeHtml.HTML = "hi there";
			this._welcomeHtml.Location = new System.Drawing.Point(0, 0);
			this._welcomeHtml.Margin = new System.Windows.Forms.Padding(0);
			this._welcomeHtml.Name = "_welcomeHtml";
			this._welcomeHtml.Size = new System.Drawing.Size(637, 310);
			this._welcomeHtml.TabIndex = 1;
			//
			// kindOfCollectionControl1
			//
			this.kindOfCollectionControl1.Location = new System.Drawing.Point(0, 3);
			this.kindOfCollectionControl1.Name = "kindOfCollectionControl1";
			this.kindOfCollectionControl1.Size = new System.Drawing.Size(608, 278);
			this.kindOfCollectionControl1.TabIndex = 0;
			//
			// _vernacularLanguageIdControl
			//
			this._vernacularLanguageIdControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
			this._vernacularLanguageIdControl.Location = new System.Drawing.Point(0, 3);
			this._vernacularLanguageIdControl.Name = "_vernacularLanguageIdControl";
			this._vernacularLanguageIdControl.Size = new System.Drawing.Size(656, 267);
			this._vernacularLanguageIdControl.TabIndex = 0;
			//
			// _languageLocationControl
			//
			this._languageLocationControl.BackColor = System.Drawing.Color.White;
			this._languageLocationControl.Location = new System.Drawing.Point(0, 0);
			this._languageLocationControl.Name = "_languageLocationControl";
			this._languageLocationControl.Size = new System.Drawing.Size(615, 310);
			this._languageLocationControl.TabIndex = 0;
			this._languageLocationControl.Load += new System.EventHandler(this._languageLocationControl_Load);
			//
			// _collectionNameControl
			//
			this._collectionNameControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
			this._collectionNameControl.Location = new System.Drawing.Point(120, 60);
			this._collectionNameControl.Name = "_collectionNameControl";
			this._collectionNameControl.Size = new System.Drawing.Size(619, 307);
			this._collectionNameControl.TabIndex = 0;
			//
			// TestWizard
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(759, 464);
			this.ControlBox = true;
			this.Controls.Add(this._wizardControl);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TestWizard";
			this.ShowIcon = true;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			((System.ComponentModel.ISupportInitialize)(this._wizardControl)).EndInit();
			this._welcomePage.ResumeLayout(false);
			this._kindOfCollectionPage.ResumeLayout(false);
			this._vernacularLanguagePage.ResumeLayout(false);
			this._languageLocationPage.ResumeLayout(false);
			this._finishPage.ResumeLayout(false);
			this._finishPage.PerformLayout();
			this._collectionNamePage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

        private TestMono5Sil.WizardAdapterControl _wizardControl;
        private TestMono5Sil.WizardAdapterPage _kindOfCollectionPage;
		private KindOfCollectionControl kindOfCollectionControl1;
        private TestMono5Sil.WizardAdapterPage _vernacularLanguagePage;
		private LanguageIdControl _vernacularLanguageIdControl;
        private TestMono5Sil.WizardAdapterPage _collectionNamePage;
		private CollectionNameControl _collectionNameControl;
        private TestMono5Sil.WizardAdapterPage _finishPage;
        private TestMono5Sil.WizardAdapterPage _collectionNameProblemPage;
        private TestMono5Sil.WizardAdapterPage _languageLocationPage;
		private TestMono5Sil.WizardAdapterPage _languageFontPage;
		private TestMono5Sil.LanguageFontDetails _fontDetails;
		private LanguageLocationControl _languageLocationControl;
		private SIL.Windows.Forms.Widgets.BetterLabel betterLabel1;
        private TestMono5Sil.WizardAdapterPage _welcomePage;
		private SIL.Windows.Forms.Widgets.HtmlLabel _welcomeHtml;
	}
}
