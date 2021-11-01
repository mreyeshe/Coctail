using Models;
using Repository.Interfaces;
using Repository.Interfaces.Actions;
using Repository.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.SqlServer
{
    public class CoctailRepositoryEF : RepositoryGenericEF<Drinks> ,ICoctailRepositoryEF
    {
        public CoctailRepositoryEF(
            DbContextEF context
        )
        {
            _context = context;

        }
    }
}
