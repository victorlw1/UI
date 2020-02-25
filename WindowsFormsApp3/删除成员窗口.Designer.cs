namespace WindowsFormsApp3
{
    partial class 删除成员窗口
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
            this.性别展示框 = new System.Windows.Forms.Label();
            this.年龄展示框 = new System.Windows.Forms.Label();
            this.姓名展示框 = new System.Windows.Forms.Label();
            this.年龄 = new System.Windows.Forms.Label();
            this.性别 = new System.Windows.Forms.Label();
            this.姓名 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.与自己的关系 = new System.Windows.Forms.Label();
            this.亲戚关系展示框 = new System.Windows.Forms.Label();
            this.确认删除 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 性别展示框
            // 
            this.性别展示框.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.性别展示框.AutoSize = true;
            this.性别展示框.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.性别展示框, 2);
            this.性别展示框.Location = new System.Drawing.Point(130, 74);
            this.性别展示框.Name = "性别展示框";
            this.性别展示框.Size = new System.Drawing.Size(208, 17);
            this.性别展示框.TabIndex = 23;
            this.性别展示框.Text = "性别展示框";
            // 
            // 年龄展示框
            // 
            this.年龄展示框.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.年龄展示框.AutoSize = true;
            this.年龄展示框.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.年龄展示框, 2);
            this.年龄展示框.Location = new System.Drawing.Point(130, 116);
            this.年龄展示框.Name = "年龄展示框";
            this.年龄展示框.Size = new System.Drawing.Size(208, 17);
            this.年龄展示框.TabIndex = 22;
            this.年龄展示框.Text = "年龄展示框";
            // 
            // 姓名展示框
            // 
            this.姓名展示框.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.姓名展示框.AutoSize = true;
            this.姓名展示框.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.姓名展示框, 2);
            this.姓名展示框.Location = new System.Drawing.Point(130, 32);
            this.姓名展示框.Name = "姓名展示框";
            this.姓名展示框.Size = new System.Drawing.Size(208, 17);
            this.姓名展示框.TabIndex = 21;
            this.姓名展示框.Text = "姓名展示框";
            // 
            // 年龄
            // 
            this.年龄.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.年龄.AutoSize = true;
            this.年龄.Location = new System.Drawing.Point(55, 117);
            this.年龄.Name = "年龄";
            this.年龄.Size = new System.Drawing.Size(37, 15);
            this.年龄.TabIndex = 2;
            this.年龄.Text = "年龄";
            // 
            // 性别
            // 
            this.性别.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.性别.AutoSize = true;
            this.性别.Location = new System.Drawing.Point(55, 75);
            this.性别.Name = "性别";
            this.性别.Size = new System.Drawing.Size(37, 15);
            this.性别.TabIndex = 1;
            this.性别.Text = "性别";
            // 
            // 姓名
            // 
            this.姓名.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.姓名.AutoSize = true;
            this.姓名.Location = new System.Drawing.Point(55, 33);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(37, 15);
            this.姓名.TabIndex = 0;
            this.姓名.Text = "姓名";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.姓名, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.性别, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.年龄, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.姓名展示框, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.年龄展示框, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.性别展示框, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.与自己的关系, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.亲戚关系展示框, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.确认删除, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 253);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // 与自己的关系
            // 
            this.与自己的关系.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.与自己的关系.AutoSize = true;
            this.与自己的关系.Location = new System.Drawing.Point(23, 159);
            this.与自己的关系.Name = "与自己的关系";
            this.与自己的关系.Size = new System.Drawing.Size(101, 15);
            this.与自己的关系.TabIndex = 24;
            this.与自己的关系.Text = "与自己的关系";
            // 
            // 亲戚关系展示框
            // 
            this.亲戚关系展示框.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.亲戚关系展示框.AutoSize = true;
            this.亲戚关系展示框.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.亲戚关系展示框, 2);
            this.亲戚关系展示框.Location = new System.Drawing.Point(130, 158);
            this.亲戚关系展示框.Name = "亲戚关系展示框";
            this.亲戚关系展示框.Size = new System.Drawing.Size(208, 17);
            this.亲戚关系展示框.TabIndex = 25;
            this.亲戚关系展示框.Text = "亲戚关系展示框";
            // 
            // 确认删除
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.确认删除, 2);
            this.确认删除.Dock = System.Windows.Forms.DockStyle.Fill;
            this.确认删除.Location = new System.Drawing.Point(130, 191);
            this.确认删除.Name = "确认删除";
            this.确认删除.Size = new System.Drawing.Size(208, 36);
            this.确认删除.TabIndex = 26;
            this.确认删除.Text = "确认删除";
            this.确认删除.UseVisualStyleBackColor = true;
            // 
            // 删除成员窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "删除成员窗口";
            this.Text = "删除成员窗口";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label 姓名;
        private System.Windows.Forms.Label 性别;
        private System.Windows.Forms.Label 年龄;
        private System.Windows.Forms.Label 姓名展示框;
        private System.Windows.Forms.Label 年龄展示框;
        private System.Windows.Forms.Label 性别展示框;
        private System.Windows.Forms.Label 与自己的关系;
        private System.Windows.Forms.Label 亲戚关系展示框;
        private System.Windows.Forms.Button 确认删除;
    }
}