using System;
using Xunit;

namespace KataTennis
{
    public class UnitTest1
    {

        [Fact]
        public void ScoreInitialized()
        {
            Game game = new Game();
            
            string score = game.Score;

            Assert.Equal("0/0", score);
        }

        [Fact]
        public void CanGetScoreAfterPlayer2WinsBall()
        {
            Game game = new Game();
            game.WinBall(2);

            string score = game.Score;

            Assert.Equal("0/15", score);
        }

        [Fact]
        public void CanGetScoreAfterPlayer1WinsBall()
        {
            Game game = new Game();
            game.WinBall(1);

            string score = game.Score;

            Assert.Equal("15/0", score);
        }

        [Fact]
        public void CanGetScoreWhenPlayer1Wins2Balls()
        {
            Game game = new Game();
            game.WinBall(1);
            game.WinBall(1);

            string score = game.Score;

            Assert.Equal("30/0", score);
        }

        [Fact]
        public void CanGetScoreAfterPlayer1AndPlayer2WinsBall()
        {
            Game game = new Game();
            game.WinBall(2);
            game.WinBall(1);
            game.WinBall(2);

            string score = game.Score;

            Assert.Equal("15/30", score);
        }

        [Fact]
        public void CanGetScoreWhenPlayer1WinsBallIfPlayer2HasAlreadyWonTwoBalls()
        {
            Game game = new Game();
            game.WinBall(2);
            game.WinBall(2);
            game.WinBall(1);

            string score = game.Score;

            Assert.Equal("15/30", score);
        }

        [Fact]
        public void CanGetScoreWhenPlayer1Wins3Balls()
        {
            Game game = new Game();
            game.WinBall(2);
            game.WinBall(1);
            game.WinBall(1);
            game.WinBall(1);

            string score = game.Score;

            Assert.Equal("40/15", score);
        }
        [Fact]
        public void CanGetScore15A()
        {
            Game game = new Game();
            game.WinBall(2);
            game.WinBall(1);

            string score = game.Score;

            Assert.Equal("15/A", score);
        }

        [Fact]
        public void CanGetScore30A()
        {
            Game game = new Game();
            game.WinBall(2);
            game.WinBall(2);
            game.WinBall(1);
            game.WinBall(1);

            string score = game.Score;

            Assert.Equal("30/A", score);
        }

        [Fact]
        public void CanGetScoreWhenPlayersHaveDeuce()
        {
            Game game = new Game();
            game.WinBall(2);
            game.WinBall(2);
            game.WinBall(1);
            game.WinBall(1);
            game.WinBall(2);
            game.WinBall(1);

            string score = game.Score;

            Assert.Equal("DEUCE", score);
        }
    }
}
