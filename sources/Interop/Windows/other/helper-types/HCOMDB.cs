// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCOMDB : IComparable, IComparable<HCOMDB>, IEquatable<HCOMDB>, IFormattable
    {
        public readonly nint Value;

        public HCOMDB(nint value)
        {
            Value = value;
        }

        public static HCOMDB INVALID_VALUE => new HCOMDB(-1);

        public static HCOMDB NULL => new HCOMDB(0);

        public static bool operator ==(HCOMDB left, HCOMDB right) => left.Value == right.Value;

        public static bool operator !=(HCOMDB left, HCOMDB right) => left.Value != right.Value;

        public static bool operator <(HCOMDB left, HCOMDB right) => left.Value < right.Value;

        public static bool operator <=(HCOMDB left, HCOMDB right) => left.Value <= right.Value;

        public static bool operator >(HCOMDB left, HCOMDB right) => left.Value > right.Value;

        public static bool operator >=(HCOMDB left, HCOMDB right) => left.Value >= right.Value;

        public static explicit operator HCOMDB(void* value) => new HCOMDB((nint)(value));

        public static implicit operator void*(HCOMDB value) => (void*)(value.Value);

        public static explicit operator HCOMDB(HANDLE value) => new HCOMDB(value);

        public static implicit operator HANDLE(HCOMDB value) => new HANDLE(value.Value);

        public static explicit operator HCOMDB(byte value) => new HCOMDB((nint)(value));

        public static explicit operator byte(HCOMDB value) => (byte)(value.Value);

        public static explicit operator HCOMDB(short value) => new HCOMDB((nint)(value));

        public static explicit operator short(HCOMDB value) => (short)(value.Value);

        public static explicit operator HCOMDB(int value) => new HCOMDB((nint)(value));

        public static explicit operator int(HCOMDB value) => (int)(value.Value);

        public static explicit operator HCOMDB(long value) => new HCOMDB((nint)(value));

        public static implicit operator long(HCOMDB value) => value.Value;

        public static explicit operator HCOMDB(nint value) => new HCOMDB((nint)(value));

        public static implicit operator nint(HCOMDB value) => value.Value;

        public static explicit operator HCOMDB(sbyte value) => new HCOMDB((nint)(value));

        public static explicit operator sbyte(HCOMDB value) => (sbyte)(value.Value);

        public static explicit operator HCOMDB(ushort value) => new HCOMDB((nint)(value));

        public static explicit operator ushort(HCOMDB value) => (ushort)(value.Value);

        public static explicit operator HCOMDB(uint value) => new HCOMDB((nint)(value));

        public static explicit operator uint(HCOMDB value) => (uint)(value.Value);

        public static explicit operator HCOMDB(ulong value) => new HCOMDB((nint)(value));

        public static explicit operator ulong(HCOMDB value) => (ulong)(value.Value);

        public static explicit operator HCOMDB(nuint value) => new HCOMDB((nint)(value));

        public static explicit operator nuint(HCOMDB value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCOMDB other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCOMDB.");
        }

        public int CompareTo(HCOMDB other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HCOMDB other) && Equals(other);

        public bool Equals(HCOMDB other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
