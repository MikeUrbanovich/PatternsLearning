namespace PatternsLearning.ServiceLocator.Services.Write
{
    internal class FileWriterService: IWriteService
    {
        public void WriteText()
        {
            Console.WriteLine("Write text to File.");
        }
    }
}
