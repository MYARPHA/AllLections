using Lection1113.Data;
using Lection1113.Models;

Console.WriteLine("Relations");
GameContext context = new();

// 1:M Category:Game
string filePath = @"Y:\МДК.11.01\Import\games.txt";

// Прочитать все строки из файла
string[] lines = File.ReadAllLines(filePath);
// Пройти по каждой строке и разделить ее на поля
foreach (string line in lines)
{
    string[] fields = line.Split(';');

    // чтение записей родителькой(категория)
    var category = context.Categories.SingleOrDefault(c => c.Name == fields[2]);
    if (category == null)
    {
        category = new() { Name = fields[2] };
        context.Categories.Add(category);
    }
    // чтение дочерней (игра)
    Game game = new()
    {
        Name = fields[0],
        Price = Convert.ToDecimal(fields[1]),
        Category = category
    };

    context.Games.Add(game);

    context.SaveChanges();
}


// M:M Photo:Tag
filePath = @"Y:\МДК.11.01\Import\photos.txt";
lines = File.ReadAllLines(filePath);

foreach (string line in lines)
{
    string[] fields = line.Split(';');

    // чтение записей родителькой(тэги)
    var tag = context.Tags.SingleOrDefault(c => c.Name == fields[1]);
    if (tag == null)
    {
        tag = new() { Name = fields[1] };
        context.Tags.Add(tag);
    }
    // чтение записей родителькой(фото)
    var photo = context.Photos
        .SingleOrDefault(p => p.Path == fields[0]);
    if (photo == null)
    {
        photo = new() { Path = fields[0] };
        context.Photos.Add(photo);
    }

    // чтение записи дочерней (тэги фото)
    if (!photo.Tags.Contains(tag))
        photo.Tags.Add(tag);

    context.SaveChanges();
}

