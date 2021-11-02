// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWINWATCH : IComparable, IComparable<HWINWATCH>, IEquatable<HWINWATCH>, IFormattable
    {
        public readonly void* Value;

        public HWINWATCH(void* value)
        {
            Value = value;
        }

        public static HWINWATCH INVALID_VALUE => new HWINWATCH((void*)(-1));

        public static HWINWATCH NULL => new HWINWATCH(null);

        public static bool operator ==(HWINWATCH left, HWINWATCH right) => left.Value == right.Value;

        public static bool operator !=(HWINWATCH left, HWINWATCH right) => left.Value != right.Value;

        public static bool operator <(HWINWATCH left, HWINWATCH right) => left.Value < right.Value;

        public static bool operator <=(HWINWATCH left, HWINWATCH right) => left.Value <= right.Value;

        public static bool operator >(HWINWATCH left, HWINWATCH right) => left.Value > right.Value;

        public static bool operator >=(HWINWATCH left, HWINWATCH right) => left.Value >= right.Value;

        public static explicit operator HWINWATCH(void* value) => new HWINWATCH(value);

        public static implicit operator void*(HWINWATCH value) => value.Value;

        public static explicit operator HWINWATCH(HANDLE value) => new HWINWATCH(value);

        public static implicit operator HANDLE(HWINWATCH value) => new HANDLE(value.Value);

        public static explicit operator HWINWATCH(byte value) => new HWINWATCH((void*)(value));

        public static explicit operator byte(HWINWATCH value) => (byte)(value.Value);

        public static explicit operator HWINWATCH(short value) => new HWINWATCH((void*)(value));

        public static explicit operator short(HWINWATCH value) => (short)(value.Value);

        public static explicit operator HWINWATCH(int value) => new HWINWATCH((void*)(value));

        public static explicit operator int(HWINWATCH value) => (int)(value.Value);

        public static explicit operator HWINWATCH(long value) => new HWINWATCH((void*)(value));

        public static explicit operator long(HWINWATCH value) => (long)(value.Value);

        public static explicit operator HWINWATCH(nint value) => new HWINWATCH((void*)(value));

        public static implicit operator nint(HWINWATCH value) => (nint)(value.Value);

        public static explicit operator HWINWATCH(sbyte value) => new HWINWATCH((void*)(value));

        public static explicit operator sbyte(HWINWATCH value) => (sbyte)(value.Value);

        public static explicit operator HWINWATCH(ushort value) => new HWINWATCH((void*)(value));

        public static explicit operator ushort(HWINWATCH value) => (ushort)(value.Value);

        public static explicit operator HWINWATCH(uint value) => new HWINWATCH((void*)(value));

        public static explicit operator uint(HWINWATCH value) => (uint)(value.Value);

        public static explicit operator HWINWATCH(ulong value) => new HWINWATCH((void*)(value));

        public static explicit operator ulong(HWINWATCH value) => (ulong)(value.Value);

        public static explicit operator HWINWATCH(nuint value) => new HWINWATCH((void*)(value));

        public static implicit operator nuint(HWINWATCH value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HWINWATCH other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HWINWATCH.");
        }

        public int CompareTo(HWINWATCH other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HWINWATCH other) && Equals(other);

        public bool Equals(HWINWATCH other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
