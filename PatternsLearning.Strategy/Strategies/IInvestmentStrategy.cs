namespace PatternsLearning.Strategy.Strategies
{
    internal interface IInvestmentStrategy
    {
        double CalculateProfit(double amountOfMoney, int period);
    }
}
