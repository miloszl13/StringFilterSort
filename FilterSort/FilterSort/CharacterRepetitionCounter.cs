using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterSort
{
    public class CharachterRepetitionCounter
    {
        public string Count(string word)
        {
            string res = "";
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                string c = word[i].ToString();
                if (!res.Contains(c))
                {
                    res = res + c;
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] == Convert.ToChar(c))
                        {
                            counter++;
                        }
                    }
                }
                else
                {
                    continue;
                }
                res = res + counter;
                counter = 0;
            }
            return res;
        }
    }
}
