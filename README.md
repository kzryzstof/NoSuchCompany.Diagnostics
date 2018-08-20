# NoSuchCompany.Diagnostics.Guards #

![Build status](https://nosuchcompany.visualstudio.com/NoSuchCompany.Diagnostics/_apis/build/status/NoSuchCompany.Diagnostics-master?branch=master)

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

3. Or use the Fluent approach:

```csharp
using NoSuchCompany.Diagnostics.Guards;

namespace Application
{
    public class SomeClass
    {
        public SomeClass(string name, Datetime timestampUtc, Socket someSocket)
        {
            name.ThrowIfIsEmpty(nameof(name));
            timestampUtc.ThrowIfIsNotUtc(nameof(timestampUtc));
            someSocket.ThrowIfIsNull(nameof(someSocket));
            
            //  ...            
        }
    }
}
```


# Features #

1. Reference types

First, the API provides with a way to prevent ```null``` instances from creeping up your application. For example:

```
public void DoSomething(SomeReferenceType inst)
{
    Argument.ThrowIfIsNull(inst, nameof(inst));   // Stop if inst is bs.
}
```

2. Guid

We often use Guid as identifiers of entities. We always expect them to represent some entity somewhere in the system. Knowing that we create new entity and assign them a ```Guid.NewGuid()```, empty Guids are not expected and may be a sign of some bug. Hence the following check:

```
public void DoSomething(Guid entityId)
{
    Argument.ThrowIfIsEmpty(entityId, nameof(entityId));   // Stop if entityId is some bs instance.
}
```

3. DateTime

A lot of our applications are used by customers across several time zones. As such, our backend does not manipulate ```DateTime``` instances that are specified in the local time zone, but only with those specified in the UTC time zone. We let the front-end deal with the time zone. To avoid tricky bugs, we have the following check whenever needed:


```
public void DoSomething(DateTime timestampUtc)
{
    Argument.ThrowIfIsNotLocal(timestampUtc, nameof(timestampUtc));   // Stop if timestampUtc is not a DateTime expressed in the UTC time zone.
}
```

The opposite can also be checked:

```
public void DoSomething(DateTime timestampLocal)
{
    Argument.ThrowIfIsNotUtc(timestampLocal nameof(timestampLocl));   // Stop if timestampLocal is not a DateTime expressed in a local time zone.
}
```

4. Strings

In some cases, you may require string instances to have some value in it aside from an empty or white-spaced list of characters. Here is the check:

```
public void NotifyUser(string someImportantMsg)
{
    Argument.ThrowIfIsNullOrWhiteSpace(someImportantMsg nameof(someImportantMsg));   // Stop if we are not notifying anything to the user.
}
```
