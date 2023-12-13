using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.UI;
using ricaun.DI;
using ricaun.Revit.DI.Extensions;

namespace ricaun.Revit.DI
{
    /// <summary>
    /// RevitContainerExtension
    /// </summary>
    public static class RevitContainerExtension
    {
        /// <summary>
        /// Add <see cref="Autodesk.Revit.UI.UIApplication"/>, <see cref="Autodesk.Revit.UI.UIControlledApplication"/>, <see cref="Autodesk.Revit.ApplicationServices.Application"/>, and <see cref="Autodesk.Revit.ApplicationServices.ControlledApplication"/> as Singleton.
        /// </summary>
        /// <param name="container">DI container</param>
        /// <param name="application">Revit UI application</param>
        public static void AddRevitSingleton(this IContainer container, UIApplication application)
        {
            container.AddSingleton(application);
            container.AddSingleton(application.GetControlledApplication());
            container.AddRevitSingleton(application.Application);
        }

        /// <summary>
        /// Add <see cref="Autodesk.Revit.UI.UIApplication"/>, <see cref="Autodesk.Revit.UI.UIControlledApplication"/>, <see cref="Autodesk.Revit.ApplicationServices.Application"/>, and <see cref="Autodesk.Revit.ApplicationServices.ControlledApplication"/> as Singleton.
        /// </summary>
        /// <param name="container">DI container</param>
        /// <param name="application">Revit UI controlled application</param>
        public static void AddRevitSingleton(this IContainer container, UIControlledApplication application)
        {
            container.AddSingleton(application);
            container.AddSingleton(application.GetUIApplication());
            container.AddRevitSingleton(application.ControlledApplication);
        }

        /// <summary>
        /// Add <see cref="Autodesk.Revit.ApplicationServices.Application"/>, and <see cref="Autodesk.Revit.ApplicationServices.ControlledApplication"/> as Singleton.
        /// </summary>
        /// <param name="container">DI container</param>
        /// <param name="application">Revit DB controlled application</param>
        public static void AddRevitSingleton(this IContainer container, ControlledApplication application)
        {
            container.AddSingleton(application);
            container.AddSingleton(application.GetApplication());
        }

        /// <summary>
        /// Add <see cref="Autodesk.Revit.ApplicationServices.Application"/>, and <see cref="Autodesk.Revit.ApplicationServices.ControlledApplication"/> as Singleton.
        /// </summary>
        /// <param name="container">DI container</param>
        /// <param name="application">Revit DB application</param>
        public static void AddRevitSingleton(this IContainer container, Application application)
        {
            container.AddSingleton(application);
            container.AddSingleton(application.GetControlledApplication());
        }
    }
}
