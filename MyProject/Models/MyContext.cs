using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Models;

namespace MyProject.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) :
            base(options) {

        }
        public DbSet<Receipt> Receipts { get; set; }

    }
}
