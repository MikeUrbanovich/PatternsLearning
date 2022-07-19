using PatternsLearning.Mediator.Options;

namespace PatternsLearning.Mediator.Services
{
    internal class FileWriterService: BaseService
    {
        public void WriteFile()
        {
            Console.WriteLine("Write to file...\n");
            _mediator.Notify(this);
        }

        public void SendWriteResult(WriteStatuses status, string message)
        {
            Console.ForegroundColor = status is WriteStatuses.Fail ? ConsoleColor.Red : ConsoleColor.Green;
            Console.WriteLine($"Write status: {status}.\nMessage: {message}\n");

            Console.ResetColor();
        }
    }
}
