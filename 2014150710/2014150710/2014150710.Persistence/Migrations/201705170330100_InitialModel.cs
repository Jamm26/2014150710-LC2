namespace _2014150710.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ATM",
                c => new
                    {
                        ATMId = c.Int(nullable: false, identity: true),
                        descipcionATM = c.String(),
                        RanuraDepositoId = c.Int(nullable: false),
                        TecladoId = c.Int(nullable: false),
                        DispensadorEfectivoId = c.Int(nullable: false),
                        PantallaId = c.Int(nullable: false),
                        RetiroId = c.Int(nullable: false),
                        BaseDatosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ATMId);
            
            CreateTable(
                "dbo.BaseDatos",
                c => new
                    {
                        BaseDatosId = c.Int(nullable: false),
                        AutentificarCuenta = c.Boolean(nullable: false),
                        ObtenerSaldoDisponible = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ObtenerSaldoToal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Debitar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Acreditar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CuentaId = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                        Cuenta_Pin = c.Int(),
                    })
                .PrimaryKey(t => t.BaseDatosId)
                .ForeignKey("dbo.Cuenta", t => t.Cuenta_Pin)
                .ForeignKey("dbo.ATM", t => t.BaseDatosId)
                .Index(t => t.BaseDatosId)
                .Index(t => t.Cuenta_Pin);
            
            CreateTable(
                "dbo.Cuenta",
                c => new
                    {
                        Pin = c.Int(nullable: false, identity: true),
                        NumeroCuenta = c.Int(nullable: false),
                        BaseDatosId = c.Int(nullable: false),
                        BaseDatos_BaseDatosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pin)
                .ForeignKey("dbo.BaseDatos", t => t.BaseDatos_BaseDatosId, cascadeDelete: true)
                .Index(t => t.BaseDatos_BaseDatosId);
            
            CreateTable(
                "dbo.DispensadorEfectivo",
                c => new
                    {
                        DispensadorEfectivoId = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                        RetiroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DispensadorEfectivoId)
                .ForeignKey("dbo.ATM", t => t.DispensadorEfectivoId)
                .Index(t => t.DispensadorEfectivoId);
            
            CreateTable(
                "dbo.Retiro",
                c => new
                    {
                        RetiroId = c.Int(nullable: false),
                        PantallaId = c.Int(nullable: false),
                        TecladoId = c.Int(nullable: false),
                        DispensadorEfectivoId = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RetiroId)
                .ForeignKey("dbo.DispensadorEfectivo", t => t.RetiroId)
                .ForeignKey("dbo.Pantalla", t => t.RetiroId)
                .ForeignKey("dbo.Teclado", t => t.RetiroId)
                .ForeignKey("dbo.ATM", t => t.RetiroId)
                .Index(t => t.RetiroId);
            
            CreateTable(
                "dbo.Pantalla",
                c => new
                    {
                        PantallaId = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                        RetiroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PantallaId)
                .ForeignKey("dbo.ATM", t => t.PantallaId)
                .Index(t => t.PantallaId);
            
            CreateTable(
                "dbo.Teclado",
                c => new
                    {
                        TecladoId = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                        RetiroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TecladoId)
                .ForeignKey("dbo.ATM", t => t.TecladoId)
                .Index(t => t.TecladoId);
            
            CreateTable(
                "dbo.Ranura",
                c => new
                    {
                        RanuraDepositoId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RanuraDepositoId)
                .ForeignKey("dbo.ATM", t => t.RanuraDepositoId)
                .Index(t => t.RanuraDepositoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teclado", "TecladoId", "dbo.ATM");
            DropForeignKey("dbo.Retiro", "RetiroId", "dbo.ATM");
            DropForeignKey("dbo.Ranura", "RanuraDepositoId", "dbo.ATM");
            DropForeignKey("dbo.Pantalla", "PantallaId", "dbo.ATM");
            DropForeignKey("dbo.DispensadorEfectivo", "DispensadorEfectivoId", "dbo.ATM");
            DropForeignKey("dbo.Retiro", "RetiroId", "dbo.Teclado");
            DropForeignKey("dbo.Retiro", "RetiroId", "dbo.Pantalla");
            DropForeignKey("dbo.Retiro", "RetiroId", "dbo.DispensadorEfectivo");
            DropForeignKey("dbo.BaseDatos", "BaseDatosId", "dbo.ATM");
            DropForeignKey("dbo.Cuenta", "BaseDatos_BaseDatosId", "dbo.BaseDatos");
            DropForeignKey("dbo.BaseDatos", "Cuenta_Pin", "dbo.Cuenta");
            DropIndex("dbo.Ranura", new[] { "RanuraDepositoId" });
            DropIndex("dbo.Teclado", new[] { "TecladoId" });
            DropIndex("dbo.Pantalla", new[] { "PantallaId" });
            DropIndex("dbo.Retiro", new[] { "RetiroId" });
            DropIndex("dbo.DispensadorEfectivo", new[] { "DispensadorEfectivoId" });
            DropIndex("dbo.Cuenta", new[] { "BaseDatos_BaseDatosId" });
            DropIndex("dbo.BaseDatos", new[] { "Cuenta_Pin" });
            DropIndex("dbo.BaseDatos", new[] { "BaseDatosId" });
            DropTable("dbo.Ranura");
            DropTable("dbo.Teclado");
            DropTable("dbo.Pantalla");
            DropTable("dbo.Retiro");
            DropTable("dbo.DispensadorEfectivo");
            DropTable("dbo.Cuenta");
            DropTable("dbo.BaseDatos");
            DropTable("dbo.ATM");
        }
    }
}
