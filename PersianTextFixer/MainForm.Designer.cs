namespace MyApplication
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.btnClearTextBoxes = new System.Windows.Forms.Button();
			this.btnCopyTarget = new System.Windows.Forms.Button();
			this.chkConvertNumbers = new System.Windows.Forms.CheckBox();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnFixText = new System.Windows.Forms.Button();
			this.pnlSource = new System.Windows.Forms.Panel();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.splSource = new System.Windows.Forms.Splitter();
			this.pnlTarget = new System.Windows.Forms.Panel();
			this.txtTarget = new System.Windows.Forms.TextBox();
			this.pnlButtons.SuspendLayout();
			this.pnlSource.SuspendLayout();
			this.pnlTarget.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlButtons
			// 
			this.pnlButtons.Controls.Add(this.btnClearTextBoxes);
			this.pnlButtons.Controls.Add(this.btnCopyTarget);
			this.pnlButtons.Controls.Add(this.chkConvertNumbers);
			this.pnlButtons.Controls.Add(this.btnAbout);
			this.pnlButtons.Controls.Add(this.btnFixText);
			this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlButtons.Location = new System.Drawing.Point(0, 0);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(766, 30);
			this.pnlButtons.TabIndex = 0;
			// 
			// btnClearTextBoxes
			// 
			this.btnClearTextBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearTextBoxes.Location = new System.Drawing.Point(167, 3);
			this.btnClearTextBoxes.Name = "btnClearTextBoxes";
			this.btnClearTextBoxes.Size = new System.Drawing.Size(150, 23);
			this.btnClearTextBoxes.TabIndex = 4;
			this.btnClearTextBoxes.Text = "&پاک کردن کادرهای محاوره‌ای";
			this.btnClearTextBoxes.UseVisualStyleBackColor = true;
			this.btnClearTextBoxes.Click += new System.EventHandler(this.btnClearTextBoxes_Click);
			// 
			// btnCopyTarget
			// 
			this.btnCopyTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopyTarget.Location = new System.Drawing.Point(323, 3);
			this.btnCopyTarget.Name = "btnCopyTarget";
			this.btnCopyTarget.Size = new System.Drawing.Size(150, 23);
			this.btnCopyTarget.TabIndex = 2;
			this.btnCopyTarget.Text = "&کپی متن تبدیل شده";
			this.btnCopyTarget.UseVisualStyleBackColor = true;
			this.btnCopyTarget.Click += new System.EventHandler(this.btnCopyTarget_Click);
			// 
			// chkConvertNumbers
			// 
			this.chkConvertNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkConvertNumbers.AutoSize = true;
			this.chkConvertNumbers.Checked = true;
			this.chkConvertNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkConvertNumbers.Location = new System.Drawing.Point(635, 7);
			this.chkConvertNumbers.Name = "chkConvertNumbers";
			this.chkConvertNumbers.Size = new System.Drawing.Size(119, 17);
			this.chkConvertNumbers.TabIndex = 1;
			this.chkConvertNumbers.Text = "تبدیل اعداد به یونیکد";
			this.chkConvertNumbers.UseVisualStyleBackColor = true;
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(12, 3);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(150, 23);
			this.btnAbout.TabIndex = 3;
			this.btnAbout.Text = "&درباره";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// btnFixText
			// 
			this.btnFixText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFixText.Location = new System.Drawing.Point(479, 3);
			this.btnFixText.Name = "btnFixText";
			this.btnFixText.Size = new System.Drawing.Size(150, 23);
			this.btnFixText.TabIndex = 0;
			this.btnFixText.Text = "&اصلاح متن";
			this.btnFixText.UseVisualStyleBackColor = true;
			this.btnFixText.Click += new System.EventHandler(this.btnFixText_Click);
			// 
			// pnlSource
			// 
			this.pnlSource.Controls.Add(this.txtSource);
			this.pnlSource.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSource.Location = new System.Drawing.Point(0, 30);
			this.pnlSource.Name = "pnlSource";
			this.pnlSource.Size = new System.Drawing.Size(766, 176);
			this.pnlSource.TabIndex = 1;
			// 
			// txtSource
			// 
			this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSource.Location = new System.Drawing.Point(0, 0);
			this.txtSource.Multiline = true;
			this.txtSource.Name = "txtSource";
			this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSource.Size = new System.Drawing.Size(766, 176);
			this.txtSource.TabIndex = 0;
			// 
			// splSource
			// 
			this.splSource.Dock = System.Windows.Forms.DockStyle.Top;
			this.splSource.Location = new System.Drawing.Point(0, 206);
			this.splSource.Name = "splSource";
			this.splSource.Size = new System.Drawing.Size(766, 10);
			this.splSource.TabIndex = 1;
			this.splSource.TabStop = false;
			// 
			// pnlTarget
			// 
			this.pnlTarget.Controls.Add(this.txtTarget);
			this.pnlTarget.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlTarget.Location = new System.Drawing.Point(0, 216);
			this.pnlTarget.Name = "pnlTarget";
			this.pnlTarget.Size = new System.Drawing.Size(766, 195);
			this.pnlTarget.TabIndex = 3;
			// 
			// txtTarget
			// 
			this.txtTarget.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtTarget.Location = new System.Drawing.Point(0, 0);
			this.txtTarget.Multiline = true;
			this.txtTarget.Name = "txtTarget";
			this.txtTarget.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtTarget.Size = new System.Drawing.Size(766, 195);
			this.txtTarget.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 411);
			this.Controls.Add(this.pnlTarget);
			this.Controls.Add(this.splSource);
			this.Controls.Add(this.pnlSource);
			this.Controls.Add(this.pnlButtons);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.MinimumSize = new System.Drawing.Size(782, 450);
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "اصلاح کننده متون فارسی";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.pnlButtons.ResumeLayout(false);
			this.pnlButtons.PerformLayout();
			this.pnlSource.ResumeLayout(false);
			this.pnlSource.PerformLayout();
			this.pnlTarget.ResumeLayout(false);
			this.pnlTarget.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.CheckBox chkConvertNumbers;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnFixText;
		private System.Windows.Forms.Panel pnlSource;
		private System.Windows.Forms.Splitter splSource;
		private System.Windows.Forms.Panel pnlTarget;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.Button btnCopyTarget;
		private System.Windows.Forms.Button btnClearTextBoxes;
	}
}
