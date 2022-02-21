Console.WriteLine("insert word");
string input = Console.ReadLine().ToLower();
Console.WriteLine("choose a method (A/B) : ");
string chosenMethod = Console.ReadLine().ToLower();
if (chosenMethod == "a")
{
    methodA(input);
}
else if (chosenMethod == "b")
{
    methodB(input);
}
else
{
    Console.WriteLine("You didn't choose the method well!");
}

static void methodA(string word)
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
    Console.WriteLine($"{res}");
}
static void methodB(string word)
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
    Console.WriteLine($"{res}");
}
