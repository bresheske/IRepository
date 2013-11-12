using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IRepository.Web.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}