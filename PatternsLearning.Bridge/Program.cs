// See https://aka.ms/new-console-template for more information

using PatternsLearning.Bridge.Clients;
using PatternsLearning.Bridge.DbWorkers;

Console.WriteLine("Hello, World!");

var clients = new List<BaseClient>()
{
    new ConsoleClient(new MySqlWorker()),
    new DesktopClient(new MySqlWorker()),
    new WebClient(new MySqlWorker())
};

Work();

foreach (var client in clients)
{
    client._dbWorker = new NoSqlWorker();
}

Console.WriteLine("_____________________________");

Work();


void Work()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Enter text");

    var data = Console.ReadLine();

    Console.ResetColor();

    Write(data);
    Console.WriteLine("--------------------------");
    Read();
}

void Write(string data)
{
    foreach (var client in clients)
    {
        client.WriteToDb(data);
    }
}

void Read()
{
    foreach (var client in clients)
    {
        client.ReadFromDb();
    }
}
