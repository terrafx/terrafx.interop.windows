// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HREPORT : IComparable, IComparable<HREPORT>, IEquatable<HREPORT>, IFormattable
    {
        public readonly void* Value;

        public HREPORT(void* value)
        {
            Value = value;
        }

        public static HREPORT INVALID_VALUE => new HREPORT((void*)(-1));

        public static HREPORT NULL => new HREPORT(null);

        public static bool operator ==(HREPORT left, HREPORT right) => left.Value == right.Value;

        public static bool operator !=(HREPORT left, HREPORT right) => left.Value != right.Value;

        public static bool operator <(HREPORT left, HREPORT right) => left.Value < right.Value;

        public static bool operator <=(HREPORT left, HREPORT right) => left.Value <= right.Value;

        public static bool operator >(HREPORT left, HREPORT right) => left.Value > right.Value;

        public static bool operator >=(HREPORT left, HREPORT right) => left.Value >= right.Value;

        public static explicit operator HREPORT(void* value) => new HREPORT(value);

        public static implicit operator void*(HREPORT value) => value.Value;

        public static explicit operator HREPORT(HANDLE value) => new HREPORT(value);

        public static implicit operator HANDLE(HREPORT value) => new HANDLE(value.Value);

        public static explicit operator HREPORT(byte value) => new HREPORT((void*)(value));

        public static explicit operator byte(HREPORT value) => (byte)(value.Value);

        public static explicit operator HREPORT(short value) => new HREPORT((void*)(value));

        public static explicit operator short(HREPORT value) => (short)(value.Value);

        public static explicit operator HREPORT(int value) => new HREPORT((void*)(value));

        public static explicit operator int(HREPORT value) => (int)(value.Value);

        public static explicit operator HREPORT(long value) => new HREPORT((void*)(value));

        public static explicit operator long(HREPORT value) => (long)(value.Value);

        public static explicit operator HREPORT(nint value) => new HREPORT((void*)(value));

        public static implicit operator nint(HREPORT value) => (nint)(value.Value);

        public static explicit operator HREPORT(sbyte value) => new HREPORT((void*)(value));

        public static explicit operator sbyte(HREPORT value) => (sbyte)(value.Value);

        public static explicit operator HREPORT(ushort value) => new HREPORT((void*)(value));

        public static explicit operator ushort(HREPORT value) => (ushort)(value.Value);

        public static explicit operator HREPORT(uint value) => new HREPORT((void*)(value));

        public static explicit operator uint(HREPORT value) => (uint)(value.Value);

        public static explicit operator HREPORT(ulong value) => new HREPORT((void*)(value));

        public static explicit operator ulong(HREPORT value) => (ulong)(value.Value);

        public static explicit operator HREPORT(nuint value) => new HREPORT((void*)(value));

        public static implicit operator nuint(HREPORT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HREPORT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HREPORT.");
        }

        public int CompareTo(HREPORT other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HREPORT other) && Equals(other);

        public bool Equals(HREPORT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
