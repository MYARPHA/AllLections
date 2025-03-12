using Lection0211;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("C# Core tututuuu tuun sad music +vibe (slowed + reverb)");
Console.WriteLine("EF Core");


// Пакеты для подключения:
// Microsoft.EntityFrameworkCore.SqlServer
// Microsoft.EntityFrameworkCore.Sqlite
// Pomelo.EntityFrameworkCore.MySql
// Npgsql.EntityFrameworkCore.PostgreSQL

CategoryService service = new();
var categories = await service.GetCategoriesAsync();
foreach (var category in categories)
    Console.WriteLine(category.Name);

await service.DeleteCategoryAsync(9);

Console.WriteLine();
categories = await service.GetCategoriesAsync();
foreach (var category in categories)
    Console.WriteLine($"{category.Name} - {category.Games.Count}");


// Навигационные свойства - показывают связь между объектами и упрощают выборку связанных данных
// Связь многие-ко-многим, у которых нет дополнительных свойств, не создает отдельные классы
// Например, PhotoTag - значит в классе Photo и Tag будет список категорий

// В Tags: public List<Photo> Photos { get; set;}
// В Photo: public List<Tag> Tags { get; set;}



// 1 Шаг - создаем класс модели данных 
// 2 Шаг - создать класс контекста базы данных 

/*AppDbContext context = new();

var categories = await context.Categories.ToListAsync();
foreach (var category in categories)
    Console.WriteLine(category.Name);

Console.WriteLine();

var category2 = await context.Categories.FindAsync(2); // Позволяет найти значение по первичному ключу
Console.WriteLine(category2.Name);

var categoryRpg = await context.Categories.FirstOrDefaultAsync(c => c.Name == "RPG"); // Возвращает первое значение из набора
Console.WriteLine(categoryRpg.Name);

// var categoryArcade = await context.Categories.SingleOrDefaultAsync(c => c.Name == "аркада"); // Возвращает единственное значение из набора
//Console.WriteLine(categoryArcade.Name);

var racing = new Category { Name = "Гонки"};
await context.Categories.AddAsync(racing); // Добавляет один объект. AddRangeAsync - добавит набор объектов
await context.SaveChangesAsync();

var racingCategory = await context.Categories.FirstOrDefaultAsync(c => c.Name == "Гонки");
if (racingCategory != null)
{
    racingCategory.Name = "Racing";
    await context.SaveChangesAsync();
}
Console.WriteLine();



/*int idCategory = 8;
var rpgCategory = await context.Categories.FindAsync(idCategory);
if (rpgCategory != null)
{
    context.Categories.Remove(rpgCategory); // RemoveRange
    await context.SaveChangesAsync();
}

Console.WriteLine();*/