using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Hosting;
using System.Web.Http.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Totosinho.Api.Controllers;
using Totosinho.Api.Tests.Moq;
using Totosinho.App.ViewModels.Servicos;

namespace Totosinho.Api.Tests.Controllers
{
    [TestClass]
    public class GameResultControllerTests
    {
        private readonly GameResultController controller;

        public GameResultControllerTests()
        {
            var moq = new AppServicoMoq();
            controller = new GameResultController(moq.GameResultAppServicoMock.Object, moq.ServidorAppServicoMock.Object);
            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost/api/GameResult");
            var route = config.Routes.MapHttpRoute("default", "api/{controller}/{id}");
            var routeData = new HttpRouteData(route, new HttpRouteValueDictionary {{"controller", "test"}});

            controller.ControllerContext = new HttpControllerContext(config, routeData, request);
            controller.Request = request;
            controller.Request.Properties[HttpPropertyKeys.HttpConfigurationKey] = config;
        }

        [TestMethod]
        public async Task Post_OK()
        {
            controller.ActionContext.ActionArguments["tokenAcesso"] = "guid";
            var actionResult = await controller.Post(new GameResultViewModel()).ExecuteAsync(new CancellationToken());
            Assert.AreEqual(actionResult.StatusCode, HttpStatusCode.OK);
        }

        [TestMethod]
        public async Task Post_NoTokenAcesso()
        {
            var actionResult = await controller.Post(new GameResultViewModel()).ExecuteAsync(new CancellationToken());
            Assert.AreEqual(actionResult.StatusCode, HttpStatusCode.BadRequest);
        }

        [TestMethod]
        public async Task Post_NoObject()
        {
            controller.ActionContext.ActionArguments["tokenAcesso"] = "guid";
            var actionResult = await controller.Post(null).ExecuteAsync(new CancellationToken());
            Assert.AreEqual(actionResult.StatusCode, HttpStatusCode.BadRequest);
        }
    }
}