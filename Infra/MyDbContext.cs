using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VstaabnerWpf.Model;

namespace VstaabnerWpf.Infra
{
    public class MyDbContext : IdentityDbContext<TbUser>
    {
        public MyDbContext() : base()
        {

        }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = .; Database=VestaAbnerDataBAseNew;Integrated Security = true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TbBook>(e =>
            {
                e.HasMany(p => p.bookAndShelvecs).WithOne(p => p.Booke).HasForeignKey(X => X.BookID);
                e.HasKey(p => p.ID);
                e.ToTable("Book");
            });
            builder.Entity<TbBookAndShelve>(e =>
            {
                e.HasKey(p => p.Id);
                e.ToTable("BookAndShelve");
            });
            builder.Entity<TbUserRole>(e =>
            {
                e.HasOne(x => x.User).WithMany(x => x.userRoles).HasForeignKey(x => x.UserId);
                e.HasOne(x => x.Role).WithMany(X => X.userRoles).HasForeignKey(x => x.RoleId).OnDelete(DeleteBehavior.NoAction);

            });
            builder.Entity<TbUser>(e =>
            {
                ///  e.Property(x => x.Birthday).HasDefaultValue("getdate()");

                e.HasKey(X => X.Id);
                e.ToTable("User");
            });
            builder.Entity<TbShelve>(e =>
            {
                e.HasOne(x => x.User).WithMany(x => x.Shelves).HasForeignKey(p => p.UserId);
                e.HasMany(x => x.bookAndShelvecs).WithOne(x => x.shelve).HasForeignKey(x => x.ShelveId);
                e.HasKey(X => X.id);
                e.ToTable("shelves");
            });

        }
        public DbSet<TbUser> users { get; set; }
        public DbSet<TbBook> Bookes { get; set; }
        public DbSet<TbShelve> Shelves { get; set; }
        public DbSet<TbBookAndShelve> BookAndShelvecs { get; set; }
    
}
}
