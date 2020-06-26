using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avangers.App.MVC.Models
{
    public class AvengersContext : DbContext
    {
        public AvengersContext(DbContextOptions<AvengersContext> options)
            : base(options) { }

        public DbSet<Person> Persons { get; set; }
    }
}
