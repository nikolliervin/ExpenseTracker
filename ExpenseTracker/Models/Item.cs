using System.ComponentModel.DataAnnotations;

namespace BorrowLanded.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string Borrower { get; set; }


    }
}
