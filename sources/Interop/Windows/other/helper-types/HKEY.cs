// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HKEY : IComparable, IComparable<HKEY>, IEquatable<HKEY>, IFormattable
    {
        public readonly nint Value;

        public HKEY(nint value)
        {
            Value = value;
        }

        public static HKEY INVALID_VALUE => new HKEY(-1);

        public static HKEY NULL => new HKEY(0);

        public static bool operator ==(HKEY left, HKEY right) => left.Value == right.Value;

        public static bool operator !=(HKEY left, HKEY right) => left.Value != right.Value;

        public static bool operator <(HKEY left, HKEY right) => left.Value < right.Value;

        public static bool operator <=(HKEY left, HKEY right) => left.Value <= right.Value;

        public static bool operator >(HKEY left, HKEY right) => left.Value > right.Value;

        public static bool operator >=(HKEY left, HKEY right) => left.Value >= right.Value;

        public static explicit operator HKEY(void* value) => new HKEY((nint)(value));

        public static implicit operator void*(HKEY value) => (void*)(value.Value);

        public static explicit operator HKEY(HANDLE value) => new HKEY(value);

        public static implicit operator HANDLE(HKEY value) => new HANDLE(value.Value);

        public static explicit operator HKEY(byte value) => new HKEY((nint)(value));

        public static explicit operator byte(HKEY value) => (byte)(value.Value);

        public static explicit operator HKEY(short value) => new HKEY((nint)(value));

        public static explicit operator short(HKEY value) => (short)(value.Value);

        public static explicit operator HKEY(int value) => new HKEY((nint)(value));

        public static explicit operator int(HKEY value) => (int)(value.Value);

        public static explicit operator HKEY(long value) => new HKEY((nint)(value));

        public static implicit operator long(HKEY value) => value.Value;

        public static explicit operator HKEY(nint value) => new HKEY((nint)(value));

        public static implicit operator nint(HKEY value) => value.Value;

        public static explicit operator HKEY(sbyte value) => new HKEY((nint)(value));

        public static explicit operator sbyte(HKEY value) => (sbyte)(value.Value);

        public static explicit operator HKEY(ushort value) => new HKEY((nint)(value));

        public static explicit operator ushort(HKEY value) => (ushort)(value.Value);

        public static explicit operator HKEY(uint value) => new HKEY((nint)(value));

        public static explicit operator uint(HKEY value) => (uint)(value.Value);

        public static explicit operator HKEY(ulong value) => new HKEY((nint)(value));

        public static explicit operator ulong(HKEY value) => (ulong)(value.Value);

        public static explicit operator HKEY(nuint value) => new HKEY((nint)(value));

        public static explicit operator nuint(HKEY value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HKEY other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HKEY.");
        }

        public int CompareTo(HKEY other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HKEY other) && Equals(other);

        public bool Equals(HKEY other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
