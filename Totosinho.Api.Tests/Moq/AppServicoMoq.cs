using System;
using Moq;
using Totosinho.App.Interfaces.Servicos;
using Totosinho.App.ViewModels.Servicos;

namespace Totosinho.Api.Tests.Moq
{
    public class AppServicoMoq
    {
        public Mock<IGameResultAppServico> GameResultAppServicoMock;
        public Mock<IServidorAppServico> ServidorAppServicoMock;

        public AppServicoMoq()
        {
            GameResultAppServicoMock = new Mock<IGameResultAppServico>();
            GameResultAppServicoMock.Setup(service => service.Add(new GameResultViewModel()))
                .Returns(() => new GameResultViewModel {GameId = 1, PlayerId = 1, TimeStamp = DateTime.Now, Win = 10});

            ServidorAppServicoMock = new Mock<IServidorAppServico>();
            ServidorAppServicoMock.Setup(service => service.ObterPorTokenAcesso("guid"))
                .Returns(() => new ServidorViewModel {AcessToken = "guid", Id = 1});
        }
    }
}