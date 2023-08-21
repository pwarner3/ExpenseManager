using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManager.DataAccess.Models
{
    [Table("expense_categories")]
    public class ExpenseCategory
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
