using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterSort
{
    public class UserInput
    {
        public string AskForWord()
        {
            Console.WriteLine("insert word");
            string input = Console.ReadLine().ToLower();
            return input;
        }
        public string AskForMethod()
        {
            Console.WriteLine("choose a method (A/B) : ");
            string chosenMethod = Console.ReadLine().ToLower();
            if (chosenMethod != "a" && chosenMethod != "b")
            {
                chosenMethod="You didn't choose the method well!";
            }
            return chosenMethod;
        }
    }
}
