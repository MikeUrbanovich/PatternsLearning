namespace PatternsLearning.Bridge.DbWorkers
{
    internal class NoSqlWorker: IDbWorker
    {
        public string Data { get; set; }

        public void WriteData(string data)
        {
            Data = data;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Write {Data} to NoSql db.");
            Console.ResetColor();
        }

        public string ReadData()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Read from NoSql db.");
            Console.ResetColor();

            return Data;
        }
    }
}
