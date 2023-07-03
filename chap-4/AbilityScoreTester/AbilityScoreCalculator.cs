namespace AbilityScoreTester
{
    public class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            // Divide the roll result by the DivideBy field
            double result = RollResult / DivideBy;

            // Add AddAmount to the result of that division
            result += (double)AddAmount;

            // If the result is too small, use Minimum
            if (result < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = (int)result;
            }
        }

    }
}