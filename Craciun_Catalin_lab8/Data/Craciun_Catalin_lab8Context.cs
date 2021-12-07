using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Craciun_Catalin_lab8.Models;

namespace Craciun_Catalin_lab8.Data
{
    public class Craciun_Catalin_lab8Context : DbContext
    {
        public Craciun_Catalin_lab8Context (DbContextOptions<Craciun_Catalin_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Craciun_Catalin_lab8.Models.Book> Book { get; set; }

        public DbSet<Craciun_Catalin_lab8.Models.Publisher> Publisher { get; set; }
    }
}
