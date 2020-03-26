namespace TestMono5Sil
{
    partial class KindOfCollectionControl
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
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KindOfCollectionControl));
			this._radioSourceCollection = new System.Windows.Forms.RadioButton();
			this._radioNormalVernacularCollection = new System.Windows.Forms.RadioButton();
			this.betterLabel1 = new System.Windows.Forms.Label();   // SIL.Windows.Forms.Widgets.BetterLabel();
			this._sourceCollectionDescription = new System.Windows.Forms.Label();   // SIL.Windows.Forms.Widgets.BetterLabel();
			this._existingCollectionDescription = new System.Windows.Forms.Label();    // SIL.Windows.Forms.Widgets.BetterLabel();
			this.SuspendLayout();
			// 
			// _radioSourceCollection
			// 
			this._radioSourceCollection.AutoSize = true;
			this._radioSourceCollection.Font = new System.Drawing.Font("Segoe UI", 14F);
			this._radioSourceCollection.Location = new System.Drawing.Point(0, 71);
			this._radioSourceCollection.Name = "_radioSourceCollection";
			this._radioSourceCollection.Size = new System.Drawing.Size(178, 29);
			this._radioSourceCollection.TabIndex = 7;
			this._radioSourceCollection.Text = "Source Collection";
			this._radioSourceCollection.UseVisualStyleBackColor = true;
			this._radioSourceCollection.CheckedChanged += new System.EventHandler(this._radioSourceCollection_CheckedChanged);
			// 
			// _radioNormalVernacularCollection
			// 
			this._radioNormalVernacularCollection.AutoSize = true;
			this._radioNormalVernacularCollection.Checked = true;
			this._radioNormalVernacularCollection.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._radioNormalVernacularCollection.Location = new System.Drawing.Point(0, 3);
			this._radioNormalVernacularCollection.Name = "_radioNormalVernacularCollection";
			this._radioNormalVernacularCollection.Size = new System.Drawing.Size(351, 29);
			this._radioNormalVernacularCollection.TabIndex = 6;
			this._radioNormalVernacularCollection.TabStop = true;
			this._radioNormalVernacularCollection.Text = "Local Language Collection";
			this._radioNormalVernacularCollection.UseVisualStyleBackColor = true;
			this._radioNormalVernacularCollection.CheckedChanged += new System.EventHandler(this._radioNormalVernacularCollection_CheckedChanged);
			// 
			// 
			// 
			// betterLabel1
			// 
			this.betterLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.betterLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.betterLabel1.Enabled = false;
			this.betterLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.betterLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.betterLabel1.Location = new System.Drawing.Point(19, 31);
			//this.betterLabel1.Multiline = true;
			this.betterLabel1.Name = "betterLabel1";
			//this.betterLabel1.ReadOnly = true;
			this.betterLabel1.Size = new System.Drawing.Size(358, 17);
			this.betterLabel1.TabIndex = 9;
			this.betterLabel1.TabStop = false;
			this.betterLabel1.Text = "A collection of books in a local language.";
			// 
			// _sourceCollectionDescription
			// 
			this._sourceCollectionDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._sourceCollectionDescription.Enabled = false;
			this._sourceCollectionDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
			this._sourceCollectionDescription.ForeColor = System.Drawing.SystemColors.ControlText;
			this._sourceCollectionDescription.Location = new System.Drawing.Point(19, 106);
			//this._sourceCollectionDescription.Multiline = true;
			this._sourceCollectionDescription.Name = "_sourceCollectionDescription";
			//this._sourceCollectionDescription.ReadOnly = true;
			this._sourceCollectionDescription.Size = new System.Drawing.Size(358, 65);
			this._sourceCollectionDescription.TabIndex = 10;
			this._sourceCollectionDescription.TabStop = false;
			this._sourceCollectionDescription.Text = resources.GetString("_sourceCollectionDescription.Text");
			// 
			// _exisitingCollectionDescription
			// 
			this._existingCollectionDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._existingCollectionDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._existingCollectionDescription.Enabled = false;
			this._existingCollectionDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
			this._existingCollectionDescription.ForeColor = System.Drawing.SystemColors.ControlText;
			this._existingCollectionDescription.Location = new System.Drawing.Point(19, 275);
			//this._existingCollectionDescription.Multiline = true;
			this._existingCollectionDescription.Name = "_exisitingCollectionDescription";
			//this._existingCollectionDescription.ReadOnly = true;
			this._existingCollectionDescription.Size = new System.Drawing.Size(358, 33);
			this._existingCollectionDescription.TabIndex = 12;
			this._existingCollectionDescription.TabStop = false;
			this._existingCollectionDescription.Text = "If you already have a collection you want to open, click  the \'Cancel\' button.";
			// 
			// KindOfCollectionControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._existingCollectionDescription);
			this.Controls.Add(this._sourceCollectionDescription);
			this.Controls.Add(this.betterLabel1);
			this.Controls.Add(this._radioSourceCollection);
			this.Controls.Add(this._radioNormalVernacularCollection);
			this.Name = "KindOfCollectionControl";
			this.Size = new System.Drawing.Size(391, 329);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		public System.Windows.Forms.RadioButton _radioSourceCollection;
        public System.Windows.Forms.RadioButton _radioNormalVernacularCollection;
		private System.Windows.Forms.Label betterLabel1;	// SIL.Windows.Forms.Widgets.BetterLabel betterLabel1;
		private System.Windows.Forms.Label _sourceCollectionDescription;	// SIL.Windows.Forms.Widgets.BetterLabel _sourceCollectionDescription;
		private System.Windows.Forms.Label _existingCollectionDescription;	// SIL.Windows.Forms.Widgets.BetterLabel _exisitingCollectionDescription;
    }
}
