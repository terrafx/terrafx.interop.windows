// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HTTP_PUSH_WAIT_HANDLE : IComparable, IComparable<HTTP_PUSH_WAIT_HANDLE>, IEquatable<HTTP_PUSH_WAIT_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public HTTP_PUSH_WAIT_HANDLE(void* value)
        {
            Value = value;
        }

        public static HTTP_PUSH_WAIT_HANDLE INVALID_VALUE => new HTTP_PUSH_WAIT_HANDLE((void*)(-1));

        public static HTTP_PUSH_WAIT_HANDLE NULL => new HTTP_PUSH_WAIT_HANDLE(null);

        public static bool operator ==(HTTP_PUSH_WAIT_HANDLE left, HTTP_PUSH_WAIT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(HTTP_PUSH_WAIT_HANDLE left, HTTP_PUSH_WAIT_HANDLE right) => left.Value != right.Value;

        public static bool operator <(HTTP_PUSH_WAIT_HANDLE left, HTTP_PUSH_WAIT_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(HTTP_PUSH_WAIT_HANDLE left, HTTP_PUSH_WAIT_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(HTTP_PUSH_WAIT_HANDLE left, HTTP_PUSH_WAIT_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(HTTP_PUSH_WAIT_HANDLE left, HTTP_PUSH_WAIT_HANDLE right) => left.Value >= right.Value;

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(void* value) => new HTTP_PUSH_WAIT_HANDLE(value);

        public static implicit operator void*(HTTP_PUSH_WAIT_HANDLE value) => value.Value;

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(HANDLE value) => new HTTP_PUSH_WAIT_HANDLE(value);

        public static implicit operator HANDLE(HTTP_PUSH_WAIT_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(byte value) => new HTTP_PUSH_WAIT_HANDLE((void*)(value));

        public static explicit operator byte(HTTP_PUSH_WAIT_HANDLE value) => (byte)(value.Value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(short value) => new HTTP_PUSH_WAIT_HANDLE((void*)(value));

        public static explicit operator short(HTTP_PUSH_WAIT_HANDLE value) => (short)(value.Value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(int value) => new HTTP_PUSH_WAIT_HANDLE((void*)(value));

        public static explicit operator int(HTTP_PUSH_WAIT_HANDLE value) => (int)(value.Value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(long value) => new HTTP_PUSH_WAIT_HANDLE((void*)(value));

        public static explicit operator long(HTTP_PUSH_WAIT_HANDLE value) => (long)(value.Value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(nint value) => new HTTP_PUSH_WAIT_HANDLE((void*)(value));

        public static implicit operator nint(HTTP_PUSH_WAIT_HANDLE value) => (nint)(value.Value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(sbyte value) => new HTTP_PUSH_WAIT_HANDLE((void*)(value));

        public static explicit operator sbyte(HTTP_PUSH_WAIT_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(ushort value) => new HTTP_PUSH_WAIT_HANDLE((void*)(value));

        public static explicit operator ushort(HTTP_PUSH_WAIT_HANDLE value) => (ushort)(value.Value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(uint value) => new HTTP_PUSH_WAIT_HANDLE((void*)(value));

        public static explicit operator uint(HTTP_PUSH_WAIT_HANDLE value) => (uint)(value.Value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(ulong value) => new HTTP_PUSH_WAIT_HANDLE((void*)(value));

        public static explicit operator ulong(HTTP_PUSH_WAIT_HANDLE value) => (ulong)(value.Value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(nuint value) => new HTTP_PUSH_WAIT_HANDLE((void*)(value));

        public static implicit operator nuint(HTTP_PUSH_WAIT_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HTTP_PUSH_WAIT_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HTTP_PUSH_WAIT_HANDLE.");
        }

        public int CompareTo(HTTP_PUSH_WAIT_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HTTP_PUSH_WAIT_HANDLE other) && Equals(other);

        public bool Equals(HTTP_PUSH_WAIT_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
