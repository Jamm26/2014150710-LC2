using _2014150710.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Persistence.Entities.Configuration
{
     class RetiroConfiguration :EntityTypeConfiguration<Retiro>
    {
         public RetiroConfiguration()
         {
             ToTable("Retiro");
             HasKey(c => c.RetiroId);


             //Relacion Pantalla
             HasRequired(c => c.Pantalla)
                .WithOptional(c => c.Retiro);
             //Dispensador de Efectivo
             HasRequired(c => c.DispensadorEfectivo)
              .WithOptional(c => c.Retiro);
             //Teclado
             HasRequired(c => c.Teclado)
               .WithOptional(c => c.Retiro);
             //Base de datos
             HasRequired(c => c.BaseDatos)
             .WithOptional(c => c.Retiro);





         }
    }
}
