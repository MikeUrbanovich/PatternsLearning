using PatternsLearning.Mediator.Options;

namespace PatternsLearning.Mediator.Services
{
    internal class FileTypeSelectionService: BaseService
    {
        public FileTypes SelectFileType()
        {
            Console.WriteLine("Select type of file (enter number):\n1) Json\n2) Txt\n3) Xml");

            do
            {
                if (!int.TryParse(Console.ReadLine(), out var type))
                {
                    Console.WriteLine("Try again to select number from list");
                    continue;
                }
                    

                switch (type)
                {
                    case 1: return FileTypes.Json;
                    case 2: return FileTypes.Txt;
                    case 3: return FileTypes.Xml;
                    default:
                        Console.WriteLine("Try again to select number from list");
                        continue;
                }
            } while (true);
        }
    }
}
