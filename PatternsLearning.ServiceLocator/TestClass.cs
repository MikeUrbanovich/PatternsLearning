using PatternsLearning.ServiceLocator.ServiceLocator;
using PatternsLearning.ServiceLocator.Services.Fly;
using PatternsLearning.ServiceLocator.Services.Read;
using PatternsLearning.ServiceLocator.Services.Write;

namespace PatternsLearning.ServiceLocator
{
    public class TestClass
    {
        private readonly IServiceLocator _serviceLocator;

        public TestClass(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public void ReadFromConsole()
        {
            var service = _serviceLocator.GetService<IReadService, ConsoleReadService>();
            service.ReadText();
        }
        public void ReadFromFile()
        {
            var service = _serviceLocator.GetService<IReadService, FileReadService>();
            service.ReadText();
        }
        public void WriteToConsole()
        {
            var service = _serviceLocator.GetService<IWriteService, ConsoleWriterService>();
            service.WriteText();
        }
        public void WriteToFile()
        {
            var service = _serviceLocator.GetService<IWriteService, FileWriterService>();
            service.WriteText();
        }
        public void FlyOnHelicopter()
        {
            var service = _serviceLocator.GetService<HelicopterFlyService>();
            service.Fly();
        }
        public void FlyOnAirplane()
        {
            var service = _serviceLocator.GetService<AirplaneFlyService>();
            service.Fly();
        }
    }
}
