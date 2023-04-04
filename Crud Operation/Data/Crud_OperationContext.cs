using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud_Operation.CommonLayer.Model;

namespace Crud_Operation.Data
{
    public class Crud_OperationContext : DbContext
    {
        public Crud_OperationContext(DbContextOptions<Crud_OperationContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Booking> Booking { get; set; } = default!;
    }
}
