// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDC : IComparable, IComparable<HDC>, IEquatable<HDC>, IFormattable
    {
        public readonly nint Value;

        public HDC(nint value)
        {
            Value = value;
        }

        public static HDC INVALID_VALUE => new HDC(-1);

        public static HDC NULL => new HDC(0);

        public static bool operator ==(HDC left, HDC right) => left.Value == right.Value;

        public static bool operator !=(HDC left, HDC right) => left.Value != right.Value;

        public static bool operator <(HDC left, HDC right) => left.Value < right.Value;

        public static bool operator <=(HDC left, HDC right) => left.Value <= right.Value;

        public static bool operator >(HDC left, HDC right) => left.Value > right.Value;

        public static bool operator >=(HDC left, HDC right) => left.Value >= right.Value;

        public static explicit operator HDC(void* value) => new HDC((nint)(value));

        public static implicit operator void*(HDC value) => (void*)(value.Value);

        public static explicit operator HDC(HANDLE value) => new HDC(value);

        public static implicit operator HANDLE(HDC value) => new HANDLE(value.Value);

        public static explicit operator HDC(byte value) => new HDC((nint)(value));

        public static explicit operator byte(HDC value) => (byte)(value.Value);

        public static explicit operator HDC(short value) => new HDC((nint)(value));

        public static explicit operator short(HDC value) => (short)(value.Value);

        public static explicit operator HDC(int value) => new HDC((nint)(value));

        public static explicit operator int(HDC value) => (int)(value.Value);

        public static explicit operator HDC(long value) => new HDC((nint)(value));

        public static implicit operator long(HDC value) => value.Value;

        public static explicit operator HDC(nint value) => new HDC((nint)(value));

        public static implicit operator nint(HDC value) => value.Value;

        public static explicit operator HDC(sbyte value) => new HDC((nint)(value));

        public static explicit operator sbyte(HDC value) => (sbyte)(value.Value);

        public static explicit operator HDC(ushort value) => new HDC((nint)(value));

        public static explicit operator ushort(HDC value) => (ushort)(value.Value);

        public static explicit operator HDC(uint value) => new HDC((nint)(value));

        public static explicit operator uint(HDC value) => (uint)(value.Value);

        public static explicit operator HDC(ulong value) => new HDC((nint)(value));

        public static explicit operator ulong(HDC value) => (ulong)(value.Value);

        public static explicit operator HDC(nuint value) => new HDC((nint)(value));

        public static explicit operator nuint(HDC value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDC other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDC.");
        }

        public int CompareTo(HDC other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HDC other) && Equals(other);

        public bool Equals(HDC other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
