// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HFASTMUTEX : IComparable, IComparable<HFASTMUTEX>, IEquatable<HFASTMUTEX>, IFormattable
    {
        public readonly nint Value;

        public HFASTMUTEX(nint value)
        {
            Value = value;
        }

        public static HFASTMUTEX INVALID_VALUE => new HFASTMUTEX(-1);

        public static HFASTMUTEX NULL => new HFASTMUTEX(0);

        public static bool operator ==(HFASTMUTEX left, HFASTMUTEX right) => left.Value == right.Value;

        public static bool operator !=(HFASTMUTEX left, HFASTMUTEX right) => left.Value != right.Value;

        public static bool operator <(HFASTMUTEX left, HFASTMUTEX right) => left.Value < right.Value;

        public static bool operator <=(HFASTMUTEX left, HFASTMUTEX right) => left.Value <= right.Value;

        public static bool operator >(HFASTMUTEX left, HFASTMUTEX right) => left.Value > right.Value;

        public static bool operator >=(HFASTMUTEX left, HFASTMUTEX right) => left.Value >= right.Value;

        public static explicit operator HFASTMUTEX(void* value) => new HFASTMUTEX((nint)(value));

        public static implicit operator void*(HFASTMUTEX value) => (void*)(value.Value);

        public static explicit operator HFASTMUTEX(HANDLE value) => new HFASTMUTEX(value);

        public static implicit operator HANDLE(HFASTMUTEX value) => new HANDLE(value.Value);

        public static explicit operator HFASTMUTEX(byte value) => new HFASTMUTEX((nint)(value));

        public static explicit operator byte(HFASTMUTEX value) => (byte)(value.Value);

        public static explicit operator HFASTMUTEX(short value) => new HFASTMUTEX((nint)(value));

        public static explicit operator short(HFASTMUTEX value) => (short)(value.Value);

        public static explicit operator HFASTMUTEX(int value) => new HFASTMUTEX((nint)(value));

        public static explicit operator int(HFASTMUTEX value) => (int)(value.Value);

        public static explicit operator HFASTMUTEX(long value) => new HFASTMUTEX((nint)(value));

        public static implicit operator long(HFASTMUTEX value) => (long)(value.Value);

        public static explicit operator HFASTMUTEX(nint value) => new HFASTMUTEX((nint)(value));

        public static implicit operator nint(HFASTMUTEX value) => (nint)(value.Value);

        public static explicit operator HFASTMUTEX(sbyte value) => new HFASTMUTEX((nint)(value));

        public static explicit operator sbyte(HFASTMUTEX value) => (sbyte)(value.Value);

        public static explicit operator HFASTMUTEX(ushort value) => new HFASTMUTEX((nint)(value));

        public static explicit operator ushort(HFASTMUTEX value) => (ushort)(value.Value);

        public static explicit operator HFASTMUTEX(uint value) => new HFASTMUTEX((nint)(value));

        public static explicit operator uint(HFASTMUTEX value) => (uint)(value.Value);

        public static explicit operator HFASTMUTEX(ulong value) => new HFASTMUTEX((nint)(value));

        public static explicit operator ulong(HFASTMUTEX value) => (ulong)(value.Value);

        public static explicit operator HFASTMUTEX(nuint value) => new HFASTMUTEX((nint)(value));

        public static explicit operator nuint(HFASTMUTEX value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HFASTMUTEX other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HFASTMUTEX.");
        }

        public int CompareTo(HFASTMUTEX other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HFASTMUTEX other) && Equals(other);

        public bool Equals(HFASTMUTEX other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
