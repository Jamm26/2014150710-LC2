using _2014150710.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Persistence.Entities.Configuration
{
    class RanuraDepositoConfiguration:EntityTypeConfiguration<RanuraDeposito>
    {
        public RanuraDepositoConfiguration()
        {
            ToTable("Ranura");
            HasKey(c => c.RanuraDepositoId);
            Property(c => c.Cantidad);
            

        }
    }
}
