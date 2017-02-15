using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Totosinho.Domain.Interfaces.App;
using Totosinho.Models;

namespace Totosinho.Controllers
{
    public class ScoreController : ApiController
    {
        private readonly IScoreAppServico _scoreAppServico;
        public ScoreController(IScoreAppServico scoreAppServico)
        {
            _scoreAppServico = scoreAppServico;
        }
      
        // POST api/values
        public void Post([FromBody]ScoreViewModel score)
        {
            _scoreAppServico.Add();
        }      
    }
}
