// See https://aka.ms/new-console-template for more information
using PatternsLearning.Strategy;
using PatternsLearning.Strategy.Strategies;

var strategyHelper = new StrategyHelper();
var exit = false;

Console.WriteLine("Hello! This application helps you to get statistics for your investment strategy.");

do
{
    Console.ResetColor();

    Console.WriteLine("Enter amount of your money.");
    if (!double.TryParse(Console.ReadLine(), out var amountOfMoney))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Enter correct amount of your money\n");
        continue;
    }

    Console.WriteLine("Enter investment period (years).");
    if (!int.TryParse(Console.ReadLine(), out var period))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Enter correct period\n");
        continue;
    }

    if (!SelectStrategy())
        continue;


    strategyHelper.GetStrategyStatistics(amountOfMoney, period);

    Console.WriteLine("If you want to close application, please enter \'y\'");
    exit = Console.ReadLine() == "y";

} while (!exit);


bool SelectStrategy()
{
    Console.WriteLine("Select your strategy (enter number):\n1) Aggressive\n2) Medium\n3) Conservative");
    var strategyType = Console.ReadLine();

    switch (strategyType)
    {
        case "1":
            strategyHelper.SetStrategy(new AggressiveStrategy());
            return true;
        case "2":
            strategyHelper.SetStrategy(new MediumStrategy());
            return true;
        case "3":
            strategyHelper.SetStrategy(new ConservativeStrategy());
            return true;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please try again and in next time enter correct number\n");
            return false;
    }
}