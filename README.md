# Remnant Dependency Simple Injector
Simple injector dependency injection adapter


## Nuget package:

        Install-Package Remnant.Dependency.SimpleInjector -Version 1.1.0

Create container for Simple Injector
```csharp
var simpleInjector = new global::SimpleInjector.Container();
var container = Container.Create("MyContainer", new SimpleInjectorAdapter(simpleInjector));
```


Get direct access to the internal DI container
```csharp
var simpleInjector = Container.Instance.InternalContainer<global::SimpleInjector.Container>();
```
