using Film_Information.Entities.ORM.Entities.Concrete;
using Film_Information.Map.Option;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.DAL.Context
{
    public class ProjectContext:IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=Film; integrated security=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FilmMapping());
            builder.ApplyConfiguration(new CategoryMapping());
            builder.ApplyConfiguration(new CommentMapping());

            base.OnModelCreating(builder);
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comments> Comments { get; set; }

    }
}
