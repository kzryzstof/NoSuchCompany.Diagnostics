# NoSuchCompany.Diagnostics.Guards #

The Diagnostics library provides simple and light classes that help checking incoming parameters of a method using the Fluent API or not, depending on what you prefer.

The library is provided as a .netstandard2.0 DLL so that it can be used in .NET Framework projects (4.6.1) as well as in .NET Core applications. The choice is yours.


# Getting Started #

1. Install the standard Nuget package into your application.

```
Package Manager : Install-Package NoSuchCompany.Diagnostics.Guards
CLI : dotnet add package NoSuchCompany.Diagnostics.Guards
```

2. Well.... use the methods of the `Argument` static class.

```csharp
using NoSuchCompany.Diagnostics.Guards;

namespace Application
{
    public class SomeClass
    {
        public SomeClass(string name, Datetime timestampUtc, Socket someSocket)
        {
            Argument.ThrowIfIsEmpty(name, nameof(name));
            Argument.ThrowIfIsNotUtc(timestampUtc, nameof(timestampUtc));
            Argument.ThrowIfIsNull(someSocket, nameof(someSocket));
            
            //  ...            
        }
    }
}
```

3. Or use the Fluent approach

```csharp
using NoSuchCompany.Diagnostics.Guards;

namespace Application
{
    public class SomeClass
    {
        public SomeClass(string name, Datetime timestampUtc, Socket someSocket)
        {
            name.ThrowIfIsEmpty(nameof(name));
            timestampUtcThrowIfIsNotUtc(nameof(timestampUtc));
            someSocket.ThrowIfIsNull(nameof(someSocket));
            
            //  ...            
        }
    }
}
```

