namespace FamilySys
{
    partial class 平均寿命窗口
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
            this.平均寿命 = new System.Windows.Forms.Label();
            this.平均寿命展示框 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.平均寿命返回 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 平均寿命
            // 
            this.平均寿命.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.平均寿命.AutoSize = true;
            this.平均寿命.Location = new System.Drawing.Point(29, 52);
            this.平均寿命.Name = "平均寿命";
            this.平均寿命.Size = new System.Drawing.Size(82, 15);
            this.平均寿命.TabIndex = 0;
            this.平均寿命.Text = "平均寿命：";
            // 
            // 平均寿命展示框
            // 
            this.平均寿命展示框.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.平均寿命展示框.AutoSize = true;
            this.平均寿命展示框.Location = new System.Drawing.Point(191, 52);
            this.平均寿命展示框.Name = "平均寿命展示框";
            this.平均寿命展示框.Size = new System.Drawing.Size(38, 15);
            this.平均寿命展示框.TabIndex = 1;
            this.平均寿命展示框.Text = "xx岁";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.平均寿命, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.平均寿命展示框, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 80);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.平均寿命返回, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-2, 86);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 65);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // 平均寿命返回
            // 
            this.平均寿命返回.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.平均寿命返回.AutoSize = true;
            this.平均寿命返回.Location = new System.Drawing.Point(102, 20);
            this.平均寿命返回.Name = "平均寿命返回";
            this.平均寿命返回.Size = new System.Drawing.Size(75, 25);
            this.平均寿命返回.TabIndex = 0;
            this.平均寿命返回.Text = "返回";
            this.平均寿命返回.UseVisualStyleBackColor = true;
            this.平均寿命返回.Click += new System.EventHandler(this.平均寿命返回_Click);
            // 
            // 平均寿命窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "平均寿命窗口";
            this.Text = "平均寿命窗口";
            this.Load += new System.EventHandler(this.平均寿命窗口_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label 平均寿命;
        private System.Windows.Forms.Label 平均寿命展示框;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button 平均寿命返回;
    }
}