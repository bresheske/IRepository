using IRepository.Web.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IRepository.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPersonRepository personRepository;

        public HomeController(IPersonRepository _personRepository)
        {
            personRepository = _personRepository;
        }


        public ActionResult Index()
        {
            return View();
        }

    }
}
