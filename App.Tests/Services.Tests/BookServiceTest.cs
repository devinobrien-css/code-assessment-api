using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models;
using App.Services;
using App.ViewModels.Responses;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace App.Tests.Services.Tests
{
    public class BookServiceTest
    {
        private ApplicationDbContext _context;
        
        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        private BookService _service;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);

            var booksData = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "Test Book 1",
                    Author = "Author 1",
                    Genre = new Genre { Id = 1, Name = "Fiction" },
                    Reviews = new List<Review>
                    {
                        new Review { Id = 1, Rating = 5, User = new User { Id = "1", First = "John", Last = "Doe" } }
                    },
                    Publisher = "Publisher 1",
                    ISBN = "1234567890",
                    Year = 2020,
                    Pages = 300,
                    CreatedAt = DateTime.Now.AddDays(-10)
                }
            };

            _context.Books.AddRange(booksData);
            _context.SaveChanges();

            _service = new BookService(_context);
        }

        [Test]
        public async Task GetBooksAsync_ReturnsBookResponses()
        {
            // Act
            var result = await _service.GetBooksAsync();

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].Title, Is.EqualTo("Test Book 1"));
            Assert.That(result[0].Author, Is.EqualTo("Author 1"));
            Assert.That(result[0].Genre.Id, Is.EqualTo(1));
            Assert.That(result[0].Genre.Name, Is.EqualTo("Fiction"));
        }
    }
}
