namespace FloatingPerformanceMonitor
{
    public partial class Monitor
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Top_most_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.move_swich = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.End_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FloatingPerformanceMonitor";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Top_most_menu,
            this.move_swich,
            this.setting_toolStripMenuItem1,
            this.End_ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 92);
            // 
            // Top_most_menu
            // 
            this.Top_most_menu.CheckOnClick = true;
            this.Top_most_menu.Name = "Top_most_menu";
            this.Top_most_menu.Size = new System.Drawing.Size(167, 22);
            this.Top_most_menu.Text = "常に最前面";
            this.Top_most_menu.Click += new System.EventHandler(this.Top_most_menu_Click);
            // 
            // move_swich
            // 
            this.move_swich.CheckOnClick = true;
            this.move_swich.Name = "move_swich";
            this.move_swich.Size = new System.Drawing.Size(167, 22);
            this.move_swich.Text = "ドラッグを無効にする";
            this.move_swich.Click += new System.EventHandler(this.move_swich_Click);
            // 
            // setting_toolStripMenuItem1
            // 
            this.setting_toolStripMenuItem1.Name = "setting_toolStripMenuItem1";
            this.setting_toolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.setting_toolStripMenuItem1.Text = "設定";
            this.setting_toolStripMenuItem1.Click += new System.EventHandler(this.setting_toolStripMenuItem1_Click);
            // 
            // End_ToolStripMenuItem
            // 
            this.End_ToolStripMenuItem.Name = "End_ToolStripMenuItem";
            this.End_ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.End_ToolStripMenuItem.Text = "終了";
            this.End_ToolStripMenuItem.Click += new System.EventHandler(this.End_ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 7);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(50, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(50, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(69, 66);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.Name = "Monitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Monitor_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem End_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setting_toolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem move_swich;
        private System.Windows.Forms.ToolStripMenuItem Top_most_menu;


    }
}

