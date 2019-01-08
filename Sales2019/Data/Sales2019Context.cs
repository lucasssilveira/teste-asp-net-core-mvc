using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sales2019.Models
{
    public class Sales2019Context : DbContext
    {
        public Sales2019Context (DbContextOptions<Sales2019Context> options)
            : base(options)
        {
        }

        public DbSet<Sales2019.Models.Department> Department { get; set; }
    }
}
