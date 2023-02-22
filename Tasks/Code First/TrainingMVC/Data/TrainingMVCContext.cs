using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainingMVC.Models;

namespace TrainingMVC.Data
{
    public class TrainingMVCContext : DbContext
    {
        public TrainingMVCContext (DbContextOptions<TrainingMVCContext> options)
            : base(options)
        {
        }

        public DbSet<TrainingMVC.Models.Author> Author { get; set; } = default!;

        public DbSet<TrainingMVC.Models.Book> Book { get; set; }
    }
}
