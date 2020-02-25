namespace WindowsFormsApp3
{
    partial class 按姓名输入成员窗口
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
            this.姓名标签 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.删除按钮 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 姓名标签
            // 
            this.姓名标签.Location = new System.Drawing.Point(202, 172);
            this.姓名标签.Name = "姓名标签";
            this.姓名标签.Size = new System.Drawing.Size(100, 23);
            this.姓名标签.TabIndex = 0;
            this.姓名标签.Text = "姓名：";
            this.姓名标签.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // 删除按钮
            // 
            this.删除按钮.AutoSize = true;
            this.删除按钮.Location = new System.Drawing.Point(227, 288);
            this.删除按钮.Name = "删除按钮";
            this.删除按钮.Size = new System.Drawing.Size(75, 25);
            this.删除按钮.TabIndex = 2;
            this.删除按钮.Text = "确定";
            this.删除按钮.UseVisualStyleBackColor = true;
            // 
            // 按姓名输入成员窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.删除按钮);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.姓名标签);
            this.Name = "按姓名输入成员窗口";
            this.Text = "按姓名输入成员窗口";
            this.Load += new System.EventHandler(this.按姓名删除成员窗口_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 姓名标签;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button 删除按钮;
    }
}