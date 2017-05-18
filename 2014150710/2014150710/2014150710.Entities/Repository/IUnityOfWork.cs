using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Entities.Repository
{

        //Debe heredar de IDisposable para que el Garbage Collector
    //pueda liberar memoria que ya no utilice.
   public interface IUnityOfWork :IDisposable
    {
        //Cada una de las propiedades deben ser solo lectura
        IATMRepository ATMs { get; }
        IBaseDatosRepository BaseDatoss { get; }
        ICuentaRepository Cuentas {get; }
        IDispensadorEfectivoRepository DispensadorEfectivos { get; }
        IPantallaRepository Pantallas { get; }
        IRanuraDepositoRepository RanuraDepositos { get; }
        IRetiroRepository Retiros { get; }
        ITecladoRepository Teclados { get; }

        //Metodo que guardara lo cambios en la base de datos.
        int SaveChanges();
        
    }
}
