using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfwork.Interfaces
{
    public interface IUnitOfWorkAdapterAdoNet: IDisposable
    {
        IUnitOfWorkRepositoryAdoNet RepositoriesAdoNet { get; }
        void SaveChanges();
    }
}
