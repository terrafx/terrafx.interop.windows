// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CO_DEVICE_CATALOG_COOKIE : IEquatable<CO_DEVICE_CATALOG_COOKIE>
    {
        public readonly nint Value;

        public CO_DEVICE_CATALOG_COOKIE(nint value)
        {
            Value = value;
        }

        public static CO_DEVICE_CATALOG_COOKIE INVALID_HANDLE_VALUE => new CO_DEVICE_CATALOG_COOKIE(-1);

        public static CO_DEVICE_CATALOG_COOKIE NULL => new CO_DEVICE_CATALOG_COOKIE(0);

        public static bool operator ==(CO_DEVICE_CATALOG_COOKIE left, CO_DEVICE_CATALOG_COOKIE right) => left.Value == right.Value;

        public static bool operator !=(CO_DEVICE_CATALOG_COOKIE left, CO_DEVICE_CATALOG_COOKIE right) => left.Value != right.Value;

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(void* value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static implicit operator void*(CO_DEVICE_CATALOG_COOKIE value) => (void*)(value.Value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(HANDLE value) => new CO_DEVICE_CATALOG_COOKIE(value);

        public static implicit operator HANDLE(CO_DEVICE_CATALOG_COOKIE value) => new CO_DEVICE_CATALOG_COOKIE(value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(byte value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static explicit operator byte(CO_DEVICE_CATALOG_COOKIE value) => (byte)(value.Value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(short value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static explicit operator short(CO_DEVICE_CATALOG_COOKIE value) => (short)(value.Value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(int value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static explicit operator int(CO_DEVICE_CATALOG_COOKIE value) => (int)(value.Value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(long value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static implicit operator long(CO_DEVICE_CATALOG_COOKIE value) => (long)(value.Value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(nint value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static implicit operator nint(CO_DEVICE_CATALOG_COOKIE value) => (nint)(value.Value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(sbyte value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static explicit operator sbyte(CO_DEVICE_CATALOG_COOKIE value) => (sbyte)(value.Value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(ushort value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static explicit operator ushort(CO_DEVICE_CATALOG_COOKIE value) => (ushort)(value.Value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(uint value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static explicit operator uint(CO_DEVICE_CATALOG_COOKIE value) => (uint)(value.Value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(ulong value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static implicit operator ulong(CO_DEVICE_CATALOG_COOKIE value) => (ulong)(value.Value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(nuint value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static explicit operator nuint(CO_DEVICE_CATALOG_COOKIE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is CO_DEVICE_CATALOG_COOKIE other) && Equals(other);

        public bool Equals(CO_DEVICE_CATALOG_COOKIE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
