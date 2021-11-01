using Repository.Interfaces;
using Repository.SqlServer;
using UnitOfwork.Interfaces;

namespace UnitOfWork.SqlServer
{
    public class UnitOfWorkSqlServerRepositoryEF : IUnitOfWorkRepositoryEF
    {
        public ICoctailRepositoryEF CoctailRepositoryEF { get; }

        public UnitOfWorkSqlServerRepositoryEF(DbContextEF context)
        {
            CoctailRepositoryEF = new CoctailRepositoryEF(context);
        }
    }
}