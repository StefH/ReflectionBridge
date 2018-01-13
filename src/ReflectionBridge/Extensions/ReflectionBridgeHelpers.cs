using System;
using System.Reflection;
#if REFLECTIONBRIDGE
using System.Collections.Generic;
using System.Linq;
#endif

namespace ReflectionBridge.Extensions
{
    public static class ReflectionBridgeHelper
    {
        public static bool IsNullableEnum(this Type type)
        {
            return type.IsGenericType() && type.GetGenericTypeDefinition() == typeof(Nullable<>) && type.GetGenericArguments()[0].IsEnum();
        }

        public static Type UnwrapNullable(this Type type)
        {
            if (!type.IsGenericType())
            {
                return type;
            }

            if (type.GetGenericTypeDefinition() != typeof(Nullable<>))
            {
                return type;
            }

            return type.GetGenericArguments()[0];
        }
    }
}