// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct DHSURF : IComparable, IComparable<DHSURF>, IEquatable<DHSURF>, IFormattable
    {
        public readonly nint Value;

        public DHSURF(nint value)
        {
            Value = value;
        }

        public static DHSURF INVALID_VALUE => new DHSURF(-1);

        public static DHSURF NULL => new DHSURF(0);

        public static bool operator ==(DHSURF left, DHSURF right) => left.Value == right.Value;

        public static bool operator !=(DHSURF left, DHSURF right) => left.Value != right.Value;

        public static bool operator <(DHSURF left, DHSURF right) => left.Value < right.Value;

        public static bool operator <=(DHSURF left, DHSURF right) => left.Value <= right.Value;

        public static bool operator >(DHSURF left, DHSURF right) => left.Value > right.Value;

        public static bool operator >=(DHSURF left, DHSURF right) => left.Value >= right.Value;

        public static explicit operator DHSURF(void* value) => new DHSURF((nint)(value));

        public static implicit operator void*(DHSURF value) => (void*)(value.Value);

        public static explicit operator DHSURF(HANDLE value) => new DHSURF(value);

        public static implicit operator HANDLE(DHSURF value) => new HANDLE(value.Value);

        public static explicit operator DHSURF(byte value) => new DHSURF((nint)(value));

        public static explicit operator byte(DHSURF value) => (byte)(value.Value);

        public static explicit operator DHSURF(short value) => new DHSURF((nint)(value));

        public static explicit operator short(DHSURF value) => (short)(value.Value);

        public static explicit operator DHSURF(int value) => new DHSURF((nint)(value));

        public static explicit operator int(DHSURF value) => (int)(value.Value);

        public static explicit operator DHSURF(long value) => new DHSURF((nint)(value));

        public static implicit operator long(DHSURF value) => (long)(value.Value);

        public static explicit operator DHSURF(nint value) => new DHSURF((nint)(value));

        public static implicit operator nint(DHSURF value) => (nint)(value.Value);

        public static explicit operator DHSURF(sbyte value) => new DHSURF((nint)(value));

        public static explicit operator sbyte(DHSURF value) => (sbyte)(value.Value);

        public static explicit operator DHSURF(ushort value) => new DHSURF((nint)(value));

        public static explicit operator ushort(DHSURF value) => (ushort)(value.Value);

        public static explicit operator DHSURF(uint value) => new DHSURF((nint)(value));

        public static explicit operator uint(DHSURF value) => (uint)(value.Value);

        public static explicit operator DHSURF(ulong value) => new DHSURF((nint)(value));

        public static explicit operator ulong(DHSURF value) => (ulong)(value.Value);

        public static explicit operator DHSURF(nuint value) => new DHSURF((nint)(value));

        public static explicit operator nuint(DHSURF value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is DHSURF other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of DHSURF.");
        }

        public int CompareTo(DHSURF other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is DHSURF other) && Equals(other);

        public bool Equals(DHSURF other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
