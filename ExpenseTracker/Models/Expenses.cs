using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BorrowLanded.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Expense Name")]
        public string ExpenseName { get; set; }

        [DisplayName("Expense Type")]
        public string ExpenseType { get; set; }

        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public double Amount { get; set; }

    }
}
