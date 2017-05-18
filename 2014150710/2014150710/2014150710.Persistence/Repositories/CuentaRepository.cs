using _2014150710.Entities;
using _2014150710.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Persistence.Repositories
{
   public class CuentaRepository:Repository<Cuenta>,ICuentaRepository
    {
       private readonly _2014150710DbContext _Context;

       public CuentaRepository(_2014150710DbContext context)
       {
           _Context= context ;
       }
       private CuentaRepository()
       {
            
       }
    }
}
