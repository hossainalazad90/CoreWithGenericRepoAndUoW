using CoreWithGenericRepoAndUoW.Data;
using CoreWithGenericRepoAndUoW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWithGenericRepoAndUoW.Repository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDBContext context) : base(context)
        {

        }

    }
}
