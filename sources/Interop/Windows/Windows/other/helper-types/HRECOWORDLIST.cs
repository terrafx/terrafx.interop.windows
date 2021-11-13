// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HRECOWORDLIST : IComparable, IComparable<HRECOWORDLIST>, IEquatable<HRECOWORDLIST>, IFormattable
    {
        public readonly void* Value;

        public HRECOWORDLIST(void* value)
        {
            Value = value;
        }

        public static HRECOWORDLIST INVALID_VALUE => new HRECOWORDLIST((void*)(-1));

        public static HRECOWORDLIST NULL => new HRECOWORDLIST(null);

        public static bool operator ==(HRECOWORDLIST left, HRECOWORDLIST right) => left.Value == right.Value;

        public static bool operator !=(HRECOWORDLIST left, HRECOWORDLIST right) => left.Value != right.Value;

        public static bool operator <(HRECOWORDLIST left, HRECOWORDLIST right) => left.Value < right.Value;

        public static bool operator <=(HRECOWORDLIST left, HRECOWORDLIST right) => left.Value <= right.Value;

        public static bool operator >(HRECOWORDLIST left, HRECOWORDLIST right) => left.Value > right.Value;

        public static bool operator >=(HRECOWORDLIST left, HRECOWORDLIST right) => left.Value >= right.Value;

        public static explicit operator HRECOWORDLIST(void* value) => new HRECOWORDLIST(value);

        public static implicit operator void*(HRECOWORDLIST value) => value.Value;

        public static explicit operator HRECOWORDLIST(HANDLE value) => new HRECOWORDLIST(value);

        public static implicit operator HANDLE(HRECOWORDLIST value) => new HANDLE(value.Value);

        public static explicit operator HRECOWORDLIST(byte value) => new HRECOWORDLIST((void*)(value));

        public static explicit operator byte(HRECOWORDLIST value) => (byte)(value.Value);

        public static explicit operator HRECOWORDLIST(short value) => new HRECOWORDLIST((void*)(value));

        public static explicit operator short(HRECOWORDLIST value) => (short)(value.Value);

        public static explicit operator HRECOWORDLIST(int value) => new HRECOWORDLIST((void*)(value));

        public static explicit operator int(HRECOWORDLIST value) => (int)(value.Value);

        public static explicit operator HRECOWORDLIST(long value) => new HRECOWORDLIST((void*)(value));

        public static explicit operator long(HRECOWORDLIST value) => (long)(value.Value);

        public static explicit operator HRECOWORDLIST(nint value) => new HRECOWORDLIST((void*)(value));

        public static implicit operator nint(HRECOWORDLIST value) => (nint)(value.Value);

        public static explicit operator HRECOWORDLIST(sbyte value) => new HRECOWORDLIST((void*)(value));

        public static explicit operator sbyte(HRECOWORDLIST value) => (sbyte)(value.Value);

        public static explicit operator HRECOWORDLIST(ushort value) => new HRECOWORDLIST((void*)(value));

        public static explicit operator ushort(HRECOWORDLIST value) => (ushort)(value.Value);

        public static explicit operator HRECOWORDLIST(uint value) => new HRECOWORDLIST((void*)(value));

        public static explicit operator uint(HRECOWORDLIST value) => (uint)(value.Value);

        public static explicit operator HRECOWORDLIST(ulong value) => new HRECOWORDLIST((void*)(value));

        public static explicit operator ulong(HRECOWORDLIST value) => (ulong)(value.Value);

        public static explicit operator HRECOWORDLIST(nuint value) => new HRECOWORDLIST((void*)(value));

        public static implicit operator nuint(HRECOWORDLIST value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HRECOWORDLIST other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HRECOWORDLIST.");
        }

        public int CompareTo(HRECOWORDLIST other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HRECOWORDLIST other) && Equals(other);

        public bool Equals(HRECOWORDLIST other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
