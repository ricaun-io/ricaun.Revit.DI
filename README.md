# ricaun.Revit.DI

[![Revit 2017](https://img.shields.io/badge/Revit-2017+-blue.svg)](https://github.com/ricaun-io/ricaun.Revit.DI)
[![Visual Studio 2022](https://img.shields.io/badge/Visual%20Studio-2022-blue)](https://github.com/ricaun-io/ricaun.Revit.DI)
[![Nuke](https://img.shields.io/badge/Nuke-Build-blue)](https://nuke.build/)
[![License MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Build](https://github.com/ricaun-io/ricaun.Revit.DI/actions/workflows/Build.yml/badge.svg)](https://github.com/ricaun-io/ricaun.Revit.DI/actions)

Dependency injection container extension for Revit add-ins.

This project was generated by the [ricaun.AppLoader](https://ricaun.com/AppLoader/) Revit plugin.

## ricaun.DI

This package uses the [ricaun.DI] package to provide the base implementation dependency injection container.

## ricaun.Revit.DI

### AddRevitSingleton

Add Revit UI singleton `UIApplication`,`UIControlledApplication`,`Application`, and `ControlledApplication` to the container.
```C#
UIApplication uiapp;
container.AddRevitSingleton(uiapp);
```
or
```C#
UIControlledApplication application;
container.AddRevitSingleton(application);
```

Add Revit DB singleton `Application`, and `ControlledApplication` to the container.
```C#
Application application;
container.AddRevitSingleton(application);
```
or
```C#
ControlledApplication application;
container.AddRevitSingleton(application);
```


## ricaun.Revit.DI.Example

The project [ricaun.Revit.DI.Example](ricaun.Revit.DI.Example) provide an example of how to use the [ricaun.Revit.DI](https://github.com/ricaun-io/ricaun.Revit.DI) package.

## Release

* [Latest release](https://github.com/ricaun-io/ricaun.Revit.DI/releases/latest)

## License

This project is [licensed](LICENSE) under the [MIT Licence](https://en.wikipedia.org/wiki/MIT_License).

---

Do you like this project? Please [star this project on GitHub](https://github.com/ricaun-io/ricaun.Revit.DI/stargazers)!