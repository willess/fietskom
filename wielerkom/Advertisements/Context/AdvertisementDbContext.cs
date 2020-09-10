using System;
using wielerkom.Advertisements.Entities;
using Microsoft.EntityFrameworkCore;

namespace wielerkom.Advertisements.Context
{
    public class AdvertisementDbContext : DbContext
    {
        public DbSet<Advertisement> Advertisements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=wielerkom.db");
    }
}
