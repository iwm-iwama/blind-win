namespace iwm_Blind
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Cms = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Cms_最大化 = new System.Windows.Forms.ToolStripMenuItem();
			this.Cms_元に戻す = new System.Windows.Forms.ToolStripMenuItem();
			this.Cms_背景色 = new System.Windows.Forms.ToolStripMenuItem();
			this.Cms_閉じる = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.Cms.SuspendLayout();
			this.SuspendLayout();
			// 
			// Cms
			// 
			this.Cms.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Cms.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cms_最大化,
            this.Cms_元に戻す,
            this.Cms_背景色,
            this.Cms_閉じる});
			this.Cms.Name = "contextMenuStrip1";
			this.Cms.Size = new System.Drawing.Size(118, 92);
			// 
			// Cms_最大化
			// 
			this.Cms_最大化.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Cms_最大化.Image = ((System.Drawing.Image)(resources.GetObject("Cms_最大化.Image")));
			this.Cms_最大化.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.Cms_最大化.Name = "Cms_最大化";
			this.Cms_最大化.Size = new System.Drawing.Size(117, 22);
			this.Cms_最大化.Text = "最大化";
			this.Cms_最大化.Click += new System.EventHandler(this.Cms_最大化_Click);
			// 
			// Cms_元に戻す
			// 
			this.Cms_元に戻す.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Cms_元に戻す.Image = ((System.Drawing.Image)(resources.GetObject("Cms_元に戻す.Image")));
			this.Cms_元に戻す.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.Cms_元に戻す.Name = "Cms_元に戻す";
			this.Cms_元に戻す.Size = new System.Drawing.Size(117, 22);
			this.Cms_元に戻す.Text = "元に戻す";
			this.Cms_元に戻す.Click += new System.EventHandler(this.Cms_元に戻す_Click);
			// 
			// Cms_背景色
			// 
			this.Cms_背景色.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Cms_背景色.Image = ((System.Drawing.Image)(resources.GetObject("Cms_背景色.Image")));
			this.Cms_背景色.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.Cms_背景色.Name = "Cms_背景色";
			this.Cms_背景色.Size = new System.Drawing.Size(117, 22);
			this.Cms_背景色.Text = "背景色";
			this.Cms_背景色.Click += new System.EventHandler(this.Cms_背景色_Click);
			// 
			// Cms_閉じる
			// 
			this.Cms_閉じる.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Cms_閉じる.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Cms_閉じる.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Cms_閉じる.Image = ((System.Drawing.Image)(resources.GetObject("Cms_閉じる.Image")));
			this.Cms_閉じる.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.Cms_閉じる.Name = "Cms_閉じる";
			this.Cms_閉じる.Size = new System.Drawing.Size(117, 22);
			this.Cms_閉じる.Text = "閉じる";
			this.Cms_閉じる.Click += new System.EventHandler(this.Cms_閉じる_Click);
			// 
			// ToolTip
			// 
			this.ToolTip.AutomaticDelay = 0;
			this.ToolTip.AutoPopDelay = 2500;
			this.ToolTip.InitialDelay = 10000;
			this.ToolTip.ReshowDelay = 5000;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(304, 304);
			this.ContextMenuStrip = this.Cms;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(40, 40);
			this.Name = "Form1";
			this.RightToLeftLayout = true;
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.Cms.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip Cms;
		private System.Windows.Forms.ToolStripMenuItem Cms_最大化;
		private System.Windows.Forms.ToolStripMenuItem Cms_元に戻す;
		private System.Windows.Forms.ToolStripMenuItem Cms_背景色;
		private System.Windows.Forms.ToolStripMenuItem Cms_閉じる;
		private System.Windows.Forms.ToolTip ToolTip;
	}
}
