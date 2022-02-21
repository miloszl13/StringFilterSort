using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterSort
{
    public class StringChecker
    {
         public string GetResult(string chosenMethod,string input)
        {
            if (chosenMethod == "a")
            {
                return new CharachterRepetitionCounter().Count(input);

            }
            else if (chosenMethod == "b")
            {
                return new StringFilter().Filter(input);
            }
            else
            {
                return "You didn't choose the method well!";
            }

        }
    }
}
