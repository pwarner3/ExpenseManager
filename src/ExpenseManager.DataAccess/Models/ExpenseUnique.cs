using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManager.DataAccess.Models
{
    [Table("expense_unique")]
    public class ExpenseUnique
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("unique_name")]
        public string UniqueName { get; set; }

        //Fk to Category
        [Column("category_id")]
        public int CategoryId { get; set; }
        public ExpenseCategory Category { get; set; }

    }
}
