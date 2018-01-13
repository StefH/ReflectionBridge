using System;
using System.Reflection;
using ReflectionBridge.Extensions;

// ReSharper disable once CheckNamespace
namespace ClassLibrary
{
    public class Class1
    {
        // ReflectionBridge.Extensions
        public Assembly GetAssembly = typeof(Class1).GetAssembly();
        public bool IsSealed = typeof(Class1).IsSealed();
        public bool IsAbstract = typeof(Class1).IsAbstract();
        public bool IsEnum = typeof(Class1).IsEnum();
        public bool IsClass = typeof(Class1).IsClass();
        public bool IsPrimitive = typeof(Class1).IsPrimitive();
        public bool IsPublic = typeof(Class1).IsPublic();
        public bool IsNestedPublic = typeof(Class1).IsNestedPublic();
        public bool IsFromLocalAssembly = typeof(Class1).IsFromLocalAssembly();
        public bool IsGenericType = typeof(Class1).IsGenericType();
        public bool IsInterface = typeof(Class1).IsInterface();
        public Type BaseType = typeof(Class1).BaseType();
        public int GetFieldValue = typeof(Class1).GetFieldValue<int>("x", "");
        public int GetPropertyValue = typeof(Class1).GetPropertyValue<int>("x", "");

        // default supported
        public bool IsInstanceOfType = typeof(Class1).IsInstanceOfType("");
        public object GetProperty = typeof(Class1).GetProperty("");

        public Class1()
        {
            // ReflectionBridge.Extensions
            typeof(Class1).SetPropertyValue("x", this, 8);
            typeof(Class1).SetFieldValue("x", this, 8);
            typeof(Class1).InvokeMethod("x", this, 8);
        }
    }
}