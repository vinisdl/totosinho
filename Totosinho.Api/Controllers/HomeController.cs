using System.Web.Mvc;

namespace Totosinho.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}