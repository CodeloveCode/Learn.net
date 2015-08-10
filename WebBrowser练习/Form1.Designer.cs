namespace WebBrowser练习
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
            this.web浏览器 = new System.Windows.Forms.WebBrowser();
            this.btGo = new System.Windows.Forms.Button();
            this.tb地址栏 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // web浏览器
            // 
            this.web浏览器.Location = new System.Drawing.Point(0, 40);
            this.web浏览器.MinimumSize = new System.Drawing.Size(20, 20);
            this.web浏览器.Name = "web浏览器";
            this.web浏览器.Size = new System.Drawing.Size(968, 760);
            this.web浏览器.TabIndex = 0;
            this.web浏览器.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(760, 0);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(75, 23);
            this.btGo.TabIndex = 2;
            this.btGo.Text = "上网";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // tb地址栏
            // 
            this.tb地址栏.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb地址栏.Location = new System.Drawing.Point(168, 0);
            this.tb地址栏.Name = "tb地址栏";
            this.tb地址栏.Size = new System.Drawing.Size(520, 25);
            this.tb地址栏.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 793);
            this.Controls.Add(this.tb地址栏);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.web浏览器);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser web浏览器;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.TextBox tb地址栏;
    }
}

