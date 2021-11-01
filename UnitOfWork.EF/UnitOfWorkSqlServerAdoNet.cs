using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfwork.Interfaces;

namespace UnitOfWork.SqlServer
{
    public class UnitOfWorkSqlServerAdoNet: IUnitOfWorkAdoNet
    {
        private readonly IConfiguration _configuration;

        public UnitOfWorkSqlServerAdoNet(IConfiguration configuration = null)
        {
            _configuration = configuration;
        }

        public IUnitOfWorkAdapterAdoNet Create()
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");

            return new UnitOfWorkSqlServerAdapterAdoNet(connectionString);
        }
    }
}
