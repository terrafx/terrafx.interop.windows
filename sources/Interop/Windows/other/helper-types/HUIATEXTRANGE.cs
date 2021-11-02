// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUIATEXTRANGE : IComparable, IComparable<HUIATEXTRANGE>, IEquatable<HUIATEXTRANGE>, IFormattable
    {
        public readonly void* Value;

        public HUIATEXTRANGE(void* value)
        {
            Value = value;
        }

        public static HUIATEXTRANGE INVALID_VALUE => new HUIATEXTRANGE((void*)(-1));

        public static HUIATEXTRANGE NULL => new HUIATEXTRANGE(null);

        public static bool operator ==(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value == right.Value;

        public static bool operator !=(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value != right.Value;

        public static bool operator <(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value < right.Value;

        public static bool operator <=(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value <= right.Value;

        public static bool operator >(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value > right.Value;

        public static bool operator >=(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value >= right.Value;

        public static explicit operator HUIATEXTRANGE(void* value) => new HUIATEXTRANGE(value);

        public static implicit operator void*(HUIATEXTRANGE value) => value.Value;

        public static explicit operator HUIATEXTRANGE(HANDLE value) => new HUIATEXTRANGE(value);

        public static implicit operator HANDLE(HUIATEXTRANGE value) => new HANDLE(value.Value);

        public static explicit operator HUIATEXTRANGE(byte value) => new HUIATEXTRANGE((void*)(value));

        public static explicit operator byte(HUIATEXTRANGE value) => (byte)(value.Value);

        public static explicit operator HUIATEXTRANGE(short value) => new HUIATEXTRANGE((void*)(value));

        public static explicit operator short(HUIATEXTRANGE value) => (short)(value.Value);

        public static explicit operator HUIATEXTRANGE(int value) => new HUIATEXTRANGE((void*)(value));

        public static explicit operator int(HUIATEXTRANGE value) => (int)(value.Value);

        public static explicit operator HUIATEXTRANGE(long value) => new HUIATEXTRANGE((void*)(value));

        public static explicit operator long(HUIATEXTRANGE value) => (long)(value.Value);

        public static explicit operator HUIATEXTRANGE(nint value) => new HUIATEXTRANGE((void*)(value));

        public static implicit operator nint(HUIATEXTRANGE value) => (nint)(value.Value);

        public static explicit operator HUIATEXTRANGE(sbyte value) => new HUIATEXTRANGE((void*)(value));

        public static explicit operator sbyte(HUIATEXTRANGE value) => (sbyte)(value.Value);

        public static explicit operator HUIATEXTRANGE(ushort value) => new HUIATEXTRANGE((void*)(value));

        public static explicit operator ushort(HUIATEXTRANGE value) => (ushort)(value.Value);

        public static explicit operator HUIATEXTRANGE(uint value) => new HUIATEXTRANGE((void*)(value));

        public static explicit operator uint(HUIATEXTRANGE value) => (uint)(value.Value);

        public static explicit operator HUIATEXTRANGE(ulong value) => new HUIATEXTRANGE((void*)(value));

        public static explicit operator ulong(HUIATEXTRANGE value) => (ulong)(value.Value);

        public static explicit operator HUIATEXTRANGE(nuint value) => new HUIATEXTRANGE((void*)(value));

        public static implicit operator nuint(HUIATEXTRANGE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HUIATEXTRANGE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HUIATEXTRANGE.");
        }

        public int CompareTo(HUIATEXTRANGE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HUIATEXTRANGE other) && Equals(other);

        public bool Equals(HUIATEXTRANGE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
