using _2014150710.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Persistence.Entities.Configuration
{
    class TecladoConfiguration :EntityTypeConfiguration<Teclado>
    {
        public TecladoConfiguration()
        {
            ToTable("Teclado");
            HasKey(c => c.TecladoId);
        }
    }
}
