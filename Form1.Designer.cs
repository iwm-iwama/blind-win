namespace iwm_blind
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Cms1_閉じる = new System.Windows.Forms.ToolStripMenuItem();
			this.Cms1_L2 = new System.Windows.Forms.ToolStripSeparator();
			this.Cms1_背景色 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
			this.Cms1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Cms1
			// 
			this.Cms1.BackColor = System.Drawing.Color.White;
			this.Cms1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cms1_閉じる,
            this.Cms1_L2,
            this.Cms1_背景色});
			this.Cms1.Name = "contextMenuStrip1";
			this.Cms1.Size = new System.Drawing.Size(123, 54);
			// 
			// Cms1_閉じる
			// 
			this.Cms1_閉じる.BackColor = System.Drawing.Color.White;
			this.Cms1_閉じる.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Cms1_閉じる.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Cms1_閉じる.Name = "Cms1_閉じる";
			this.Cms1_閉じる.Size = new System.Drawing.Size(122, 22);
			this.Cms1_閉じる.Text = "閉じる";
			this.Cms1_閉じる.Click += new System.EventHandler(this.Cms1_閉じる_Click);
			// 
			// Cms1_L2
			// 
			this.Cms1_L2.Name = "Cms1_L2";
			this.Cms1_L2.Size = new System.Drawing.Size(119, 6);
			// 
			// Cms1_背景色
			// 
			this.Cms1_背景色.Name = "Cms1_背景色";
			this.Cms1_背景色.Size = new System.Drawing.Size(122, 22);
			this.Cms1_背景色.Text = "■背景色";
			this.Cms1_背景色.Click += new System.EventHandler(this.Cms1_背景色_Click);
			// 
			// ToolTip1
			// 
			this.ToolTip1.AutomaticDelay = 0;
			this.ToolTip1.AutoPopDelay = 2500;
			this.ToolTip1.InitialDelay = 5000;
			this.ToolTip1.ReshowDelay = 5000;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(304, 304);
			this.ContextMenuStrip = this.Cms1;
			this.ControlBox = false;
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(40, 40);
			this.Name = "Form1";
			this.RightToLeftLayout = true;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.Cms1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip Cms1;
		private System.Windows.Forms.ToolStripMenuItem Cms1_閉じる;
		private System.Windows.Forms.ToolTip ToolTip1;
		private System.Windows.Forms.ToolStripMenuItem Cms1_背景色;
		private System.Windows.Forms.ToolStripSeparator Cms1_L2;
		private System.Windows.Forms.ColorDialog ColorDialog1;
	}
}
