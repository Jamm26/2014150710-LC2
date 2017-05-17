﻿using _2014150710.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Persistence.Entities.Configuration
{
    public class ATMConfiguration:EntityTypeConfiguration<ATM>
   {
        public ATMConfiguration()
        {
            ToTable("ATM");
            HasKey(c => c.ATMId);
           
            Property(c => c.descripcionATM);

            //RelacionRanuraDeposito
            HasRequired(c => c.RanuraDeposito)
              .WithRequiredPrincipal(c => c.ATM);
            
            //RelacionTeclado
            HasRequired(c => c.Teclado)
                .WithRequiredPrincipal(c => c.ATM);
            
            //RelacionPantalla
            HasRequired(c => c.Pantalla)
                .WithRequiredPrincipal(c => c.ATM);
            
            //DispensadorEfectivo
            HasRequired(c => c.DispensadorEfectivo)
               .WithRequiredPrincipal(c => c.ATM);
            

            //Retiro
            HasOptional(c => c.Retiro)
                .WithRequired(c => c.ATM);
            //Base de Datos
            HasRequired(c => c.BaseDatos)
                .WithRequiredPrincipal(c => c.ATM);







        }

    }
}
