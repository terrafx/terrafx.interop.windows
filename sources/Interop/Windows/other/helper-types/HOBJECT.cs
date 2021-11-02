// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HOBJECT : IComparable, IComparable<HOBJECT>, IEquatable<HOBJECT>, IFormattable
    {
        public readonly nint Value;

        public HOBJECT(nint value)
        {
            Value = value;
        }

        public static HOBJECT INVALID_VALUE => new HOBJECT(-1);

        public static HOBJECT NULL => new HOBJECT(0);

        public static bool operator ==(HOBJECT left, HOBJECT right) => left.Value == right.Value;

        public static bool operator !=(HOBJECT left, HOBJECT right) => left.Value != right.Value;

        public static bool operator <(HOBJECT left, HOBJECT right) => left.Value < right.Value;

        public static bool operator <=(HOBJECT left, HOBJECT right) => left.Value <= right.Value;

        public static bool operator >(HOBJECT left, HOBJECT right) => left.Value > right.Value;

        public static bool operator >=(HOBJECT left, HOBJECT right) => left.Value >= right.Value;

        public static explicit operator HOBJECT(void* value) => new HOBJECT((nint)(value));

        public static implicit operator void*(HOBJECT value) => (void*)(value.Value);

        public static explicit operator HOBJECT(HANDLE value) => new HOBJECT(value);

        public static implicit operator HANDLE(HOBJECT value) => new HANDLE(value.Value);

        public static explicit operator HOBJECT(byte value) => new HOBJECT((nint)(value));

        public static explicit operator byte(HOBJECT value) => (byte)(value.Value);

        public static explicit operator HOBJECT(short value) => new HOBJECT((nint)(value));

        public static explicit operator short(HOBJECT value) => (short)(value.Value);

        public static explicit operator HOBJECT(int value) => new HOBJECT((nint)(value));

        public static explicit operator int(HOBJECT value) => (int)(value.Value);

        public static explicit operator HOBJECT(long value) => new HOBJECT((nint)(value));

        public static implicit operator long(HOBJECT value) => value.Value;

        public static explicit operator HOBJECT(nint value) => new HOBJECT((nint)(value));

        public static implicit operator nint(HOBJECT value) => value.Value;

        public static explicit operator HOBJECT(sbyte value) => new HOBJECT((nint)(value));

        public static explicit operator sbyte(HOBJECT value) => (sbyte)(value.Value);

        public static explicit operator HOBJECT(ushort value) => new HOBJECT((nint)(value));

        public static explicit operator ushort(HOBJECT value) => (ushort)(value.Value);

        public static explicit operator HOBJECT(uint value) => new HOBJECT((nint)(value));

        public static explicit operator uint(HOBJECT value) => (uint)(value.Value);

        public static explicit operator HOBJECT(ulong value) => new HOBJECT((nint)(value));

        public static explicit operator ulong(HOBJECT value) => (ulong)(value.Value);

        public static explicit operator HOBJECT(nuint value) => new HOBJECT((nint)(value));

        public static explicit operator nuint(HOBJECT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HOBJECT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HOBJECT.");
        }

        public int CompareTo(HOBJECT other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HOBJECT other) && Equals(other);

        public bool Equals(HOBJECT other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
