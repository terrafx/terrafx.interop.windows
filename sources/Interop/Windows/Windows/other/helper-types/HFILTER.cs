// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HFILTER : IComparable, IComparable<HFILTER>, IEquatable<HFILTER>, IFormattable
    {
        public readonly void* Value;

        public HFILTER(void* value)
        {
            Value = value;
        }

        public static HFILTER INVALID_VALUE => new HFILTER((void*)(-1));

        public static HFILTER NULL => new HFILTER(null);

        public static bool operator ==(HFILTER left, HFILTER right) => left.Value == right.Value;

        public static bool operator !=(HFILTER left, HFILTER right) => left.Value != right.Value;

        public static bool operator <(HFILTER left, HFILTER right) => left.Value < right.Value;

        public static bool operator <=(HFILTER left, HFILTER right) => left.Value <= right.Value;

        public static bool operator >(HFILTER left, HFILTER right) => left.Value > right.Value;

        public static bool operator >=(HFILTER left, HFILTER right) => left.Value >= right.Value;

        public static explicit operator HFILTER(void* value) => new HFILTER(value);

        public static implicit operator void*(HFILTER value) => value.Value;

        public static explicit operator HFILTER(HANDLE value) => new HFILTER(value);

        public static implicit operator HANDLE(HFILTER value) => new HANDLE(value.Value);

        public static explicit operator HFILTER(byte value) => new HFILTER((void*)(value));

        public static explicit operator byte(HFILTER value) => (byte)(value.Value);

        public static explicit operator HFILTER(short value) => new HFILTER((void*)(value));

        public static explicit operator short(HFILTER value) => (short)(value.Value);

        public static explicit operator HFILTER(int value) => new HFILTER((void*)(value));

        public static explicit operator int(HFILTER value) => (int)(value.Value);

        public static explicit operator HFILTER(long value) => new HFILTER((void*)(value));

        public static explicit operator long(HFILTER value) => (long)(value.Value);

        public static explicit operator HFILTER(nint value) => new HFILTER((void*)(value));

        public static implicit operator nint(HFILTER value) => (nint)(value.Value);

        public static explicit operator HFILTER(sbyte value) => new HFILTER((void*)(value));

        public static explicit operator sbyte(HFILTER value) => (sbyte)(value.Value);

        public static explicit operator HFILTER(ushort value) => new HFILTER((void*)(value));

        public static explicit operator ushort(HFILTER value) => (ushort)(value.Value);

        public static explicit operator HFILTER(uint value) => new HFILTER((void*)(value));

        public static explicit operator uint(HFILTER value) => (uint)(value.Value);

        public static explicit operator HFILTER(ulong value) => new HFILTER((void*)(value));

        public static explicit operator ulong(HFILTER value) => (ulong)(value.Value);

        public static explicit operator HFILTER(nuint value) => new HFILTER((void*)(value));

        public static implicit operator nuint(HFILTER value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HFILTER other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HFILTER.");
        }

        public int CompareTo(HFILTER other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HFILTER other) && Equals(other);

        public bool Equals(HFILTER other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
