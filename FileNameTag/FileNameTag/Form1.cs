using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        string OldPath = "";
         string OldFileName = "test-三星.mp4";//从参数获取
         char SeparationChar = '_';

        List<string> filetypes = null;
        TypeTag typeTags = null;
        string filename = null;
        char separation_character = '_';
        List<string> filename_parts = null;
        string suffiex = null;

        private bool down = false;
        public string Filename
        {
            get => filename; set
            {
                filename = value;
                this.Text = this.Text + " -" + filename;
            }
        }

        private void GetArgs()
        {
            String[] CmdArgs = System.Environment.GetCommandLineArgs();
            if (CmdArgs.Length > 1)
            {
                //参数0是它本身的路径
                String arg0 = CmdArgs[0].ToString();
                String arg1 = CmdArgs[1].ToString();

               //MessageBox.Show(arg1);//显示得到的第一个参数

                OldPath = arg1;
                
            }
        }
        public void init()
        {
            if(OldPath!="")
                OldFileName = new List<String>(OldPath.Split('\\')).Last();
            //设置文件名
            filename = OldFileName;
            FlashFileNamePart();
            FlashFileNameBox();
            //设置分隔符
            separation_character = SeparationChar;
            SeparationBox.Text = separation_character.ToString();
            //设置文件类别
            filetypes = new FileTagConfigFileHelper().getTypes(suffiex);
            string ft = Tools.combine(filetypes, ",");
            if(ft!="")
                FileTypeLable.Text = ft;
            //设置标签类别
            TypesBox.Items.Clear();
            TypesBox.Items.Add("[所有]");
            typeTags = new FileTagConfigFileHelper().getTags(suffiex);
            foreach (var type in typeTags.Keys)
            {
                TypesBox.Items.Add("-" + type);
                //Console.WriteLine(type+"="+tags[type]);
            }
            TypesBox.Items.Add("[其他]");
            TypesBox.SetSelected(0, true);

        }
        public MainWindow()
        {
            InitializeComponent();
            //获取启动参数
            GetArgs();

            //初始化
            init();

            //标题栏
            if (filename != "")
                this.Text = this.Text + " -" + filename;


        }

        private void FlashFileNamePart()
        {
            suffiex = filename.Substring((filename.LastIndexOf(".")+1)).ToLower();
            filename =filename.Substring(0, (filename.LastIndexOf(".") ));
            filename_parts = new List<string>(filename.Split(separation_character));
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
                label.Click += FIleNameBoxPartLabel_Click;
                label.MouseDown += Label_MouseDown;
                label.MouseUp += Label_MouseUp;
                label.MouseMove += Label_MouseMove;
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

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FIleNameBoxPartLabel_Click(object sender, EventArgs e)
        {
            Console.WriteLine(((Label)sender).Text);
            filename_parts.Remove(((Label)sender).Text);
            FlashFileNameBox();
            FlashTagBox();
            MyTagBox.Text = ((Label)sender).Text;
        }

        private void TagTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlashTagBox();
            //删除按钮
            var cur = TypesBox.SelectedItem.ToString();
            if (cur.StartsWith("["))
                DelTagTypeButton.Enabled = false;
            else
                DelTagTypeButton.Enabled = true;

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
            init();
        }

        private void MainWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            OldPath=((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (System.IO.File.Exists(OldPath))
            {
                Console.WriteLine(OldPath);
                init();
            }


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(OldPath);
            string newPath = OldPath.Substring(0, OldPath.LastIndexOf('\\') +1)+ GetCurFileName();
            
            try
            {
                fileInfo.MoveTo(newPath);
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "致命错误", MessageBoxButtons.OK);
                Environment.Exit(1);
            }
            MessageBox.Show("重命名成功", "成功！", MessageBoxButtons.OK);
            //Environment.Exit(0);
            Application.Exit();

        }

        private void 注册右键菜单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey reg;
                reg = Registry.ClassesRoot;

                //创建新项FileNameTag
                reg = reg.CreateSubKey(@"*\shell\FileNameTag");
                //设置项值
                reg.SetValue("", "文件标签");

                reg = Registry.ClassesRoot;
                //创建新项command
                reg=reg.CreateSubKey(@"*\shell\FileNameTag\Command");
                //设置command的值
                reg.SetValue("", this.GetType().Assembly.Location + " \"%1\"");

                reg.Close();
                MessageBox.Show("右键注册成功", "成功！", MessageBoxButtons.OK);
            }
            catch(UnauthorizedAccessException e3)
            {
                MessageBox.Show(e3.Message+"请右键管理员权限运行!", "失败", MessageBoxButtons.OK);
                Environment.Exit(2);
            }
        }

        private void 删除右键菜单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    RegistryKey reg;
                    reg = Registry.ClassesRoot;
                    reg.DeleteSubKeyTree(@"*\shell\FileNameTag");
                    reg.Close();
                    MessageBox.Show("删除右键菜单成功", "成功！", MessageBoxButtons.OK);
                }
                catch (UnauthorizedAccessException e3)
                {
                    MessageBox.Show(e3.Message + "请右键管理员权限运行!", "失败", MessageBoxButtons.OK);
                    Environment.Exit(2);
                }
            }
        }

        private void AddTagType_Click(object sender, EventArgs e)
        {
            var addTagTypeForm=new AddTagTypeForm(filetypes);
            addTagTypeForm.ShowDialog();
            init();


        }

        private void TypesBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var name = TypesBox.SelectedItem.ToString();
            if (name.StartsWith("["))
                return;
            var tags = new List<String>();
            foreach(var tag in TagsBox.Items)
            {
                tags.Add(tag.ToString());
            }
            var addTagTypeForm = new AddTagTypeForm(filetypes,name.Remove(0,1),tags);
            addTagTypeForm.Text = "编辑标签";
            addTagTypeForm.ShowDialog();
            init();
            TypesBox.SelectedItem = name;
        }

        private void FileNameBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void FileNameBox_DragDrop(object sender, DragEventArgs e)
        {
            
            Label label = (Label)e.Data.GetData(typeof(Label));
            Point p = FileNameBox.PointToClient(new Point(e.X, e.Y));
            Control control = FileNameBox.GetChildAtPoint(p);
            int index = FileNameBox.Controls.GetChildIndex(control, false);
            //Console.WriteLine(index);
            filename_parts.RemoveAll(s=>s==label.Text);
            filename_parts.Insert(index/2,label.Text);
            FlashFileNameBox();
            //FileNameBox.Controls.SetChildIndex(label, index);
        }

        private void DelTagTypeButton_Click(object sender, EventArgs e)
        {
            var name = TypesBox.SelectedItem.ToString();
            new FileTagConfigFileHelper().DeleteTagType(name.Remove(0, 1));
            init();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var editFileTypeForm = new EditFileTypesForm();
            editFileTypeForm.ShowDialog();
            init();
        }
    }
}
