using System;
using Dartboard;

namespace Simple_Darts
{
    public class Player
    {
        public Dart Dart { get; set; }
        public Score Score { get; set; }

        public Player(Random random)
        {
            Dart = new Dart(random);
            Score = new Score();
        }
    }
}