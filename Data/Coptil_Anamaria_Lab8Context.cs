using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coptil_Anamaria_Lab8.Models;

namespace Coptil_Anamaria_Lab8.Data
{
    public class Coptil_Anamaria_Lab8Context : DbContext
    {
        public Coptil_Anamaria_Lab8Context (DbContextOptions<Coptil_Anamaria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Coptil_Anamaria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Coptil_Anamaria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Coptil_Anamaria_Lab8.Models.Category> Category { get; set; }
    }
}
