using DapperRepo;

Console.WriteLine("Dapper + Repository");

DatabaseContext context = new("PRSERVER\\SQLEXPRESS", "ispp2112", "ispp2112", "2112");
CategoryRepository repository = new(context);

var categories = await repository.GetAllAsync();
Console.WriteLine();

var category = await repository.GetByIdAsync(3);
Console.WriteLine(category.Name);

category.Name = "qwerty";
repository.UpdateAsync(category);
category = await repository.GetByIdAsync(3);
Console.WriteLine(category.Name);
Console.WriteLine();

