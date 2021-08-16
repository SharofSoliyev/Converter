using Converter.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Infostructure.DataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Currency> Currencies { get; set; }
       public DbSet<CurrencyConverter> CurrencyConverters { get; set; }
    }

}