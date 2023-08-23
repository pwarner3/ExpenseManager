using System.ComponentModel.DataAnnotations;

namespace ExpenseManagerWebApp.Models
{
    public class DisplayExpenseCategory
    {
        [Required]
        [StringLength(20, ErrorMessage = "Length is too long, max 20 chars")]
        [MinLength(2, ErrorMessage = "Length is too short, need 2 chars")]
        public string CategoryName { get; set; }
    }
}
