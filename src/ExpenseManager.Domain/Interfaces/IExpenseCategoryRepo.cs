using ExpenseManager.DataAccess.Models;

namespace ExpenseManager.Domain.Interfaces
{
    public interface IExpenseCategoryRepo
    {
        Task<List<ExpenseCategory>> GetCategories();
        void AddCategory(ExpenseCategory category);
        void DeleteCategory(ExpenseCategory category);
        ExpenseCategory GetSingleCategory(int id);
        void UpdateCategory(ExpenseCategory category);
    }
}