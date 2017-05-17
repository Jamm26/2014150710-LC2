using _2014150710.Entities;
using _2014150710.Persistence.Entities.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Persistence
{
    public class _2014150710DbContext:DbContext
    {
        public DbSet<Teclado> Teclado { get; set; }
        public DbSet<ATM> ATM { get; set; }
        public DbSet<BaseDatos> BasedeDatos { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<DispensadorEfectivo> DispensadorEfectivo { get; set; }
        public DbSet<RanuraDeposito> RanuraDeposito { get; set; }
        public DbSet<Pantalla> Pantalla { get; set; }
        public DbSet<Retiro> Retiro { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ATMConfiguration());
            modelBuilder.Configurations.Add(new BaseDatosConfiguration());
            modelBuilder.Configurations.Add(new CuentaConfiguration());
            modelBuilder.Configurations.Add(new DispensadorEfectivoConfiguration());
            modelBuilder.Configurations.Add(new PantallaConfiguration());
            modelBuilder.Configurations.Add(new RanuraDepositoConfiguration());
            modelBuilder.Configurations.Add(new RetiroConfiguration());
            modelBuilder.Configurations.Add(new TecladoConfiguration());
            

            base.OnModelCreating(modelBuilder);
        }
    
    }
}
