namespace VLCPlayer
{
	partial class FormMain
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.TableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.PanelMain2 = new System.Windows.Forms.Panel();
			this.VLCMain2 = new Vlc.DotNet.Forms.VlcControl();
			this.PanelMain1 = new System.Windows.Forms.Panel();
			this.VLCMain1 = new Vlc.DotNet.Forms.VlcControl();
			this.TableLayoutPanelMain.SuspendLayout();
			this.PanelMain2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VLCMain2)).BeginInit();
			this.PanelMain1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VLCMain1)).BeginInit();
			this.SuspendLayout();
			// 
			// TableLayoutPanelMain
			// 
			this.TableLayoutPanelMain.ColumnCount = 2;
			this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayoutPanelMain.Controls.Add(this.PanelMain2, 0, 1);
			this.TableLayoutPanelMain.Controls.Add(this.PanelMain1, 0, 0);
			this.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
			this.TableLayoutPanelMain.RowCount = 2;
			this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayoutPanelMain.Size = new System.Drawing.Size(584, 361);
			this.TableLayoutPanelMain.TabIndex = 3;
			// 
			// PanelMain2
			// 
			this.PanelMain2.AutoScroll = true;
			this.PanelMain2.BackColor = System.Drawing.SystemColors.Control;
			this.PanelMain2.Controls.Add(this.VLCMain2);
			this.PanelMain2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelMain2.Location = new System.Drawing.Point(3, 183);
			this.PanelMain2.Name = "PanelMain2";
			this.PanelMain2.Size = new System.Drawing.Size(286, 175);
			this.PanelMain2.TabIndex = 3;
			// 
			// VLCMain2
			// 
			this.VLCMain2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.VLCMain2.BackColor = System.Drawing.Color.Black;
			this.VLCMain2.Location = new System.Drawing.Point(3, 3);
			this.VLCMain2.Name = "VLCMain2";
			this.VLCMain2.Size = new System.Drawing.Size(280, 142);
			this.VLCMain2.Spu = -1;
			this.VLCMain2.TabIndex = 1;
			this.VLCMain2.VlcLibDirectory = null;
			this.VLCMain2.VlcMediaplayerOptions = null;
			this.VLCMain2.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.VLCMain_VlcLibDirectoryNeeded);
			// 
			// PanelMain1
			// 
			this.PanelMain1.BackColor = System.Drawing.SystemColors.Control;
			this.PanelMain1.Controls.Add(this.VLCMain1);
			this.PanelMain1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelMain1.Location = new System.Drawing.Point(3, 3);
			this.PanelMain1.Name = "PanelMain1";
			this.PanelMain1.Size = new System.Drawing.Size(286, 174);
			this.PanelMain1.TabIndex = 2;
			// 
			// VLCMain1
			// 
			this.VLCMain1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.VLCMain1.BackColor = System.Drawing.Color.Black;
			this.VLCMain1.Location = new System.Drawing.Point(3, 3);
			this.VLCMain1.Name = "VLCMain1";
			this.VLCMain1.Size = new System.Drawing.Size(279, 141);
			this.VLCMain1.Spu = -1;
			this.VLCMain1.TabIndex = 1;
			this.VLCMain1.VlcLibDirectory = null;
			this.VLCMain1.VlcMediaplayerOptions = null;
			this.VLCMain1.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.VLCMain_VlcLibDirectoryNeeded);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.TableLayoutPanelMain);
			this.Name = "FormMain";
			this.Text = "VLCPlayer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.TableLayoutPanelMain.ResumeLayout(false);
			this.PanelMain2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.VLCMain2)).EndInit();
			this.PanelMain1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.VLCMain1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMain;
		private System.Windows.Forms.Panel PanelMain2;
		private Vlc.DotNet.Forms.VlcControl VLCMain2;
		private System.Windows.Forms.Panel PanelMain1;
		private Vlc.DotNet.Forms.VlcControl VLCMain1;
	}
}

