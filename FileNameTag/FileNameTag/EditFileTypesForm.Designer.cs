namespace FileNameTag
{
    partial class EditFileTypesForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DelFIleTypeButton = new System.Windows.Forms.Button();
            this.FileTypesGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suffiexs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FileTypesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(234, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "退出编辑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(425, 336);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(84, 28);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DelFIleTypeButton
            // 
            this.DelFIleTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelFIleTypeButton.Enabled = false;
            this.DelFIleTypeButton.Location = new System.Drawing.Point(621, 37);
            this.DelFIleTypeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DelFIleTypeButton.Name = "DelFIleTypeButton";
            this.DelFIleTypeButton.Size = new System.Drawing.Size(82, 34);
            this.DelFIleTypeButton.TabIndex = 4;
            this.DelFIleTypeButton.Text = "删除";
            this.DelFIleTypeButton.UseVisualStyleBackColor = true;
            this.DelFIleTypeButton.Click += new System.EventHandler(this.DelFIleTypeButton_Click);
            // 
            // FileTypesGridView
            // 
            this.FileTypesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileTypesGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.FileTypesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileTypesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.suffiexs});
            this.FileTypesGridView.Location = new System.Drawing.Point(55, 37);
            this.FileTypesGridView.Name = "FileTypesGridView";
            this.FileTypesGridView.RowHeadersWidth = 51;
            this.FileTypesGridView.RowTemplate.Height = 27;
            this.FileTypesGridView.Size = new System.Drawing.Size(525, 265);
            this.FileTypesGridView.TabIndex = 5;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "类型名";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // suffiexs
            // 
            this.suffiexs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.suffiexs.DataPropertyName = "suffiexs";
            this.suffiexs.HeaderText = "后辍";
            this.suffiexs.MinimumWidth = 6;
            this.suffiexs.Name = "suffiexs";
            // 
            // EditFileTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 400);
            this.Controls.Add(this.FileTypesGridView);
            this.Controls.Add(this.DelFIleTypeButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(755, 447);
            this.Name = "EditFileTypesForm";
            this.Text = "EditFileTypesForm";
            ((System.ComponentModel.ISupportInitialize)(this.FileTypesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DelFIleTypeButton;
        private System.Windows.Forms.DataGridView FileTypesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn suffiexs;
    }
}