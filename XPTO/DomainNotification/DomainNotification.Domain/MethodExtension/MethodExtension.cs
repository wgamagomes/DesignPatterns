using System;

namespace DomainNotification.Domain.MethodExtension
{
    public static class MethodExtension
    {
        public static bool IsNotNullOrEmpty(this String value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static bool IsNotNullOrEmpty(this int value)
        {
            return value > default(int);
        }

        public static bool IsNotNullOrEmpty(this Decimal value)
        {
            return value > default(decimal);
        }
    }
}
