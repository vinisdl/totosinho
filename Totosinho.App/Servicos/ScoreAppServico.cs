using AutoMapper;
using Totosinho.App.Interfaces.Servicos;
using Totosinho.App.ViewModels.Servicos;
using Totosinho.Domain.Entidades;
using Totosinho.Domain.Interfaces.Servicos;

namespace Totosinho.App.Servicos
{
    public class GameResultAppServico : IGameResultAppServico
    {
        private readonly IGameResultServico _GameResultServico;

        public GameResultAppServico(IGameResultServico GameResultServico)
        {
            _GameResultServico = GameResultServico;
        }


        public GameResultViewModel Add(GameResultViewModel obj)
        {
            var GameResult = MapperGameResultToModel(obj);
            GameResult = _GameResultServico.Add(GameResult);
            _GameResultServico.Commit();
            return MapperGameResultToViewModel(GameResult);
        }


        private GameResult MapperGameResultToModel(GameResultViewModel GameResultViewModel)
        {
            return Mapper.Map<GameResultViewModel, GameResult>(GameResultViewModel);
        }

        private GameResultViewModel MapperGameResultToViewModel(GameResult GameResult)
        {
            return Mapper.Map<GameResult, GameResultViewModel>(GameResult);
        }
    }
}