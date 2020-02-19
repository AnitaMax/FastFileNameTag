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
    using TypeTag = Dictionary<string, List<String>>;

    public partial class MainWindow : Form
    {
        //用于复原
        const string OldFileName = "test-三星.txt";//从参数获取
        const char SeparationChar = '_';

        TypeTag typeTags = null;
        string filename = null;
        char separation_character = '_';
        List<string> filename_parts = null;
        string suffiex = null;
        public string Filename
        {
            get => filename; set
            {
                filename = value;
                this.Text = this.Text + " -" + filename;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            //标题栏
            if (filename != "")
                this.Text = this.Text + " -" + filename;
            //设置文件名
            filename = OldFileName;
            FlashFileNamePart();
            FlashFileNameBox();
            //设置分隔符
            separation_character = SeparationChar;
            SeparationBox.Text = separation_character.ToString();
            

            //设置标签类别
            typeTags = new FileTagConfigFileHelper().getTags(Filename.Split('.').Last());
            foreach (var type in typeTags.Keys)
            {
                TypesBox.Items.Add("-" + type);
                //Console.WriteLine(type+"="+tags[type]);
            }
            TypesBox.Items.Add("[其他]");
            TypesBox.SetSelected(0, true);
        }

        private void FlashFileNamePart()
        {
            filename_parts = new List<string>(filename.Split(separation_character, '.'));
            suffiex = filename_parts.Last();
            filename_parts.RemoveAt(filename_parts.Count - 1);
        }
        private void FlashFileNameBox()
        {
            FileNameBox.Controls.Clear();
            for (int i = 0; i < filename_parts.Count; i++)
            {

                Label label = new Label();
                label.Text = filename_parts[i];
                label.AutoSize = true;
                label.BorderStyle = BorderStyle.FixedSingle;
                FileNameBox.Controls.Add(label);
                if (i != filename_parts.Count - 1)
                {
                    Label label2 = new Label();
                    label2.Text = separation_character.ToString();
                    label2.AutoSize = true;
                    FileNameBox.Controls.Add(label2);
                }
            }
            Label label3 = new Label();
            label3.Text = "." + suffiex;
            label3.AutoSize = true;
            FileNameBox.Controls.Add(label3);
            Console.WriteLine(filename_parts.Count());
        }

        private void TagTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlashTagBox();
        }
        private void FlashTagBox()
        {
            //添加对应类别的标签
            String index = (String)TypesBox.SelectedItem;
            if (index == null)
                return;
            Console.WriteLine(index);
            TagsBox.Items.Clear();
            if (index == "[所有]")
            {
                foreach (var tags in typeTags.Values)
                {
                    tags.ForEach(t => TagsBox.Items.Add(t));
                }
            }
            else if (index == "[其他]")
            {
                filename_parts.ForEach(t => TagsBox.Items.Add(t));
                foreach (var tags in typeTags.Values)
                {
                    tags.ForEach(t => TagsBox.Items.Remove(t));
                }
            }
            else
            {
                typeTags[index.Replace("-", "")].ForEach(t => TagsBox.Items.Add(t));
            }
            //文件名里有的标签打勾
            filename_parts.ForEach(part =>
            {
                if (TagsBox.Items.Contains(part))
                {
                    TagsBox.SetItemChecked(TagsBox.Items.IndexOf(part), true);
                }

            });
        }

        private void TagsBox_MouseClick(object sender, MouseEventArgs e)
        {

            int index = TagsBox.IndexFromPoint(e.X, e.Y);
            TagsBox.SelectedIndex = index;
            if (TagsBox.SelectedIndex != -1)
            {
                var str = TagsBox.SelectedItem.ToString();
                //MessageBox.Show(TagsBox.SelectedItem.ToString());
                if (TagsBox.GetItemChecked(index))
                {
                    if (filename_parts.Contains(str))
                    {
                        filename_parts.Remove(TagsBox.SelectedItem.ToString());
                        Console.WriteLine(str + "删除成功");
                        MyTagBox.Text = str;//在MytagBox里保存上一个删除的内容，提供反悔的机会
                    }

                    else
                        Console.WriteLine(str + "不存在");
               
                }
                else
                {
                    if (!filename_parts.Contains(str))
                    {
                        filename_parts.Add(TagsBox.SelectedItem.ToString());
                        Console.WriteLine(str + "添加成功");
                    }
                    else
                        Console.WriteLine(str + "已存在");
                }
                FlashFileNameBox();
                FlashTagBox();
            }
        }


        private void SeparationBox_MouseClick(object sender, MouseEventArgs e)
        {
            SeparationBox.SelectAll();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            var str = MyTagBox.Text;
            if (!filename_parts.Contains(str))
            {
                filename_parts.Add(MyTagBox.Text);
                Console.WriteLine(str + "添加成功");
            }
            else
                Console.WriteLine(str + "已存在");
            FlashFileNameBox();
            FlashTagBox();
        }

        private void MyTagBox_MouseClick(object sender, MouseEventArgs e)
        {
            MyTagBox.SelectAll();
        }

        private string GetCurFileName()
        {
            string res = "";
            foreach(var part in FileNameBox.Controls)
            {
                Label a = (Label)part;
                res+=a.Text;
            }
            return res;
        }

        private void ReSplitButton_Click(object sender, EventArgs e)
        {
            if (SeparationBox.Text.Length > 0)
            {
                filename = GetCurFileName();
                separation_character = SeparationBox.Text[0];
                FlashFileNamePart();
                FlashFileNameBox();
                FlashTagBox();
            }
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            if (SeparationBox.Text.Length > 0)
            {
                filename = GetCurFileName();
                separation_character = SeparationBox.Text[0];
                FlashFileNameBox();

            }
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //初始化分隔符
            separation_character = SeparationChar;
            SeparationBox.Text = separation_character.ToString();
            //初始化文件名
            filename = OldFileName;
            FlashFileNamePart();
            FlashFileNameBox();
            //初始化标签
            FlashTagBox();
        }
    }
}
