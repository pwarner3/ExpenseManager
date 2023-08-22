using ExpenseManager.DataAccess.Models;

namespace ExpenseManager.Domain.Interfaces
{
    public interface IExpenseUniqueRepo
    {
        void AddCategory(ExpenseUnique uniqueExp);
        void DeleteCategory(ExpenseUnique uniqueExp);
        ExpenseUnique GetSingleCategory(int id);
        Task<List<ExpenseUnique>> GetUniqueExpenses();
        void UpdateCategory(ExpenseUnique uniqueExp);
    }
}