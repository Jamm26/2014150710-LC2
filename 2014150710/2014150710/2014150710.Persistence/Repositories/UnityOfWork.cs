using _2014150710.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Persistence.Repositories
{
   public class UnityOfWork : IUnityOfWork
    {
       private readonly _2014150710DbContext _Context;
       private static UnityOfWork _Instance;
       private static readonly object _Look = new object();

       public IATMRepository ATMs { get; private set; }
       public IBaseDatosRepository BaseDatoss { get; private set; }
       public ICuentaRepository Cuentas { get; private set; }
       public IDispensadorEfectivoRepository DispensadorEfectivos { get; private set; }
        public IPantallaRepository Pantallas{ get; private set; }
       public IRanuraDepositoRepository RanuraDepositos{ get; private set; }
       public IRetiroRepository Retiros{ get; private set; }
       public ITecladoRepository Teclados { get; private set; }


       //Se define el constructor por defecto como privado para
       //que se fuerce a utilizar la propiead Instance
       private UnityOfWork()
       {
           //Se crea un unico concexto de base de datos
           //para apuntar todos los repositorios a la misma base de datos
           _Context = new _2014150710DbContext();

           ATMs = new  ATMRepository(_Context);
           BaseDatoss = new  BaseDatosRepository(_Context);
           Cuentas = new CuentaRepository(_Context);
           DispensadorEfectivos = new DispensadorEfectivoRepository(_Context);
           Pantallas = new PantallaRepository(_Context);
           RanuraDepositos = new RanuraDepositoRepository(_Context);
           Retiros = new RetiroRepository(_Context);
           Teclados = new TecladoRepository(_Context);
            
       }
       //Implementacion del patron singleton para instanciar  la clase UnityOfWork
       //Con este patron se asugura que en cualquier parte del codigo que se quiera
       //intanciar la base de datos , se devuelva una unica referencia

       public static UnityOfWork Instance 
       {
           get 
           {

               //Variable de control para manejar el acceso concurrente 
               //al instanciamiento de la clase UnityOfWork.
                lock(_Look)
               {
                   if (_Instance == null)
               
                   _Instance = new UnityOfWork();
               }
                return _Instance;
           }
       }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

      
    }
}
