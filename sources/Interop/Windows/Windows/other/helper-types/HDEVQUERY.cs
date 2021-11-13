// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HDEVQUERY : IComparable, IComparable<HDEVQUERY>, IEquatable<HDEVQUERY>, IFormattable
    {
        public readonly void* Value;

        public HDEVQUERY(void* value)
        {
            Value = value;
        }

        public static HDEVQUERY INVALID_VALUE => new HDEVQUERY((void*)(-1));

        public static HDEVQUERY NULL => new HDEVQUERY(null);

        public static bool operator ==(HDEVQUERY left, HDEVQUERY right) => left.Value == right.Value;

        public static bool operator !=(HDEVQUERY left, HDEVQUERY right) => left.Value != right.Value;

        public static bool operator <(HDEVQUERY left, HDEVQUERY right) => left.Value < right.Value;

        public static bool operator <=(HDEVQUERY left, HDEVQUERY right) => left.Value <= right.Value;

        public static bool operator >(HDEVQUERY left, HDEVQUERY right) => left.Value > right.Value;

        public static bool operator >=(HDEVQUERY left, HDEVQUERY right) => left.Value >= right.Value;

        public static explicit operator HDEVQUERY(void* value) => new HDEVQUERY(value);

        public static implicit operator void*(HDEVQUERY value) => value.Value;

        public static explicit operator HDEVQUERY(HANDLE value) => new HDEVQUERY(value);

        public static implicit operator HANDLE(HDEVQUERY value) => new HANDLE(value.Value);

        public static explicit operator HDEVQUERY(byte value) => new HDEVQUERY((void*)(value));

        public static explicit operator byte(HDEVQUERY value) => (byte)(value.Value);

        public static explicit operator HDEVQUERY(short value) => new HDEVQUERY((void*)(value));

        public static explicit operator short(HDEVQUERY value) => (short)(value.Value);

        public static explicit operator HDEVQUERY(int value) => new HDEVQUERY((void*)(value));

        public static explicit operator int(HDEVQUERY value) => (int)(value.Value);

        public static explicit operator HDEVQUERY(long value) => new HDEVQUERY((void*)(value));

        public static explicit operator long(HDEVQUERY value) => (long)(value.Value);

        public static explicit operator HDEVQUERY(nint value) => new HDEVQUERY((void*)(value));

        public static implicit operator nint(HDEVQUERY value) => (nint)(value.Value);

        public static explicit operator HDEVQUERY(sbyte value) => new HDEVQUERY((void*)(value));

        public static explicit operator sbyte(HDEVQUERY value) => (sbyte)(value.Value);

        public static explicit operator HDEVQUERY(ushort value) => new HDEVQUERY((void*)(value));

        public static explicit operator ushort(HDEVQUERY value) => (ushort)(value.Value);

        public static explicit operator HDEVQUERY(uint value) => new HDEVQUERY((void*)(value));

        public static explicit operator uint(HDEVQUERY value) => (uint)(value.Value);

        public static explicit operator HDEVQUERY(ulong value) => new HDEVQUERY((void*)(value));

        public static explicit operator ulong(HDEVQUERY value) => (ulong)(value.Value);

        public static explicit operator HDEVQUERY(nuint value) => new HDEVQUERY((void*)(value));

        public static implicit operator nuint(HDEVQUERY value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDEVQUERY other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDEVQUERY.");
        }

        public int CompareTo(HDEVQUERY other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HDEVQUERY other) && Equals(other);

        public bool Equals(HDEVQUERY other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
