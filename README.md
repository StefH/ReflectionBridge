# ReflectionBridge
ReflectionBridge

Provides some extensions which define a bridge for the differences between Type and TypeInfo.

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
