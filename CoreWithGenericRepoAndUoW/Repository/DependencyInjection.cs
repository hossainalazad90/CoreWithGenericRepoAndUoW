using CoreWithGenericRepoAndUoW.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWithGenericRepoAndUoW.Repository
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<ICatalogueRepository, CatalogueRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //services.AddDbContext<ApplicationDBContext>(opt => opt
            //    .UseSqlServer("Server=localhost; Database=GenericRepoDB;Trusted_Connection=True;"));
            return services;
        }
    }
}
