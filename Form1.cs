using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace iwm_Blind
{
	public partial class Form1 : Form
	{
		/// private const string Ver = "iwm20210713";

		public Form1()
		{
			InitializeComponent();

			// MouseWhell イベント追加
			MouseWheel += new MouseEventHandler(Form_MouseWheel);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			StartPosition = FormStartPosition.Manual;
			SubFormStartPosition();

			TopMost = true;
			ShowInTaskbar = false;
			Show();

			SubBgBlind();
		}

		private void Form1_MouseEnter(object sender, EventArgs e)
		{
			ToolTip1.SetToolTip(
				this,
				"[マウスホイール] 透過度を調整\n" +
				"[ダブルクリック] 一瞬だけ背景を表示／コントロール移動\n" +
				"[右クリック] 閉じる"
			);
		}

		private void Form_MouseWheel(object sender, MouseEventArgs e)
		{
			// 上回転 +120
			if (e.Delta > 0)
			{
				SubBgBlindUp();
			}
			// 下回転 -120
			else if (e.Delta < 0)
			{
				SubBgBlindDown();
			}

			ToolTip1.SetToolTip(this, "不透過" + (Opacity * 100) + "%");
		}

		private Point MousePoint;

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
			FormWindowState ws = WindowState;
			TopMost = false;
			WindowState = FormWindowState.Minimized;
			Thread.Sleep(1000);
			TopMost = true;
			WindowState = ws;
		}

		private void SubFormStartPosition()
		{
			int WorkingAreaW = Screen.PrimaryScreen.WorkingArea.Width;
			int WorkingAreaH = Screen.PrimaryScreen.WorkingArea.Height;

			int WorkingAreaX = Screen.PrimaryScreen.WorkingArea.X;
			int WorkingAreaY = Screen.PrimaryScreen.WorkingArea.Y;

			int MouseX = Cursor.Position.X;
			int MouseY = Cursor.Position.Y;

			// X = Width
			if (WorkingAreaW < MouseX + Size.Width)
			{
				MouseX -= Size.Width;
				if (MouseX < 0)
				{
					MouseX = WorkingAreaX + 10;
				}
			}

			// Y = Height
			if (WorkingAreaH < MouseY + Size.Height)
			{
				MouseY -= Size.Height;
				if (MouseY < 0)
				{
					MouseY = WorkingAreaY + 10;
				}
			}

			Location = new Point(MouseX, MouseY);
		}

		private void Cms1_最大化_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized;
		}

		private void Cms1_元に戻す_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Normal;
		}

		private void Cms1_背景色_Click(object sender, EventArgs e)
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

		private void Cms1_閉じる_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SubBgBlind(
			double level = 0.5
		)
		{
			// 無限ループにしない
			if (level > 1.01)
			{
				level = 1.0;
			}
			else if (level < 0.1)
			{
				level = 0.1;
			}

			Opacity = level;
		}

		private void SubBgBlindUp()
		{
			SubBgBlind(Opacity + 0.05);
		}

		private void SubBgBlindDown()
		{
			SubBgBlind(Opacity - 0.05);
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
