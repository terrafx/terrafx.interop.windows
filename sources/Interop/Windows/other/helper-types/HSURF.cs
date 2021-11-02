// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSURF : IComparable, IComparable<HSURF>, IEquatable<HSURF>, IFormattable
    {
        public readonly void* Value;

        public HSURF(void* value)
        {
            Value = value;
        }

        public static HSURF INVALID_VALUE => new HSURF((void*)(-1));

        public static HSURF NULL => new HSURF(null);

        public static bool operator ==(HSURF left, HSURF right) => left.Value == right.Value;

        public static bool operator !=(HSURF left, HSURF right) => left.Value != right.Value;

        public static bool operator <(HSURF left, HSURF right) => left.Value < right.Value;

        public static bool operator <=(HSURF left, HSURF right) => left.Value <= right.Value;

        public static bool operator >(HSURF left, HSURF right) => left.Value > right.Value;

        public static bool operator >=(HSURF left, HSURF right) => left.Value >= right.Value;

        public static explicit operator HSURF(void* value) => new HSURF(value);

        public static implicit operator void*(HSURF value) => value.Value;

        public static explicit operator HSURF(HANDLE value) => new HSURF(value);

        public static implicit operator HANDLE(HSURF value) => new HANDLE(value.Value);

        public static explicit operator HSURF(byte value) => new HSURF((void*)(value));

        public static explicit operator byte(HSURF value) => (byte)(value.Value);

        public static explicit operator HSURF(short value) => new HSURF((void*)(value));

        public static explicit operator short(HSURF value) => (short)(value.Value);

        public static explicit operator HSURF(int value) => new HSURF((void*)(value));

        public static explicit operator int(HSURF value) => (int)(value.Value);

        public static explicit operator HSURF(long value) => new HSURF((void*)(value));

        public static explicit operator long(HSURF value) => (long)(value.Value);

        public static explicit operator HSURF(nint value) => new HSURF((void*)(value));

        public static implicit operator nint(HSURF value) => (nint)(value.Value);

        public static explicit operator HSURF(sbyte value) => new HSURF((void*)(value));

        public static explicit operator sbyte(HSURF value) => (sbyte)(value.Value);

        public static explicit operator HSURF(ushort value) => new HSURF((void*)(value));

        public static explicit operator ushort(HSURF value) => (ushort)(value.Value);

        public static explicit operator HSURF(uint value) => new HSURF((void*)(value));

        public static explicit operator uint(HSURF value) => (uint)(value.Value);

        public static explicit operator HSURF(ulong value) => new HSURF((void*)(value));

        public static explicit operator ulong(HSURF value) => (ulong)(value.Value);

        public static explicit operator HSURF(nuint value) => new HSURF((void*)(value));

        public static implicit operator nuint(HSURF value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HSURF other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSURF.");
        }

        public int CompareTo(HSURF other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HSURF other) && Equals(other);

        public bool Equals(HSURF other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
