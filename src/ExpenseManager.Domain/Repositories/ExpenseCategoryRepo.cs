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
        public IQueryable<ExpenseCategory> ExpenseCategories => _context.ExpenseCategories;

        public async Task<List<ExpenseCategory>> GetCategories()
        {
            return await _context.ExpenseCategories.ToListAsync();
        }
        public ExpenseCategory GetSingleCategory(int id)
        {
            return _context.ExpenseCategories.Single(c => c.Id == id);
        }
        public void AddCategory(ExpenseCategory category)
        {
            if (category.Id == 0)
            {
                _context.ExpenseCategories.Add(category);
            }

            _context.SaveChanges();
        }
        public void UpdateCategory(ExpenseCategory category)
        {
            _context.ExpenseCategories.Update(category);
            _context.SaveChanges();
        }
        public void DeleteCategory(ExpenseCategory category)
        {
            _context.ExpenseCategories.Remove(category);
            _context.SaveChanges();
        }
    }
}
