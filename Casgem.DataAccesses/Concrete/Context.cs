using Casgem.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DataAccesses.Concrete
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<CostumerProcess> CostumerProcessies { get; set; }
        public DbSet<Costumer> Costumer { get; set; }
    }
}
