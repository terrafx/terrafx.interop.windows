// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBM : IComparable, IComparable<HBM>, IEquatable<HBM>, IFormattable
    {
        public readonly nint Value;

        public HBM(nint value)
        {
            Value = value;
        }

        public static HBM INVALID_VALUE => new HBM(-1);

        public static HBM NULL => new HBM(0);

        public static bool operator ==(HBM left, HBM right) => left.Value == right.Value;

        public static bool operator !=(HBM left, HBM right) => left.Value != right.Value;

        public static bool operator <(HBM left, HBM right) => left.Value < right.Value;

        public static bool operator <=(HBM left, HBM right) => left.Value <= right.Value;

        public static bool operator >(HBM left, HBM right) => left.Value > right.Value;

        public static bool operator >=(HBM left, HBM right) => left.Value >= right.Value;

        public static explicit operator HBM(void* value) => new HBM((nint)(value));

        public static implicit operator void*(HBM value) => (void*)(value.Value);

        public static explicit operator HBM(HANDLE value) => new HBM(value);

        public static implicit operator HANDLE(HBM value) => new HANDLE(value.Value);

        public static explicit operator HBM(byte value) => new HBM((nint)(value));

        public static explicit operator byte(HBM value) => (byte)(value.Value);

        public static explicit operator HBM(short value) => new HBM((nint)(value));

        public static explicit operator short(HBM value) => (short)(value.Value);

        public static explicit operator HBM(int value) => new HBM((nint)(value));

        public static explicit operator int(HBM value) => (int)(value.Value);

        public static explicit operator HBM(long value) => new HBM((nint)(value));

        public static implicit operator long(HBM value) => value.Value;

        public static explicit operator HBM(nint value) => new HBM((nint)(value));

        public static implicit operator nint(HBM value) => value.Value;

        public static explicit operator HBM(sbyte value) => new HBM((nint)(value));

        public static explicit operator sbyte(HBM value) => (sbyte)(value.Value);

        public static explicit operator HBM(ushort value) => new HBM((nint)(value));

        public static explicit operator ushort(HBM value) => (ushort)(value.Value);

        public static explicit operator HBM(uint value) => new HBM((nint)(value));

        public static explicit operator uint(HBM value) => (uint)(value.Value);

        public static explicit operator HBM(ulong value) => new HBM((nint)(value));

        public static explicit operator ulong(HBM value) => (ulong)(value.Value);

        public static explicit operator HBM(nuint value) => new HBM((nint)(value));

        public static explicit operator nuint(HBM value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HBM other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HBM.");
        }

        public int CompareTo(HBM other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HBM other) && Equals(other);

        public bool Equals(HBM other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
