using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totosinho.Domain.Entities
{
    public class Score : EntityBase
    {
        public Score(long playerId, long gameId, long win, DateTime timestamp)
        {
            SetPlayerId(playerId);
            SetGameId(gameId);
            SetWin(win);
            SetTimeStamp(timestamp);
        }
        
        public long PlayerId { get; private set; }
        public long GameId { get; private set; }
        public long Win { get; private set; }
        public DateTime TimeStamp { get; private set; }

        public void SetPlayerId(long playerId)
        {
            PlayerId = playerId;
        }

        public void SetGameId(long gameId)
        {
            GameId = gameId;
        }

        public void SetWin(long win)
        {
            Win = win;
        }

        public void SetTimeStamp(DateTime timestamp)
        {
            TimeStamp = timestamp;
        }

    }
}
