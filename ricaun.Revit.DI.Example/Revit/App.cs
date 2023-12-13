using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using ricaun.Revit.DI.Example.Revit.Commands;
using ricaun.Revit.DI.Example.Services;
using ricaun.Revit.UI;
using System;

namespace ricaun.Revit.DI.Example.Revit
{
    [AppLoader]
    public class App : IExternalApplication, IHost
    {
        private static RibbonPanel ribbonPanel;
        public Result OnStartup(UIControlledApplication application)
        {
            ribbonPanel = application.CreatePanel("DI.Example");
            ribbonPanel.RowStackedItems(
                ribbonPanel.CreatePushButton<Command<RevitVersionCommand>>("Revit Version"),
                ribbonPanel.CreatePushButton<Command<RevitDocumentTitle>>("Active Document"),
                ribbonPanel.CreatePushButton<Command<RevitDocumentsInfo>>("Info Documents")
            );

            // Container
            var container = this.GetContainer();

            // Add Revit UIApplication
            container.AddRevitSingleton(application);

            container.AddScoped<IMessageService, MessageService>();
            container.AddScoped<IDocumentService, DocumentService>();

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            ribbonPanel?.Remove();

            // Container Dispose
            this.GetContainer().Dispose();

            return Result.Succeeded;
        }
    }
}