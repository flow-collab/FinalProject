using Microsoft.EntityFrameworkCore;
using QueueCheckIns.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueCheckIn.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<CheckIn> CheckIns { get; set; }
    }
}
