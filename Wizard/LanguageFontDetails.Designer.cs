﻿namespace TestMono5Sil
{
	partial class LanguageFontDetails
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
			this._fontCombo = new System.Windows.Forms.ComboBox();
			this._rightToLeftCheck = new System.Windows.Forms.CheckBox();
			this._tallerLinesCheck = new System.Windows.Forms.CheckBox();
			this._lineSpacingCombo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// _fontCombo
			// 
			this._fontCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._fontCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._fontCombo.FormattingEnabled = true;
			this._fontCombo.Location = new System.Drawing.Point(10, 10);
			this._fontCombo.Name = "_fontCombo";
			this._fontCombo.Size = new System.Drawing.Size(210, 25);
			this._fontCombo.TabIndex = 0;
			// 
			// _rightToLeftCheck
			// 
			this._rightToLeftCheck.AutoSize = true;
			this._rightToLeftCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rightToLeftCheck.Location = new System.Drawing.Point(10, 45);
			this._rightToLeftCheck.Name = "_rightToLeftCheck";
			this._rightToLeftCheck.Size = new System.Drawing.Size(175, 23);
			this._rightToLeftCheck.TabIndex = 1;
			this._rightToLeftCheck.Text = "This script is right to left";
			this._rightToLeftCheck.UseVisualStyleBackColor = true;
			// 
			// _tallerLinesCheck
			// 
			this._tallerLinesCheck.AutoSize = true;
			this._tallerLinesCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._tallerLinesCheck.Location = new System.Drawing.Point(10, 75);
			this._tallerLinesCheck.Name = "_tallerLinesCheck";
			this._tallerLinesCheck.Size = new System.Drawing.Size(207, 23);
			this._tallerLinesCheck.TabIndex = 2;
			this._tallerLinesCheck.Text = "This script requires taller lines";
			this._tallerLinesCheck.UseVisualStyleBackColor = true;
			this._tallerLinesCheck.CheckedChanged += new System.EventHandler(this._tallerLinesCheck_CheckedChanged);
			// 
			// _lineSpacingCombo
			// 
			this._lineSpacingCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._lineSpacingCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lineSpacingCombo.FormattingEnabled = true;
			this._lineSpacingCombo.Location = new System.Drawing.Point(33, 104);
			this._lineSpacingCombo.Margin = new System.Windows.Forms.Padding(26, 3, 20, 20);
			this._lineSpacingCombo.Name = "_lineSpacingCombo";
			this._lineSpacingCombo.Size = new System.Drawing.Size(125, 25);
			this._lineSpacingCombo.TabIndex = 28;
			// 
			// 
			// 
			// LanguageFontDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._lineSpacingCombo);
			this.Controls.Add(this._tallerLinesCheck);
			this.Controls.Add(this._rightToLeftCheck);
			this.Controls.Add(this._fontCombo);
			this.Name = "LanguageFontDetails";
			this.Size = new System.Drawing.Size(265, 139);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox _fontCombo;
		private System.Windows.Forms.CheckBox _rightToLeftCheck;
		private System.Windows.Forms.CheckBox _tallerLinesCheck;
		private System.Windows.Forms.ComboBox _lineSpacingCombo;
	}
}
