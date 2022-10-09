using System.ComponentModel.DataAnnotations;

namespace BorrowLanded.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }

        public string ExpenseName { get; set; }

        public string ExpenseType { get; set; }


        public double Amount { get; set; }

    }
}
