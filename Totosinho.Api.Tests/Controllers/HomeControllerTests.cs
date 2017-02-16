using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Totosinho.Api.Controllers;

namespace Totosinho.Api.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_OK()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}