// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WEB_SOCKET_HANDLE : IComparable, IComparable<WEB_SOCKET_HANDLE>, IEquatable<WEB_SOCKET_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public WEB_SOCKET_HANDLE(void* value)
        {
            Value = value;
        }

        public static WEB_SOCKET_HANDLE INVALID_VALUE => new WEB_SOCKET_HANDLE((void*)(-1));

        public static WEB_SOCKET_HANDLE NULL => new WEB_SOCKET_HANDLE(null);

        public static bool operator ==(WEB_SOCKET_HANDLE left, WEB_SOCKET_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(WEB_SOCKET_HANDLE left, WEB_SOCKET_HANDLE right) => left.Value != right.Value;

        public static bool operator <(WEB_SOCKET_HANDLE left, WEB_SOCKET_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(WEB_SOCKET_HANDLE left, WEB_SOCKET_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(WEB_SOCKET_HANDLE left, WEB_SOCKET_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(WEB_SOCKET_HANDLE left, WEB_SOCKET_HANDLE right) => left.Value >= right.Value;

        public static explicit operator WEB_SOCKET_HANDLE(void* value) => new WEB_SOCKET_HANDLE(value);

        public static implicit operator void*(WEB_SOCKET_HANDLE value) => value.Value;

        public static explicit operator WEB_SOCKET_HANDLE(HANDLE value) => new WEB_SOCKET_HANDLE(value);

        public static implicit operator HANDLE(WEB_SOCKET_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(byte value) => new WEB_SOCKET_HANDLE((void*)(value));

        public static explicit operator byte(WEB_SOCKET_HANDLE value) => (byte)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(short value) => new WEB_SOCKET_HANDLE((void*)(value));

        public static explicit operator short(WEB_SOCKET_HANDLE value) => (short)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(int value) => new WEB_SOCKET_HANDLE((void*)(value));

        public static explicit operator int(WEB_SOCKET_HANDLE value) => (int)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(long value) => new WEB_SOCKET_HANDLE((void*)(value));

        public static explicit operator long(WEB_SOCKET_HANDLE value) => (long)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(nint value) => new WEB_SOCKET_HANDLE((void*)(value));

        public static implicit operator nint(WEB_SOCKET_HANDLE value) => (nint)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(sbyte value) => new WEB_SOCKET_HANDLE((void*)(value));

        public static explicit operator sbyte(WEB_SOCKET_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(ushort value) => new WEB_SOCKET_HANDLE((void*)(value));

        public static explicit operator ushort(WEB_SOCKET_HANDLE value) => (ushort)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(uint value) => new WEB_SOCKET_HANDLE((void*)(value));

        public static explicit operator uint(WEB_SOCKET_HANDLE value) => (uint)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(ulong value) => new WEB_SOCKET_HANDLE((void*)(value));

        public static explicit operator ulong(WEB_SOCKET_HANDLE value) => (ulong)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(nuint value) => new WEB_SOCKET_HANDLE((void*)(value));

        public static implicit operator nuint(WEB_SOCKET_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is WEB_SOCKET_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of WEB_SOCKET_HANDLE.");
        }

        public int CompareTo(WEB_SOCKET_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is WEB_SOCKET_HANDLE other) && Equals(other);

        public bool Equals(WEB_SOCKET_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
