using System;
using System.Threading.Tasks;
using AutoMapper;
using Totosinho.App.Interfaces;
using Totosinho.App.Interfaces.Servicos;
using Totosinho.App.ViewModels.Servicos;
using Totosinho.Domain.Entidades;
using Totosinho.Domain.Interfaces.Servicos;
using Totosinho.Infra.Contexto.Interfaces;

namespace Totosinho.App.Servicos
{
    public class ServidorAppServico : IServidorAppServico
    {
        private readonly IServidorServico _servicoServidor;        

        public ServidorAppServico(IServidorServico servicoServidor){
            _servicoServidor = servicoServidor;            
        }

        public ServidorViewModel ObterPorTokenAcesso(string tokenAcesso)
        {
            var servidor = _servicoServidor.ObterPorTokenAcesso(tokenAcesso);
            return ObterBoletoViewModel(servidor);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        private ServidorViewModel ObterBoletoViewModel(Servidor Servidor)
        {
            return Mapper.Map<Servidor, ServidorViewModel>(Servidor);
        }
    }
}
