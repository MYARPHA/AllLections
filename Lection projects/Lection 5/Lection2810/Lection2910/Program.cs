using Dapper;
using Lection2910;
using Microsoft.Data.SqlClient;
using System.Data;

Console.WriteLine("Dapper"); // При создании подключения вместо класса провайдера Connection используется интерфейс IDbConnection, который dapper дополняет методами Query и Execute

// Создание подключения
SqlConnectionStringBuilder builder = new()
{
    DataSource = "PRSERVER\\SQLEXPRESS", // Сервер
    InitialCatalog = "ispp2112", // БД
    UserID = "ispp2112", // Логин
    Password = "2112", //Пароль
    TrustServerCertificate = true
};
using IDbConnection connection = new SqlConnection(builder.ConnectionString);

// Создание запроса
// string query = "SELECT * FROM Category"; // В query может быть несколько запросов через точку с запятой (;) 

// Выполнение запроса 
//connection.МетодDapper(query, параметры); // Параметром может быть объект пользовательского типа или анонимного
//await connection.МетодDapperAsync(query, new {ИмяПараметра = знач1, ИмяПараметра2 = знач2});



// Методы Dapper:

//Query:
//1 Query<T> - вернет набор объектов
//2 QuerySingle<T> - Вернет единственную строку. Если строк будет больше, то это ошибка
//3 QueryFirst<T> - Вернет первую строку. 
//4 QuerySingleOrDefault<T>
//3 QueryFirstOrDefault<T>

//Execute DML(INSERT, UPDATE, DELETE):
//1 ExecuteScalar<T> - вернет простое значение 
//2 ExecuteMultiple<T> - позволяет получить значения(данные) нескольких запросов

string query = "SELECT * FROM Category";
var categories = await connection.QueryAsync<Category>(query);
Console.WriteLine();

query = "SELECT * FROM Category WHERE CategoryId = @Id";
var category = await connection.QuerySingleOrDefaultAsync<Category>(query, new { Id = 1 });
Console.WriteLine();

query = "UPDATE Category SET Name = 'RPG' WHERE Name = @Name";
await connection.ExecuteAsync(query, new { Name = "РПГ" });
Console.WriteLine();

query = "INSERT INTO Category(Name) VALUES(@Name)";
await connection.ExecuteAsync(query, new { Name = "Souls-like" });
Console.WriteLine();

query = "INSERT INTO Category(Name) VALUES(@Name); SELECT SCOPE_IDENTITY()";
Category arcada = new() { Name = "аркада" };
int id = await connection.ExecuteScalarAsync<int>(query, arcada);
Console.WriteLine();

