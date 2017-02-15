using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Totosinho.App.ViewModels.Servicos;

namespace Totosinho.App.Interfaces.Servicos
{
   public interface IServidorAppServico
   {
       ServidorViewModel ObterPorTokenAcesso(string tokenAcesso);
   }
}
