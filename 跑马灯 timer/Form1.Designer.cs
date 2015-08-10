namespace 跑马灯_timer
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
            this.lbl显示器 = new System.Windows.Forms.Label();
            this.tmr跑马灯 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl显示器
            // 
            this.lbl显示器.AutoSize = true;
            this.lbl显示器.Location = new System.Drawing.Point(208, 96);
            this.lbl显示器.Name = "lbl显示器";
            this.lbl显示器.Size = new System.Drawing.Size(187, 15);
            this.lbl显示器.TabIndex = 0;
            this.lbl显示器.Text = "☆★☆★☆★☆★☆★☆★";
            this.lbl显示器.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr跑马灯
            // 
            this.tmr跑马灯.Enabled = true;
            this.tmr跑马灯.Tick += new System.EventHandler(this.tmr跑马灯_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 255);
            this.Controls.Add(this.lbl显示器);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl显示器;
        private System.Windows.Forms.Timer tmr跑马灯;
    }
}

