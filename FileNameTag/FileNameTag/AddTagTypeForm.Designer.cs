namespace FileNameTag
{
    partial class AddTagTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TypeNameBox = new System.Windows.Forms.TextBox();
            this.TagsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ConcelButton = new System.Windows.Forms.Button();
            this.FileTypesBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "目标类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "标签类型名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "标签";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(469, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "编辑类型";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TypeNameBox
            // 
            this.TypeNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeNameBox.Location = new System.Drawing.Point(180, 90);
            this.TypeNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TypeNameBox.Name = "TypeNameBox";
            this.TypeNameBox.Size = new System.Drawing.Size(260, 28);
            this.TypeNameBox.TabIndex = 5;
            // 
            // TagsBox
            // 
            this.TagsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TagsBox.Location = new System.Drawing.Point(180, 133);
            this.TagsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TagsBox.Multiline = true;
            this.TagsBox.Name = "TagsBox";
            this.TagsBox.Size = new System.Drawing.Size(260, 169);
            this.TagsBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "以“,”分割，非空";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveButton.Location = new System.Drawing.Point(119, 332);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(84, 28);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ConcelButton
            // 
            this.ConcelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConcelButton.Location = new System.Drawing.Point(398, 332);
            this.ConcelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConcelButton.Name = "ConcelButton";
            this.ConcelButton.Size = new System.Drawing.Size(84, 28);
            this.ConcelButton.TabIndex = 9;
            this.ConcelButton.Text = "取消";
            this.ConcelButton.UseVisualStyleBackColor = true;
            this.ConcelButton.Click += new System.EventHandler(this.ConcelButton_Click);
            // 
            // FileTypesBox
            // 
            this.FileTypesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileTypesBox.Location = new System.Drawing.Point(180, 40);
            this.FileTypesBox.Name = "FileTypesBox";
            this.FileTypesBox.Size = new System.Drawing.Size(260, 28);
            this.FileTypesBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "若为空则默认所有";
            // 
            // AddTagTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 379);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FileTypesBox);
            this.Controls.Add(this.ConcelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TagsBox);
            this.Controls.Add(this.TypeNameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(639, 426);
            this.Name = "AddTagTypeForm";
            this.Text = "添加标签类别";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TypeNameBox;
        private System.Windows.Forms.TextBox TagsBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ConcelButton;
        private System.Windows.Forms.TextBox FileTypesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}