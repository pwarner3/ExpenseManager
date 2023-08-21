using System.ComponentModel.DataAnnotations;

namespace ExpenseManager.DataAccess.Models
{
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
