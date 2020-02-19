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
        TypeTag typeTags = null;
        string filename = "test_三星.txt";//从参数获取
        char separation_character = '_'; //从配置文件读取
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
            filename_parts = new List<string>(filename.Split(separation_character, '.'));
            suffiex = filename_parts.Last();
            filename_parts.RemoveAt(filename_parts.Count - 1);
            FlashFileNameBox();
            //设置分隔符
            SeparationBox.Text = separation_character.ToString();
            

            //设置标签类别
            typeTags = new FileTagConfigFileHelper().getTags(Filename.Split('.').Last());
            foreach (var type in typeTags.Keys)
            {
                TypesBox.Items.Add("-" + type);
                //Console.WriteLine(type+"="+tags[type]);
            }

            TypesBox.SetSelected(0, true);
        }


        private void FlashFileNameBox()
        {
            FileNameBox.Controls.Clear();
            for (int i = 0; i < filename_parts.Count; i++)
            {

                Label label = new Label();
                label.Text = filename_parts[i];
                label.AutoSize = true;
                FileNameBox.Controls.Add(label);
                if (i != filename_parts.Count - 1)
                {
                    Label label2 = new Label();
                    label2.Text = separation_character.ToString();
                    label2.AutoSize = true;
                    FileNameBox.Controls.Add(label2);
                }
            }
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

    }
}
