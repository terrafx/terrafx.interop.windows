// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCONV : IComparable, IComparable<HCONV>, IEquatable<HCONV>, IFormattable
    {
        public readonly nint Value;

        public HCONV(nint value)
        {
            Value = value;
        }

        public static HCONV INVALID_VALUE => new HCONV(-1);

        public static HCONV NULL => new HCONV(0);

        public static bool operator ==(HCONV left, HCONV right) => left.Value == right.Value;

        public static bool operator !=(HCONV left, HCONV right) => left.Value != right.Value;

        public static bool operator <(HCONV left, HCONV right) => left.Value < right.Value;

        public static bool operator <=(HCONV left, HCONV right) => left.Value <= right.Value;

        public static bool operator >(HCONV left, HCONV right) => left.Value > right.Value;

        public static bool operator >=(HCONV left, HCONV right) => left.Value >= right.Value;

        public static explicit operator HCONV(void* value) => new HCONV((nint)(value));

        public static implicit operator void*(HCONV value) => (void*)(value.Value);

        public static explicit operator HCONV(HANDLE value) => new HCONV(value);

        public static implicit operator HANDLE(HCONV value) => new HANDLE(value.Value);

        public static explicit operator HCONV(byte value) => new HCONV((nint)(value));

        public static explicit operator byte(HCONV value) => (byte)(value.Value);

        public static explicit operator HCONV(short value) => new HCONV((nint)(value));

        public static explicit operator short(HCONV value) => (short)(value.Value);

        public static explicit operator HCONV(int value) => new HCONV((nint)(value));

        public static explicit operator int(HCONV value) => (int)(value.Value);

        public static explicit operator HCONV(long value) => new HCONV((nint)(value));

        public static implicit operator long(HCONV value) => value.Value;

        public static explicit operator HCONV(nint value) => new HCONV((nint)(value));

        public static implicit operator nint(HCONV value) => value.Value;

        public static explicit operator HCONV(sbyte value) => new HCONV((nint)(value));

        public static explicit operator sbyte(HCONV value) => (sbyte)(value.Value);

        public static explicit operator HCONV(ushort value) => new HCONV((nint)(value));

        public static explicit operator ushort(HCONV value) => (ushort)(value.Value);

        public static explicit operator HCONV(uint value) => new HCONV((nint)(value));

        public static explicit operator uint(HCONV value) => (uint)(value.Value);

        public static explicit operator HCONV(ulong value) => new HCONV((nint)(value));

        public static explicit operator ulong(HCONV value) => (ulong)(value.Value);

        public static explicit operator HCONV(nuint value) => new HCONV((nint)(value));

        public static explicit operator nuint(HCONV value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCONV other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCONV.");
        }

        public int CompareTo(HCONV other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HCONV other) && Equals(other);

        public bool Equals(HCONV other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
