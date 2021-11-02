// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUMPD : IComparable, IComparable<HUMPD>, IEquatable<HUMPD>, IFormattable
    {
        public readonly nint Value;

        public HUMPD(nint value)
        {
            Value = value;
        }

        public static HUMPD INVALID_VALUE => new HUMPD(-1);

        public static HUMPD NULL => new HUMPD(0);

        public static bool operator ==(HUMPD left, HUMPD right) => left.Value == right.Value;

        public static bool operator !=(HUMPD left, HUMPD right) => left.Value != right.Value;

        public static bool operator <(HUMPD left, HUMPD right) => left.Value < right.Value;

        public static bool operator <=(HUMPD left, HUMPD right) => left.Value <= right.Value;

        public static bool operator >(HUMPD left, HUMPD right) => left.Value > right.Value;

        public static bool operator >=(HUMPD left, HUMPD right) => left.Value >= right.Value;

        public static explicit operator HUMPD(void* value) => new HUMPD((nint)(value));

        public static implicit operator void*(HUMPD value) => (void*)(value.Value);

        public static explicit operator HUMPD(HANDLE value) => new HUMPD(value);

        public static implicit operator HANDLE(HUMPD value) => new HANDLE(value.Value);

        public static explicit operator HUMPD(byte value) => new HUMPD((nint)(value));

        public static explicit operator byte(HUMPD value) => (byte)(value.Value);

        public static explicit operator HUMPD(short value) => new HUMPD((nint)(value));

        public static explicit operator short(HUMPD value) => (short)(value.Value);

        public static explicit operator HUMPD(int value) => new HUMPD((nint)(value));

        public static explicit operator int(HUMPD value) => (int)(value.Value);

        public static explicit operator HUMPD(long value) => new HUMPD((nint)(value));

        public static implicit operator long(HUMPD value) => value.Value;

        public static explicit operator HUMPD(nint value) => new HUMPD((nint)(value));

        public static implicit operator nint(HUMPD value) => value.Value;

        public static explicit operator HUMPD(sbyte value) => new HUMPD((nint)(value));

        public static explicit operator sbyte(HUMPD value) => (sbyte)(value.Value);

        public static explicit operator HUMPD(ushort value) => new HUMPD((nint)(value));

        public static explicit operator ushort(HUMPD value) => (ushort)(value.Value);

        public static explicit operator HUMPD(uint value) => new HUMPD((nint)(value));

        public static explicit operator uint(HUMPD value) => (uint)(value.Value);

        public static explicit operator HUMPD(ulong value) => new HUMPD((nint)(value));

        public static explicit operator ulong(HUMPD value) => (ulong)(value.Value);

        public static explicit operator HUMPD(nuint value) => new HUMPD((nint)(value));

        public static explicit operator nuint(HUMPD value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HUMPD other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HUMPD.");
        }

        public int CompareTo(HUMPD other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HUMPD other) && Equals(other);

        public bool Equals(HUMPD other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
