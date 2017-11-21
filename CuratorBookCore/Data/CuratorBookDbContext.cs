using Microsoft.EntityFrameworkCore;

namespace CuratorBook.Models
{
    public partial class CuratorBookDbContext : DbContext
    {
        public CuratorBookDbContext(DbContextOptions<CuratorBookDbContext> options) : base(options)
        { }
    }
}
