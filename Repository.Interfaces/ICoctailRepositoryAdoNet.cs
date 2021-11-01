using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface ICoctailRepositoryAdoNet
    {
        IEnumerable<Drinks> SearchDrinkByName(string name);

        IEnumerable<Drinks> SearchDrinkByCategory(string name);
    }
}
