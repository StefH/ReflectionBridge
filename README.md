# ReflectionBridge

[![Build status](https://ci.appveyor.com/api/projects/status/xe3rcxeyyvfr9kwc?svg=true)](https://ci.appveyor.com/project/StefH/ReflectionBridge)

[![NuGet Badge](https://buildstats.info/nuget/ReflectionBridge)](https://www.nuget.org/packages/ReflectionBridge)

Provides some extensions which define a bridge for the differences between Type and TypeInfo.

This library can be used for the following Frameworks:
- net2.0
- net3.5
- net4.0
- net4.5
- net4.5.x
- net4.6
- net4.6.1
- netcore4.5 Windows Store apps
- netcore4.5.1 Windows Store apps (Windows 8.1)
- netcore5.0 Windows Universal
- dnx451
- dnxcore5
- uap10.0
- sl5 (SilverLight 5.0)
- netstandard1.3 and up


So instead of doing this in your code:
```c#
string s = "example";
#if (!(NET40 || NET35 || NET20))
Type t = s.BaseType;
#else
Type t = s.GetTypeInfo().BaseType;
#endif
```

You can just do:
```c#
string s = "example";
Type t = s.BaseType();
```

An extension method in this project like this does the if-def:
```c#
        public static Type BaseType(this Type type)
        {
#if REFLECTIONBRIDGE && (!(NET40 || NET35 || NET20))
            return type.GetTypeInfo().BaseType;
#else
            return type.BaseType;
#endif
        }
```

Please provide feedback on this project.