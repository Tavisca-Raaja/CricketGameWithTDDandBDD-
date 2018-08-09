using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
   
    public class Cricket
    {
        private ScoreCard[] _Player = new ScoreCard[2];

        public void StartPlay(int PlayerId)
        {
            
            _Player[PlayerId] = new ScoreCard();
            _Player[PlayerId].score = 0;
            _Player[PlayerId].status = "NOTOUT";
        }

        public void UpdateScore(int PlayerId, int runs)
        {
            if (_Player[PlayerId].status.Equals("NOTOUT"))
            {
                if (runs < 7 && runs > 0)
                    _Player[PlayerId].score += runs;
            }
        }
        public int GetScore(int PlayerId)
        {
            return _Player[PlayerId].score;
        }
        public void UpdatePlayerStatus(int PlayerId)
        {
            _Player[PlayerId].status = "OUT";
        }
        public int Winner()
        {
            if (_Player[0].score > _Player[1].score)
                return 1;
            else if (_Player[0].score < _Player[1].score)
                return 2;
            else
                return 0;
                
        }
       
    }
}
