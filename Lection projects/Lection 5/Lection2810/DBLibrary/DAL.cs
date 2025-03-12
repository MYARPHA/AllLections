using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace DBLibrary
{
    public static class DAL
    {
        // Требуется подключить NuGet-пакет для соответствующей СУБД (провайдер данных)
        private static string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new()
                {
                    DataSource = "PRSERVER\\SQLEXPRESS", // Сервер
                    InitialCatalog = "ispp2112", // БД
                    UserID = "ispp2112", // Логин
                    Password = "2112", //Пароль
                    TrustServerCertificate = true
                };
                return builder.ConnectionString;
            }
        }

        public static async Task UpdatePriceAsync(int idGame, int newPrice)
        {
            using SqlConnection connection = new(ConnectionString);
            await connection.OpenAsync();

            string query = "UPDATE Game SET Price=@price WHERE GameId=@id";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", idGame);
            command.Parameters.AddWithValue("@price", newPrice);
            await command.ExecuteNonQueryAsync();
        }

        public static async Task<string?> GetTitleByIdAsync(int idGame)
        {
            using SqlConnection connection = new(ConnectionString);
            await connection.OpenAsync();

            string query = "SELECT Name FROM Game WHERE GameId=@id";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", idGame);
            var title = await command.ExecuteScalarAsync();
            return title.ToString();
        }

        public static async Task<List<string>> GetTitlesAsync()
        {
            using SqlConnection connection = new(ConnectionString);
            await connection.OpenAsync();

            string query = "SELECT Name FROM Game";
            SqlCommand command = new(query, connection);

            var reader = await command.ExecuteReaderAsync(); // Select lines
            List<string> titles = new();
            while (await reader.ReadAsync())
            {
                titles.Add(reader["Name"].ToString());
            }

            return titles;
        }
        public static async Task<List<Game>> GetGamesAsync()
        {
            using SqlConnection connection = new(ConnectionString);
            await connection.OpenAsync();

            string query = "SELECT * FROM Game";
            SqlCommand command = new(query, connection);

            var reader = await command.ExecuteReaderAsync(); // Select lines
            List<Game> games = new();
            while (await reader.ReadAsync())
            {
                games.Add(
                    new Game
                    {   Id = Convert.ToInt32(reader["GameId"]),
                        Name = reader["Name"].ToString(),
                        Price = Convert.ToDouble(reader["Price"])
                    });
            }

            return games;
        }
    }   
}


/*public class Role
    {
        string RoleName;
    }

    public class User
    {
        string Login;
        string Password;
        Role Role; //FK
    }*/

// LINQ-запрос:
// Code First - Сначала описываются классы, потом на их основе с помощью миграций создается база данных.
// Database First - Сначала создается база данных, потом на её основе в ручную или с помощью мапперов (mapper) создается описание классов.

// Алгоритм:
//1 Подключить провайдера используя NuGet

//2 Настроить строку подключения

//3 Открыть подключение:
/* using SqlConnection connection = new(connectionString);
await connection.OpenAsync();
connection.Open()*/

//4 выполнение SQL-запросов:
/*string query = "sql-запрос";
SqlCommand command = new(query, connection);
await command.Execute..Async();
command.Execute..();*/

//ExecuteNonQuery - DML/DDL
//ExecuteScalar - SELECT
//ExecuteReader - SELECT

//Для избавления от SQL-инъекций можно добавить параметр в запрос query и в параметры объекта command
//command.Parameters.AddWithValue("@имяПараметра", значение)

//тип? - это тип данных, допускающий NULL (int?)значение 