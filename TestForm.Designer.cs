using System;

namespace TestMono5Sil
{
	partial class TestForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button _fileChooserButton;
		private System.Windows.Forms.Label _fileChosenLabel;
		private System.Windows.Forms.Button _wizardButton;
		private System.Windows.Forms.Label _wizardOutputLabel;

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._fileChooserButton = new System.Windows.Forms.Button();
			this._fileChosenLabel = new System.Windows.Forms.Label();
			this._wizardButton = new System.Windows.Forms.Button();
			this._wizardOutputLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this._fileChooserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._fileChooserButton.Location = new System.Drawing.Point(9, 9);
			this._fileChooserButton.Name = "button1";
			this._fileChooserButton.Size = new System.Drawing.Size(120, 23);
			this._fileChooserButton.TabIndex = 0;
			this._fileChooserButton.Text = "Choose File ...";
			this._fileChooserButton.UseVisualStyleBackColor = true;
			this._fileChooserButton.Click += new System.EventHandler(this._fileChooserButton_Click);
			// 
			// label1
			// 
			this._fileChosenLabel.AutoSize = true;
			this._fileChosenLabel.Location = new System.Drawing.Point(138, 11);
			this._fileChosenLabel.Name = "label1";
			this._fileChosenLabel.Size = new System.Drawing.Size(195, 17);
			this._fileChosenLabel.TabIndex = 1;
			this._fileChosenLabel.Text = "No file has been selected yet.";
			// 
			// button2
			// 
			this._wizardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._wizardButton.Location = new System.Drawing.Point(9, 40);
			this._wizardButton.Name = "button2";
			this._wizardButton.Size = new System.Drawing.Size(120, 23);
			this._wizardButton.TabIndex = 2;
			this._wizardButton.Text = "Start Wizard ...";
			this._wizardButton.UseVisualStyleBackColor = true;
			this._wizardButton.Click += new System.EventHandler(this._wizardButton_Click);
			// 
			// label2
			// 
			this._wizardOutputLabel.AutoSize = true;
			this._wizardOutputLabel.Location = new System.Drawing.Point(138, 42);
			this._wizardOutputLabel.Name = "label2";
			this._wizardOutputLabel.Size = new System.Drawing.Size(195, 17);
			this._wizardOutputLabel.TabIndex = 3;
			this._wizardOutputLabel.Text = "The wizard has not yet returned a value.";
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 153);
			this.Controls.Add(this._fileChooserButton);
			this.Controls.Add(this._fileChosenLabel);
			this.Controls.Add(this._wizardButton);
			this.Controls.Add(this._wizardOutputLabel);
			this.Name = "TestForm";
			this.Text = "TestForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
	}
}

