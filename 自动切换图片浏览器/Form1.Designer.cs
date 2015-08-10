namespace 自动切换图片浏览器
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
            this.picb1 = new System.Windows.Forms.PictureBox();
            this.picb5 = new System.Windows.Forms.PictureBox();
            this.picb2 = new System.Windows.Forms.PictureBox();
            this.picb3 = new System.Windows.Forms.PictureBox();
            this.picb4 = new System.Windows.Forms.PictureBox();
            this.picb6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb6)).BeginInit();
            this.SuspendLayout();
            // 
            // picb1
            // 
            this.picb1.Location = new System.Drawing.Point(0, 48);
            this.picb1.Name = "picb1";
            this.picb1.Size = new System.Drawing.Size(328, 272);
            this.picb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb1.TabIndex = 0;
            this.picb1.TabStop = false;
            // 
            // picb5
            // 
            this.picb5.Location = new System.Drawing.Point(344, 376);
            this.picb5.Name = "picb5";
            this.picb5.Size = new System.Drawing.Size(328, 272);
            this.picb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb5.TabIndex = 1;
            this.picb5.TabStop = false;
            // 
            // picb2
            // 
            this.picb2.Location = new System.Drawing.Point(344, 48);
            this.picb2.Name = "picb2";
            this.picb2.Size = new System.Drawing.Size(328, 272);
            this.picb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb2.TabIndex = 2;
            this.picb2.TabStop = false;
            // 
            // picb3
            // 
            this.picb3.Location = new System.Drawing.Point(688, 48);
            this.picb3.Name = "picb3";
            this.picb3.Size = new System.Drawing.Size(328, 272);
            this.picb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb3.TabIndex = 3;
            this.picb3.TabStop = false;
            // 
            // picb4
            // 
            this.picb4.Location = new System.Drawing.Point(0, 376);
            this.picb4.Name = "picb4";
            this.picb4.Size = new System.Drawing.Size(328, 272);
            this.picb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb4.TabIndex = 4;
            this.picb4.TabStop = false;
            // 
            // picb6
            // 
            this.picb6.Location = new System.Drawing.Point(688, 376);
            this.picb6.Name = "picb6";
            this.picb6.Size = new System.Drawing.Size(328, 272);
            this.picb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb6.TabIndex = 5;
            this.picb6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 694);
            this.Controls.Add(this.picb6);
            this.Controls.Add(this.picb4);
            this.Controls.Add(this.picb3);
            this.Controls.Add(this.picb2);
            this.Controls.Add(this.picb5);
            this.Controls.Add(this.picb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picb1;
        private System.Windows.Forms.PictureBox picb5;
        private System.Windows.Forms.PictureBox picb2;
        private System.Windows.Forms.PictureBox picb3;
        private System.Windows.Forms.PictureBox picb4;
        private System.Windows.Forms.PictureBox picb6;
        private System.Windows.Forms.Timer timer1;
    }
}

