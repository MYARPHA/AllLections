using lection4_1;

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("record");

Person person = new("Имя", 20);
person = new("Володя", person.Age);

Console.WriteLine(person);

Person volodya = new("Володя", 20);
Console.WriteLine(person.Equals(volodya));


Color color = Color.White;
Color orange = Color.Red | Color.Yellow;

Color red = (Color)1;  // Color.Red = 1
int whiteNumber = (int)Color.White;
Console.WriteLine(whiteNumber);

for (int i = (int)Color.Black; i <= (int)Color.White; i++)
{
    Console.WriteLine((Color)i);
}

var admin = GetUser(123, "admin");
Console.WriteLine(admin);
Console.WriteLine(admin.id);
Console.WriteLine(admin.login);

static (int id, string login) GetUser(int id, string login)
{
    var user = (id, login);
    return user;
}