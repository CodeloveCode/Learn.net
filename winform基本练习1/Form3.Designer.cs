namespace winform基本练习1
{
    partial class Form3
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
            this.bt窗体3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt窗体3
            // 
            this.bt窗体3.Location = new System.Drawing.Point(96, 128);
            this.bt窗体3.Name = "bt窗体3";
            this.bt窗体3.Size = new System.Drawing.Size(136, 23);
            this.bt窗体3.TabIndex = 0;
            this.bt窗体3.Text = "关闭所有窗口";
            this.bt窗体3.UseVisualStyleBackColor = true;
            this.bt窗体3.Click += new System.EventHandler(this.bt窗体3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.bt窗体3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt窗体3;
    }
}