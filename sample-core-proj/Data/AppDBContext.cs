using Microsoft.EntityFrameworkCore;
using sample_core_proj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_core_proj.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
             
        }

        public DbSet<Category> Category { get; set; }
    }
}
