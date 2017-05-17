using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Entities
{
   public  class Cuenta
   {
       public int NumeroCuenta { get; set; }
       public int Pin { get; set; }
       //Base de Datos
       public int BaseDatosId { get; set; }
       public BaseDatos BaseDatos { get; set; } 

   }
}
