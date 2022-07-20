using PatternsLearning.Bridge.DbWorkers;

namespace PatternsLearning.Bridge.Clients
{
    internal class ConsoleClient: BaseClient
    {
        public ConsoleClient(IDbWorker dbWorker) : base(dbWorker)
        {
        }
        public override void WriteToDb(string data)
        {
            Console.WriteLine("Write to db from Console");
            _dbWorker.WriteData(data);
        }
    }
}
