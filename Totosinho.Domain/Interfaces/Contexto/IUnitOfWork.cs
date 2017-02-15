﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totosinho.Domain.Interfaces.Contexto
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        DbContext Context { get; }
    }
}
