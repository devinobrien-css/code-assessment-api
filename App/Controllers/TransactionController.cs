using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.Models;
using App.Data;
using App.Services;
using Microsoft.AspNetCore.Identity;
using App.ViewModels.Requests;
using Microsoft.AspNetCore.Authorization;

namespace App.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class TransactionController(ApplicationDbContext context, UserManager<User> userManager) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        private readonly TransactionService _transactionService = new(context, userManager);

        private readonly UserManager<User> _identityManager = userManager;

        // POST: api/transaction
        [HttpPost]
        public async Task<IActionResult> PostTransaction(PostTransactionRequest transaction)
        {
            var user = await _identityManager.FindByIdAsync(transaction.UserId);
            var book = await _context.Books.FindAsync(transaction.BookId);

            if (user == null || book == null)
            {
                return NotFound();
            }

            await _transactionService.PostTransactionAsync(transaction);

            return NoContent();
        }


        // GET: api/transaction
        [HttpGet]
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> GetAllUserTransactions()
        {
            var transactions = await _transactionService.GetAllUserTransactionsAsync();
            return Ok(transactions);
        }

        // GET: api/transaction/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserTransaction(int id)
        {
            var transaction = await _transactionService.GetUserTransactionAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(transaction);
        }

        // PATCH: api/transaction/{id}
        [HttpPatch("{id}")]
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> UpdateTransaction(int id, UpdateTransactionRequest transaction)
        {
            await _transactionService.ProcessReturnAsync(id, transaction.CheckedInById);
            return NoContent();
        }
    }
}
