# ricaun.Revit.DI.Example

This example project uses the [ricaun.DI](https://github.com/ricaun-io/ricaun.DI) and [ricaun.Revit.DI](https://github.com/ricaun-io/ricaun.Revit.DI) to create a dependency injection container to work with Revit API.

## How to use

### 1. Create a static class to hold the container
This project uses the [Host.cs](Host.cs) implementation to hold the container.

### 2. Initialize the container in the `OnStartup` method.
Add the Revit dependencies in the container using.
```C#
Host.Container.AddRevitSingleton(application);
```
If your `IExternalApplication` class have `IHost` you could add it to the container using.
```C#
var container = this.GetContainer();
container.AddRevitSingleton(application);
```

And you could add the dependencies of your project like.
```C#
container.AddScoped<IMessageService, MessageService>();
```

### 3. Dispose the container in the `OnShutdown` method.
On the `OnShutdown` method you could dispose the container using.
```C#
Host.Container.Dispose();
```
or
```C#
this.GetContainer().Dispose();
```

### 4. Use the container to resolve the dependencies.
To resolve the dependencies you could use the `Host.Container` to resolve the dependencies.
```C#
var messageService = Host.Container.Resolve<IMessageService>();
```
or if your class have `IHost` you could use the `Resolve` method to resolve the dependencies.
```C#
var messageService = this.Resolve<IMessageService>();
```

The [Command.cs](Revit/Commands/Command.cs) has a example of how to use the container to resolve a custom `ICommand` in the `Command<T>`.

---

Do you like this project? Please [star this project on GitHub](https://github.com/ricaun-io/ricaun.Revit.DI/stargazers)!