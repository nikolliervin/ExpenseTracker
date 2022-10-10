using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BorrowLanded.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense Name")]
        public string ExpenseName { get; set; }

        [DisplayName("Expense Type")]
        public string ExpenseType { get; set; }


        public double Amount { get; set; }

    }
}
