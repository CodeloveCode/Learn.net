namespace 普通记事本
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb编辑框 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menustrip自动换行 = new System.Windows.Forms.ToolStripMenuItem();
            this.样式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel文件列表开关 = new System.Windows.Forms.Panel();
            this.bt隐藏文件列表 = new System.Windows.Forms.Button();
            this.lb文件列表 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panel文件列表开关.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb编辑框
            // 
            this.tb编辑框.AcceptsReturn = true;
            this.tb编辑框.AcceptsTab = true;
            this.tb编辑框.Location = new System.Drawing.Point(0, 32);
            this.tb编辑框.Multiline = true;
            this.tb编辑框.Name = "tb编辑框";
            this.tb编辑框.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb编辑框.Size = new System.Drawing.Size(1072, 688);
            this.tb编辑框.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.样式ToolStripMenuItem,
            this.文件记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menustrip自动换行});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // Menustrip自动换行
            // 
            this.Menustrip自动换行.Name = "Menustrip自动换行";
            this.Menustrip自动换行.Size = new System.Drawing.Size(155, 26);
            this.Menustrip自动换行.Text = "√自动换行";
            this.Menustrip自动换行.Click += new System.EventHandler(this.自动换行ToolStripMenuItem_Click);
            // 
            // 样式ToolStripMenuItem
            // 
            this.样式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字体ToolStripMenuItem,
            this.颜色ToolStripMenuItem});
            this.样式ToolStripMenuItem.Name = "样式ToolStripMenuItem";
            this.样式ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.样式ToolStripMenuItem.Text = "样式";
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.字体ToolStripMenuItem.Text = "字体";
            this.字体ToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripMenuItem_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.颜色ToolStripMenuItem.Text = "颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 文件记录ToolStripMenuItem
            // 
            this.文件记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.隐藏ToolStripMenuItem});
            this.文件记录ToolStripMenuItem.Name = "文件记录ToolStripMenuItem";
            this.文件记录ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.文件记录ToolStripMenuItem.Text = "文件记录";
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 隐藏ToolStripMenuItem
            // 
            this.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem";
            this.隐藏ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.隐藏ToolStripMenuItem.Text = "隐藏";
            this.隐藏ToolStripMenuItem.Click += new System.EventHandler(this.隐藏ToolStripMenuItem_Click);
            // 
            // panel文件列表开关
            // 
            this.panel文件列表开关.Controls.Add(this.bt隐藏文件列表);
            this.panel文件列表开关.Controls.Add(this.lb文件列表);
            this.panel文件列表开关.Location = new System.Drawing.Point(8, 40);
            this.panel文件列表开关.Name = "panel文件列表开关";
            this.panel文件列表开关.Size = new System.Drawing.Size(320, 680);
            this.panel文件列表开关.TabIndex = 3;
            this.panel文件列表开关.Visible = false;
            // 
            // bt隐藏文件列表
            // 
            this.bt隐藏文件列表.Location = new System.Drawing.Point(256, 200);
            this.bt隐藏文件列表.Name = "bt隐藏文件列表";
            this.bt隐藏文件列表.Size = new System.Drawing.Size(51, 208);
            this.bt隐藏文件列表.TabIndex = 1;
            this.bt隐藏文件列表.Text = "隐藏";
            this.bt隐藏文件列表.UseVisualStyleBackColor = true;
            this.bt隐藏文件列表.Click += new System.EventHandler(this.bt隐藏文件列表_Click);
            // 
            // lb文件列表
            // 
            this.lb文件列表.FormattingEnabled = true;
            this.lb文件列表.ItemHeight = 15;
            this.lb文件列表.Location = new System.Drawing.Point(0, 0);
            this.lb文件列表.Name = "lb文件列表";
            this.lb文件列表.Size = new System.Drawing.Size(232, 679);
            this.lb文件列表.TabIndex = 0;
            this.lb文件列表.DoubleClick += new System.EventHandler(this.lb文件列表_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 792);
            this.Controls.Add(this.panel文件列表开关);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tb编辑框);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel文件列表开关.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb编辑框;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menustrip自动换行;
        private System.Windows.Forms.ToolStripMenuItem 样式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.Panel panel文件列表开关;
        private System.Windows.Forms.Button bt隐藏文件列表;
        private System.Windows.Forms.ListBox lb文件列表;
    }
}

