// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HADDRESS : IComparable, IComparable<HADDRESS>, IEquatable<HADDRESS>, IFormattable
    {
        public readonly nint Value;

        public HADDRESS(nint value)
        {
            Value = value;
        }

        public static HADDRESS INVALID_VALUE => new HADDRESS(-1);

        public static HADDRESS NULL => new HADDRESS(0);

        public static bool operator ==(HADDRESS left, HADDRESS right) => left.Value == right.Value;

        public static bool operator !=(HADDRESS left, HADDRESS right) => left.Value != right.Value;

        public static bool operator <(HADDRESS left, HADDRESS right) => left.Value < right.Value;

        public static bool operator <=(HADDRESS left, HADDRESS right) => left.Value <= right.Value;

        public static bool operator >(HADDRESS left, HADDRESS right) => left.Value > right.Value;

        public static bool operator >=(HADDRESS left, HADDRESS right) => left.Value >= right.Value;

        public static explicit operator HADDRESS(void* value) => new HADDRESS((nint)(value));

        public static implicit operator void*(HADDRESS value) => (void*)(value.Value);

        public static explicit operator HADDRESS(HANDLE value) => new HADDRESS(value);

        public static implicit operator HANDLE(HADDRESS value) => new HANDLE(value.Value);

        public static explicit operator HADDRESS(byte value) => new HADDRESS((nint)(value));

        public static explicit operator byte(HADDRESS value) => (byte)(value.Value);

        public static explicit operator HADDRESS(short value) => new HADDRESS((nint)(value));

        public static explicit operator short(HADDRESS value) => (short)(value.Value);

        public static explicit operator HADDRESS(int value) => new HADDRESS((nint)(value));

        public static explicit operator int(HADDRESS value) => (int)(value.Value);

        public static explicit operator HADDRESS(long value) => new HADDRESS((nint)(value));

        public static implicit operator long(HADDRESS value) => value.Value;

        public static explicit operator HADDRESS(nint value) => new HADDRESS((nint)(value));

        public static implicit operator nint(HADDRESS value) => value.Value;

        public static explicit operator HADDRESS(sbyte value) => new HADDRESS((nint)(value));

        public static explicit operator sbyte(HADDRESS value) => (sbyte)(value.Value);

        public static explicit operator HADDRESS(ushort value) => new HADDRESS((nint)(value));

        public static explicit operator ushort(HADDRESS value) => (ushort)(value.Value);

        public static explicit operator HADDRESS(uint value) => new HADDRESS((nint)(value));

        public static explicit operator uint(HADDRESS value) => (uint)(value.Value);

        public static explicit operator HADDRESS(ulong value) => new HADDRESS((nint)(value));

        public static explicit operator ulong(HADDRESS value) => (ulong)(value.Value);

        public static explicit operator HADDRESS(nuint value) => new HADDRESS((nint)(value));

        public static explicit operator nuint(HADDRESS value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HADDRESS other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HADDRESS.");
        }

        public int CompareTo(HADDRESS other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HADDRESS other) && Equals(other);

        public bool Equals(HADDRESS other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
