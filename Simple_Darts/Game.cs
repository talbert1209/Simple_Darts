using System;
using Dartboard;

namespace Simple_Darts
{
    public class Game
    {
        private readonly Player _humanPlayer;
        private Player _computerPlayer;

        public Game()
        {
            var random = new Random();
            _humanPlayer = new Player(random);
            _computerPlayer = new Player(random);
        }

        public string HumanThrow()
        {
            string throwLocation = _humanPlayer.Dart.Throw();
            _humanPlayer.Score.ConvertScore(throwLocation);
            return throwLocation;
        }

        public int GetScore(bool human)
        {
            if (human)
                return _humanPlayer.Score.Total;
            return _computerPlayer.Score.Total;
        }

        public int ComputersTurn()
        {
            var throw1 = _computerPlayer.Dart.Throw();
            var throw2 = _computerPlayer.Dart.Throw();
            var throw3 = _computerPlayer.Dart.Throw();

            _computerPlayer.Score.ConvertScore(throw1);
            _computerPlayer.Score.ConvertScore(throw2);
            _computerPlayer.Score.ConvertScore(throw3);

            return _computerPlayer.Score.Total;
        }
    }
}