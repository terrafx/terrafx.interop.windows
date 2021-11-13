// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct PDH_HQUERY : IComparable, IComparable<PDH_HQUERY>, IEquatable<PDH_HQUERY>, IFormattable
    {
        public readonly void* Value;

        public PDH_HQUERY(void* value)
        {
            Value = value;
        }

        public static PDH_HQUERY INVALID_VALUE => new PDH_HQUERY((void*)(-1));

        public static PDH_HQUERY NULL => new PDH_HQUERY(null);

        public static bool operator ==(PDH_HQUERY left, PDH_HQUERY right) => left.Value == right.Value;

        public static bool operator !=(PDH_HQUERY left, PDH_HQUERY right) => left.Value != right.Value;

        public static bool operator <(PDH_HQUERY left, PDH_HQUERY right) => left.Value < right.Value;

        public static bool operator <=(PDH_HQUERY left, PDH_HQUERY right) => left.Value <= right.Value;

        public static bool operator >(PDH_HQUERY left, PDH_HQUERY right) => left.Value > right.Value;

        public static bool operator >=(PDH_HQUERY left, PDH_HQUERY right) => left.Value >= right.Value;

        public static explicit operator PDH_HQUERY(void* value) => new PDH_HQUERY(value);

        public static implicit operator void*(PDH_HQUERY value) => value.Value;

        public static explicit operator PDH_HQUERY(HANDLE value) => new PDH_HQUERY(value);

        public static implicit operator HANDLE(PDH_HQUERY value) => new HANDLE(value.Value);

        public static explicit operator PDH_HQUERY(byte value) => new PDH_HQUERY((void*)(value));

        public static explicit operator byte(PDH_HQUERY value) => (byte)(value.Value);

        public static explicit operator PDH_HQUERY(short value) => new PDH_HQUERY((void*)(value));

        public static explicit operator short(PDH_HQUERY value) => (short)(value.Value);

        public static explicit operator PDH_HQUERY(int value) => new PDH_HQUERY((void*)(value));

        public static explicit operator int(PDH_HQUERY value) => (int)(value.Value);

        public static explicit operator PDH_HQUERY(long value) => new PDH_HQUERY((void*)(value));

        public static explicit operator long(PDH_HQUERY value) => (long)(value.Value);

        public static explicit operator PDH_HQUERY(nint value) => new PDH_HQUERY((void*)(value));

        public static implicit operator nint(PDH_HQUERY value) => (nint)(value.Value);

        public static explicit operator PDH_HQUERY(sbyte value) => new PDH_HQUERY((void*)(value));

        public static explicit operator sbyte(PDH_HQUERY value) => (sbyte)(value.Value);

        public static explicit operator PDH_HQUERY(ushort value) => new PDH_HQUERY((void*)(value));

        public static explicit operator ushort(PDH_HQUERY value) => (ushort)(value.Value);

        public static explicit operator PDH_HQUERY(uint value) => new PDH_HQUERY((void*)(value));

        public static explicit operator uint(PDH_HQUERY value) => (uint)(value.Value);

        public static explicit operator PDH_HQUERY(ulong value) => new PDH_HQUERY((void*)(value));

        public static explicit operator ulong(PDH_HQUERY value) => (ulong)(value.Value);

        public static explicit operator PDH_HQUERY(nuint value) => new PDH_HQUERY((void*)(value));

        public static implicit operator nuint(PDH_HQUERY value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is PDH_HQUERY other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PDH_HQUERY.");
        }

        public int CompareTo(PDH_HQUERY other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is PDH_HQUERY other) && Equals(other);

        public bool Equals(PDH_HQUERY other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
