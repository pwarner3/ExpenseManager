using System.ComponentModel.DataAnnotations;

namespace ExpenseManager.DataAccess.Models
{
    public class ExpenseCategory
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
