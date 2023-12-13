using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ricaun.Revit.DI.Example.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly UIApplication uiapp;

        public DocumentService(UIApplication uiapp)
        {
            this.uiapp = uiapp;
        }

        public Document GetDocument()
        {
            return uiapp.ActiveUIDocument.Document;
        }

        public IList<Document> GetDocuments()
        {
            return uiapp.Application.Documents
                .OfType<Document>()
                .ToList();
        }

    }

    public interface IDocumentService
    {
        public Document GetDocument();
        public IList<Document> GetDocuments();
    }
}
