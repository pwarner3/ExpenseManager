using ExpenseManager.DataAccess.Contexts;
using ExpenseManager.DataAccess.Models;
using ExpenseManager.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManager.Domain.Repositories
{
    public class ExpenseUniqueRepo : IExpenseUniqueRepo
    {
        private ExpenseManagerDBContext _context;
        public ExpenseUniqueRepo(ExpenseManagerDBContext context)
        {
            _context = context;
        }

        public async Task<List<ExpenseUnique>> GetUniqueExpenses()
        {
            return await _context.ExpenseUnique.ToListAsync();
        }
        public ExpenseUnique GetSingleUniqueExpense(int id)
        {
            return _context.ExpenseUnique.Single(x => x.Id == id);
        }
        public Task AddUniqueExpense(ExpenseUnique uniqueExp)
        {
            _context.ExpenseUnique.Add(uniqueExp);
            return _context.SaveChangesAsync();
        }
        public Task DeleteUniqueExpense(ExpenseUnique uniqueExp)
        {
            _context.Remove(uniqueExp);
            return _context.SaveChangesAsync();
        }
        public Task UpdateUniqueExpense(ExpenseUnique uniqueExp)
        {
            _context.Update(uniqueExp);
            return _context.SaveChangesAsync();
        }
    }
}
