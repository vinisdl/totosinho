using System;
using System.ComponentModel.DataAnnotations;

namespace Totosinho.App.ViewModels.Servicos
{
    public class GameResultViewModel
    {
        public long Id { get; private set; }

        [Required]
        [Range(1, long.MaxValue)]
        public long PlayerId { get; set; }

        [Required]
        [Range(1, long.MaxValue)]
        public long GameId { get; set; }

        [Required]
        public long Win { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        public long ServidorCod { get; private set; }


        public void SetServidorCod(long servidorCod)
        {
            ServidorCod = servidorCod;
        }

        public override bool Equals(object obj)
        {
            var view = obj as GameResultViewModel;
            return view?.Id == Id;
        }
    }
}