using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Baghiut_Ioana_Lab8.Models;

namespace Baghiut_Ioana_Lab8.Data
{
    public class Baghiut_Ioana_Lab8Context : DbContext
    {
        public Baghiut_Ioana_Lab8Context (DbContextOptions<Baghiut_Ioana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Baghiut_Ioana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Baghiut_Ioana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Baghiut_Ioana_Lab8.Models.Category> Category { get; set; }
    }
}
