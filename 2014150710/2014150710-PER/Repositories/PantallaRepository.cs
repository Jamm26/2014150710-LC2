using _2014150710_ENT;
using _2014150710_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710_PER.Repositories
{
    public class PantallaRepository : Repository<Pantalla>, IPantallaRepository
    {
        
        public PantallaRepository(_2014150710DbContext context) : base(context)
        {

        }
        
        
        
        /*private readonly _2014150710DbContext _Context;

        public PantallaRepository(_2014150710DbContext context)
        {
            _Context = context;
        }
        private PantallaRepository()
        {

        }
        */
    }
}
