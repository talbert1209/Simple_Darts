namespace Simple_Darts
{
    public class Score
    {
        public int Total { get; private set; }

        public int ConvertScore(string throwLocation)
        {
            // Account for single score
            if (int.TryParse(throwLocation, out var score))
            {
                AddToTotal(score);
                return score;
            }

            // Account for bullseye
            if (throwLocation.ToLower().Contains("bullseye"))
            {
                if (throwLocation.ToLower().Contains("double"))
                {
                    AddToTotal(50);
                    return 50;
                }

                AddToTotal(25);
                return 25;
            }

            // Account for double or triple
            var splitThrowLocation = throwLocation.Split(' ');
            int.TryParse(splitThrowLocation[1], out var baseScore);
            if (splitThrowLocation[0].ToLower() == "double")
            {
                AddToTotal(baseScore * 2);
                return baseScore * 2;
            }

            if (splitThrowLocation[0].ToLower() == "triple")
            {
                AddToTotal(baseScore * 3);
                return baseScore * 3;
            }

            return 0;
        }

        private void AddToTotal(int score)
        {
            Total += score;
        }
    }
}