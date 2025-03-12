using System.ComponentModel.DataAnnotations.Schema;

namespace Lection0211
{
    [Table("Game")]
    public class Game
    {
        public int GameId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public int TotalKeys { get; set; }

        public Category Category { get; set; } // У одной игры одна категория 
    }
}
