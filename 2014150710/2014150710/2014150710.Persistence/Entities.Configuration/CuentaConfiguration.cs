using _2014150710.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Persistence.Entities.Configuration
{
    class CuentaConfiguration: EntityTypeConfiguration<Cuenta>
    {
        public CuentaConfiguration()
        {
            ToTable("Cuenta");
            HasKey(c => c.Pin);
            Property(c => c.NumeroCuenta);
        }
    }
}
