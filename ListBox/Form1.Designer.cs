namespace ListBox
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
            this.listBox列表 = new System.Windows.Forms.ListBox();
            this.picB图片显示框 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picB图片显示框)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox列表
            // 
            this.listBox列表.FormattingEnabled = true;
            this.listBox列表.ItemHeight = 15;
            this.listBox列表.Location = new System.Drawing.Point(0, 0);
            this.listBox列表.Name = "listBox列表";
            this.listBox列表.Size = new System.Drawing.Size(200, 784);
            this.listBox列表.TabIndex = 0;
            this.listBox列表.SelectedIndexChanged += new System.EventHandler(this.listBox列表_SelectedIndexChanged);
            // 
            // picB图片显示框
            // 
            this.picB图片显示框.Location = new System.Drawing.Point(200, 0);
            this.picB图片显示框.Name = "picB图片显示框";
            this.picB图片显示框.Size = new System.Drawing.Size(864, 784);
            this.picB图片显示框.TabIndex = 1;
            this.picB图片显示框.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 784);
            this.Controls.Add(this.picB图片显示框);
            this.Controls.Add(this.listBox列表);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB图片显示框)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox列表;
        private System.Windows.Forms.PictureBox picB图片显示框;
    }
}

