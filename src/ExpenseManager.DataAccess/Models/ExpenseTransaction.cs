using System.ComponentModel.DataAnnotations;

namespace ExpenseManager.DataAccess.Models
{
    public class ExpenseTransaction
    {
        [Key]
        [Required]
        public int TransactionId { get; set; }
    }
}
