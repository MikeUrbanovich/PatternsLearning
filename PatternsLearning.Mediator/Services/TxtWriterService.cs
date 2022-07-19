using PatternsLearning.Mediator.Options;

namespace PatternsLearning.Mediator.Services
{
    internal class TxtWriterService: BaseService
    {
        public void WriteFile(string text)
        {
            WriteStatuses status = 0;
            var message = "";

            try
            {
                Console.WriteLine($"Write to txt file: {text}");
                status = WriteStatuses.Ok;
                message = "The write was successful";
            }
            catch (Exception ex)
            {
                status = WriteStatuses.Fail;
                message = ex.Message;
            }
            finally
            {
                _mediator.Notify(this, status, message);
            }
        }
    }
}
