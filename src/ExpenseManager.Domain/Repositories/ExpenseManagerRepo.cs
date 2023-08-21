using ExpenseManager.DataAccess.Contexts;

namespace ExpenseManager.Domain.Repositories
{
    public class ExpenseManagerRepo
    {
        private ExpenseManagerDBContext _context;

        public ExpenseManagerRepo(ExpenseManagerDBContext context)
        {
            _context = context;
        }
        public void GetCategories()
        {

        }
        public void GetSingleCategory()
        {

        }

    }
}
