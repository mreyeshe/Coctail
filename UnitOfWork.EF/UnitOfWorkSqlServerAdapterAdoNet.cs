using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfwork.Interfaces;

namespace UnitOfWork.SqlServer
{
    public class UnitOfWorkSqlServerAdapterAdoNet: IUnitOfWorkAdapterAdoNet
    {
        private SqlConnection _context { get; set; }
        private SqlTransaction _transaction { get; set; }
        public IUnitOfWorkRepositoryAdoNet RepositoriesAdoNet { get; set; }

        public UnitOfWorkSqlServerAdapterAdoNet(string connectionString)
        {
            _context = new SqlConnection(connectionString);
            _context.Open();

            _transaction = _context.BeginTransaction();

            RepositoriesAdoNet = new UnitOfWorkSqlServerRepositoryAdoNet(_context, _transaction);
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
            }

            if (_context != null)
            {
                _context.Close();
                _context.Dispose();
            }

            RepositoriesAdoNet = null;
        }

        public void SaveChanges()
        {
            _transaction.Commit();
        }
    }
}
