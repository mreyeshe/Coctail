using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfwork.Interfaces
{
    public interface IUnitOfWorkRepositoryMockService
    {
        ICoctailRepositoryMockService CoctailRepositoryMockService { get; }
    }
}
