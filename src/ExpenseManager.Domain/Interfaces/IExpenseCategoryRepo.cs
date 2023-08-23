using ExpenseManager.DataAccess.Models;

namespace ExpenseManager.Domain.Interfaces
{
    public interface IExpenseCategoryRepo
    {
        Task<List<ExpenseCategory>> GetCategories();
        Task AddCategory(ExpenseCategory category);
        Task DeleteCategory(ExpenseCategory category);
        ExpenseCategory GetSingleCategory(int id);
        Task UpdateCategory(ExpenseCategory category);
    }
}