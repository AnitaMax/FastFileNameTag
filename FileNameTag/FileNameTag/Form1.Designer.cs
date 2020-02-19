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
            this.编辑类别 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.Tags.Location = new System.Drawing.Point(286, 149);
            this.Tags.Name = "Tags";
            this.Tags.Size = new System.Drawing.Size(357, 244);
            this.Tags.TabIndex = 2;
            // 
            // TagTypes
            // 
            this.TagTypes.FormattingEnabled = true;
            this.TagTypes.ItemHeight = 15;
            this.TagTypes.Items.AddRange(new object[] {
            "[所有]",
            "-类别",
            "-星级",
            "[其他]"});
            this.TagTypes.Location = new System.Drawing.Point(64, 149);
            this.TagTypes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TagTypes.Name = "TagTypes";
            this.TagTypes.Size = new System.Drawing.Size(162, 244);
            this.TagTypes.TabIndex = 3;
            this.TagTypes.SelectedIndexChanged += new System.EventHandler(this.TagTypes_SelectedIndexChanged);
            // 
            // 编辑类别
            // 
            this.编辑类别.Location = new System.Drawing.Point(156, 399);
            this.编辑类别.Name = "编辑类别";
            this.编辑类别.Size = new System.Drawing.Size(70, 28);
            this.编辑类别.TabIndex = 4;
            this.编辑类别.Text = "编辑";
            this.编辑类别.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "编辑标签";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "增加";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(64, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 55);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.编辑类别);
            this.Controls.Add(this.TagTypes);
            this.Controls.Add(this.Tags);
            this.Controls.Add(this.separation);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "修改文件标签";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox separation;
        private System.Windows.Forms.CheckedListBox Tags;
        private System.Windows.Forms.ListBox TagTypes;
        private System.Windows.Forms.Button 编辑类别;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

