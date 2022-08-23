namespace PatternsLearning.ServiceLocator.Services.Read
{
    internal class FileReadService: IReadService
    {
        public void ReadText()
        {
            Console.WriteLine("Read from File.");
        }
    }
}
