using ExpenseManager.DataAccess.Models;

namespace ExpenseManager.Domain.Interfaces
{
    public interface IExpenseCategoryRepo
    {
        IQueryable<ExpenseCategory> ExpenseCategories { get; }

        void AddCategory(ExpenseCategory category);
        void DeleteCategory(ExpenseCategory category);
        ExpenseCategory GetSingleCategory(int id);
        void UpdateCategory(ExpenseCategory category);
    }
}