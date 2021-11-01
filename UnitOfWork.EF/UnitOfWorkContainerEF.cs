using Microsoft.EntityFrameworkCore.Storage;
using Repository.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfwork.Interfaces;

namespace UnitOfWork.SqlServer
{
    public class UnitOfWorkContainerEF: IUnitOfWorkEF
    {

        private readonly DbContextEF _context;
        public IUnitOfWorkRepositoryEF RepositoryEF { get; }

        public UnitOfWorkContainerEF(
            DbContextEF context
        )
        {
            _context = context;
            RepositoryEF = new UnitOfWorkSqlServerRepositoryEF(_context);
        }

        #region Detect Changes
        public void DetectChanges()
        {
            _context.ChangeTracker.DetectChanges();
        }
        #endregion

        #region Transactions
        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public void CommitTransaction()
        {
            _context.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _context.Database.RollbackTransaction();
        }
        #endregion

    }
}
