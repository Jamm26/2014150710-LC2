using _2014150710.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Persistence.Entities.Configuration
{
    class BaseDatosConfiguration:EntityTypeConfiguration<BaseDatos>
    {
        public BaseDatosConfiguration(){
         ToTable("BaseDatos");
            HasKey(c => c.BaseDatosId);
            Property(c => c.AutentificarCuenta);
            Property(c => c.ObtenerSaldoDisponible);
            Property(c => c.ObtenerSaldoTotal);
            Property(c => c.Debitar);
            Property(c => c.Acreditar);
            
          

        //Relacion Cuenta
            HasMany(c => c.Cuentas)
               .WithRequired(c => c.BaseDatos);
            
        
        }
        
        

    }
}
