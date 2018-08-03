using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoOnDemand.Web.Controllers
{
    public class MovieCatalogoController : Controller
    {
        // GET: MovieCatalogo
        public ActionResult Index()
        {
            return View();
        }
    }
}