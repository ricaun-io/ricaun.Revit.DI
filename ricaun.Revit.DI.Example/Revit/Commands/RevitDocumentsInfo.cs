using ricaun.Revit.DI.Example.Services;
using System.Linq;

namespace ricaun.Revit.DI.Example.Revit.Commands
{
    public class RevitDocumentsInfo : ICommand
    {
        private readonly IDocumentService documentsService;
        private readonly IMessageService messageService;
        public RevitDocumentsInfo(IDocumentService documentsService, IMessageService messageService)
        {
            this.documentsService = documentsService;
            this.messageService = messageService;
        }
        public void Execute()
        {
            var documents = documentsService.GetDocuments();
            var message = string.Join("\n", documents.Select(x => x.Title));
            messageService.Show("Documents", message);
        }
    }
}