namespace FamilySys
{
    partial class 查找方法选择窗口
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.通过何种方式 = new System.Windows.Forms.Label();
            this.姓名选择框 = new System.Windows.Forms.RadioButton();
            this.关系选择框 = new System.Windows.Forms.RadioButton();
            this.确定 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28082F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.Controls.Add(this.通过何种方式, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.姓名选择框, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.关系选择框, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.确定, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 153);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // 通过何种方式
            // 
            this.通过何种方式.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.通过何种方式.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.通过何种方式, 2);
            this.通过何种方式.Location = new System.Drawing.Point(134, 30);
            this.通过何种方式.Name = "通过何种方式";
            this.通过何种方式.Size = new System.Drawing.Size(112, 15);
            this.通过何种方式.TabIndex = 0;
            this.通过何种方式.Text = "通过何种方式？";
            // 
            // 姓名选择框
            // 
            this.姓名选择框.AutoSize = true;
            this.姓名选择框.Location = new System.Drawing.Point(57, 60);
            this.姓名选择框.Name = "姓名选择框";
            this.姓名选择框.Size = new System.Drawing.Size(58, 19);
            this.姓名选择框.TabIndex = 1;
            this.姓名选择框.TabStop = true;
            this.姓名选择框.Text = "姓名";
            this.姓名选择框.UseVisualStyleBackColor = true;
            // 
            // 关系选择框
            // 
            this.关系选择框.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.关系选择框, 2);
            this.关系选择框.Location = new System.Drawing.Point(193, 60);
            this.关系选择框.Name = "关系选择框";
            this.关系选择框.Size = new System.Drawing.Size(58, 19);
            this.关系选择框.TabIndex = 2;
            this.关系选择框.TabStop = true;
            this.关系选择框.Text = "关系";
            this.关系选择框.UseVisualStyleBackColor = true;
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
            // 查找方法选择窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "查找方法选择窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label 通过何种方式;
        private System.Windows.Forms.RadioButton 姓名选择框;
        private System.Windows.Forms.RadioButton 关系选择框;
        private System.Windows.Forms.Button 确定;
    }
}