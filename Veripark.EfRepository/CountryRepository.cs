using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Veripark.Entities;
using Veripark.Repository;

namespace Veripark.EfRepository
{
    public class CountryRepository : EfRepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(DbContextOptions<EfContext> options) : base(options)
        {
        }

        public async Task<List<Country>> GetCountries()
        {
            return await EfContext.Countries
                .Include(x => x.Weekends)
                .Include(x => x.Holidays).ToListAsync();
        }
    }
}