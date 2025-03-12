using Microsoft.EntityFrameworkCore;

namespace Lection0211
{
    public class CategoryService
    {
        public readonly AppDbContext _context = new();

        public async Task<List<Category>> GetCategoriesAsync() => await _context.Categories.Include(c=> c.Games).ToListAsync();

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category); // RemoveRange
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            var currentCategory = await _context.Categories.FindAsync(category.CategoryId);
            if (currentCategory != null)
            {
                currentCategory.Name = category.Name;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> AddCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category.CategoryId;
        }
    }
}
