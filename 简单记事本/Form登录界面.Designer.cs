namespace 简单记事本
{
    partial class Form登录界面
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl登录用户名 = new System.Windows.Forms.Label();
            this.lbl登录密码 = new System.Windows.Forms.Label();
            this.tb用户名输入 = new System.Windows.Forms.TextBox();
            this.tb密码输入 = new System.Windows.Forms.TextBox();
            this.bt登录按钮 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl登录用户名
            // 
            this.lbl登录用户名.AutoSize = true;
            this.lbl登录用户名.Location = new System.Drawing.Point(32, 56);
            this.lbl登录用户名.Name = "lbl登录用户名";
            this.lbl登录用户名.Size = new System.Drawing.Size(52, 15);
            this.lbl登录用户名.TabIndex = 0;
            this.lbl登录用户名.Text = "用户名";
            // 
            // lbl登录密码
            // 
            this.lbl登录密码.AutoSize = true;
            this.lbl登录密码.Location = new System.Drawing.Point(24, 120);
            this.lbl登录密码.Name = "lbl登录密码";
            this.lbl登录密码.Size = new System.Drawing.Size(37, 15);
            this.lbl登录密码.TabIndex = 1;
            this.lbl登录密码.Text = "密码";
            // 
            // tb用户名输入
            // 
            this.tb用户名输入.Location = new System.Drawing.Point(160, 56);
            this.tb用户名输入.Name = "tb用户名输入";
            this.tb用户名输入.Size = new System.Drawing.Size(144, 25);
            this.tb用户名输入.TabIndex = 2;
            // 
            // tb密码输入
            // 
            this.tb密码输入.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tb密码输入.Location = new System.Drawing.Point(152, 120);
            this.tb密码输入.Name = "tb密码输入";
            this.tb密码输入.PasswordChar = '*';
            this.tb密码输入.Size = new System.Drawing.Size(152, 25);
            this.tb密码输入.TabIndex = 3;
            // 
            // bt登录按钮
            // 
            this.bt登录按钮.Location = new System.Drawing.Point(160, 240);
            this.bt登录按钮.Name = "bt登录按钮";
            this.bt登录按钮.Size = new System.Drawing.Size(75, 23);
            this.bt登录按钮.TabIndex = 4;
            this.bt登录按钮.Text = "登录";
            this.bt登录按钮.UseVisualStyleBackColor = true;
            this.bt登录按钮.Click += new System.EventHandler(this.bt登录按钮_Click);
            // 
            // Form登录界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 363);
            this.Controls.Add(this.bt登录按钮);
            this.Controls.Add(this.tb密码输入);
            this.Controls.Add(this.tb用户名输入);
            this.Controls.Add(this.lbl登录密码);
            this.Controls.Add(this.lbl登录用户名);
            this.Name = "Form登录界面";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form登录界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl登录用户名;
        private System.Windows.Forms.Label lbl登录密码;
        private System.Windows.Forms.TextBox tb用户名输入;
        private System.Windows.Forms.TextBox tb密码输入;
        private System.Windows.Forms.Button bt登录按钮;
    }
}