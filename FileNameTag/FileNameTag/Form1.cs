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
         TypeTag typeTags=null;
        public MainWindow()
        {
            InitializeComponent();
            separation.SelectionStart = 0;
            typeTags=new FileTagConfigFileHelper().getTags("txt");
            foreach(var type in typeTags.Keys)
            {
                TypesBox.Items.Add("-" + type);
                //Console.WriteLine(type+"="+tags[type]);
            }
            
           
        }

        private void separation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TagTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            String index = (String)TypesBox.SelectedItem;
            Console.WriteLine(index);
            TagsBox.Items.Clear();
            typeTags[index.Replace("-","")].ForEach(t => TagsBox.Items.Add(t));
            
        }


    }
}
