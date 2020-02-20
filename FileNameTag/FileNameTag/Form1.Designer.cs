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
            this.SeparationBox = new System.Windows.Forms.TextBox();
            this.TagsBox = new System.Windows.Forms.CheckedListBox();
            this.TypesBox = new System.Windows.Forms.ListBox();
            this.DelTagTypeButton = new System.Windows.Forms.Button();
            this.AddTagType = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前进ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册右键菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除右键菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNameBox = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MyTagBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ReSplitButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ToolsPanel = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FileTypeLable = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(55, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "分隔符";
            // 
            // SeparationBox
            // 
            this.SeparationBox.Location = new System.Drawing.Point(142, 170);
            this.SeparationBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SeparationBox.MaxLength = 1;
            this.SeparationBox.Name = "SeparationBox";
            this.SeparationBox.Size = new System.Drawing.Size(33, 28);
            this.SeparationBox.TabIndex = 0;
            this.SeparationBox.Text = "_";
            this.SeparationBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SeparationBox_MouseClick);
            // 
            // TagsBox
            // 
            this.TagsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TagsBox.CheckOnClick = true;
            this.TagsBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TagsBox.FormattingEnabled = true;
            this.TagsBox.Location = new System.Drawing.Point(308, 270);
            this.TagsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TagsBox.Name = "TagsBox";
            this.TagsBox.Size = new System.Drawing.Size(204, 188);
            this.TagsBox.TabIndex = 2;
            this.TagsBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TagsBox_MouseClick);
            // 
            // TypesBox
            // 
            this.TypesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TypesBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TypesBox.FormattingEnabled = true;
            this.TypesBox.ItemHeight = 18;
            this.TypesBox.Items.AddRange(new object[] {
            "[所有]"});
            this.TypesBox.Location = new System.Drawing.Point(58, 271);
            this.TypesBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TypesBox.Name = "TypesBox";
            this.TypesBox.Size = new System.Drawing.Size(182, 184);
            this.TypesBox.TabIndex = 0;
            this.TypesBox.SelectedIndexChanged += new System.EventHandler(this.TagTypes_SelectedIndexChanged);
            this.TypesBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TypesBox_MouseDoubleClick);
            // 
            // DelTagTypeButton
            // 
            this.DelTagTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelTagTypeButton.Enabled = false;
            this.DelTagTypeButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DelTagTypeButton.Location = new System.Drawing.Point(161, 465);
            this.DelTagTypeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DelTagTypeButton.Name = "DelTagTypeButton";
            this.DelTagTypeButton.Size = new System.Drawing.Size(79, 34);
            this.DelTagTypeButton.TabIndex = 4;
            this.DelTagTypeButton.Text = "删除";
            this.DelTagTypeButton.UseVisualStyleBackColor = true;
            this.DelTagTypeButton.Click += new System.EventHandler(this.DelTagTypeButton_Click);
            // 
            // AddTagType
            // 
            this.AddTagType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddTagType.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddTagType.Location = new System.Drawing.Point(59, 465);
            this.AddTagType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddTagType.Name = "AddTagType";
            this.AddTagType.Size = new System.Drawing.Size(63, 34);
            this.AddTagType.TabIndex = 6;
            this.AddTagType.Text = "增加";
            this.AddTagType.UseVisualStyleBackColor = true;
            this.AddTagType.Click += new System.EventHandler(this.AddTagType_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(696, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.前进ToolStripMenuItem,
            this.撤销ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 前进ToolStripMenuItem
            // 
            this.前进ToolStripMenuItem.Name = "前进ToolStripMenuItem";
            this.前进ToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.前进ToolStripMenuItem.Text = "前进";
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.撤销ToolStripMenuItem.Text = "撤销";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册右键菜单ToolStripMenuItem,
            this.删除右键菜单ToolStripMenuItem,
            this.更新ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.关于ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 注册右键菜单ToolStripMenuItem
            // 
            this.注册右键菜单ToolStripMenuItem.Name = "注册右键菜单ToolStripMenuItem";
            this.注册右键菜单ToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.注册右键菜单ToolStripMenuItem.Text = "注册右键菜单";
            this.注册右键菜单ToolStripMenuItem.Click += new System.EventHandler(this.注册右键菜单ToolStripMenuItem_Click);
            // 
            // 删除右键菜单ToolStripMenuItem
            // 
            this.删除右键菜单ToolStripMenuItem.Name = "删除右键菜单ToolStripMenuItem";
            this.删除右键菜单ToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.删除右键菜单ToolStripMenuItem.Text = "删除右键菜单";
            this.删除右键菜单ToolStripMenuItem.Click += new System.EventHandler(this.删除右键菜单ToolStripMenuItem_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.更新ToolStripMenuItem.Text = "检查更新";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // FileNameBox
            // 
            this.FileNameBox.AllowDrop = true;
            this.FileNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameBox.AutoScroll = true;
            this.FileNameBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FileNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileNameBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileNameBox.Location = new System.Drawing.Point(58, 49);
            this.FileNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(454, 79);
            this.FileNameBox.TabIndex = 10;
            this.FileNameBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileNameBox_DragDrop);
            this.FileNameBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileNameBox_DragEnter);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(306, 522);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(162, 36);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "保存文件名";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(181, 166);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "保存至配置";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MyTagBox
            // 
            this.MyTagBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyTagBox.Location = new System.Drawing.Point(308, 175);
            this.MyTagBox.Name = "MyTagBox";
            this.MyTagBox.Size = new System.Drawing.Size(204, 28);
            this.MyTagBox.TabIndex = 12;
            this.MyTagBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyTagBox_MouseClick);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(430, 216);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(82, 36);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "插入";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ReSplitButton
            // 
            this.ReSplitButton.Location = new System.Drawing.Point(58, 216);
            this.ReSplitButton.Name = "ReSplitButton";
            this.ReSplitButton.Size = new System.Drawing.Size(100, 37);
            this.ReSplitButton.TabIndex = 14;
            this.ReSplitButton.Text = "重新划分";
            this.ReSplitButton.UseVisualStyleBackColor = true;
            this.ReSplitButton.Click += new System.EventHandler(this.ReSplitButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(181, 217);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(89, 36);
            this.ReplaceButton.TabIndex = 15;
            this.ReplaceButton.Text = "替换";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackButton.Location = new System.Drawing.Point(140, 522);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 36);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "复原";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolsPanel.Controls.Add(this.button4);
            this.ToolsPanel.Location = new System.Drawing.Point(535, 49);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(115, 437);
            this.ToolsPanel.TabIndex = 17;
            this.ToolsPanel.TabStop = false;
            this.ToolsPanel.Text = "工具箱";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 31);
            this.button4.TabIndex = 0;
            this.button4.Text = "插入日期";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "类别：";
            // 
            // FileTypeLable
            // 
            this.FileTypeLable.AutoSize = true;
            this.FileTypeLable.Location = new System.Drawing.Point(127, 139);
            this.FileTypeLable.Name = "FileTypeLable";
            this.FileTypeLable.Size = new System.Drawing.Size(28, 19);
            this.FileTypeLable.TabIndex = 20;
            this.FileTypeLable.Text = "无";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(414, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 27);
            this.button6.TabIndex = 21;
            this.button6.Text = "编辑类型";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "双击标签类别编辑";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(399, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "单击删除，拖拽排序";
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 566);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.FileTypeLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.ReSplitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MyTagBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddTagType);
            this.Controls.Add(this.DelTagTypeButton);
            this.Controls.Add(this.TypesBox);
            this.Controls.Add(this.TagsBox);
            this.Controls.Add(this.SeparationBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(714, 613);
            this.Name = "MainWindow";
            this.Text = "修改文件标签";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ToolsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SeparationBox;
        private System.Windows.Forms.CheckedListBox TagsBox;
        private System.Windows.Forms.ListBox TypesBox;
        private System.Windows.Forms.Button DelTagTypeButton;
        private System.Windows.Forms.Button AddTagType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel FileNameBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox MyTagBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ReSplitButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前进ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ToolStripMenuItem 注册右键菜单ToolStripMenuItem;
        private System.Windows.Forms.GroupBox ToolsPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem 删除右键菜单ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FileTypeLable;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

