using Dapper;
using static Dapper.SqlMapper;

namespace DapperRepo
{
    internal class CategoryRepository : IRepository<Category>
    {
        private readonly DatabaseContext _context;

        public CategoryRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Category entity)
        {
            string query = "INSERT INTO Category(Name) VALUES(@Name)";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, entity);
        }

        public async Task DeleteAsync(int id)
        {
            string query = "DELETE FROM Category WHERE CategoryId = @Id";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { Id = id });
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            string query = "SELECT * FROM Category";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<Category>(query);
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            string query = "SELECT * FROM Category WHERE CategoryId = @Id";
            using var connection = _context.CreateConnection();
            return await connection.QuerySingleOrDefaultAsync<Category>(query, new { Id = id });
        }

        public async Task UpdateAsync(Category entity)
        {
            string query = "UPDATE Category SET Name = @Name WHERE CategoryId = @Id";
            using var connection = _context.CreateConnection();
            connection.ExecuteAsync(query, entity);
        }
    }
}
