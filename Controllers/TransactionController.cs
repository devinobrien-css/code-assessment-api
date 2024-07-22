using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using code_assessment_api.Models;
using code_assessment_api.Data;
using code_assessment_api.Services;
using Microsoft.AspNetCore.Identity;
using code_assessment_api.ViewModels.Requests;
using Microsoft.AspNetCore.Authorization;

namespace code_assessment_api.Controllers
{
    [ApiController]
    [Authorize(Roles = "Employee")]
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
        public async Task<IActionResult> UpdateTransaction(int id, UpdateTransactionRequest transaction)
        {
            await _transactionService.ProcessReturnAsync(id, transaction.CheckedInById);
            return NoContent();
        }
    }
}
