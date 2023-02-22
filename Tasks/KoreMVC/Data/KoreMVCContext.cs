using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KoreMVC.Models;

namespace KoreMVC.Data
{
    public class KoreMVCContext : DbContext
    {
        public KoreMVCContext (DbContextOptions<KoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<KoreMVC.Models.Customer> Customer { get; set; } = default!;
    }
}
