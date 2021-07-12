using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace GigHb.Data
{
    using Models;
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        
        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        //     => options.UseSqlite(@"Data Source=../gighub.db");
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // public static ApplicationDbContext Create()
        // {
        //     var conf = new DbContextOptionsBuilder().Options;
        //     
        //     return new ApplicationDbContext();
        // }
    }
}