// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HFILTER_VOLUME : IComparable, IComparable<HFILTER_VOLUME>, IEquatable<HFILTER_VOLUME>, IFormattable
    {
        public readonly void* Value;

        public HFILTER_VOLUME(void* value)
        {
            Value = value;
        }

        public static HFILTER_VOLUME INVALID_VALUE => new HFILTER_VOLUME((void*)(-1));

        public static HFILTER_VOLUME NULL => new HFILTER_VOLUME(null);

        public static bool operator ==(HFILTER_VOLUME left, HFILTER_VOLUME right) => left.Value == right.Value;

        public static bool operator !=(HFILTER_VOLUME left, HFILTER_VOLUME right) => left.Value != right.Value;

        public static bool operator <(HFILTER_VOLUME left, HFILTER_VOLUME right) => left.Value < right.Value;

        public static bool operator <=(HFILTER_VOLUME left, HFILTER_VOLUME right) => left.Value <= right.Value;

        public static bool operator >(HFILTER_VOLUME left, HFILTER_VOLUME right) => left.Value > right.Value;

        public static bool operator >=(HFILTER_VOLUME left, HFILTER_VOLUME right) => left.Value >= right.Value;

        public static explicit operator HFILTER_VOLUME(void* value) => new HFILTER_VOLUME(value);

        public static implicit operator void*(HFILTER_VOLUME value) => value.Value;

        public static explicit operator HFILTER_VOLUME(HANDLE value) => new HFILTER_VOLUME(value);

        public static implicit operator HANDLE(HFILTER_VOLUME value) => new HANDLE(value.Value);

        public static explicit operator HFILTER_VOLUME(byte value) => new HFILTER_VOLUME((void*)(value));

        public static explicit operator byte(HFILTER_VOLUME value) => (byte)(value.Value);

        public static explicit operator HFILTER_VOLUME(short value) => new HFILTER_VOLUME((void*)(value));

        public static explicit operator short(HFILTER_VOLUME value) => (short)(value.Value);

        public static explicit operator HFILTER_VOLUME(int value) => new HFILTER_VOLUME((void*)(value));

        public static explicit operator int(HFILTER_VOLUME value) => (int)(value.Value);

        public static explicit operator HFILTER_VOLUME(long value) => new HFILTER_VOLUME((void*)(value));

        public static explicit operator long(HFILTER_VOLUME value) => (long)(value.Value);

        public static explicit operator HFILTER_VOLUME(nint value) => new HFILTER_VOLUME((void*)(value));

        public static implicit operator nint(HFILTER_VOLUME value) => (nint)(value.Value);

        public static explicit operator HFILTER_VOLUME(sbyte value) => new HFILTER_VOLUME((void*)(value));

        public static explicit operator sbyte(HFILTER_VOLUME value) => (sbyte)(value.Value);

        public static explicit operator HFILTER_VOLUME(ushort value) => new HFILTER_VOLUME((void*)(value));

        public static explicit operator ushort(HFILTER_VOLUME value) => (ushort)(value.Value);

        public static explicit operator HFILTER_VOLUME(uint value) => new HFILTER_VOLUME((void*)(value));

        public static explicit operator uint(HFILTER_VOLUME value) => (uint)(value.Value);

        public static explicit operator HFILTER_VOLUME(ulong value) => new HFILTER_VOLUME((void*)(value));

        public static explicit operator ulong(HFILTER_VOLUME value) => (ulong)(value.Value);

        public static explicit operator HFILTER_VOLUME(nuint value) => new HFILTER_VOLUME((void*)(value));

        public static implicit operator nuint(HFILTER_VOLUME value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HFILTER_VOLUME other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HFILTER_VOLUME.");
        }

        public int CompareTo(HFILTER_VOLUME other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HFILTER_VOLUME other) && Equals(other);

        public bool Equals(HFILTER_VOLUME other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
