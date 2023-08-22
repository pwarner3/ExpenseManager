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
        public ExpenseUnique GetSingleCategory(int id)
        {
            return _context.ExpenseUnique.Single(x => x.Id == id);
        }
        public void AddCategory(ExpenseUnique uniqueExp)
        {
            _context.ExpenseUnique.Add(uniqueExp);
            _context.SaveChanges();
        }
        public void DeleteCategory(ExpenseUnique uniqueExp)
        {
            _context.Remove(uniqueExp);
            _context.SaveChanges();
        }
        public void UpdateCategory(ExpenseUnique uniqueExp)
        {
            _context.Update(uniqueExp);
            _context.SaveChanges();
        }
    }
}
