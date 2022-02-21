using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterSort
{
    public class StringFilter
    {
        public string Filter(string word)
        {
            string res = "";
            for (int i = 0; i < word.Length; i++)
            {
                string c = word[i].ToString();
                if (!res.Contains(c))
                {
                    res = res + c;
                }
            }
            return res;
        }
    }
}
