using Autodesk.Revit.ApplicationServices;
using System;
using System.Linq;
using System.Reflection;

namespace ricaun.Revit.DI.Extensions
{
    /// <summary>
    /// ControlledApplicationExtension
    /// </summary>
    internal static class ControlledApplicationExtension
    {
        /// <summary>
        /// Get <see cref="Autodesk.Revit.ApplicationServices.Application"/> using the <paramref name="application"/>
        /// </summary>
        /// <param name="application">Revit ControlledApplication</param>
        public static Application GetApplication(this ControlledApplication application)
        {
            var type = typeof(ControlledApplication);

            var propertie = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(e => e.FieldType == typeof(Application));

            return propertie?.GetValue(application) as Application;
        }

        /// <summary>
        /// Get <see cref="Autodesk.Revit.ApplicationServices.ControlledApplication"/> using the <paramref name="application"/>
        /// </summary>
        /// <param name="application">Revit Application</param>
        public static ControlledApplication GetControlledApplication(this Application application)
        {
            var type = typeof(ControlledApplication);

            var constructor = type.GetConstructor(
                BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { application.GetType() }, null);

            return constructor?.Invoke(new object[] { application }) as ControlledApplication;
        }
    }
}
