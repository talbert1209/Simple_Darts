using System;
using Dartboard;

namespace Simple_Darts
{
    public class Player
    {
        public Dart Dart { get; set; }

        public Player(Random random)
        {
            Dart = new Dart(random);
        }
    }
}