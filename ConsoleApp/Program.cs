using Humanizer;

Console.WriteLine("please insert a name");
string name = Console.ReadLine();
Console.WriteLine("please insert your position");
string position = Console.ReadLine();
Console.WriteLine("please insert your age");
int age = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"My name is  {name}, my position is {position}, and have {age.ToWords(new System.Globalization.CultureInfo("en"))} years");
