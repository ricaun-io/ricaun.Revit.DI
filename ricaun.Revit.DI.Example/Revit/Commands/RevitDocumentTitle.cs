using ricaun.Revit.DI.Example.Services;

namespace ricaun.Revit.DI.Example.Revit.Commands
{
    public class RevitDocumentTitle : ICommand
    {
        private readonly IDocumentService documentsService;
        private readonly IMessageService messageService;
        public RevitDocumentTitle(IDocumentService documentsService, IMessageService messageService)
        {
            this.documentsService = documentsService;
            this.messageService = messageService;
        }
        public void Execute()
        {
            var document = documentsService.GetDocument();
            messageService.Show("Active Document", document.Title);
        }
    }
}