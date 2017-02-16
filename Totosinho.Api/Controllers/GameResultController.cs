using System;
using System.Web.Http;
using Totosinho.App.Interfaces.Servicos;
using Totosinho.App.ViewModels.Servicos;

namespace Totosinho.Api.Controllers
{
    public class GameResultController : BaseApiController
    {
        private readonly IGameResultAppServico _GameResultAppServico;

        public GameResultController(IGameResultAppServico GameResultAppServico, IServidorAppServico servidorAppServico)
            : base(servidorAppServico)
        {
            _GameResultAppServico = GameResultAppServico;
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] GameResultViewModel GameResultViewModel)
        {
            try
            {
                GameResultViewModel.SetServidorCod(GetIdServidor());
                return Ok(_GameResultAppServico.Add(GameResultViewModel));
            }
            catch (Exception e)
            {
                if (e.InnerException != null)
                    return BadRequest(e.InnerException.Message);
                return BadRequest(e.Message);
            }
        }
    }
}