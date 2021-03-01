using CoreWithGenericRepoAndUoW.Data;
using CoreWithGenericRepoAndUoW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWithGenericRepoAndUoW.Repository
{
    public class CatalogueRepository : GenericRepository<Catalogue>, ICatalogueRepository
    {
        public CatalogueRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
