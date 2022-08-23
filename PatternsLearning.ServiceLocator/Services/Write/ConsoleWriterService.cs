namespace PatternsLearning.ServiceLocator.Services.Write
{
    internal class ConsoleWriterService: IWriteService
    {
        public void WriteText()
        {
            Console.WriteLine("Write text to Console.");
        }
    }
}
