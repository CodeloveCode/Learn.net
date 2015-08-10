namespace 下拉框comboBox_日期选择器
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
            this.cmb年 = new System.Windows.Forms.ComboBox();
            this.cmb月 = new System.Windows.Forms.ComboBox();
            this.cmb日 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb年
            // 
            this.cmb年.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb年.FormattingEnabled = true;
            this.cmb年.Location = new System.Drawing.Point(184, 176);
            this.cmb年.Name = "cmb年";
            this.cmb年.Size = new System.Drawing.Size(121, 23);
            this.cmb年.TabIndex = 0;
            this.cmb年.SelectedIndexChanged += new System.EventHandler(this.cmb年_SelectedIndexChanged);
            // 
            // cmb月
            // 
            this.cmb月.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb月.FormattingEnabled = true;
            this.cmb月.Location = new System.Drawing.Point(352, 176);
            this.cmb月.Name = "cmb月";
            this.cmb月.Size = new System.Drawing.Size(121, 23);
            this.cmb月.TabIndex = 1;
            this.cmb月.SelectedIndexChanged += new System.EventHandler(this.cmb月_SelectedIndexChanged);
            // 
            // cmb日
            // 
            this.cmb日.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb日.FormattingEnabled = true;
            this.cmb日.Location = new System.Drawing.Point(536, 176);
            this.cmb日.Name = "cmb日";
            this.cmb日.Size = new System.Drawing.Size(121, 23);
            this.cmb日.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 642);
            this.Controls.Add(this.cmb日);
            this.Controls.Add(this.cmb月);
            this.Controls.Add(this.cmb年);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb年;
        private System.Windows.Forms.ComboBox cmb月;
        private System.Windows.Forms.ComboBox cmb日;
    }
}

