namespace 简单闹钟
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
            this.components = new System.ComponentModel.Container();
            this.tb输入 = new System.Windows.Forms.TextBox();
            this.lbl显示时间 = new System.Windows.Forms.Label();
            this.lbl同步文本框 = new System.Windows.Forms.Label();
            this.timer1显示时间 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tb输入
            // 
            this.tb输入.Location = new System.Drawing.Point(248, 24);
            this.tb输入.Name = "tb输入";
            this.tb输入.Size = new System.Drawing.Size(304, 25);
            this.tb输入.TabIndex = 0;
            this.tb输入.TextChanged += new System.EventHandler(this.tb输入_TextChanged);
            // 
            // lbl显示时间
            // 
            this.lbl显示时间.AutoSize = true;
            this.lbl显示时间.Location = new System.Drawing.Point(104, 80);
            this.lbl显示时间.Name = "lbl显示时间";
            this.lbl显示时间.Size = new System.Drawing.Size(55, 15);
            this.lbl显示时间.TabIndex = 1;
            this.lbl显示时间.Text = "label1";
            // 
            // lbl同步文本框
            // 
            this.lbl同步文本框.AutoSize = true;
            this.lbl同步文本框.Location = new System.Drawing.Point(112, 152);
            this.lbl同步文本框.Name = "lbl同步文本框";
            this.lbl同步文本框.Size = new System.Drawing.Size(0, 15);
            this.lbl同步文本框.TabIndex = 2;
            // 
            // timer1显示时间
            // 
            this.timer1显示时间.Enabled = true;
            this.timer1显示时间.Interval = 1000;
            this.timer1显示时间.Tick += new System.EventHandler(this.timer1显示时间_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 255);
            this.Controls.Add(this.lbl同步文本框);
            this.Controls.Add(this.lbl显示时间);
            this.Controls.Add(this.tb输入);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb输入;
        private System.Windows.Forms.Label lbl显示时间;
        private System.Windows.Forms.Label lbl同步文本框;
        private System.Windows.Forms.Timer timer1显示时间;
    }
}

