using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Abstractions
{
    public interface IUnitOfWork
    {
        Task<int> SaveCahangesAsyync();
    }
}
