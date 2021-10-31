// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CO_DEVICE_CATALOG_COOKIE : IEquatable<CO_DEVICE_CATALOG_COOKIE>
    {
        public readonly nint Value;

        public static CO_DEVICE_CATALOG_COOKIE NULL => (CO_DEVICE_CATALOG_COOKIE)(0);

        public CO_DEVICE_CATALOG_COOKIE(int value)
        {
            Value = ((nint)(value));
        }

        public CO_DEVICE_CATALOG_COOKIE(uint value)
        {
            Value = ((nint)(value));
        }

        public CO_DEVICE_CATALOG_COOKIE(nint value)
        {
            Value = ((nint)(value));
        }

        public CO_DEVICE_CATALOG_COOKIE(nuint value)
        {
            Value = ((nint)(value));
        }

        public CO_DEVICE_CATALOG_COOKIE(void* value)
        {
            Value = ((nint)(value));
        }

        public CO_DEVICE_CATALOG_COOKIE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(CO_DEVICE_CATALOG_COOKIE left, CO_DEVICE_CATALOG_COOKIE right) => left.Value == right.Value;

        public static bool operator !=(CO_DEVICE_CATALOG_COOKIE left, CO_DEVICE_CATALOG_COOKIE right) => left.Value != right.Value;

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(int value) => new CO_DEVICE_CATALOG_COOKIE(value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(uint value) => new CO_DEVICE_CATALOG_COOKIE(value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(nint value) => new CO_DEVICE_CATALOG_COOKIE(value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(nuint value) => new CO_DEVICE_CATALOG_COOKIE(value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(void* value) => new CO_DEVICE_CATALOG_COOKIE(value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(HANDLE value) => new CO_DEVICE_CATALOG_COOKIE(value);

        public static implicit operator int(CO_DEVICE_CATALOG_COOKIE value) => (int)(value.Value);

        public static implicit operator uint(CO_DEVICE_CATALOG_COOKIE value) => (uint)(value.Value);

        public static implicit operator nint(CO_DEVICE_CATALOG_COOKIE value) => (nint)(value.Value);

        public static implicit operator nuint(CO_DEVICE_CATALOG_COOKIE value) => (nuint)(value.Value);

        public static implicit operator void*(CO_DEVICE_CATALOG_COOKIE value) => (void*)(value.Value);

        public static implicit operator HANDLE(CO_DEVICE_CATALOG_COOKIE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is CO_DEVICE_CATALOG_COOKIE other) && Equals(other);

        public bool Equals(CO_DEVICE_CATALOG_COOKIE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
