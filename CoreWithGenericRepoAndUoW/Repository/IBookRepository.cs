using CoreWithGenericRepoAndUoW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWithGenericRepoAndUoW.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAll();
    }
}
