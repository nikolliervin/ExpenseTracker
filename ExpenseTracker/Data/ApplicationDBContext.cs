using BorrowLanded.Models;
using Microsoft.EntityFrameworkCore;

namespace BorrowLanded.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Item> Item { get; set; }
    }
}
