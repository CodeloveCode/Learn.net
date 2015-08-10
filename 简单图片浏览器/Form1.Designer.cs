namespace 简单图片浏览器
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
            this.picb图片框 = new System.Windows.Forms.PictureBox();
            this.bt上一张 = new System.Windows.Forms.Button();
            this.bt下一张 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picb图片框)).BeginInit();
            this.SuspendLayout();
            // 
            // picb图片框
            // 
            this.picb图片框.Location = new System.Drawing.Point(0, 0);
            this.picb图片框.Name = "picb图片框";
            this.picb图片框.Size = new System.Drawing.Size(880, 680);
            this.picb图片框.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picb图片框.TabIndex = 0;
            this.picb图片框.TabStop = false;
            // 
            // bt上一张
            // 
            this.bt上一张.Location = new System.Drawing.Point(104, 688);
            this.bt上一张.Name = "bt上一张";
            this.bt上一张.Size = new System.Drawing.Size(112, 23);
            this.bt上一张.TabIndex = 1;
            this.bt上一张.Text = "上一张";
            this.bt上一张.UseVisualStyleBackColor = true;
            this.bt上一张.Click += new System.EventHandler(this.bt上一张_Click);
            // 
            // bt下一张
            // 
            this.bt下一张.Location = new System.Drawing.Point(608, 688);
            this.bt下一张.Name = "bt下一张";
            this.bt下一张.Size = new System.Drawing.Size(96, 23);
            this.bt下一张.TabIndex = 2;
            this.bt下一张.Text = "下一张";
            this.bt下一张.UseVisualStyleBackColor = true;
            this.bt下一张.Click += new System.EventHandler(this.bt下一张_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(881, 727);
            this.Controls.Add(this.bt下一张);
            this.Controls.Add(this.bt上一张);
            this.Controls.Add(this.picb图片框);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picb图片框)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picb图片框;
        private System.Windows.Forms.Button bt上一张;
        private System.Windows.Forms.Button bt下一张;
    }
}

