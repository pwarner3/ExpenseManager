using ExpenseManager.DataAccess.Contexts;
using ExpenseManager.DataAccess.Models;
using ExpenseManager.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManager.Domain.Repositories
{
    public class ExpenseCategoryRepo : IExpenseCategoryRepo
    {
        private ExpenseManagerDBContext _context;

        public ExpenseCategoryRepo(ExpenseManagerDBContext context)
        {
            _context = context;
        }

        public async Task<List<ExpenseCategory>> GetCategories()
        {
            return await _context.ExpenseCategories.ToListAsync();
        }
        public ExpenseCategory GetSingleCategory(int id)
        {
            return _context.ExpenseCategories.Single(c => c.Id == id);
        }
        public Task AddCategory(ExpenseCategory category)
        {
            if (category.Id == 0)
            {
                _context.ExpenseCategories.Add(category);
            }

            return _context.SaveChangesAsync();
        }
        public Task UpdateCategory(ExpenseCategory category)
        {
            _context.ExpenseCategories.Update(category);
            return _context.SaveChangesAsync();
        }
        public Task DeleteCategory(ExpenseCategory category)
        {
            _context.ExpenseCategories.Remove(category);
            return _context.SaveChangesAsync();
        }
    }
}
