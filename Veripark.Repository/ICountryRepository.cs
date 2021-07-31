using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veripark.Entities;

namespace Veripark.Repository
{
    public interface ICountryRepository : IRepositoryBase<Country>
    {
        public Task<List<Country>> GetCountries();
    }
}