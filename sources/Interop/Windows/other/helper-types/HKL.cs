// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HKL : IComparable, IComparable<HKL>, IEquatable<HKL>, IFormattable
    {
        public readonly nint Value;

        public HKL(nint value)
        {
            Value = value;
        }

        public static HKL INVALID_VALUE => new HKL(-1);

        public static HKL NULL => new HKL(0);

        public static bool operator ==(HKL left, HKL right) => left.Value == right.Value;

        public static bool operator !=(HKL left, HKL right) => left.Value != right.Value;

        public static bool operator <(HKL left, HKL right) => left.Value < right.Value;

        public static bool operator <=(HKL left, HKL right) => left.Value <= right.Value;

        public static bool operator >(HKL left, HKL right) => left.Value > right.Value;

        public static bool operator >=(HKL left, HKL right) => left.Value >= right.Value;

        public static explicit operator HKL(void* value) => new HKL((nint)(value));

        public static implicit operator void*(HKL value) => (void*)(value.Value);

        public static explicit operator HKL(HANDLE value) => new HKL(value);

        public static implicit operator HANDLE(HKL value) => new HANDLE(value.Value);

        public static explicit operator HKL(byte value) => new HKL((nint)(value));

        public static explicit operator byte(HKL value) => (byte)(value.Value);

        public static explicit operator HKL(short value) => new HKL((nint)(value));

        public static explicit operator short(HKL value) => (short)(value.Value);

        public static explicit operator HKL(int value) => new HKL((nint)(value));

        public static explicit operator int(HKL value) => (int)(value.Value);

        public static explicit operator HKL(long value) => new HKL((nint)(value));

        public static implicit operator long(HKL value) => (long)(value.Value);

        public static explicit operator HKL(nint value) => new HKL((nint)(value));

        public static implicit operator nint(HKL value) => (nint)(value.Value);

        public static explicit operator HKL(sbyte value) => new HKL((nint)(value));

        public static explicit operator sbyte(HKL value) => (sbyte)(value.Value);

        public static explicit operator HKL(ushort value) => new HKL((nint)(value));

        public static explicit operator ushort(HKL value) => (ushort)(value.Value);

        public static explicit operator HKL(uint value) => new HKL((nint)(value));

        public static explicit operator uint(HKL value) => (uint)(value.Value);

        public static explicit operator HKL(ulong value) => new HKL((nint)(value));

        public static explicit operator ulong(HKL value) => (ulong)(value.Value);

        public static explicit operator HKL(nuint value) => new HKL((nint)(value));

        public static explicit operator nuint(HKL value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HKL other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HKL.");
        }

        public int CompareTo(HKL other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HKL other) && Equals(other);

        public bool Equals(HKL other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
