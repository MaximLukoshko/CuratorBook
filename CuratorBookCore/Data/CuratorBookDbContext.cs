using CuratorBookCore.Data.Tables;
using CuratorBookCore.Data.Tables.FormsSchema;
using Microsoft.EntityFrameworkCore;

namespace CuratorBook.Models
{
    public partial class CuratorBookDbContext : DbContext
    {
        public CuratorBookDbContext(DbContextOptions<CuratorBookDbContext> options) : base(options)
        { }

        public DbSet<AnswerRows> AnswerRows { get; set; }
        protected DbSet<AnswerValues> AnswerValues { get; set; }
        protected DbSet<Controls> Controls { get; set; }
        public DbSet<Forms> Forms { get; set; }
        protected DbSet<FormsControls> FormsControls { get; set; }
        public DbSet<Pages> Pages { get; set; }


        public DbSet<Messages> Messages { get; set; }


        public DbSet<Rights> Rights { get; set; }
        protected DbSet<PagesRights> PagesRights { get; set; }
        protected DbSet<UsersRights> UsersRights { get; set; }
        protected DbSet<RolesRights> RolesRights { get; set; }


        public DbSet<Groups> Groups { get; set; }
        public DbSet<Specialities> Specialities { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Interviews> Interviews { get; set; }
    }
}
