// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HFILTER : IComparable, IComparable<HFILTER>, IEquatable<HFILTER>, IFormattable
    {
        public readonly nint Value;

        public HFILTER(nint value)
        {
            Value = value;
        }

        public static HFILTER INVALID_VALUE => new HFILTER(-1);

        public static HFILTER NULL => new HFILTER(0);

        public static bool operator ==(HFILTER left, HFILTER right) => left.Value == right.Value;

        public static bool operator !=(HFILTER left, HFILTER right) => left.Value != right.Value;

        public static bool operator <(HFILTER left, HFILTER right) => left.Value < right.Value;

        public static bool operator <=(HFILTER left, HFILTER right) => left.Value <= right.Value;

        public static bool operator >(HFILTER left, HFILTER right) => left.Value > right.Value;

        public static bool operator >=(HFILTER left, HFILTER right) => left.Value >= right.Value;

        public static explicit operator HFILTER(void* value) => new HFILTER((nint)(value));

        public static implicit operator void*(HFILTER value) => (void*)(value.Value);

        public static explicit operator HFILTER(HANDLE value) => new HFILTER(value);

        public static implicit operator HANDLE(HFILTER value) => new HANDLE(value.Value);

        public static explicit operator HFILTER(byte value) => new HFILTER((nint)(value));

        public static explicit operator byte(HFILTER value) => (byte)(value.Value);

        public static explicit operator HFILTER(short value) => new HFILTER((nint)(value));

        public static explicit operator short(HFILTER value) => (short)(value.Value);

        public static explicit operator HFILTER(int value) => new HFILTER((nint)(value));

        public static explicit operator int(HFILTER value) => (int)(value.Value);

        public static explicit operator HFILTER(long value) => new HFILTER((nint)(value));

        public static implicit operator long(HFILTER value) => value.Value;

        public static explicit operator HFILTER(nint value) => new HFILTER((nint)(value));

        public static implicit operator nint(HFILTER value) => value.Value;

        public static explicit operator HFILTER(sbyte value) => new HFILTER((nint)(value));

        public static explicit operator sbyte(HFILTER value) => (sbyte)(value.Value);

        public static explicit operator HFILTER(ushort value) => new HFILTER((nint)(value));

        public static explicit operator ushort(HFILTER value) => (ushort)(value.Value);

        public static explicit operator HFILTER(uint value) => new HFILTER((nint)(value));

        public static explicit operator uint(HFILTER value) => (uint)(value.Value);

        public static explicit operator HFILTER(ulong value) => new HFILTER((nint)(value));

        public static explicit operator ulong(HFILTER value) => (ulong)(value.Value);

        public static explicit operator HFILTER(nuint value) => new HFILTER((nint)(value));

        public static explicit operator nuint(HFILTER value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HFILTER other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HFILTER.");
        }

        public int CompareTo(HFILTER other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HFILTER other) && Equals(other);

        public bool Equals(HFILTER other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
