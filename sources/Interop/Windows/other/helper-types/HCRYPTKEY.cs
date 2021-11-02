// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTKEY : IComparable, IComparable<HCRYPTKEY>, IEquatable<HCRYPTKEY>, IFormattable
    {
        public readonly nint Value;

        public HCRYPTKEY(nint value)
        {
            Value = value;
        }

        public static HCRYPTKEY INVALID_VALUE => new HCRYPTKEY(-1);

        public static HCRYPTKEY NULL => new HCRYPTKEY(0);

        public static bool operator ==(HCRYPTKEY left, HCRYPTKEY right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTKEY left, HCRYPTKEY right) => left.Value != right.Value;

        public static bool operator <(HCRYPTKEY left, HCRYPTKEY right) => left.Value < right.Value;

        public static bool operator <=(HCRYPTKEY left, HCRYPTKEY right) => left.Value <= right.Value;

        public static bool operator >(HCRYPTKEY left, HCRYPTKEY right) => left.Value > right.Value;

        public static bool operator >=(HCRYPTKEY left, HCRYPTKEY right) => left.Value >= right.Value;

        public static explicit operator HCRYPTKEY(void* value) => new HCRYPTKEY((nint)(value));

        public static implicit operator void*(HCRYPTKEY value) => (void*)(value.Value);

        public static explicit operator HCRYPTKEY(HANDLE value) => new HCRYPTKEY(value);

        public static implicit operator HANDLE(HCRYPTKEY value) => new HANDLE(value.Value);

        public static explicit operator HCRYPTKEY(byte value) => new HCRYPTKEY((nint)(value));

        public static explicit operator byte(HCRYPTKEY value) => (byte)(value.Value);

        public static explicit operator HCRYPTKEY(short value) => new HCRYPTKEY((nint)(value));

        public static explicit operator short(HCRYPTKEY value) => (short)(value.Value);

        public static explicit operator HCRYPTKEY(int value) => new HCRYPTKEY((nint)(value));

        public static explicit operator int(HCRYPTKEY value) => (int)(value.Value);

        public static explicit operator HCRYPTKEY(long value) => new HCRYPTKEY((nint)(value));

        public static implicit operator long(HCRYPTKEY value) => value.Value;

        public static explicit operator HCRYPTKEY(nint value) => new HCRYPTKEY((nint)(value));

        public static implicit operator nint(HCRYPTKEY value) => value.Value;

        public static explicit operator HCRYPTKEY(sbyte value) => new HCRYPTKEY((nint)(value));

        public static explicit operator sbyte(HCRYPTKEY value) => (sbyte)(value.Value);

        public static explicit operator HCRYPTKEY(ushort value) => new HCRYPTKEY((nint)(value));

        public static explicit operator ushort(HCRYPTKEY value) => (ushort)(value.Value);

        public static explicit operator HCRYPTKEY(uint value) => new HCRYPTKEY((nint)(value));

        public static explicit operator uint(HCRYPTKEY value) => (uint)(value.Value);

        public static explicit operator HCRYPTKEY(ulong value) => new HCRYPTKEY((nint)(value));

        public static explicit operator ulong(HCRYPTKEY value) => (ulong)(value.Value);

        public static explicit operator HCRYPTKEY(nuint value) => new HCRYPTKEY((nint)(value));

        public static explicit operator nuint(HCRYPTKEY value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCRYPTKEY other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCRYPTKEY.");
        }

        public int CompareTo(HCRYPTKEY other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTKEY other) && Equals(other);

        public bool Equals(HCRYPTKEY other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
