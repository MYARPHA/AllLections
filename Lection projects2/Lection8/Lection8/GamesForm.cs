namespace Lection8
{
    public partial class GamesForm : Form
    {
        List<Game> Games => new List<Game>
        {
             new Game{IdGame = 1, Name = "Tetris", Category = "головоломка", Price = 150},
             new Game{IdGame = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
             new Game{IdGame = 3, Name = "Pac-man", Description = "игра про колобка", Category = "аркада", Price = 300},
             new Game{IdGame = 4, Name = "Arkanoid", Category = "аркада", Price = 400},
             new Game{IdGame = 5, Name = "Mario", Description = "игра про Марио", Category = "платформер", Price = 1000},
             new Game{IdGame = 6, Name = "Tetris2", Category = "головоломка", Price = 150},
             new Game{IdGame = 7, Name = "Flappy Bird2", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
             new Game{IdGame = 8, Name = "Pac-man2", Description = "игра про колобка", Category = "аркада", Price = 300},
             new Game{IdGame = 9, Name = "Arkanoid2", Category = "аркада", Price = 400},
             new Game{IdGame = 10, Name = "Mario2", Description = "игра про Марио", Category = "платформер", Price = 1000},
        };

        List<Category> Categories => new List<Category>
        {
             new Category{Name = "головоломка", Description = "описание жанра головоломка"},
             new Category{Name = "платформер", Description = "описание жанра платформер"},
             new Category{Name = "RPG", Description = "описание жанра RPG"},
             new Category{Name = "аркада", Description = "описание жанра аркада"}
        };

        public GamesForm()
        {
            InitializeComponent();

            /* gamesDataGridView.DataSource = Games
                .Where(game => game.Price < 400)
                .ToList(); */

            //var games = Games.Select(game => new { game.Name });
            //var games = Games.Select(game => new
            //{
            //    game.Name,
            //    game.Price,
            //    SalePrice = game.Price * 0.9
            //});

            /* var games = Games.AsEnumerable();
            //если есть фильтр if по категории
            games = games.Where(game => game.Category == "аркада");
            //если есть фильтр if по описанию
            games = games.Where(game => game.Description != null);

            gamesDataGridView.DataSource = games.ToList(); */

            //пагинация
            /* int pageSize = 3;   //количество требуемых строк

            // 1 вариант поиска номера последней страницы где находятся писички сисички попочки
            int lastPageNumber = Games.Count / pageSize + (Games.Count % pageSize > 0 ? 1 : 0);
            // 2 вариант
            int maxPageNumber = (int)Math.Ceiling(1.0 * Games.Count / pageSize);

            MessageBox.Show(maxPageNumber.ToString());

            int pageNumber = 1; //номер страницы (с 1)
            var games = Games.Skip(pageSize * (pageNumber - 1)).Take(pageSize); */

            /* var games = Games
                .OrderBy(g => g.Category)
                .ThenBy(g => g.Price);

            gamesDataGridView.DataSource = games.ToList(); */

            /* var games = Games
                .GroupBy(game => game.Category)
                .Select(group => new
                {
                    Category = group.Key,
                    MaxPrice = group.Max(g => g.Price),
                    MinPrice = group.Min(g => g.Price),
                    GamesCount = group.Count()
                });
            gamesDataGridView.DataSource = games.ToList(); */

            /* var maxPrice = Games.Max(game => game.Price);
            MessageBox.Show($"{maxPrice} руб");

            string[] numbers = ["1", "2", "afgasdfg", "asdf", "5"];
            var result = numbers.Aggregate((s1, s2) => $"{s1}; {s2}");
            MessageBox.Show(result); */

            bool checkPrice = Games.All(game => game.Price > 500);
            MessageBox.Show(checkPrice.ToString());

            var password = "12qwwA!";
            bool hasDigit = password.Any(symbol => Char.IsDigit(symbol));
            bool hasPunctuation = password.Any(symbol => Char.IsPunctuation(symbol));
            bool hasLower = password.Any(symbol => Char.IsLower(symbol));
            bool hasUpper = password.Any(symbol => Char.IsUpper(symbol));
            MessageBox.Show($"{password}\n" +
                $"{hasDigit} - цифра\n" +
                $"{hasLower} - маленькая буква\n" +
                $"{hasUpper} - большая буква\n");

        }

        public void GamesForm_Load_1(object sender, EventArgs e)
        {
        }
    }
}
