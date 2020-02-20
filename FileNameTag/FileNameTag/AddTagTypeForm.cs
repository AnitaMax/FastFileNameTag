using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileNameTag
{
    public partial class AddTagTypeForm : Form
    {
        
        public AddTagTypeForm()
        {
            InitializeComponent();
        }
        public AddTagTypeForm(List<string> filetypes )
        {
            InitializeComponent();
            FileTypesBox.Text = Tools.combine(filetypes, ",");
            SaveButton.Click += AddSaveButton_Click;


        }
        public AddTagTypeForm(List<string> filetypes,string name,List<string> Tags)
        {
            InitializeComponent();
            FileTypesBox.Text = Tools.combine(filetypes, ",");
            TypeNameBox.Text = name;
            TagsBox.Text= Tools.combine(Tags, ",");
            SaveButton.Click += EditSaveButton_Click;

        }

        private void ConcelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSaveButton_Click(object sender, EventArgs e)
        {
            if (FileTypesBox.Text == "")
            {
                MessageBox.Show("目标类型不能为空！");
            }
            if (TagsBox.Text == "")
            {
                MessageBox.Show("标签不能为空！");
            }
            new FileTagConfigFileHelper().AddTagType( FileTypesBox.Text.Replace("，",","), TypeNameBox.Text ,TagsBox.Text.Replace("，", ","));
            this.Close();
        }
        private void EditSaveButton_Click(object sender, EventArgs e)
        {
            if (FileTypesBox.Text == "")
            {
                MessageBox.Show("目标类型不能为空！");
            }
            if (TagsBox.Text == "")
            {
                MessageBox.Show("标签不能为空！");
            }
            new FileTagConfigFileHelper().EditTagsType(FileTypesBox.Text.Replace("，", ","), TypeNameBox.Text, TagsBox.Text.Replace("，", ","));
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var editFileTypeForm = new EditFileTypesForm();
            editFileTypeForm.ShowDialog();
        }
    }
}
