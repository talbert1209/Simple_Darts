using System;
using Dartboard;

namespace Simple_Darts
{
    public class Game
    {
        private Player _humanPlayer;
        private Player _computerPlayer;

        public Game(string name)
        {
            var random = new Random();
            _humanPlayer = new Player(random, name);
            _computerPlayer = new Player(random, "Computer");
        }

        public string HumanThrow()
        {
            return _humanPlayer.Dart.Throw();
        }

    }
}