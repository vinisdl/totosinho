using System;
using System.Activities;

namespace Totosinho.Domain.Entidades
{
    public class Score : EntityBase
    {
        public Score(long playerId, long gameId, long win, DateTime timestamp, long servidorCod)
        {
            SetPlayerId(playerId);
            SetGameId(gameId);
            SetWin(win);
            SetTimeStamp(timestamp);
            SetServidorCod(servidorCod);
        }

        public long PlayerId { get; private set; }
        public long GameId { get; private set; }
        public long Win { get; private set; }
        public DateTime TimeStamp { get; private set; }
        public long ServidorCod { get; private set; }

        public void SetPlayerId(long playerId)
        {
            if (playerId <= 0)
                throw new ValidationException("Player Id deve ser maior que 0.");
            PlayerId = playerId;
        }

        public void SetGameId(long gameId)
        {
            if (gameId <= 0)
                throw new ValidationException("Game Id deve ser maior que 0.");
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

        public void SetServidorCod(long servidorCod)
        {
            ServidorCod = servidorCod;
        }
    }
}