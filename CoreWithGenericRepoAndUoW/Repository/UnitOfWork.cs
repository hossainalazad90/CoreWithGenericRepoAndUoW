using CoreWithGenericRepoAndUoW.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWithGenericRepoAndUoW.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;

        public IBookRepository  Books { get; }

       public ICatalogueRepository Catalogues { get; }

        public UnitOfWork(ApplicationDBContext context, IBookRepository book, ICatalogueRepository catalogue)
        {
            _context = context;
            this.Books = book;
            this.Catalogues = catalogue;
        }

        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
