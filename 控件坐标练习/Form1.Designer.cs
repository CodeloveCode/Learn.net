namespace 控件坐标练习
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
            this.bt爱 = new System.Windows.Forms.Button();
            this.bt不爱 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt爱
            // 
            this.bt爱.Location = new System.Drawing.Point(80, 120);
            this.bt爱.Name = "bt爱";
            this.bt爱.Size = new System.Drawing.Size(75, 23);
            this.bt爱.TabIndex = 0;
            this.bt爱.Text = "爱";
            this.bt爱.UseVisualStyleBackColor = true;
            this.bt爱.Click += new System.EventHandler(this.bt爱_Click);
            // 
            // bt不爱
            // 
            this.bt不爱.Location = new System.Drawing.Point(224, 120);
            this.bt不爱.Name = "bt不爱";
            this.bt不爱.Size = new System.Drawing.Size(75, 23);
            this.bt不爱.TabIndex = 1;
            this.bt不爱.Text = "不爱";
            this.bt不爱.UseVisualStyleBackColor = true;
            this.bt不爱.Click += new System.EventHandler(this.bt不爱_Click);
            this.bt不爱.MouseEnter += new System.EventHandler(this.bt不爱_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 255);
            this.Controls.Add(this.bt不爱);
            this.Controls.Add(this.bt爱);
            this.Name = "Form1";
            this.Text = "你爱我吗?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt爱;
        private System.Windows.Forms.Button bt不爱;
    }
}

