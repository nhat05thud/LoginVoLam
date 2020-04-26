using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace LoginVoLam.EntityFramework.Models
{
    public partial class LoginVoLamDbContext : DbContext
    {
        public LoginVoLamDbContext()
            : base("name=LoginVoLamDbContext")
        {
        }

        public virtual DbSet<Account_Info> Account_Info { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account_Info>()
                .Property(e => e.cAccName)
                .IsUnicode(false);

            modelBuilder.Entity<Account_Info>()
                .Property(e => e.cSecPassWord)
                .IsUnicode(false);

            modelBuilder.Entity<Account_Info>()
                .Property(e => e.cPassWord)
                .IsUnicode(false);
        }
    }
}
