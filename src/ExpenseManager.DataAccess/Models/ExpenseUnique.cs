using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManager.DataAccess.Models
{
    [Table("expense_unique")]
    public class ExpenseUnique
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string UniqueName { get; set; }
        
        //Fk to Category
        public int CategoryId { get; set; }
        public ExpenseCategory Category { get; set; }

    }
}
