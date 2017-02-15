using System;
using System.Web.Mvc;
using Totosinho.App.Interfaces.Servicos;
using Totosinho.App.ViewModels.Servicos;


namespace Totosinho.Api.Controllers
{
    public class HomeController : Controller
    {
        private IScoreAppServico _scoreAppServico;

        public ActionResult Index()
        {            
            return View();
        }
	}
}