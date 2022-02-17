# Remnant Dependency Simple Injector
Simple injector dependency injection adapter


## Nuget package:

        Install-Package Remnant.Dependency.SimpleInjector -Version 1.0.0
        
```csharp
var simpleInjector = new global::SimpleInjector.Container();
var container = Container.Create("MyContainer", new SimpleInjectorAdapter(simpleInjector));
```
