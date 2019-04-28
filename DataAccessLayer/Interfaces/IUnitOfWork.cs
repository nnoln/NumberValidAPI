﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Patterns> PatternsRepo { get; }
        IRepository<OperatorCodes> OpCodesRepo { get; }
        void Save();
    }
}