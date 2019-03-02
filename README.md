# String Split Documentation

Upon upgrading from Visual Studio 2015 to Visual Studio 2017, I had some unit tests fail.
The unit test project was targeting .NET Framework 4.52, and the project under test was targeting Xamarin Android 6.0.
The test failed with the following exception

```csharp
System.MissingMethodException: Method not found: 'System.String[] System.String.Split(Char, System.StringSplitOptions)'.
```

I starting browsing the [String.Split method documentation](https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=netframework-4.5.2).
I noticed `Split(char separator, StringSplitOptions options)` was not found in .NET Framework 4.5.2 or Xamarin Android.

However, I am able to use that overload when targeting Xamarin Android (even in Visual Studio 2017).
