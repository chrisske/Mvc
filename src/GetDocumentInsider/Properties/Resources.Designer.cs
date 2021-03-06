// <auto-generated />
namespace Microsoft.Extensions.ApiDescription.Tool
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.Extensions.ApiDescription.Tool.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The assembly to use.
        /// </summary>
        internal static string AssemblyDescription
        {
            get => GetString("AssemblyDescription");
        }

        /// <summary>
        /// The assembly to use.
        /// </summary>
        internal static string FormatAssemblyDescription()
            => GetString("AssemblyDescription");

        /// <summary>
        /// Missing required option '--{0}'.
        /// </summary>
        internal static string MissingOption
        {
            get => GetString("MissingOption");
        }

        /// <summary>
        /// Missing required option '--{0}'.
        /// </summary>
        internal static string FormatMissingOption(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("MissingOption"), p0);

        /// <summary>
        /// Do not colorize output.
        /// </summary>
        internal static string NoColorDescription
        {
            get => GetString("NoColorDescription");
        }

        /// <summary>
        /// Do not colorize output.
        /// </summary>
        internal static string FormatNoColorDescription()
            => GetString("NoColorDescription");

        /// <summary>
        /// The file to write the result to.
        /// </summary>
        internal static string OutputDescription
        {
            get => GetString("OutputDescription");
        }

        /// <summary>
        /// The file to write the result to.
        /// </summary>
        internal static string FormatOutputDescription()
            => GetString("OutputDescription");

        /// <summary>
        /// Prefix console output with logging level.
        /// </summary>
        internal static string PrefixDescription
        {
            get => GetString("PrefixDescription");
        }

        /// <summary>
        /// Prefix console output with logging level.
        /// </summary>
        internal static string FormatPrefixDescription()
            => GetString("PrefixDescription");

        /// <summary>
        /// Show verbose output.
        /// </summary>
        internal static string VerboseDescription
        {
            get => GetString("VerboseDescription");
        }

        /// <summary>
        /// Show verbose output.
        /// </summary>
        internal static string FormatVerboseDescription()
            => GetString("VerboseDescription");

        /// <summary>
        /// Location from which inside man was copied (in the .NET Framework case) or loaded.
        /// </summary>
        internal static string ToolsDirectoryDescription
        {
            get => GetString("ToolsDirectoryDescription");
        }

        /// <summary>
        /// Location from which inside man was copied (in the .NET Framework case) or loaded.
        /// </summary>
        internal static string FormatToolsDirectoryDescription()
            => GetString("ToolsDirectoryDescription");

        /// <summary>
        /// The name of the method to invoke on the '--service' instance. Default value '{0}'.
        /// </summary>
        internal static string MethodDescription
        {
            get => GetString("MethodDescription");
        }

        /// <summary>
        /// The name of the method to invoke on the '--service' instance. Default value '{0}'.
        /// </summary>
        internal static string FormatMethodDescription(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("MethodDescription"), p0);

        /// <summary>
        /// The qualified name of the service type to retrieve from dependency injection. Default value '{0}'.
        /// </summary>
        internal static string ServiceDescription
        {
            get => GetString("ServiceDescription");
        }

        /// <summary>
        /// The qualified name of the service type to retrieve from dependency injection. Default value '{0}'.
        /// </summary>
        internal static string FormatServiceDescription(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ServiceDescription"), p0);

        /// <summary>
        /// The name of the document to pass to the '--method' method. Default value '{0}'.
        /// </summary>
        internal static string DocumentDescription
        {
            get => GetString("DocumentDescription");
        }

        /// <summary>
        /// The name of the document to pass to the '--method' method. Default value '{0}'.
        /// </summary>
        internal static string FormatDocumentDescription(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DocumentDescription"), p0);

        /// <summary>
        /// Using document name '{0}'.
        /// </summary>
        internal static string UsingDocument
        {
            get => GetString("UsingDocument");
        }

        /// <summary>
        /// Using document name '{0}'.
        /// </summary>
        internal static string FormatUsingDocument(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("UsingDocument"), p0);

        /// <summary>
        /// Using method '{0}'.
        /// </summary>
        internal static string UsingMethod
        {
            get => GetString("UsingMethod");
        }

        /// <summary>
        /// Using method '{0}'.
        /// </summary>
        internal static string FormatUsingMethod(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("UsingMethod"), p0);

        /// <summary>
        /// Using service '{0}'.
        /// </summary>
        internal static string UsingService
        {
            get => GetString("UsingService");
        }

        /// <summary>
        /// Using service '{0}'.
        /// </summary>
        internal static string FormatUsingService(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("UsingService"), p0);

        /// <summary>
        /// Method '{0}' of service '{1}' failed to generate document '{2}'.
        /// </summary>
        internal static string MethodInvocationFailed
        {
            get => GetString("MethodInvocationFailed");
        }

        /// <summary>
        /// Method '{0}' of service '{1}' failed to generate document '{2}'.
        /// </summary>
        internal static string FormatMethodInvocationFailed(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("MethodInvocationFailed"), p0, p1, p2);

        /// <summary>
        /// Assembly '{0}' does not contain an entry point.
        /// </summary>
        internal static string MissingEntryPoint
        {
            get => GetString("MissingEntryPoint");
        }

        /// <summary>
        /// Assembly '{0}' does not contain an entry point.
        /// </summary>
        internal static string FormatMissingEntryPoint(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("MissingEntryPoint"), p0);

        /// <summary>
        /// Unable to find service type '{0}' in loaded assemblies.
        /// </summary>
        internal static string ServiceTypeNotFound
        {
            get => GetString("ServiceTypeNotFound");
        }

        /// <summary>
        /// Unable to find service type '{0}' in loaded assemblies.
        /// </summary>
        internal static string FormatServiceTypeNotFound(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ServiceTypeNotFound"), p0);

        /// <summary>
        /// Unable to find method named '{0}' in '{1}' implementation.
        /// </summary>
        internal static string MethodNotFound
        {
            get => GetString("MethodNotFound");
        }

        /// <summary>
        /// Unable to find method named '{0}' in '{1}' implementation.
        /// </summary>
        internal static string FormatMethodNotFound(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("MethodNotFound"), p0, p1);

        /// <summary>
        /// Unable to find service of type '{0}' in dependency injection container.
        /// </summary>
        internal static string ServiceNotFound
        {
            get => GetString("ServiceNotFound");
        }

        /// <summary>
        /// Unable to find service of type '{0}' in dependency injection container.
        /// </summary>
        internal static string FormatServiceNotFound(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ServiceNotFound"), p0);

        /// <summary>
        /// Method '{0}' of service '{1}' returned null. Must return a non-null '{2}'.
        /// </summary>
        internal static string MethodReturnedNull
        {
            get => GetString("MethodReturnedNull");
        }

        /// <summary>
        /// Method '{0}' of service '{1}' returned null. Must return a non-null '{2}'.
        /// </summary>
        internal static string FormatMethodReturnedNull(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("MethodReturnedNull"), p0, p1, p2);

        /// <summary>
        /// Method '{0}' of service '{1}' has unsupported return type '{2}'. Must return a '{3}'.
        /// </summary>
        internal static string MethodReturnTypeUnsupported
        {
            get => GetString("MethodReturnTypeUnsupported");
        }

        /// <summary>
        /// Method '{0}' of service '{1}' has unsupported return type '{2}'. Must return a '{3}'.
        /// </summary>
        internal static string FormatMethodReturnTypeUnsupported(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("MethodReturnTypeUnsupported"), p0, p1, p2, p3);

        /// <summary>
        /// Method '{0}' of service '{1}' timed out. Must complete execution within {2} minute.
        /// </summary>
        internal static string MethodTimedOut
        {
            get => GetString("MethodTimedOut");
        }

        /// <summary>
        /// Method '{0}' of service '{1}' timed out. Must complete execution within {2} minute.
        /// </summary>
        internal static string FormatMethodTimedOut(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("MethodTimedOut"), p0, p1, p2);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
