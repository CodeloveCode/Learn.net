namespace 多选和单选控件
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
            this.tb帐号 = new System.Windows.Forms.TextBox();
            this.tb密码 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb游客 = new System.Windows.Forms.RadioButton();
            this.rb会员 = new System.Windows.Forms.RadioButton();
            this.bt登陆 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb帐号
            // 
            this.tb帐号.Location = new System.Drawing.Point(144, 56);
            this.tb帐号.Name = "tb帐号";
            this.tb帐号.Size = new System.Drawing.Size(100, 25);
            this.tb帐号.TabIndex = 0;
            // 
            // tb密码
            // 
            this.tb密码.Location = new System.Drawing.Point(144, 136);
            this.tb密码.Name = "tb密码";
            this.tb密码.PasswordChar = '*';
            this.tb密码.Size = new System.Drawing.Size(100, 25);
            this.tb密码.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "帐号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // rb游客
            // 
            this.rb游客.AutoSize = true;
            this.rb游客.Location = new System.Drawing.Point(40, 216);
            this.rb游客.Name = "rb游客";
            this.rb游客.Size = new System.Drawing.Size(58, 19);
            this.rb游客.TabIndex = 4;
            this.rb游客.TabStop = true;
            this.rb游客.Text = "游客";
            this.rb游客.UseVisualStyleBackColor = true;
            // 
            // rb会员
            // 
            this.rb会员.AutoSize = true;
            this.rb会员.Location = new System.Drawing.Point(216, 216);
            this.rb会员.Name = "rb会员";
            this.rb会员.Size = new System.Drawing.Size(58, 19);
            this.rb会员.TabIndex = 5;
            this.rb会员.TabStop = true;
            this.rb会员.Text = "会员";
            this.rb会员.UseVisualStyleBackColor = true;
            // 
            // bt登陆
            // 
            this.bt登陆.Location = new System.Drawing.Point(144, 272);
            this.bt登陆.Name = "bt登陆";
            this.bt登陆.Size = new System.Drawing.Size(75, 23);
            this.bt登陆.TabIndex = 6;
            this.bt登陆.Text = "登录";
            this.bt登陆.UseVisualStyleBackColor = true;
            this.bt登陆.Click += new System.EventHandler(this.bt登陆_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 280);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "啥";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 304);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(44, 19);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "啥";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(8, 328);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 19);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "呵呵";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(8, 352);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(59, 19);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "哈哈";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 411);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bt登陆);
            this.Controls.Add(this.rb会员);
            this.Controls.Add(this.rb游客);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb密码);
            this.Controls.Add(this.tb帐号);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb帐号;
        private System.Windows.Forms.TextBox tb密码;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb游客;
        private System.Windows.Forms.RadioButton rb会员;
        private System.Windows.Forms.Button bt登陆;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

