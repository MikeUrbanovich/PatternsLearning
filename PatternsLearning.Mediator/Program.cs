// See https://aka.ms/new-console-template for more information

using PatternsLearning.Mediator.Mediator;
using PatternsLearning.Mediator.Services;

var textGettingService = new TextGettingService();
var fileWriterService = new FileWriterService();

new FileWorkerMediator(textGettingService, fileWriterService);

do
{
    textGettingService.GetText();
    fileWriterService.WriteFile();

} while (true);

