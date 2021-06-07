namespace winform基本练习1
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
            this.bt窗体1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt窗体1
            // 
            this.bt窗体1.Location = new System.Drawing.Point(73, 165);
            this.bt窗体1.Name = "bt窗体1";
            this.bt窗体1.Size = new System.Drawing.Size(136, 23);
            this.bt窗体1.TabIndex = 0;
            this.bt窗体1.Text = "打开窗体2";
            this.bt窗体1.UseVisualStyleBackColor = true;
            this.bt窗体1.Click += new System.EventHandler(this.bt窗体1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.bt窗体1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt窗体1;
    }
}

