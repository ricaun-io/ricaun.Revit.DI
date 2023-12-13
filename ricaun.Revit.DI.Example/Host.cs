namespace ricaun.Revit.DI.Example
{
    using ricaun.DI;

    public static class Host
    {
        public static IContainer Container { get; } = ContainerUtils.CreateContainer();
        public static IContainerResolver ContainerResolver => Container;
        public static T Resolve<T>() where T : class => ContainerResolver.Resolve<T>();
        public static T ResolveOrNull<T>() where T : class => ContainerResolver.ResolveOrNull<T>();
    }

    public interface IHost { }
    public static class HostExtension
    {
        public static IContainer GetContainer(this IHost _) => Host.Container;
        public static IContainerResolver GetContainerResolver(this IHost _) => Host.ContainerResolver;
        public static T Resolve<T>(this IHost _) where T : class => Host.Resolve<T>();
        public static T ResolveOrNull<T>(this IHost _) where T : class => Host.ResolveOrNull<T>();
    }
}
