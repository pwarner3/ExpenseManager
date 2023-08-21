using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManager.DataAccess.Models
{
    [Table("expense_categories")]
    public class ExpenseCategory
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Column("category_name")]
        public string CategoryName { get; set; }
    }
}
