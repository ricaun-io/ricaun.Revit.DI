using Autodesk.Revit.UI;
using System;
using System.Linq;
using System.Reflection;

namespace ricaun.Revit.DI.Extensions
{
    /// <summary>
    /// UIControlledApplicationExtension
    /// </summary>
    public static class UIControlledApplicationExtension
    {
        /// <summary>
        /// Get <see cref="Autodesk.Revit.UI.UIApplication"/> using the <paramref name="application"/>
        /// </summary>
        /// <param name="application">Revit UIApplication</param>
        public static UIApplication GetUIApplication(this UIControlledApplication application)
        {
            var type = typeof(UIControlledApplication);

            var propertie = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(e => e.FieldType == typeof(UIApplication));

            return propertie?.GetValue(application) as UIApplication;
        }

        /// <summary>
        /// Get <see cref="Autodesk.Revit.UI.UIControlledApplication"/> using the <paramref name="application"/>
        /// </summary>
        /// <param name="application">Revit UIControlledApplication</param>
        public static UIControlledApplication GetUIControlledApplication(this UIApplication application)
        {
            var type = typeof(UIControlledApplication);

            var constructor = type.GetConstructor(
                BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { application.GetType() }, null);

            return constructor?.Invoke(new object[] { application }) as UIControlledApplication;
        }
    }
}