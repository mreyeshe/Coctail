using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfwork.Interfaces
{
    public interface IUnitOfWorkEF
    {
        void DetectChanges();
        IDbContextTransaction BeginTransaction();
        Task<IDbContextTransaction> BeginTransactionAsync();
        void CommitTransaction();
        void RollbackTransaction();

        IUnitOfWorkRepositoryEF RepositoryEF { get; }
    }
}
