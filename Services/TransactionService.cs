using Microsoft.EntityFrameworkCore;
using code_assessment_api.Data;
using code_assessment_api.Models;
using code_assessment_api.Services;
using code_assessment_api.ViewModels.Responses;
using code_assessment_api.ViewModels.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace code_assessment_api.Services
{
    public class TransactionService(ApplicationDbContext context, UserManager<User> userManager) : ITransactionService
    {
        private readonly UserManager<User> _identityManager = userManager;

        private readonly ApplicationDbContext _context = context;

        public async Task PostTransactionAsync(PostTransactionRequest transaction)
        {
            var user = await _identityManager.FindByIdAsync(transaction.UserId);
            var book = await _context.Books.FindAsync(transaction.BookId);
            if (user == null || book == null)
            {
                return;
            }

            var newTransaction = new BookTransaction
            {
                UserId = user.Id,
                BookId = book.Id,
                DueTime = DateTime.Now.AddDays(5),
                CheckOutTime = DateTime.Now,
                CheckedInById = null,
                CheckedOutById = null
            };

            await _context.BookTransactions.AddAsync(newTransaction);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserTransactionResponse>> GetAllUserTransactionsAsync()
        {
            var transactions = await _context.BookTransactions
                .Include(t => t.Book)
                .Include(t => t.CheckedOutBy)
                .Include(t => t.CheckedInBy)
                .Select(t => new UserTransactionResponse
            {
                Id = t.Id,
                User = new TransactionUserResponse {
                    Id = t.User.Id,
                    First = t.User.First,
                    Last = t.User.Last,
                    Email = t.User.Email ?? ""
                
                },
                Book = t.Book,
                CheckOutTime = t.CheckOutTime,
                CheckInTime = t.CheckInTime,
                DueTime = t.DueTime,
                CheckedOutBy = t.CheckedOutBy == null ? null : new TransactionUserResponse
                {
                    Id = t.CheckedOutBy.Id,
                    First = t.CheckedOutBy.First,
                    Last = t.CheckedOutBy.Last,
                    Email = t.CheckedOutBy.Email ?? ""
                },
                CheckedInBy = t.CheckedInBy == null ? null : new TransactionUserResponse
                {
                    Id = t.CheckedInBy.Id,
                    First = t.CheckedInBy.First,
                    Last = t.CheckedInBy.Last,
                    Email = t.CheckedInBy.Email ?? ""
                },
                IsCheckedIn = t.CheckedInById != null,
                IsOverdue = t.DueTime < DateTime.Now
            }).OrderBy(
                t => t.IsCheckedIn
            ).ThenBy(
                t => t.IsOverdue
            ).ThenBy(
                t => t.DueTime
            ).ToListAsync();

            return transactions;
        }

        public async Task<UserTransactionResponse?> GetUserTransactionAsync(int id)
        {
            var userTransaction = await _context.BookTransactions
                .Include(t => t.Book)
                .Include(t => t.CheckedOutBy)
                .Include(t => t.CheckedInBy)
                .Where(t => t.Id == id)
                .Select(t => new UserTransactionResponse
                {
                    Id = t.Id,
                    User = new TransactionUserResponse {
                        Id = t.User.Id,
                        First = t.User.First,
                        Last = t.User.Last,
                        Email = t.User.Email ?? ""
                    },
                    Book = t.Book,
                    CheckOutTime = t.CheckOutTime,
                    CheckInTime = t.CheckInTime,
                    DueTime = t.DueTime,
                    CheckedOutBy = t.CheckedOutBy == null ? null : new TransactionUserResponse
                    {
                        Id = t.CheckedOutBy.Id,
                        First = t.CheckedOutBy.First,
                        Last = t.CheckedOutBy.Last,
                        Email = t.CheckedOutBy.Email ?? ""
                    },
                    CheckedInBy = t.CheckedInBy == null ? null : new TransactionUserResponse
                    {
                        Id = t.CheckedInBy.Id,
                        First = t.CheckedInBy.First,
                        Last = t.CheckedInBy.Last,
                        Email = t.CheckedInBy.Email ?? ""
                    },
                    IsCheckedIn = t.CheckedInById != null,
                    IsOverdue = t.DueTime < DateTime.Now
                }).FirstOrDefaultAsync();

            return userTransaction;
        }


        public async Task ProcessReturnAsync(int transactionId, string checkedInById)
        {
            var transaction = await _context.BookTransactions.FindAsync(transactionId);
            if (transaction == null)
            {
                return;
            }

            transaction.CheckedInById = checkedInById;
            transaction.CheckInTime = DateTime.Now;

            await _context.SaveChangesAsync();
        }
    }

}