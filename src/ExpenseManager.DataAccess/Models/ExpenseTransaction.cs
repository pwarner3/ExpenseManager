using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManager.DataAccess.Models
{
    [Table("expense_transactions")]
    public class ExpenseTransaction
    {
        [Key]
        [Required]
        public int TransactionId { get; set; }
    }
}
