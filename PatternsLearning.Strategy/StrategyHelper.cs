using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLearning.Strategy.Strategies;

namespace PatternsLearning.Strategy
{
    internal class StrategyHelper
    {
        private IInvestmentStrategy _strategy;

        public void SetStrategy(IInvestmentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void GetStrategyStatistics(double amountOfMoney, int period)
        {
            var result = _strategy.CalculateProfit(amountOfMoney, period);

            Console.WriteLine($"Your capital will be {result} after {period} years ");
        }
    }
}
