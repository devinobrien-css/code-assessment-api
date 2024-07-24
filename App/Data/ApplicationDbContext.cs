using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using App.Models;
using Bogus;

namespace App.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<User>(options)
    {
        public new DbSet<User> Users { get; set; } = default!;
        public DbSet<ProfileAvatar> ProfileAvatars { get; set; } = default!;
        public DbSet<Book> Books { get; set; } = default!;
        public DbSet<Genre> Genres { get; set; } = default!;
        public DbSet<BookTransaction> BookTransactions { get; set; } = default!;
        public DbSet<UserFavoritesBook> UserFavoritesbooks { get; set; } = default!;
        public DbSet<Review> Reviews { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var profileAvatars = new List<ProfileAvatar>();
            for (int i = 1; i <= 35; i++)
            {
                profileAvatars.Add(new ProfileAvatar() { Id = i, Url = $"https://robohash.org/{i}" });
            }

            #region ProfileAvatarSeed
            builder.Entity<ProfileAvatar>().HasData(profileAvatars);
            #endregion

            var users = new Faker<User>()
                .RuleFor(u => u.First, f => f.Person.FirstName)
                .RuleFor(u => u.Last, f => f.Person.LastName)
                .RuleFor(u => u.Email, f => f.Person.Email)
                .RuleFor(u => u.UserName, f => f.Person.UserName)
                .RuleFor(u => u.ProfileAvatarId, f => f.Random.Number(1, 35))
                .Generate(5);

            var sampleUserIndex = 1;
            users.ForEach((u) =>
            {
                u.Id = "" + sampleUserIndex++;
            });

            #region UserSeed
            builder.Entity<User>().HasData(users);
            #endregion

            var genres = new List<Genre>
            {
                new() { Id = 1, Name = "Fiction" },
                new() { Id = 2, Name = "Non-Fiction" },
                new() { Id = 3, Name = "Self-Help" },
                new() { Id = 4, Name = "Biography" },
                new() { Id = 5, Name = "Cookbook" }
            };

            #region GenreSeed
            builder.Entity<Genre>().HasData(genres);
            #endregion

            builder.Entity<Book>()
                .HasMany(b => b.Transactions)
                .WithOne(t => t.Book)
                .HasForeignKey(t => t.BookId);

            builder.Entity<User>()
                .HasMany(u => u.Transactions)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId);

            builder.Entity<User>()
                .HasMany(u => u.Reviews)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId);

            builder.Entity<Book>()
                .HasMany(b => b.Reviews)
                .WithOne(t => t.Book)
                .HasForeignKey(t => t.BookId);

            var fakeBookImageIds = new List<string>([
                "https://drive.google.com/thumbnail?id=1zycl7EiCECK541ialA9UCrs9HdfddUQb&sz=w1000",
                "https://drive.google.com/thumbnail?id=1C4sRKzQrFUDNQ1X12WVeKbX0knOoC6tA&sz=w1000",
                "https://drive.google.com/thumbnail?id=12xFmb08WRoRr5omVtZ38Obo1imbutVlh&sz=w1000",
                "https://drive.google.com/thumbnail?id=1bOcpnwGFqsWJVLKxwXC4pdQgo5M1wzDi&sz=w1000",
                "https://drive.google.com/thumbnail?id=1Eu7yiiaAMfb0ktMOKhJZN6htKhF-TPDc&sz=w1000",
                "https://drive.google.com/thumbnail?id=1Hk2fvOg7hpmRwKWc-QTl82NGerqKib71&sz=w1000",
                "https://drive.google.com/thumbnail?id=1cozBSsETbbn8YWA27-cyfpxAgOKX-FwJ&sz=w1000",
                "https://drive.google.com/thumbnail?id=1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl&sz=w1000",
                "https://drive.google.com/thumbnail?id=1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5&sz=w1000",
                "https://drive.google.com/thumbnail?id=1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK&sz=w1000",
                "https://drive.google.com/thumbnail?id=1dwug9Rd51uRSIR61N0de32UGuZ1Ns3WH&sz=w1000",
                "https://drive.google.com/thumbnail?id=1UCje5bgDDxlWMWdYSK8tRgwMp-LkYM27&sz=w1000",
                "https://drive.google.com/thumbnail?id=17pwzIwvq6pyTJyqQ9ooT7dRXMwIHVNeU&sz=w1000",
                "https://drive.google.com/thumbnail?id=1VGdbU9YQSgzTyesLYdt6xgANcWlOzVlX&sz=w1000",
                "https://drive.google.com/thumbnail?id=1-wmBdCw9y0cuT_jaYQVd8zUtQ5Y6WydG&sz=w1000",
                "https://drive.google.com/thumbnail?id=17LCGXsaF8chECGxR5IXHkj5qc7UrWIqw&sz=w1000",
                "https://drive.google.com/thumbnail?id=1V5-GfhMxAUE5QhKYGDtE1XlAjl3sRZFN&sz=w1000",
                "https://drive.google.com/thumbnail?id=129hAaWbWcEXubYXVEy2-a4Gbs0ulv9La&sz=w1000",
                "https://drive.google.com/thumbnail?id=1iS1vCXQNst3Cm0hkq0m9m53HlFXB2e_b&sz=w1000",
                "https://drive.google.com/thumbnail?id=1EsQ7X9KyU57dg3N3AjHn_xtUtauiElDF&sz=w1000",
            ]);

            var books = new Faker<Book>()
                .RuleFor(b => b.Title, f => f.Lorem.Sentence(3))
                .RuleFor(b => b.Author, f => f.Name.FullName())
                .RuleFor(b => b.Description, f => f.Lorem.Paragraph())
                .RuleFor(b => b.GenreId, f => f.Random.Number(1, 5))
                .RuleFor(b => b.Publisher, f => f.Company.CompanyName())
                .RuleFor(b => b.ISBN, f => f.Random.Guid().ToString())
                .RuleFor(b => b.Year, f => f.Date.Past().Year)
                .RuleFor(b => b.Pages, f => f.Random.Number(100, 500))
                .RuleFor(b => b.IsBestSeller, f => f.Random.Bool())
                .RuleFor(b => b.IsFeatured, f => f.Random.Bool())
                .Generate(20);

            books.ForEach((b) =>
            {
                b.Id = books.IndexOf(b) + 1;
                b.Image = fakeBookImageIds[books.IndexOf(b)];
            });

            #region BookSeed
            builder.Entity<Book>().HasData(books);
            #endregion

            var bookTransactions = new Faker<BookTransaction>()
                .RuleFor(t => t.CheckOutTime, DateTime.Now)
                .RuleFor(t => t.DueTime, f => DateTime.Now + TimeSpan.FromDays(5))
                .RuleFor(t => t.BookId, f => f.Random.Number(1, 20))
                .RuleFor(t => t.UserId, f => f.Random.Number(1, 4).ToString())
                .RuleFor(t => t.CheckedOutById, "5")
                .RuleFor(t => t.CheckedInById, () => null)
                .RuleFor(t => t.CheckInTime, () => null)
                .Generate(5);

            bookTransactions.ForEach((b) =>
            {
                b.Id = bookTransactions.IndexOf(b) + 1;
            });

            #region TransactionSeed
            builder.Entity<BookTransaction>().HasData(bookTransactions);
            #endregion

            #region FavoritedBooksSeed
            builder.Entity<UserFavoritesBook>().HasData(
                new UserFavoritesBook() { Id = 1, UserId = "1", BookId = 1 },
                new UserFavoritesBook() { Id = 2, UserId = "1", BookId = 2 },
                new UserFavoritesBook() { Id = 3, UserId = "1", BookId = 3 },
                new UserFavoritesBook() { Id = 4, UserId = "1", BookId = 4 },
                new UserFavoritesBook() { Id = 5, UserId = "1", BookId = 5 },

                new UserFavoritesBook() { Id = 6, UserId = "2", BookId = 4 },
                new UserFavoritesBook() { Id = 7, UserId = "2", BookId = 5 },
                new UserFavoritesBook() { Id = 8, UserId = "2", BookId = 6 },
                new UserFavoritesBook() { Id = 9, UserId = "2", BookId = 7 },
                new UserFavoritesBook() { Id = 10, UserId = "2", BookId = 8 },
                new UserFavoritesBook() { Id = 11, UserId = "2", BookId = 9 },

                new UserFavoritesBook() { Id = 12, UserId = "3", BookId = 1 },
                new UserFavoritesBook() { Id = 13, UserId = "3", BookId = 2 },
                new UserFavoritesBook() { Id = 14, UserId = "3", BookId = 3 },
                new UserFavoritesBook() { Id = 15, UserId = "3", BookId = 4 },
                new UserFavoritesBook() { Id = 16, UserId = "3", BookId = 5 }
            );
            #endregion

            var reviews = new Faker<Review>()
                .RuleFor(r => r.Rating, f => f.Random.Number(1, 5))
                .RuleFor(r => r.Description, f => f.Lorem.Paragraph())
                .RuleFor(r => r.UserId, f => f.Random.Number(1, 4).ToString())
                .RuleFor(r => r.BookId, f => f.Random.Number(1, 20))
                .RuleFor(r => r.DateReviewed, f => f.Date.Past().ToString("yyyy-MM-dd"))
                .Generate(20);

            reviews.ForEach((r) =>
            {
                r.Id = reviews.IndexOf(r) + 1;
            });

            #region ReviewSeed
            builder.Entity<Review>().HasData(reviews);
            #endregion

            base.OnModelCreating(builder);
        }
    }
}
