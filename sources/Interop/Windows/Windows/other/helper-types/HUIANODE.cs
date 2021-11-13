// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HUIANODE : IComparable, IComparable<HUIANODE>, IEquatable<HUIANODE>, IFormattable
    {
        public readonly void* Value;

        public HUIANODE(void* value)
        {
            Value = value;
        }

        public static HUIANODE INVALID_VALUE => new HUIANODE((void*)(-1));

        public static HUIANODE NULL => new HUIANODE(null);

        public static bool operator ==(HUIANODE left, HUIANODE right) => left.Value == right.Value;

        public static bool operator !=(HUIANODE left, HUIANODE right) => left.Value != right.Value;

        public static bool operator <(HUIANODE left, HUIANODE right) => left.Value < right.Value;

        public static bool operator <=(HUIANODE left, HUIANODE right) => left.Value <= right.Value;

        public static bool operator >(HUIANODE left, HUIANODE right) => left.Value > right.Value;

        public static bool operator >=(HUIANODE left, HUIANODE right) => left.Value >= right.Value;

        public static explicit operator HUIANODE(void* value) => new HUIANODE(value);

        public static implicit operator void*(HUIANODE value) => value.Value;

        public static explicit operator HUIANODE(HANDLE value) => new HUIANODE(value);

        public static implicit operator HANDLE(HUIANODE value) => new HANDLE(value.Value);

        public static explicit operator HUIANODE(byte value) => new HUIANODE((void*)(value));

        public static explicit operator byte(HUIANODE value) => (byte)(value.Value);

        public static explicit operator HUIANODE(short value) => new HUIANODE((void*)(value));

        public static explicit operator short(HUIANODE value) => (short)(value.Value);

        public static explicit operator HUIANODE(int value) => new HUIANODE((void*)(value));

        public static explicit operator int(HUIANODE value) => (int)(value.Value);

        public static explicit operator HUIANODE(long value) => new HUIANODE((void*)(value));

        public static explicit operator long(HUIANODE value) => (long)(value.Value);

        public static explicit operator HUIANODE(nint value) => new HUIANODE((void*)(value));

        public static implicit operator nint(HUIANODE value) => (nint)(value.Value);

        public static explicit operator HUIANODE(sbyte value) => new HUIANODE((void*)(value));

        public static explicit operator sbyte(HUIANODE value) => (sbyte)(value.Value);

        public static explicit operator HUIANODE(ushort value) => new HUIANODE((void*)(value));

        public static explicit operator ushort(HUIANODE value) => (ushort)(value.Value);

        public static explicit operator HUIANODE(uint value) => new HUIANODE((void*)(value));

        public static explicit operator uint(HUIANODE value) => (uint)(value.Value);

        public static explicit operator HUIANODE(ulong value) => new HUIANODE((void*)(value));

        public static explicit operator ulong(HUIANODE value) => (ulong)(value.Value);

        public static explicit operator HUIANODE(nuint value) => new HUIANODE((void*)(value));

        public static implicit operator nuint(HUIANODE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HUIANODE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HUIANODE.");
        }

        public int CompareTo(HUIANODE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HUIANODE other) && Equals(other);

        public bool Equals(HUIANODE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
