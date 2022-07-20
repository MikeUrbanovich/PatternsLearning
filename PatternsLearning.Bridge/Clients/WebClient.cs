using PatternsLearning.Bridge.DbWorkers;

namespace PatternsLearning.Bridge.Clients
{
    internal class WebClient: BaseClient
    {
        public WebClient(IDbWorker dbWorker) : base(dbWorker)
        {
        }

        public override void WriteToDb(string data)
        {
            Console.WriteLine("Write to db from Web");
            _dbWorker.WriteData(data);
        }
    }
}
