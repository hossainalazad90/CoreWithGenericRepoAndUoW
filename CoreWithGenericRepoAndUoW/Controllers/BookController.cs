using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWithGenericRepoAndUoW.Models;
using CoreWithGenericRepoAndUoW.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWithGenericRepoAndUoW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public BookController(IUnitOfWork  unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IEnumerable<Book> Get()
        {
             return _unitOfWork.Books.GetAll().Result ;           
           
        }        
    }
}
