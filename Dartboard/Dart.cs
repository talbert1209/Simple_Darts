using System;

namespace Dartboard
{
    public class Dart
    {
        private readonly Random _random;
        private readonly int[] _board = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

        public Dart(Random random)
        {
            _random = random;
        }

        public string Throw()
        {
            return GetBoardLocation(GetBoardNumber());
        }

        private int GetBoardNumber()
        {
            return _board[_random.Next(_board.Length)];
        }

        private string GetBoardLocation(int boardNumber)
        {
            if (boardNumber == 0)
                return GetBullseyeType();
            return GetBoardNumberType(boardNumber);
        }

        private string GetBullseyeType()
        {
            if (_random.Next(5) == 2)
                return "Double Bullseye";
            return "Bullseye";
        }

        private string GetBoardNumberType(int boardNumber)
        {
            var doubleOrTriple = _random.Next(5);

            if (doubleOrTriple == 2)
                return $"Double {boardNumber}";
            if (doubleOrTriple == 3)
                return $"Triple {boardNumber}";
            return $"{boardNumber}";
        }
    }
}
