namespace FamilySys
{
    partial class 男女比例窗口
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
            this.男女比例 = new System.Windows.Forms.Label();
            this.男女比例展示框 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.男女比例返回 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.男女比例, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.男女比例展示框, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // 男女比例
            // 
            this.男女比例.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.男女比例.AutoSize = true;
            this.男女比例.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.男女比例.Location = new System.Drawing.Point(29, 52);
            this.男女比例.Name = "男女比例";
            this.男女比例.Size = new System.Drawing.Size(82, 15);
            this.男女比例.TabIndex = 0;
            this.男女比例.Text = "男女比例：";
            // 
            // 男女比例展示框
            // 
            this.男女比例展示框.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.男女比例展示框.AutoSize = true;
            this.男女比例展示框.Location = new System.Drawing.Point(194, 52);
            this.男女比例展示框.Name = "男女比例展示框";
            this.男女比例展示框.Size = new System.Drawing.Size(31, 15);
            this.男女比例展示框.TabIndex = 1;
            this.男女比例展示框.Text = "x:x";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.男女比例返回, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 87);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 65);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // 男女比例返回
            // 
            this.男女比例返回.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.男女比例返回.AutoSize = true;
            this.男女比例返回.Location = new System.Drawing.Point(102, 20);
            this.男女比例返回.Name = "男女比例返回";
            this.男女比例返回.Size = new System.Drawing.Size(75, 25);
            this.男女比例返回.TabIndex = 0;
            this.男女比例返回.Text = "返回";
            this.男女比例返回.UseVisualStyleBackColor = true;
            this.男女比例返回.Click += new System.EventHandler(this.男女比例返回_Click);
            // 
            // 男女比例窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "男女比例窗口";
            this.Text = "男女比例窗口";
            this.Load += new System.EventHandler(this.男女比例窗口_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label 男女比例;
        private System.Windows.Forms.Button 男女比例返回;
        private System.Windows.Forms.Label 男女比例展示框;
    }
}