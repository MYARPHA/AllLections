using DBLibrary;
using Microsoft.Identity.Client;

Console.WriteLine("ADO.Net"); // 1 вариант
//Console.WriteLine(DAL.ConnectionString);
await DAL.UpdatePriceAsync(1, 123);
Console.WriteLine(await DAL.GetTitleByIdAsync(1));

Console.WriteLine();

var titles = await DAL.GetTitlesAsync();
foreach (var title in titles)
    Console.WriteLine(title);

Console.ReadLine();