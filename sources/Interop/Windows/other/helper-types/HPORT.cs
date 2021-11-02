// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPORT : IComparable, IComparable<HPORT>, IEquatable<HPORT>, IFormattable
    {
        public readonly void* Value;

        public HPORT(void* value)
        {
            Value = value;
        }

        public static HPORT INVALID_VALUE => new HPORT((void*)(-1));

        public static HPORT NULL => new HPORT(null);

        public static bool operator ==(HPORT left, HPORT right) => left.Value == right.Value;

        public static bool operator !=(HPORT left, HPORT right) => left.Value != right.Value;

        public static bool operator <(HPORT left, HPORT right) => left.Value < right.Value;

        public static bool operator <=(HPORT left, HPORT right) => left.Value <= right.Value;

        public static bool operator >(HPORT left, HPORT right) => left.Value > right.Value;

        public static bool operator >=(HPORT left, HPORT right) => left.Value >= right.Value;

        public static explicit operator HPORT(void* value) => new HPORT(value);

        public static implicit operator void*(HPORT value) => value.Value;

        public static explicit operator HPORT(HANDLE value) => new HPORT(value);

        public static implicit operator HANDLE(HPORT value) => new HANDLE(value.Value);

        public static explicit operator HPORT(byte value) => new HPORT((void*)(value));

        public static explicit operator byte(HPORT value) => (byte)(value.Value);

        public static explicit operator HPORT(short value) => new HPORT((void*)(value));

        public static explicit operator short(HPORT value) => (short)(value.Value);

        public static explicit operator HPORT(int value) => new HPORT((void*)(value));

        public static explicit operator int(HPORT value) => (int)(value.Value);

        public static explicit operator HPORT(long value) => new HPORT((void*)(value));

        public static explicit operator long(HPORT value) => (long)(value.Value);

        public static explicit operator HPORT(nint value) => new HPORT((void*)(value));

        public static implicit operator nint(HPORT value) => (nint)(value.Value);

        public static explicit operator HPORT(sbyte value) => new HPORT((void*)(value));

        public static explicit operator sbyte(HPORT value) => (sbyte)(value.Value);

        public static explicit operator HPORT(ushort value) => new HPORT((void*)(value));

        public static explicit operator ushort(HPORT value) => (ushort)(value.Value);

        public static explicit operator HPORT(uint value) => new HPORT((void*)(value));

        public static explicit operator uint(HPORT value) => (uint)(value.Value);

        public static explicit operator HPORT(ulong value) => new HPORT((void*)(value));

        public static explicit operator ulong(HPORT value) => (ulong)(value.Value);

        public static explicit operator HPORT(nuint value) => new HPORT((void*)(value));

        public static implicit operator nuint(HPORT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HPORT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HPORT.");
        }

        public int CompareTo(HPORT other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HPORT other) && Equals(other);

        public bool Equals(HPORT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
