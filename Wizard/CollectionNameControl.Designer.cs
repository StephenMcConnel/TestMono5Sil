﻿namespace TestMono5Sil
{
	partial class CollectionNameControl
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
            this._collectionNameControl = new System.Windows.Forms.TextBox();
			this._exampleText = new System.Windows.Forms.Label(); //new SIL.Windows.Forms.Widgets.BetterLabel();
			this.htmlLabel1 = new System.Windows.Forms.Label(); //new SIL.Windows.Forms.Widgets.HtmlLabel();
            this._nameCollectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _collectionNameControl
            // 
            this._collectionNameControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this._collectionNameControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._collectionNameControl.Location = new System.Drawing.Point(3, 29);
            this._collectionNameControl.Name = "_collectionNameControl";
            this._collectionNameControl.Size = new System.Drawing.Size(229, 29);
            this._collectionNameControl.TabIndex = 10;
            this._collectionNameControl.TextChanged += new System.EventHandler(this._textLibraryName_TextChanged);
            // 
            // _exampleText
            // 
            this._exampleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._exampleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._exampleText.Enabled = false;
            this._exampleText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._exampleText.ForeColor = System.Drawing.Color.DimGray;
            this._exampleText.Location = new System.Drawing.Point(3, 64);
            //this._exampleText.Multiline = true;
            this._exampleText.Name = "_exampleText";
            //this._exampleText.ReadOnly = true;
            this._exampleText.Size = new System.Drawing.Size(311, 17);
            this._exampleText.TabIndex = 13;
            this._exampleText.TabStop = false;
            this._exampleText.Text = "Examples: \"Health Books\", \"PNG Animal Stories\"";
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            //this.htmlLabel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.htmlLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.htmlLabel1.HTML = null;
            this.htmlLabel1.Location = new System.Drawing.Point(3, 108);
            this.htmlLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(321, 168);
            this.htmlLabel1.TabIndex = 14;
            // 
            // _nameCollectionLabel
            // 
            this._nameCollectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._nameCollectionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._nameCollectionLabel.Enabled = false;
            this._nameCollectionLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._nameCollectionLabel.Location = new System.Drawing.Point(3, 0);
            this._nameCollectionLabel.Name = "_nameCollectionLabel";
            this._nameCollectionLabel.Size = new System.Drawing.Size(321, 23);
            this._nameCollectionLabel.TabIndex = 15;
            this._nameCollectionLabel.TabStop = false;
            this._nameCollectionLabel.Text = "What would you like to call this collection?";
            // 
            // 
            // 
            // CollectionNameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._nameCollectionLabel);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this._exampleText);
            this.Controls.Add(this._collectionNameControl);
            this.Name = "CollectionNameControl";
            this.Size = new System.Drawing.Size(329, 352);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		protected System.Windows.Forms.TextBox _collectionNameControl;
		private System.Windows.Forms.Label _exampleText; //SIL.Windows.Forms.Widgets.BetterLabel _exampleText;
		private System.Windows.Forms.Label htmlLabel1;	//SIL.Windows.Forms.Widgets.HtmlLabel htmlLabel1;
		private System.Windows.Forms.Label _nameCollectionLabel;
	}
}
