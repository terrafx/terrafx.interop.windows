// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct DHSURF : IComparable, IComparable<DHSURF>, IEquatable<DHSURF>, IFormattable
    {
        public readonly void* Value;

        public DHSURF(void* value)
        {
            Value = value;
        }

        public static DHSURF INVALID_VALUE => new DHSURF((void*)(-1));

        public static DHSURF NULL => new DHSURF(null);

        public static bool operator ==(DHSURF left, DHSURF right) => left.Value == right.Value;

        public static bool operator !=(DHSURF left, DHSURF right) => left.Value != right.Value;

        public static bool operator <(DHSURF left, DHSURF right) => left.Value < right.Value;

        public static bool operator <=(DHSURF left, DHSURF right) => left.Value <= right.Value;

        public static bool operator >(DHSURF left, DHSURF right) => left.Value > right.Value;

        public static bool operator >=(DHSURF left, DHSURF right) => left.Value >= right.Value;

        public static explicit operator DHSURF(void* value) => new DHSURF(value);

        public static implicit operator void*(DHSURF value) => value.Value;

        public static explicit operator DHSURF(HANDLE value) => new DHSURF(value);

        public static implicit operator HANDLE(DHSURF value) => new HANDLE(value.Value);

        public static explicit operator DHSURF(byte value) => new DHSURF((void*)(value));

        public static explicit operator byte(DHSURF value) => (byte)(value.Value);

        public static explicit operator DHSURF(short value) => new DHSURF((void*)(value));

        public static explicit operator short(DHSURF value) => (short)(value.Value);

        public static explicit operator DHSURF(int value) => new DHSURF((void*)(value));

        public static explicit operator int(DHSURF value) => (int)(value.Value);

        public static explicit operator DHSURF(long value) => new DHSURF((void*)(value));

        public static explicit operator long(DHSURF value) => (long)(value.Value);

        public static explicit operator DHSURF(nint value) => new DHSURF((void*)(value));

        public static implicit operator nint(DHSURF value) => (nint)(value.Value);

        public static explicit operator DHSURF(sbyte value) => new DHSURF((void*)(value));

        public static explicit operator sbyte(DHSURF value) => (sbyte)(value.Value);

        public static explicit operator DHSURF(ushort value) => new DHSURF((void*)(value));

        public static explicit operator ushort(DHSURF value) => (ushort)(value.Value);

        public static explicit operator DHSURF(uint value) => new DHSURF((void*)(value));

        public static explicit operator uint(DHSURF value) => (uint)(value.Value);

        public static explicit operator DHSURF(ulong value) => new DHSURF((void*)(value));

        public static explicit operator ulong(DHSURF value) => (ulong)(value.Value);

        public static explicit operator DHSURF(nuint value) => new DHSURF((void*)(value));

        public static implicit operator nuint(DHSURF value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is DHSURF other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of DHSURF.");
        }

        public int CompareTo(DHSURF other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is DHSURF other) && Equals(other);

        public bool Equals(DHSURF other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
