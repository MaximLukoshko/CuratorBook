using CuratorBookCore;
using CuratorBookCore.Data.Tables;
using CuratorBookCore.Data.Tables.FormsSchema;
using Microsoft.EntityFrameworkCore;

namespace CuratorBook.Models
{
    public partial class CuratorBookDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ApplicationSettings.Instance.ConnectionString);
        }

        public DbSet<AnswerRows> AnswerRows { get; set; }
        public DbSet<AnswerValues> AnswerValues { get; set; }
        public DbSet<Controls> Controls { get; set; }
        public DbSet<Forms> Forms { get; set; }
        public DbSet<FormsControls> FormsControls { get; set; }
        public DbSet<Pages> Pages { get; set; }


        public DbSet<Messages> Messages { get; set; }


        public DbSet<Rights> Rights { get; set; }
        public DbSet<UsersRights> UsersRights { get; set; }
        public DbSet<RolesRights> RolesRights { get; set; }


        public DbSet<Groups> Groups { get; set; }
        public DbSet<Specialities> Specialities { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Interviews> Interviews { get; set; }
    }
}
