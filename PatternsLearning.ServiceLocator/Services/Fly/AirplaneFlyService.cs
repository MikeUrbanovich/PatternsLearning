namespace PatternsLearning.ServiceLocator.Services.Fly
{
    internal class AirplaneFlyService: IFlyService
    {
        public void Fly()
        {
            Console.WriteLine("Fly on airplane");
        }
    }
}
