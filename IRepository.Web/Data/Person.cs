using IRepository.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRepository.Web.Data
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
    }
}