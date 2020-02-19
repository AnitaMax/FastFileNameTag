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
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
            separation.SelectionStart = 0;
            var s=new FileTagConfigFileHelper().getTags("txt");
            foreach(var str in s.Keys)
            {
                Console.WriteLine(str+"="+s[str]);
            }
            
           
        }

        private void separation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TagTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            String index = (String)TagTypes.SelectedItem;
            Console.WriteLine(index);
        }


    }
}
