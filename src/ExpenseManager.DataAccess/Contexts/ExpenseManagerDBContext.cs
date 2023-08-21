using ExpenseManager.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManager.DataAccess.Contexts
{
    public class ExpenseManagerDBContext : DbContext
    {
        public ExpenseManagerDBContext(DbContextOptions<ExpenseManagerDBContext> options) : base(options) { }

        public DbSet<ExpenseUnique> ExpenseUnique { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<ExpenseTransaction> ExpenseTransactions { get; set; }
    }
}
