using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coltoi_Iustin_Lab8.Models;

namespace Coltoi_Iustin_Lab8.Data
{
    public class Coltoi_Iustin_Lab8Context : DbContext
    {
        public Coltoi_Iustin_Lab8Context (DbContextOptions<Coltoi_Iustin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Coltoi_Iustin_Lab8.Models.Book> Book { get; set; }

        public DbSet<Coltoi_Iustin_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Coltoi_Iustin_Lab8.Models.Category> Category { get; set; }
    }
}
