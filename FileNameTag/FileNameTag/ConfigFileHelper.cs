using System;
using System.Collections.Generic;
namespace FileNameTag
{
    public class IniFileHelper
    {
        public class Section
        {
            public List<Dictionary<String, String>> Contents = new List<Dictionary<String, String>>();
        }
        
        public static List<Section> ReadAllSections()
        {
             List<Section> Sections = new List<Section>();

            return Sections;
        }
    }

}
