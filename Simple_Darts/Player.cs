using System;
using Dartboard;

namespace Simple_Darts
{
    public class Player
    {
        public string Name { get; set; }
        public Dart Dart { get; set; }

        public Player(Random random, string name)
        {
            Name = name;
            Dart = new Dart(random);
        }
    }
}