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
    public class UnitOfWorkMockService : IUnitOfWorkMockService
    {
        private readonly IConfiguration _configuration;

        public IUnitOfWorkRepositoryMockService RepositoryMS { get; }

        public UnitOfWorkMockService(IConfiguration configuration = null)
        {
            _configuration = configuration;
            RepositoryMS = new UnitOfWorkRepositoryMockService(configuration);
        }


    }
}
