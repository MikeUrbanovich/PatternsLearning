namespace PatternsLearning.Bridge.DbWorkers
{
    public interface IDbWorker
    {
        string Data { get; set; }
        void WriteData(string data);
        string ReadData();

    }
}
