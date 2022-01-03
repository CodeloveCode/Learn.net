namespace key_spirit
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJump = new System.Windows.Forms.Button();
            this.autoKeySetGroupBox = new System.Windows.Forms.GroupBox();
            this.btnSaveKeyConfig = new System.Windows.Forms.Button();
            this.keySelector1 = new System.Windows.Forms.ComboBox();
            this.startHotKeySelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.keyInterval1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.autoKeySetGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(18, 18);
            this.btnJump.Margin = new System.Windows.Forms.Padding(4);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(112, 34);
            this.btnJump.TabIndex = 0;
            this.btnJump.Text = "左右横跳";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // autoKeySetGroupBox
            // 
            this.autoKeySetGroupBox.Controls.Add(this.btnSaveKeyConfig);
            this.autoKeySetGroupBox.Controls.Add(this.keySelector1);
            this.autoKeySetGroupBox.Controls.Add(this.startHotKeySelector);
            this.autoKeySetGroupBox.Controls.Add(this.label3);
            this.autoKeySetGroupBox.Controls.Add(this.btnStart);
            this.autoKeySetGroupBox.Controls.Add(this.keyInterval1);
            this.autoKeySetGroupBox.Controls.Add(this.label2);
            this.autoKeySetGroupBox.Controls.Add(this.label1);
            this.autoKeySetGroupBox.Location = new System.Drawing.Point(140, 18);
            this.autoKeySetGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.autoKeySetGroupBox.Name = "autoKeySetGroupBox";
            this.autoKeySetGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.autoKeySetGroupBox.Size = new System.Drawing.Size(1042, 639);
            this.autoKeySetGroupBox.TabIndex = 1;
            this.autoKeySetGroupBox.TabStop = false;
            this.autoKeySetGroupBox.Text = "自动按键设置";
            // 
            // btnSaveKeyConfig
            // 
            this.btnSaveKeyConfig.Location = new System.Drawing.Point(471, 506);
            this.btnSaveKeyConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveKeyConfig.Name = "btnSaveKeyConfig";
            this.btnSaveKeyConfig.Size = new System.Drawing.Size(112, 34);
            this.btnSaveKeyConfig.TabIndex = 10;
            this.btnSaveKeyConfig.Text = "保存配置";
            this.btnSaveKeyConfig.UseVisualStyleBackColor = true;
            this.btnSaveKeyConfig.Click += new System.EventHandler(this.btnSaveKeyConfig_Click);
            // 
            // keySelector1
            // 
            this.keySelector1.FormattingEnabled = true;
            this.keySelector1.Location = new System.Drawing.Point(44, 56);
            this.keySelector1.Margin = new System.Windows.Forms.Padding(4);
            this.keySelector1.Name = "keySelector1";
            this.keySelector1.Size = new System.Drawing.Size(138, 26);
            this.keySelector1.TabIndex = 9;
            this.keySelector1.SelectedIndexChanged += new System.EventHandler(this.keySelector1_SelectedIndexChanged);
            // 
            // startHotKeySelector
            // 
            this.startHotKeySelector.FormattingEnabled = true;
            this.startHotKeySelector.Location = new System.Drawing.Point(98, 510);
            this.startHotKeySelector.Margin = new System.Windows.Forms.Padding(4);
            this.startHotKeySelector.Name = "startHotKeySelector";
            this.startHotKeySelector.Size = new System.Drawing.Size(180, 26);
            this.startHotKeySelector.TabIndex = 8;
            this.startHotKeySelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 514);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "启动热键";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(310, 507);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // keyInterval1
            // 
            this.keyInterval1.Location = new System.Drawing.Point(194, 56);
            this.keyInterval1.Margin = new System.Windows.Forms.Padding(4);
            this.keyInterval1.Name = "keyInterval1";
            this.keyInterval1.Size = new System.Drawing.Size(84, 28);
            this.keyInterval1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "毫秒";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.autoKeySetGroupBox);
            this.Controls.Add(this.btnJump);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.autoKeySetGroupBox.ResumeLayout(false);
            this.autoKeySetGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.GroupBox autoKeySetGroupBox;
        private System.Windows.Forms.TextBox keyInterval1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox startHotKeySelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox keySelector1;
        private System.Windows.Forms.Button btnSaveKeyConfig;
    }
}

