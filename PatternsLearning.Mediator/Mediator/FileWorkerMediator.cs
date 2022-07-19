using PatternsLearning.Mediator.Options;
using PatternsLearning.Mediator.Services;

namespace PatternsLearning.Mediator.Mediator
{
    internal class FileWorkerMediator: IMediator
    {
        private readonly JsonWriterService _jsonWriterService;
        private readonly TxtWriterService _txtWriterService;
        private readonly XmlWriterService _xmlWriterService;
        private readonly FileTypeSelectionService _fileSelectionService;
        private readonly TextGettingService _textGettingService;
        private readonly FileWriterService _fileWriterService;

        private string _text;
        private FileTypes _fileTypes;

        public FileWorkerMediator(TextGettingService textGettingService, FileWriterService fileWriterService)
        {
            _jsonWriterService = new JsonWriterService();
            _jsonWriterService.SetMediator(this);
            _txtWriterService = new TxtWriterService();
            _txtWriterService.SetMediator(this);
            _xmlWriterService = new XmlWriterService();
            _xmlWriterService.SetMediator(this);
            _fileSelectionService = new FileTypeSelectionService();
            _fileSelectionService.SetMediator(this);
            _textGettingService = textGettingService;
            _textGettingService.SetMediator(this);
            _fileWriterService = fileWriterService;
            _fileWriterService.SetMediator(this);
        }

        public void Notify(object sender, string text)
        {
            _text = text;

            _fileTypes = _fileSelectionService.SelectFileType();
        }

        public void Notify(object sender)
        {
            switch (_fileTypes)
            {
                case FileTypes.Txt: 
                    _txtWriterService.WriteFile(_text);
                    break;
                case FileTypes.Json:
                    _jsonWriterService.WriteFile(_text);
                    break;
                case FileTypes.Xml:
                    _xmlWriterService.WriteFile(_text);
                    break;
            }
        }

        public void Notify(object sender, WriteStatuses status, string message)
        {
            _fileWriterService.SendWriteResult(status, message);
        }
    }
}
