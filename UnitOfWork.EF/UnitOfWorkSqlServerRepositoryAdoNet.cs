using Repository.Interfaces;
using Repository.SqlServer;
using System.Data.SqlClient;
using UnitOfwork.Interfaces;

namespace UnitOfWork.SqlServer
{
    public class UnitOfWorkSqlServerRepositoryAdoNet: IUnitOfWorkRepositoryAdoNet
    {

        public ICoctailRepositoryAdoNet CoctailRepositoryAdoNet { get; }

        public UnitOfWorkSqlServerRepositoryAdoNet(SqlConnection context, SqlTransaction transaction)
        {
            CoctailRepositoryAdoNet = new CoctailRepositoryAdoNet(context, transaction);
        }
    }
}
