namespace FamilySys
{
    partial class 输入姓名
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.请输入姓名 = new System.Windows.Forms.Label();
            this.确定 = new System.Windows.Forms.Button();
            this.姓名输入框 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28082F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.86387F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.34031F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.Controls.Add(this.请输入姓名, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.确定, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.姓名输入框, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 153);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // 请输入姓名
            // 
            this.请输入姓名.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.请输入姓名.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.请输入姓名, 2);
            this.请输入姓名.Location = new System.Drawing.Point(149, 30);
            this.请输入姓名.Name = "请输入姓名";
            this.请输入姓名.Size = new System.Drawing.Size(82, 15);
            this.请输入姓名.TabIndex = 0;
            this.请输入姓名.Text = "请输入姓名";
            // 
            // 确定
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.确定, 2);
            this.确定.Dock = System.Windows.Forms.DockStyle.Fill;
            this.确定.Location = new System.Drawing.Point(57, 98);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(266, 32);
            this.确定.TabIndex = 3;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            this.确定.Click += new System.EventHandler(this.确定_Click);
            // 
            // 姓名输入框
            // 
            this.姓名输入框.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.姓名输入框, 2);
            this.姓名输入框.Location = new System.Drawing.Point(57, 63);
            this.姓名输入框.Name = "姓名输入框";
            this.姓名输入框.Size = new System.Drawing.Size(266, 25);
            this.姓名输入框.TabIndex = 4;
            // 
            // 输入姓名
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "输入姓名";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label 请输入姓名;
        private System.Windows.Forms.Button 确定;
        private System.Windows.Forms.TextBox 姓名输入框;
    }
}