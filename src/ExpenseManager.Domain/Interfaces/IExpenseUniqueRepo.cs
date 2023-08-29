using ExpenseManager.DataAccess.Models;

namespace ExpenseManager.Domain.Interfaces
{
    public interface IExpenseUniqueRepo
    {
        Task AddUniqueExpense(ExpenseUnique uniqueExp);
        Task DeleteUniqueExpense(ExpenseUnique uniqueExp);
        ExpenseUnique GetSingleUniqueExpense(int id);
        Task<List<ExpenseUnique>> GetUniqueExpenses();
        Task UpdateUniqueExpense(ExpenseUnique uniqueExp);
    }
}