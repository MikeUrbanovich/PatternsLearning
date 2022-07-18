namespace PatternsLearning.Strategy.Strategies
{
    internal class AggressiveStrategy : IInvestmentStrategy
    {
        private const double profitCoef = 0.5;
        public double CalculateProfit(double amountOfMoney, int period)
        {
            var result = amountOfMoney;

            for (var i = 0; i < period; i++)
            {
                result += result * profitCoef;
            }

            return Math.Round(result, 2);
        }
    }
}
