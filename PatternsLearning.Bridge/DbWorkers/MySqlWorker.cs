namespace PatternsLearning.Bridge.DbWorkers
{
    internal class MySqlWorker: IDbWorker
    {
        public string Data { get; set; }

        public void WriteData(string data)
        {
            Data = data;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Write {Data} to MySql db.");
            Console.ResetColor();
        }

        public string ReadData()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Read from MySql db.");
            Console.ResetColor();

            return Data;
        }
    }
}
