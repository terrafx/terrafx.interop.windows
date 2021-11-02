// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCONVLIST : IComparable, IComparable<HCONVLIST>, IEquatable<HCONVLIST>, IFormattable
    {
        public readonly void* Value;

        public HCONVLIST(void* value)
        {
            Value = value;
        }

        public static HCONVLIST INVALID_VALUE => new HCONVLIST((void*)(-1));

        public static HCONVLIST NULL => new HCONVLIST(null);

        public static bool operator ==(HCONVLIST left, HCONVLIST right) => left.Value == right.Value;

        public static bool operator !=(HCONVLIST left, HCONVLIST right) => left.Value != right.Value;

        public static bool operator <(HCONVLIST left, HCONVLIST right) => left.Value < right.Value;

        public static bool operator <=(HCONVLIST left, HCONVLIST right) => left.Value <= right.Value;

        public static bool operator >(HCONVLIST left, HCONVLIST right) => left.Value > right.Value;

        public static bool operator >=(HCONVLIST left, HCONVLIST right) => left.Value >= right.Value;

        public static explicit operator HCONVLIST(void* value) => new HCONVLIST(value);

        public static implicit operator void*(HCONVLIST value) => value.Value;

        public static explicit operator HCONVLIST(HANDLE value) => new HCONVLIST(value);

        public static implicit operator HANDLE(HCONVLIST value) => new HANDLE(value.Value);

        public static explicit operator HCONVLIST(byte value) => new HCONVLIST((void*)(value));

        public static explicit operator byte(HCONVLIST value) => (byte)(value.Value);

        public static explicit operator HCONVLIST(short value) => new HCONVLIST((void*)(value));

        public static explicit operator short(HCONVLIST value) => (short)(value.Value);

        public static explicit operator HCONVLIST(int value) => new HCONVLIST((void*)(value));

        public static explicit operator int(HCONVLIST value) => (int)(value.Value);

        public static explicit operator HCONVLIST(long value) => new HCONVLIST((void*)(value));

        public static explicit operator long(HCONVLIST value) => (long)(value.Value);

        public static explicit operator HCONVLIST(nint value) => new HCONVLIST((void*)(value));

        public static implicit operator nint(HCONVLIST value) => (nint)(value.Value);

        public static explicit operator HCONVLIST(sbyte value) => new HCONVLIST((void*)(value));

        public static explicit operator sbyte(HCONVLIST value) => (sbyte)(value.Value);

        public static explicit operator HCONVLIST(ushort value) => new HCONVLIST((void*)(value));

        public static explicit operator ushort(HCONVLIST value) => (ushort)(value.Value);

        public static explicit operator HCONVLIST(uint value) => new HCONVLIST((void*)(value));

        public static explicit operator uint(HCONVLIST value) => (uint)(value.Value);

        public static explicit operator HCONVLIST(ulong value) => new HCONVLIST((void*)(value));

        public static explicit operator ulong(HCONVLIST value) => (ulong)(value.Value);

        public static explicit operator HCONVLIST(nuint value) => new HCONVLIST((void*)(value));

        public static implicit operator nuint(HCONVLIST value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCONVLIST other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCONVLIST.");
        }

        public int CompareTo(HCONVLIST other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HCONVLIST other) && Equals(other);

        public bool Equals(HCONVLIST other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
