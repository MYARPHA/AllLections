using Lection3;
using System.Threading.Channels;

Console.WriteLine("Наследование классов");

Random random = new();
int x;
x = random.Next();              // min-max int
x = random.Next(100);           // 0-99
x = random.Next(-10, 10);       // -10 - 9
double y = random.NextDouble(); // 0.0 - 0.9999999999999999999999999~

ExtendedRandom random1 = new();
double r = random1.NextDouble(5.9, 8.7);
Console.WriteLine(r);

Cat garfield = new("Garfield", 5, "ginger");
garfield.Say();
Console.WriteLine(garfield.ToString());
Console.WriteLine(garfield.Equals(garfield));