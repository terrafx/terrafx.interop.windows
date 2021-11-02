// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIC : IComparable, IComparable<HIC>, IEquatable<HIC>, IFormattable
    {
        public readonly nint Value;

        public HIC(nint value)
        {
            Value = value;
        }

        public static HIC INVALID_VALUE => new HIC(-1);

        public static HIC NULL => new HIC(0);

        public static bool operator ==(HIC left, HIC right) => left.Value == right.Value;

        public static bool operator !=(HIC left, HIC right) => left.Value != right.Value;

        public static bool operator <(HIC left, HIC right) => left.Value < right.Value;

        public static bool operator <=(HIC left, HIC right) => left.Value <= right.Value;

        public static bool operator >(HIC left, HIC right) => left.Value > right.Value;

        public static bool operator >=(HIC left, HIC right) => left.Value >= right.Value;

        public static explicit operator HIC(void* value) => new HIC((nint)(value));

        public static implicit operator void*(HIC value) => (void*)(value.Value);

        public static explicit operator HIC(HANDLE value) => new HIC(value);

        public static implicit operator HANDLE(HIC value) => new HANDLE(value.Value);

        public static explicit operator HIC(byte value) => new HIC((nint)(value));

        public static explicit operator byte(HIC value) => (byte)(value.Value);

        public static explicit operator HIC(short value) => new HIC((nint)(value));

        public static explicit operator short(HIC value) => (short)(value.Value);

        public static explicit operator HIC(int value) => new HIC((nint)(value));

        public static explicit operator int(HIC value) => (int)(value.Value);

        public static explicit operator HIC(long value) => new HIC((nint)(value));

        public static implicit operator long(HIC value) => value.Value;

        public static explicit operator HIC(nint value) => new HIC((nint)(value));

        public static implicit operator nint(HIC value) => value.Value;

        public static explicit operator HIC(sbyte value) => new HIC((nint)(value));

        public static explicit operator sbyte(HIC value) => (sbyte)(value.Value);

        public static explicit operator HIC(ushort value) => new HIC((nint)(value));

        public static explicit operator ushort(HIC value) => (ushort)(value.Value);

        public static explicit operator HIC(uint value) => new HIC((nint)(value));

        public static explicit operator uint(HIC value) => (uint)(value.Value);

        public static explicit operator HIC(ulong value) => new HIC((nint)(value));

        public static explicit operator ulong(HIC value) => (ulong)(value.Value);

        public static explicit operator HIC(nuint value) => new HIC((nint)(value));

        public static explicit operator nuint(HIC value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HIC other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HIC.");
        }

        public int CompareTo(HIC other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HIC other) && Equals(other);

        public bool Equals(HIC other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
