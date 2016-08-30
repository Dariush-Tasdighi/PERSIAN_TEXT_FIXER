namespace MyApplication
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			Text += " - " + "نسخه:" + " " + Dtx.Utility.VERSION;
		}

		private void btnAbout_Click(object sender, System.EventArgs e)
		{
			string strText =
				"این برنامه توسط داریوش تصدیقی نوشته شده است." +
				System.Environment.NewLine +
				System.Environment.NewLine +
				"Email: DariushT@GMail.com" +
				System.Environment.NewLine +
				"Cell Phone: 0098-912-108-7461" +
				System.Environment.NewLine +
				System.Environment.NewLine +
				"Telegram ID: @Dariush_Tasdighi" +
				System.Environment.NewLine +
				"Telgram Channel ID: @IranianExperts" +
				System.Environment.NewLine +
				System.Environment.NewLine +
				"برای اجرای این برنامه، باید بر روی سیستم شما، دات نت فریم‌ورک ۴.۰ نصب شده باشد."
				;

			System.Windows.Forms.MessageBox.Show(strText, "درباره", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information, System.Windows.Forms.MessageBoxDefaultButton.Button1, System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);
		}

		private void btnFixText_Click(object sender, System.EventArgs e)
		{
			txtTarget.Text =
				Dtx.Utility.FixPersianText(txtSource.Text, chkConvertNumbers.Checked);
		}

		private void btnCopyTarget_Click(object sender, System.EventArgs e)
		{
			txtTarget.SelectAll();

			//txtTarget.SelectionStart = 0;
			//txtTarget.SelectionLength = txtTarget.Text.Length;

			System.Windows.Forms.Clipboard.SetText(txtTarget.Text);
		}

		private void btnClearTextBoxes_Click(object sender, System.EventArgs e)
		{
			txtTarget.Text = string.Empty;
			txtSource.Text = string.Empty;
		}
	}
}
