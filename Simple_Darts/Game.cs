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
            return _humanPlayer.Dart.Throw();
        }

    }
}