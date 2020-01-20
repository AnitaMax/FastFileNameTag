namespace FileNameTag
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.separation = new System.Windows.Forms.TextBox();
            this.Tags = new System.Windows.Forms.CheckedListBox();
            this.TagTypes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(60, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "分隔符";
            // 
            // separation
            // 
            this.separation.Location = new System.Drawing.Point(168, 55);
            this.separation.MaxLength = 3;
            this.separation.Name = "separation";
            this.separation.Size = new System.Drawing.Size(100, 25);
            this.separation.TabIndex = 0;
            this.separation.Text = "_";
            this.separation.TextChanged += new System.EventHandler(this.separation_TextChanged);
            // 
            // Tags
            // 
            this.Tags.FormattingEnabled = true;
            this.Tags.Location = new System.Drawing.Point(276, 154);
            this.Tags.Name = "Tags";
            this.Tags.Size = new System.Drawing.Size(277, 224);
            this.Tags.TabIndex = 2;
            // 
            // TagTypes
            // 
            this.TagTypes.FormattingEnabled = true;
            this.TagTypes.ItemHeight = 15;
            this.TagTypes.Items.AddRange(new object[] {
            "类别",
            "星级",
            "其他"});
            this.TagTypes.Location = new System.Drawing.Point(64, 154);
            this.TagTypes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TagTypes.Name = "TagTypes";
            this.TagTypes.Size = new System.Drawing.Size(131, 214);
            this.TagTypes.TabIndex = 3;
            this.TagTypes.SelectedIndexChanged += new System.EventHandler(this.TagTypes_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 409);
            this.Controls.Add(this.TagTypes);
            this.Controls.Add(this.Tags);
            this.Controls.Add(this.separation);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "修改文件标签";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox separation;
        private System.Windows.Forms.CheckedListBox Tags;
        private System.Windows.Forms.ListBox TagTypes;
    }
}

