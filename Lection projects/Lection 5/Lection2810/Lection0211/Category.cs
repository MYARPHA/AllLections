using System.ComponentModel.DataAnnotations.Schema;

namespace Lection0211
{
    [Table("Category")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<Game> Games { get; set; } //  В одной категории много игр 
    }
}
