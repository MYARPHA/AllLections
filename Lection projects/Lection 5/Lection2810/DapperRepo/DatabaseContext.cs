﻿using Microsoft.Data.SqlClient;
using System.Data;

namespace DapperRepo
{
    internal class DatabaseContext
    {
        private readonly string _connectionString;

        public DatabaseContext(string server, string database, string login, string password)
        {
            SqlConnectionStringBuilder builder = new()
            {
                DataSource = server,
                InitialCatalog = database,
                UserID = login,
                Password = password,
                TrustServerCertificate = true
            };
            _connectionString = builder.ConnectionString;
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
