﻿using _2014150710_ENT;
using _2014150710_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150710_PER.Repositories
{
    public class CuentaRepository : Repository<Cuenta>, ICuentaRepository
    {

        public CuentaRepository(_2014150710DbContext context) : base( context){
            

        }

       /* private readonly _2014150710DbContext _Context;

        public CuentaRepository(_2014150710DbContext context)
        {
            _Context = context;
        }
        private CuentaRepository()
        {

        }*/
    }
}
