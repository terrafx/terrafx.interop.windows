// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HLSURF : IComparable, IComparable<HLSURF>, IEquatable<HLSURF>, IFormattable
    {
        public readonly void* Value;

        public HLSURF(void* value)
        {
            Value = value;
        }

        public static HLSURF INVALID_VALUE => new HLSURF((void*)(-1));

        public static HLSURF NULL => new HLSURF(null);

        public static bool operator ==(HLSURF left, HLSURF right) => left.Value == right.Value;

        public static bool operator !=(HLSURF left, HLSURF right) => left.Value != right.Value;

        public static bool operator <(HLSURF left, HLSURF right) => left.Value < right.Value;

        public static bool operator <=(HLSURF left, HLSURF right) => left.Value <= right.Value;

        public static bool operator >(HLSURF left, HLSURF right) => left.Value > right.Value;

        public static bool operator >=(HLSURF left, HLSURF right) => left.Value >= right.Value;

        public static explicit operator HLSURF(void* value) => new HLSURF(value);

        public static implicit operator void*(HLSURF value) => value.Value;

        public static explicit operator HLSURF(HANDLE value) => new HLSURF(value);

        public static implicit operator HANDLE(HLSURF value) => new HANDLE(value.Value);

        public static explicit operator HLSURF(byte value) => new HLSURF((void*)(value));

        public static explicit operator byte(HLSURF value) => (byte)(value.Value);

        public static explicit operator HLSURF(short value) => new HLSURF((void*)(value));

        public static explicit operator short(HLSURF value) => (short)(value.Value);

        public static explicit operator HLSURF(int value) => new HLSURF((void*)(value));

        public static explicit operator int(HLSURF value) => (int)(value.Value);

        public static explicit operator HLSURF(long value) => new HLSURF((void*)(value));

        public static explicit operator long(HLSURF value) => (long)(value.Value);

        public static explicit operator HLSURF(nint value) => new HLSURF((void*)(value));

        public static implicit operator nint(HLSURF value) => (nint)(value.Value);

        public static explicit operator HLSURF(sbyte value) => new HLSURF((void*)(value));

        public static explicit operator sbyte(HLSURF value) => (sbyte)(value.Value);

        public static explicit operator HLSURF(ushort value) => new HLSURF((void*)(value));

        public static explicit operator ushort(HLSURF value) => (ushort)(value.Value);

        public static explicit operator HLSURF(uint value) => new HLSURF((void*)(value));

        public static explicit operator uint(HLSURF value) => (uint)(value.Value);

        public static explicit operator HLSURF(ulong value) => new HLSURF((void*)(value));

        public static explicit operator ulong(HLSURF value) => (ulong)(value.Value);

        public static explicit operator HLSURF(nuint value) => new HLSURF((void*)(value));

        public static implicit operator nuint(HLSURF value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HLSURF other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HLSURF.");
        }

        public int CompareTo(HLSURF other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HLSURF other) && Equals(other);

        public bool Equals(HLSURF other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
