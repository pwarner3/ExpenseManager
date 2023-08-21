using ExpenseManager.DataAccess.Contexts;
using ExpenseManager.DataAccess.Models;

namespace ExpenseManager.Domain.Repositories
{
    public class ExpenseCategoryRepo : IExpenseCategoryRepo
    {
        private ExpenseManagerDBContext _context;

        public ExpenseCategoryRepo(ExpenseManagerDBContext context)
        {
            _context = context;
        }
        public IQueryable<ExpenseCategory> ExpenseCategories => _context.Expense_Categories;
        public ExpenseCategory GetSingleCategory(int id)
        {
            return _context.Expense_Categories.Single(c => c.Id == id);
        }
        public void AddCategory(ExpenseCategory category)
        {
            if (category.Id == 0)
            {
                _context.Expense_Categories.Add(category);
            }

            _context.SaveChanges();
        }
        public void UpdateCategory(ExpenseCategory category)
        {
            _context.Expense_Categories.Update(category);
            _context.SaveChanges();
        }
        public void DeleteCategory(ExpenseCategory category)
        {
            _context.Expense_Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
