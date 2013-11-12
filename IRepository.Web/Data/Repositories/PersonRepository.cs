using IRepository.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRepository.Web.Data.Repositories
{
    public class PersonRepository : Repository<Person, DatabaseContext>, IPersonRepository
    {
        public PersonRepository(DatabaseContext db) : base(db) { }
    }
}