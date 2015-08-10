namespace 简单记事本
{
    partial class Form记事本
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
            this.tb主编辑框 = new System.Windows.Forms.TextBox();
            this.bt自动换行 = new System.Windows.Forms.Button();
            this.bt保存文件 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb主编辑框
            // 
            this.tb主编辑框.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb主编辑框.Location = new System.Drawing.Point(32, 64);
            this.tb主编辑框.Multiline = true;
            this.tb主编辑框.Name = "tb主编辑框";
            this.tb主编辑框.Size = new System.Drawing.Size(672, 640);
            this.tb主编辑框.TabIndex = 0;
            this.tb主编辑框.WordWrap = false;
            // 
            // bt自动换行
            // 
            this.bt自动换行.Location = new System.Drawing.Point(56, 16);
            this.bt自动换行.Name = "bt自动换行";
            this.bt自动换行.Size = new System.Drawing.Size(152, 23);
            this.bt自动换行.TabIndex = 1;
            this.bt自动换行.Text = "设置自动换行";
            this.bt自动换行.UseVisualStyleBackColor = true;
            this.bt自动换行.Click += new System.EventHandler(this.bt自动换行_Click);
            // 
            // bt保存文件
            // 
            this.bt保存文件.Location = new System.Drawing.Point(464, 16);
            this.bt保存文件.Name = "bt保存文件";
            this.bt保存文件.Size = new System.Drawing.Size(160, 23);
            this.bt保存文件.TabIndex = 2;
            this.bt保存文件.Text = "保存文件";
            this.bt保存文件.UseVisualStyleBackColor = true;
            this.bt保存文件.Click += new System.EventHandler(this.bt保存文件_Click);
            // 
            // Form记事本
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 730);
            this.Controls.Add(this.bt保存文件);
            this.Controls.Add(this.bt自动换行);
            this.Controls.Add(this.tb主编辑框);
            this.Name = "Form记事本";
            this.Text = "简单记事本";
            this.Load += new System.EventHandler(this.Form记事本_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb主编辑框;
        private System.Windows.Forms.Button bt自动换行;
        private System.Windows.Forms.Button bt保存文件;
    }
}

