using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNameTag
{
    class Tools
    {
        public static List<string> split(string src,char split)
        {
            return src.Split(split).ToList<string>();
        }
        public static string combine(List<string> src,string s)
        {
            string res = "";
            if (src != null&&src.Count>0)
            {
                src.ForEach(a => res += a + s);
                res = res.Substring(0, res.Length - s.Length);
            }
            return res;
        }
    }
}
