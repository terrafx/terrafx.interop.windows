// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct ADS_SEARCH_HANDLE : IComparable, IComparable<ADS_SEARCH_HANDLE>, IEquatable<ADS_SEARCH_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public ADS_SEARCH_HANDLE(void* value)
        {
            Value = value;
        }

        public static ADS_SEARCH_HANDLE INVALID_VALUE => new ADS_SEARCH_HANDLE((void*)(-1));

        public static ADS_SEARCH_HANDLE NULL => new ADS_SEARCH_HANDLE(null);

        public static bool operator ==(ADS_SEARCH_HANDLE left, ADS_SEARCH_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(ADS_SEARCH_HANDLE left, ADS_SEARCH_HANDLE right) => left.Value != right.Value;

        public static bool operator <(ADS_SEARCH_HANDLE left, ADS_SEARCH_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(ADS_SEARCH_HANDLE left, ADS_SEARCH_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(ADS_SEARCH_HANDLE left, ADS_SEARCH_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(ADS_SEARCH_HANDLE left, ADS_SEARCH_HANDLE right) => left.Value >= right.Value;

        public static explicit operator ADS_SEARCH_HANDLE(void* value) => new ADS_SEARCH_HANDLE(value);

        public static implicit operator void*(ADS_SEARCH_HANDLE value) => value.Value;

        public static explicit operator ADS_SEARCH_HANDLE(HANDLE value) => new ADS_SEARCH_HANDLE(value);

        public static implicit operator HANDLE(ADS_SEARCH_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator ADS_SEARCH_HANDLE(byte value) => new ADS_SEARCH_HANDLE((void*)(value));

        public static explicit operator byte(ADS_SEARCH_HANDLE value) => (byte)(value.Value);

        public static explicit operator ADS_SEARCH_HANDLE(short value) => new ADS_SEARCH_HANDLE((void*)(value));

        public static explicit operator short(ADS_SEARCH_HANDLE value) => (short)(value.Value);

        public static explicit operator ADS_SEARCH_HANDLE(int value) => new ADS_SEARCH_HANDLE((void*)(value));

        public static explicit operator int(ADS_SEARCH_HANDLE value) => (int)(value.Value);

        public static explicit operator ADS_SEARCH_HANDLE(long value) => new ADS_SEARCH_HANDLE((void*)(value));

        public static explicit operator long(ADS_SEARCH_HANDLE value) => (long)(value.Value);

        public static explicit operator ADS_SEARCH_HANDLE(nint value) => new ADS_SEARCH_HANDLE((void*)(value));

        public static implicit operator nint(ADS_SEARCH_HANDLE value) => (nint)(value.Value);

        public static explicit operator ADS_SEARCH_HANDLE(sbyte value) => new ADS_SEARCH_HANDLE((void*)(value));

        public static explicit operator sbyte(ADS_SEARCH_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator ADS_SEARCH_HANDLE(ushort value) => new ADS_SEARCH_HANDLE((void*)(value));

        public static explicit operator ushort(ADS_SEARCH_HANDLE value) => (ushort)(value.Value);

        public static explicit operator ADS_SEARCH_HANDLE(uint value) => new ADS_SEARCH_HANDLE((void*)(value));

        public static explicit operator uint(ADS_SEARCH_HANDLE value) => (uint)(value.Value);

        public static explicit operator ADS_SEARCH_HANDLE(ulong value) => new ADS_SEARCH_HANDLE((void*)(value));

        public static explicit operator ulong(ADS_SEARCH_HANDLE value) => (ulong)(value.Value);

        public static explicit operator ADS_SEARCH_HANDLE(nuint value) => new ADS_SEARCH_HANDLE((void*)(value));

        public static implicit operator nuint(ADS_SEARCH_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is ADS_SEARCH_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of ADS_SEARCH_HANDLE.");
        }

        public int CompareTo(ADS_SEARCH_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is ADS_SEARCH_HANDLE other) && Equals(other);

        public bool Equals(ADS_SEARCH_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
