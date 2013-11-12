using IRepository.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRepository.Web.Data.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
    }
}