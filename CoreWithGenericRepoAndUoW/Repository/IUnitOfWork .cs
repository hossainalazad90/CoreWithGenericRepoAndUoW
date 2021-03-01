using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWithGenericRepoAndUoW.Repository
{
   public interface IUnitOfWork:IDisposable
    {
        IBookRepository Books { get; }
        ICatalogueRepository Catalogues { get; }
        int Complete();
    }
}
