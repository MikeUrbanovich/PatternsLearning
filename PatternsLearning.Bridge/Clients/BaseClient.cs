using PatternsLearning.Bridge.DbWorkers;

namespace PatternsLearning.Bridge.Clients
{
    public abstract class BaseClient
    {
        public IDbWorker _dbWorker;

        public BaseClient(IDbWorker dbWorker)
        {
            _dbWorker = dbWorker;
        }

        public abstract void WriteToDb(string data);

        public void ReadFromDb()
        {
            var data = _dbWorker.ReadData();
            Console.WriteLine($"Data from db: {data}");
        }
    }
}
