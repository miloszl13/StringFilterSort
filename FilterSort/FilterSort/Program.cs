using FilterSort;

string input = new UserInput().AskForWord();
string chosenMethod = new UserInput().AskForMethod();

string result = new StringChecker().GetResult(chosenMethod, input);
Console.WriteLine(result);
