// See https://aka.ms/new-console-template for more information

using PatternsLearning.ServiceLocator;
using PatternsLearning.ServiceLocator.ServiceLocator;
using PatternsLearning.ServiceLocator.Services.Fly;
using PatternsLearning.ServiceLocator.Services.Read;
using PatternsLearning.ServiceLocator.Services.Write;

Console.WriteLine("Hello, World!");


var locator = new ServiceLocator();

locator.Register<IReadService>(new ConsoleReadService());
locator.Register<IReadService>(new FileReadService());

locator.Register<IWriteService>(new ConsoleWriterService());
locator.Register<IWriteService>(new FileWriterService());

locator.Register(new HelicopterFlyService());
locator.Register(new AirplaneFlyService());


var test = new TestClass(locator);

test.FlyOnHelicopter();
Console.WriteLine("----------------");

test.FlyOnAirplane();
Console.WriteLine("----------------");

test.ReadFromConsole();
Console.WriteLine("----------------");

test.ReadFromFile();
Console.WriteLine("----------------");

test.WriteToConsole();
Console.WriteLine("----------------");

test.WriteToFile();
Console.WriteLine("----------------");