using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rusu_Eugen_Ovidiu_Lab8.Models;

namespace Rusu_Eugen_Ovidiu_Lab8.Data
{
    public class Rusu_Eugen_Ovidiu_Lab8Context : DbContext
    {
        public Rusu_Eugen_Ovidiu_Lab8Context (DbContextOptions<Rusu_Eugen_Ovidiu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Rusu_Eugen_Ovidiu_Lab8.Models.Book> Book { get; set; }

        public DbSet<Rusu_Eugen_Ovidiu_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Rusu_Eugen_Ovidiu_Lab8.Models.Category> Category { get; set; }
    }
}
