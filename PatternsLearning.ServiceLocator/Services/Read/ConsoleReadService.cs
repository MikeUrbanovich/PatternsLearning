namespace PatternsLearning.ServiceLocator.Services.Read
{
    internal class ConsoleReadService: IReadService
    {
        public void ReadText()
        {
            Console.WriteLine("Read from Console.");
        }
    }
}
