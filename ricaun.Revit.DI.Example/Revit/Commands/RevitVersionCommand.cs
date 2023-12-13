using Autodesk.Revit.UI;
using ricaun.Revit.DI.Example.Services;

namespace ricaun.Revit.DI.Example.Revit.Commands
{
    public class RevitVersionCommand : ICommand
    {
        private readonly UIApplication uiapp;
        private readonly IMessageService messageService;

        public RevitVersionCommand(UIApplication uiapp, IMessageService messageService)
        {
            this.uiapp = uiapp;
            this.messageService = messageService;
        }
        public void Execute()
        {
            messageService.Show(uiapp.Application.VersionName);
        }
    }
}