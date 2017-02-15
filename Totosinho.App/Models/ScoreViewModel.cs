using System;

namespace Totosinho.App.Models
{
    public class ScoreViewModel
    {
        public long PlayerId { get; set; }
        public long GameId { get; set; }
        public long Win { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}