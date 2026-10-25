using CleanArchitecture.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
        }

        Task<int> IUnitOfWork.SaveCahangesAsyync() => _db.SaveChangesAsync();
    }
}
