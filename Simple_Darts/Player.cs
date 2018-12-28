using System;
using Dartboard;

namespace Simple_Darts
{
    public class Player
    {
        public string Name { get; set; }
        public Dart Dart1 { get; set; }
        public Dart Dart2 { get; set; }
        public Dart Dart3 { get; set; }

        public Player(Random random, string name)
        {
            Name = name;
            Dart1 = new Dart(random);
            Dart2 = new Dart(random);
            Dart3 = new Dart(random);
        }
    }
}