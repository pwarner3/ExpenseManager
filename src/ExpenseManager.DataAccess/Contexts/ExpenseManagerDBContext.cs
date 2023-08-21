using ExpenseManager.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManager.DataAccess.Contexts
{
    public class ExpenseManagerDBContext : DbContext
    {
        public ExpenseManagerDBContext(DbContextOptions<ExpenseManagerDBContext> options) : base(options) { }

        public DbSet<ExpenseUnique> Expense_Unique { get; set; }
        public DbSet<ExpenseCategory> Expense_Categories { get; set; }
        public DbSet<ExpenseTransaction> Expense_Transactions { get; set; }
    }
}
