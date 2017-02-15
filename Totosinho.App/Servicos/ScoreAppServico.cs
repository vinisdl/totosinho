using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Totosinho.App.Interfaces.Servicos;
using Totosinho.App.ViewModels.Servicos;
using Totosinho.Domain.Entidades;
using Totosinho.Domain.Interfaces.Contexto;
using Totosinho.Domain.Interfaces.Servicos;

namespace Totosinho.App.Servicos
{
    public class ScoreAppServico : IScoreAppServico
    {
        private readonly IScoreServico _scoreServico;
        public ScoreAppServico(IScoreServico scoreServico)
        {
            _scoreServico = scoreServico;
        }


        public ScoreViewModel Add(ScoreViewModel obj)
        {
            var score = MapperScoreToModel(obj);
            score = _scoreServico.Add(score);
            _scoreServico.Commit();
            return MapperScoreToViewModel(score);
        }


        private Score MapperScoreToModel(ScoreViewModel scoreViewModel)
        {
            return Mapper.Map<ScoreViewModel, Score>(scoreViewModel);
        }

        private ScoreViewModel MapperScoreToViewModel(Score score)
        {
            return Mapper.Map<Score, ScoreViewModel>(score);
            
        }
    }
}
