using System;
using System.Web.Http;
using Totosinho.App.Interfaces.Servicos;
using Totosinho.App.ViewModels.Servicos;

namespace Totosinho.Api.Controllers
{
    public class ScoreController : BaseApiController
    {
        private readonly IScoreAppServico _scoreAppServico;

        public ScoreController(IScoreAppServico scoreAppServico, IServidorAppServico servidorAppServico)
            : base(servidorAppServico)
        {
            _scoreAppServico = scoreAppServico;
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] ScoreViewModel scoreViewModel)
        {
            try
            {
                scoreViewModel.SetServidorCod(GetIdServidor());
                return Ok(_scoreAppServico.Add(scoreViewModel));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}