using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Totosinho.App.ViewModels.Servicos
{
    public class ScoreViewModel
    {
        public long Id { get; private set; }
        public long PlayerId { get; set; }
        public long GameId { get; set; }
        public long Win { get; set; }
        public DateTime TimeStamp { get; set; }
        public long ServidorCod { get; private set; }


        public void SetServidorCod(long servidorCod)
        {
            ServidorCod = servidorCod;
        }
    }
}
