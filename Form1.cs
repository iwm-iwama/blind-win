using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace iwm_Blind
{
	public partial class Form1 : Form
	{
		///private const string COPYRIGHT = "(C)2021-2023 iwm-iwama";
		///private const string VERSION = "iwm_Blind_20231228";

		public Form1()
		{
			InitializeComponent();

			// MouseWhell イベント追加
			MouseWheel += new MouseEventHandler(Form_MouseWheel);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			StartPosition = FormStartPosition.CenterScreen;
			///StartPosition = FormStartPosition.Manual;
			///Location = new Point(Cursor.Position.X - (Width / 2), Cursor.Position.Y - (SystemInformation.CaptionHeight / 2));
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			Opacity = 1.0 - 0.3;
			SubBgBlind(0);
		}

		private void Form1_MouseEnter(object sender, EventArgs e)
		{
			ToolTip.SetToolTip(
				this,
				"[マウスホイール] 透過率を変更\n" +
				"[ダブルクリック] 一瞬だけ背景を表示\n" +
				"[右クリック] 各種メニュー"
			);
		}

		private void Form_MouseWheel(object sender, MouseEventArgs e)
		{
			// 上回転 +120
			if (e.Delta > 0)
			{
				SubBgBlind(-10);
			}
			// 下回転 -120
			else if (e.Delta < 0)
			{
				SubBgBlind(10);
			}

			ToolTip.SetToolTip(this, $"透過率 {100 - (int)(Opacity * 100)}%");
		}

		private void SubBgBlind(
			int blindPerAdd
		)
		{
			int iBlind = (int)(Opacity * 100) + blindPerAdd;

			if (iBlind > 100)
			{
				iBlind = 100;
			}
			else if (iBlind < 10)
			{
				iBlind = 10;
			}

			Opacity = iBlind / 100.0;
		}

		private Point MousePoint = Point.Empty;

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				MousePoint = new Point(e.X, e.Y);
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				Left += e.X - MousePoint.X;
				Top += e.Y - MousePoint.Y;
			}
		}

		private void Form1_DoubleClick(object sender, EventArgs e)
		{
			Visible = false;
			Thread.Sleep(1000);
			Visible = true;
		}

		private int GblX = 0, GblY = 0, GblW = 0, GblH = 0;
		private bool GblFormMax = false;

		private void Cms_最大化_Click(object sender, EventArgs e)
		{
			if (!GblFormMax)
			{
				GblX = Left;
				GblY = Top;
				GblW = Width;
				GblH = Height;
			}
			Left = SystemInformation.WorkingArea.Left - 8;
			Top = SystemInformation.WorkingArea.Top - 8;
			Width = SystemInformation.WorkingArea.Width + 16;
			Height = SystemInformation.WorkingArea.Height + 16;
			GblFormMax = true;
		}

		private void Cms_元に戻す_Click(object sender, EventArgs e)
		{
			Left = GblX;
			Top = GblY;
			Width = GblW;
			Height = GblH;
			GblFormMax = false;
		}

		private void Cms_背景色_Click(object sender, EventArgs e)
		{
			using (ColorDialog cd = new ColorDialog
			{
				Color = BackColor,
				AllowFullOpen = true,
				SolidColorOnly = true,
				CustomColors = new int[] { }
			})
			{
				if (cd.ShowDialog() == DialogResult.OK)
				{
					BackColor = cd.Color;
				}
			}
		}

		private void Cms_閉じる_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private static class Program
		{
			/// <summary>
			/// アプリケーションのメイン エントリ ポイントです。
			/// </summary>
			[STAThread]
			private static void Main()
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			}
		}
	}
}
