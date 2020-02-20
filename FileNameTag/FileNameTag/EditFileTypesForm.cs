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

    public partial class EditFileTypesForm : Form
    {
        BindingList<FileType> fileTypeslist;
        public EditFileTypesForm()
        {
            InitializeComponent();
            fileTypeslist = new BindingList<FileType>(new FileTagConfigFileHelper().GetFileTypes());
            FileTypesGridView.DataSource = fileTypeslist;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FileTypesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
            if (e.RowIndex > -1 && e.RowIndex!= FileTypesGridView.Rows.Count -1&& FileTypesGridView.SelectedRows.Count>0)
            {
                DelFIleTypeButton.Enabled = true;

            }
            else
            {
                DelFIleTypeButton.Enabled = false;
            }
        }

        private void DelFIleTypeButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in FileTypesGridView.SelectedRows)
            {
                FileTypesGridView.Rows.Remove(row);
            }
            Console.WriteLine(fileTypeslist.Count);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var section = new Section();
            section.title = "文件类型";
            foreach(var row in fileTypeslist)
            {
                if (row.Name != null && row.Name!="")
                section.Contents.Add(row.Name, row.Suffiexs.Replace("，",","));
            }
            var sections = IniFileHelper.ReadAllSections();
            sections.RemoveAll(s => s.title == "文件类型");
            sections.Add(section);
            IniFileHelper.Save(sections);
            this.Close();
        }
    }
}
