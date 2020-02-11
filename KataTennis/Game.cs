using System;

namespace KataTennis
{
    internal class Game
    {
        string _score = "0/0";
        int _player1PointsWon = 0;
        int _player2PointsWon = 0;

        string _scorePlayer1 = "0";
        string _scorePlayer2 = "0";

        public string Score { get { return _score; } }

        internal void WinBall(int iPlayer)
        {
            if (iPlayer == 1)
            {
                _player1PointsWon++;

                _scorePlayer1 = GetScoreFromPoints(_player1PointsWon);
            }
            else
            {
                _player2PointsWon++;
                _scorePlayer2 = GetScoreFromPoints(_player2PointsWon);
            }                    
            _score = string.Format("{0}/{1}", _scorePlayer1, _scorePlayer2);

            if (_player1PointsWon == _player2PointsWon)
            {
                if (_player1PointsWon < 3)
                {
                    _score = string.Format("{0}/A", _scorePlayer1);
                }
                else
                {
                    _score = "DEUCE";
                }
            }            
        }

        private static string GetScoreFromPoints(int iNbPointsWon)
        {
            return (new string[] { "0", "15", "30", "40" })[iNbPointsWon];
        }
    }
}