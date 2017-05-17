using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710.Entities
{
    public class ATM
    {
        public int ATMId { get; set; }
        public string descripcionATM { get; set; }

        //RanuraDeposito
        public int RanuraDepositoId { get; set; }
        public RanuraDeposito RanuraDeposito { get; set; }

        //Teclado
        public int TecladoId { get; set; }
        public Teclado Teclado { get; set; }

        //DispensadorEfectivo
        public int DispensadorEfectivoId { get; set; }
        public DispensadorEfectivo DispensadorEfectivo { get; set; }

        //Pantalla
        public int PantallaId { get; set; }
        public Pantalla Pantalla { get; set; }

        //Retiro
        public int RetiroId { get; set; }
        public Retiro Retiro { get; set; }

        //Base de Datos 
        public int BaseDatosId{get;set;}
        public BaseDatos BaseDatos { get; set; }


       


    }
}

