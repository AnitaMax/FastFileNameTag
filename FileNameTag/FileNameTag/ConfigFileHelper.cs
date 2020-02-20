using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FileNameTag
{
    using TypeTag = Dictionary<string, List<String>>;
    public class Section
    {
        public String title = "";
        public Dictionary<String, String> Contents = new Dictionary<String, String>();
        public List<string> ToList()
        {
            List<string> strs = new List<string>();
            strs.Add("["+title+"]");
            foreach(var key in Contents.Keys)
            {
                strs.Add(key + " = " + Contents[key]);
            }
            return strs;
        }
    }
    public class FileType
    {
        private string name;
        private string suffiexs;

        public string Name { get => name; set => name = value; }
        public string Suffiexs { get => suffiexs; set => suffiexs = value; }


        public FileType(string name, string suffiexs)
        {
            this.Name = name;
            this.Suffiexs = suffiexs;
        }

        public FileType()
        {
        }
    }
    public class IniFileHelper
    {

        //static String ConfigFilePath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"..\..\tags.ini";
        static String ConfigFilePath = @"D:\tags.ini";

        public static List<Section> ReadAllSections()
        {
           
            //读取配置文件
            string[] lines = null;
            try
            {
                lines = System.IO.File.ReadAllLines(ConfigFilePath);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "致命错误", MessageBoxButtons.OK);
                Environment.Exit(1);
            }
            //容器
            List<Section> Sections = new List<Section>(); 
            Section section = null;
            foreach(var line in lines)
            {
                //去掉每行的空格 回车 换行
                string line2 = line.Replace(" ", "").Replace("/n", "").Replace("/r", "");
                //如果是[title]
                if (line2.StartsWith("[") && line2.EndsWith("]"))
                {
                    //添加上个循环中的section ，null是第一次
                    if (section != null)
                    {
                        Sections.Add(section);
                    }
                    section = new Section();
                    section.title=line2.Substring(1, line2.Length - 2);
                }
                //如果是xx = xx
                else if(line2.Contains("="))
                {
                    var attribute = line2.Split('=');
                    section.Contents.Add(attribute[0], attribute[1]);

                }
                //如果是其他
                else
                {

                }

            }
            //添加最后一个循环中的section ，null是第一次为空
            if (section != null)
            {
                Sections.Add(section);
            }
            print(Sections);
            return Sections;
        }
        public static void print(List<Section> sections)
        {
            foreach (var sec in sections)
            {
                Console.WriteLine(sec.title);
                foreach (var a in sec.Contents)
                {
                    Console.WriteLine(a.Key + ":" + a.Value);
                }
            }
        }

        public static void Save(List<Section> sections)
        {
            List<string> strs = new List<string>();
            foreach (var section in sections)
            {
                section.ToList().ForEach(str => strs.Add(str));
                strs.Add("     ");
            }
            System.IO.File.WriteAllLines(ConfigFilePath, strs.ToArray());
        }


    }
    public class FileTagConfigFileHelper 
    {
        List<Section> sections = IniFileHelper.ReadAllSections();
        public List<string> getTypes(string sufflex)
        {
            //容器
            List<string> types = new List<string>();
            Section FileTypeSection = null;
            //找到文件类型的section
            foreach(var section in sections)
            {
                if (section.title == "文件类型")
                {
                    FileTypeSection = section;
                }
            }
            //找到后辍对应的类型
            if (FileTypeSection != null)
            {
                foreach(var type in FileTypeSection.Contents.Keys)
                {
                    //分割
                    var values = FileTypeSection.Contents[type].Split(',');
                    //判断
                    if((new List<string>(values)).Contains(sufflex))
                    {
                        types.Add(type);
                    }

                }
            }
            return types;
        }
        public TypeTag getTags(string sufflex)
        {
            //文件类型
            var types = getTypes(sufflex);
            //容器
            var tags = new TypeTag();
            //找到文件类型的section
            foreach (var section in sections)
            {
                if (section.title != "文件类型" && section.title.StartsWith("#"))
                {
                    
                    if (section.Contents.ContainsKey("目标"))
                    {
                        var taget = new List<String>(section.Contents["目标"].Split(','));
                        if (taget.Contains("所有") 
                            || taget.Where(t => !t.StartsWith(".")&&types.Contains(t)).Count() > 0
                            || taget.Contains("."+sufflex)
                            )
                        {
                            tags.Add(section.title.Replace("#", ""), new List<string>(section.Contents["标签"].Split(',')));
                        }
                    }
                    else
                    {
                        tags.Add(section.title.Replace("#", ""), new List<string>(section.Contents["标签"].Split(',')));
                    }
                }
            }


            return tags;
        } 

        public List<FileType> GetFileTypes()
        {
            List<FileType> fileTypes = new List<FileType>();
            Section section = sections.Where<Section>(s => s.title == "文件类型").First();
            foreach(var key in section.Contents.Keys)
            {
                fileTypes.Add(new FileType(key, section.Contents[key]));
            }
            return fileTypes;
        }
        public void AddTagType(string target,string name,string tags)
        {
            Section section = new Section();
            section.title = "#"+name;
            if (target=="")
                section.Contents.Add("目标", "所有");
            else
                section.Contents.Add("目标", target);
            section.Contents.Add("标签 ", tags);
            sections.Add(section);
            IniFileHelper.Save(sections);
        }
        public void DeleteTagType(string name)
        {

            for(int i = 0; i < sections.Count; i++)
            {
                if (sections[i].title == "#" + name)
                {
                    sections.RemoveAt(i);
                }
            }
            IniFileHelper.Save(sections);
        }

        public void EditTagsType(string target, string name, string tags)
        {
            DeleteTagType(name);
            AddTagType(target, name, tags);

        }

    }

}
