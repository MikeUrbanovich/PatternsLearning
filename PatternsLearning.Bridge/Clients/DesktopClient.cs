using PatternsLearning.Bridge.DbWorkers;

namespace PatternsLearning.Bridge.Clients
{
    internal class DesktopClient: BaseClient
    {
        public DesktopClient(IDbWorker dbWorker) : base(dbWorker)
        {
        }

        public override void WriteToDb(string data)
        {
            Console.WriteLine("Write to db from Desk");
            _dbWorker.WriteData(data);
        }
    }
}
