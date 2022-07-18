namespace PatternsLearning.Strategy.Strategies
{
    internal class MediumStrategy : IInvestmentStrategy
    {
        private const double profitCoef = 0.2;
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
