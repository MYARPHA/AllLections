using System.Text.RegularExpressions;

Console.WriteLine("Regex");

// 1
string input = "Hello world hello 123 hELLO";
string pattern = @"hello";
string replacement = "..."; //шаблон замены

/* // 2 Regex
// 2 (1 вариант)
string result = Regex.Replace(input, pattern, replacement, RegexOptions.IgnoreCase);
Console.WriteLine(result);
// 2 (2 вариант)
Regex regex = new(pattern, RegexOptions.IgnoreCase);
result = regex.Replace(result, replacement); */

//
string[] results =  Regex.Split(input, pattern);
//
Regex regex = new(pattern);
results = regex.Split(input);

// 3
/* if (regex.IsMatch(input))
    Console.WriteLine("Совпадение найдено"); */

/* Match match = regex.Match(input);
if (match.Success)
    Console.WriteLine($"Совпадение {match.Value} найдено"); */

/* Match match = regex.Match(input);
if (match.Success)
{
    // match.Groups
    Console.WriteLine($"Совпадение {match.Groups[0]} найдено");
    for (int i = 0; i < match.Groups.Count; i++)
        Console.WriteLine($"{i}: {match.Groups[i]}");
} */

/* Match match = regex.Match(input);
while (match.Success)
{
    Console.WriteLine($"Совпадение {match.Value} найдено");
    match = match.NextMatch();  //переход к следующему совпадению
} */

/* MatchCollection matches = regex.Matches(input);
foreach (Match match in matches)
    Console.WriteLine($"совпадение {match.Value}");
for (int i = 0; i < matches.Count; i++)
    Console.WriteLine($"{i} совпадение {matches[i].Value}"); */
