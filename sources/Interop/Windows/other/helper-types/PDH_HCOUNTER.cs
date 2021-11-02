// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PDH_HCOUNTER : IComparable, IComparable<PDH_HCOUNTER>, IEquatable<PDH_HCOUNTER>, IFormattable
    {
        public readonly nint Value;

        public PDH_HCOUNTER(nint value)
        {
            Value = value;
        }

        public static PDH_HCOUNTER INVALID_VALUE => new PDH_HCOUNTER(-1);

        public static PDH_HCOUNTER NULL => new PDH_HCOUNTER(0);

        public static bool operator ==(PDH_HCOUNTER left, PDH_HCOUNTER right) => left.Value == right.Value;

        public static bool operator !=(PDH_HCOUNTER left, PDH_HCOUNTER right) => left.Value != right.Value;

        public static bool operator <(PDH_HCOUNTER left, PDH_HCOUNTER right) => left.Value < right.Value;

        public static bool operator <=(PDH_HCOUNTER left, PDH_HCOUNTER right) => left.Value <= right.Value;

        public static bool operator >(PDH_HCOUNTER left, PDH_HCOUNTER right) => left.Value > right.Value;

        public static bool operator >=(PDH_HCOUNTER left, PDH_HCOUNTER right) => left.Value >= right.Value;

        public static explicit operator PDH_HCOUNTER(void* value) => new PDH_HCOUNTER((nint)(value));

        public static implicit operator void*(PDH_HCOUNTER value) => (void*)(value.Value);

        public static explicit operator PDH_HCOUNTER(HANDLE value) => new PDH_HCOUNTER(value);

        public static implicit operator HANDLE(PDH_HCOUNTER value) => new HANDLE(value.Value);

        public static explicit operator PDH_HCOUNTER(byte value) => new PDH_HCOUNTER((nint)(value));

        public static explicit operator byte(PDH_HCOUNTER value) => (byte)(value.Value);

        public static explicit operator PDH_HCOUNTER(short value) => new PDH_HCOUNTER((nint)(value));

        public static explicit operator short(PDH_HCOUNTER value) => (short)(value.Value);

        public static explicit operator PDH_HCOUNTER(int value) => new PDH_HCOUNTER((nint)(value));

        public static explicit operator int(PDH_HCOUNTER value) => (int)(value.Value);

        public static explicit operator PDH_HCOUNTER(long value) => new PDH_HCOUNTER((nint)(value));

        public static implicit operator long(PDH_HCOUNTER value) => (long)(value.Value);

        public static explicit operator PDH_HCOUNTER(nint value) => new PDH_HCOUNTER((nint)(value));

        public static implicit operator nint(PDH_HCOUNTER value) => (nint)(value.Value);

        public static explicit operator PDH_HCOUNTER(sbyte value) => new PDH_HCOUNTER((nint)(value));

        public static explicit operator sbyte(PDH_HCOUNTER value) => (sbyte)(value.Value);

        public static explicit operator PDH_HCOUNTER(ushort value) => new PDH_HCOUNTER((nint)(value));

        public static explicit operator ushort(PDH_HCOUNTER value) => (ushort)(value.Value);

        public static explicit operator PDH_HCOUNTER(uint value) => new PDH_HCOUNTER((nint)(value));

        public static explicit operator uint(PDH_HCOUNTER value) => (uint)(value.Value);

        public static explicit operator PDH_HCOUNTER(ulong value) => new PDH_HCOUNTER((nint)(value));

        public static explicit operator ulong(PDH_HCOUNTER value) => (ulong)(value.Value);

        public static explicit operator PDH_HCOUNTER(nuint value) => new PDH_HCOUNTER((nint)(value));

        public static explicit operator nuint(PDH_HCOUNTER value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is PDH_HCOUNTER other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PDH_HCOUNTER.");
        }

        public int CompareTo(PDH_HCOUNTER other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is PDH_HCOUNTER other) && Equals(other);

        public bool Equals(PDH_HCOUNTER other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
