namespace PatternsLearning.Mediator.Services
{
    internal class TextGettingService: BaseService
    {
        public void GetText()
        {
            Console.WriteLine("Enter text");
            var text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
                text = "...empty line...";

            _mediator.Notify(this, text);
        }
    }
}
