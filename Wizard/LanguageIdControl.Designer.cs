using System.Windows.Forms;

namespace TestMono5Sil
{
	partial class LanguageIdControl
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
			_lookupISOControl.ReadinessChanged -= OnLookupISOControlReadinessChanged;
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
			this._lookupISOControl = new SIL.Windows.Forms.WritingSystems.LanguageLookupControl();
			this.SuspendLayout();
			// 
			// _lookupISOControl
			// 
			this._lookupISOControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this._lookupISOControl.Location = new System.Drawing.Point(3, 3);
			this._lookupISOControl.Name = "_lookupISOControl";
			this._lookupISOControl.Size = new System.Drawing.Size(560, 231);
			this._lookupISOControl.TabIndex = 11;
			this._lookupISOControl.Leave += new System.EventHandler(this._lookupISOControl_Leave);
			this._lookupISOControl.Dock = DockStyle.Fill;
			// 
			// 
			// 
			// LanguageIdControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._lookupISOControl);
			this.Name = "LanguageIdControl";
			this.Size = new System.Drawing.Size(615, 260);
			this.ResumeLayout(false);

		}

		#endregion

		private SIL.Windows.Forms.WritingSystems.LanguageLookupControl _lookupISOControl;
	}
}
