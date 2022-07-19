using PatternsLearning.Mediator.Options;

namespace PatternsLearning.Mediator.Mediator
{
    internal interface IMediator
    {
        void Notify(object sender, string text);
        void Notify(object sender);
        void Notify(object sender, WriteStatuses status, string message);
    }
}
