using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;

namespace ricaun.Revit.DI.Example.Revit.Commands
{
    [Transaction(TransactionMode.Manual)]
    public class Command<T> : IExternalCommand, IHost where T : class, ICommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elementSet)
        {
            this.Resolve<T>().Execute();
            return Result.Succeeded;
        }
    }

    public interface ICommand
    {
        public void Execute();
    }
}
