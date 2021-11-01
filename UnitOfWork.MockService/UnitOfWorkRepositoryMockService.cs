using Microsoft.Extensions.Configuration;
using Repository.Interfaces;
using Repository.MockService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfwork.Interfaces;

namespace UnitOfWork.MockService
{
    public class UnitOfWorkRepositoryMockService : IUnitOfWorkRepositoryMockService
    {
        public ICoctailRepositoryMockService CoctailRepositoryMockService { get; }

        public UnitOfWorkRepositoryMockService(IConfiguration configuration)
        {
            CoctailRepositoryMockService = new CoctailRepositoryMockService(configuration);
        }
    }
}
