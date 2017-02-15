using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Totosinho.App.Interfaces.Servicos;
using Totosinho.App.ViewModels.Servicos;
using Totosinho.Infra.CrossCutting.Execoes;

namespace Totosinho.Api
{
    [BaseActionFilter]
    public class BaseApiController : ApiController
    {
        private static IServidorAppServico _servidorAppService;

        public BaseApiController(IServidorAppServico servidorAppService)
        {
            _servidorAppService = servidorAppService;
        }

        protected int GetIdServidor()
        {
            var servidorViewModel =
                _servidorAppService.ObterPorTokenAcesso(ActionContext.ActionArguments["tokenAcesso"].ToString());

            if (servidorViewModel == null)
                throw new ApiException(HttpStatusCode.Unauthorized.GetHashCode(), "Servidor inválido.");
            return servidorViewModel.Id;
        }

        public class BaseActionFilter : ActionFilterAttribute
        {
            public ServidorViewModel _servidor;

            public override void OnActionExecuting(HttpActionContext actionContext)
            {
                var request = actionContext.Request;
                var tokenAcesso = request.Headers.All(t => t.Key != "tokenAcesso")
                    ? null
                    : request.Headers.GetValues("tokenAcesso").First();
                if (tokenAcesso == null)
                {
                    var ex = new ApiException(HttpStatusCode.BadRequest.GetHashCode(),
                        "Token de acesso é obrigatório");
                    throw ex;
                }

                _servidor = _servidorAppService.ObterPorTokenAcesso(tokenAcesso);
                if (_servidor == null)
                    throw new ApiException(HttpStatusCode.BadRequest.GetHashCode(),
                        "Token de acesso é invalido");

                actionContext.ActionArguments["tokenAcesso"] = tokenAcesso;
                actionContext.ActionArguments["servidorId"] = _servidor.Id;

                base.OnActionExecuting(actionContext);
            }

            public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
            {
            }
        }
    }
}