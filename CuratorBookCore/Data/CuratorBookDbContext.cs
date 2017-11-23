using CuratorBookCore.Data.Tables;
using Microsoft.EntityFrameworkCore;

namespace CuratorBook.Models
{
    public partial class CuratorBookDbContext : DbContext
    {
        public CuratorBookDbContext(DbContextOptions<CuratorBookDbContext> options) : base(options)
        { }

        public DbSet<Pages> Pages { get; set; }
        public DbSet<Forms> Forms { get; set; }
        protected DbSet<FormsControls> FormsControls { get; set; }
        protected DbSet<Controls> Controls { get; set; }

        public DbSet<Rights> Rights { get; set; }
        protected DbSet<PagesRights> PagesRights { get; set; }

        public DbSet<Answers> Answers { get; set; }

        public DbSet<Groups> Groups { get; set; }
    }
}
