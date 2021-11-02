// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDSKSPC : IComparable, IComparable<HDSKSPC>, IEquatable<HDSKSPC>, IFormattable
    {
        public readonly nint Value;

        public HDSKSPC(nint value)
        {
            Value = value;
        }

        public static HDSKSPC INVALID_VALUE => new HDSKSPC(-1);

        public static HDSKSPC NULL => new HDSKSPC(0);

        public static bool operator ==(HDSKSPC left, HDSKSPC right) => left.Value == right.Value;

        public static bool operator !=(HDSKSPC left, HDSKSPC right) => left.Value != right.Value;

        public static bool operator <(HDSKSPC left, HDSKSPC right) => left.Value < right.Value;

        public static bool operator <=(HDSKSPC left, HDSKSPC right) => left.Value <= right.Value;

        public static bool operator >(HDSKSPC left, HDSKSPC right) => left.Value > right.Value;

        public static bool operator >=(HDSKSPC left, HDSKSPC right) => left.Value >= right.Value;

        public static explicit operator HDSKSPC(void* value) => new HDSKSPC((nint)(value));

        public static implicit operator void*(HDSKSPC value) => (void*)(value.Value);

        public static explicit operator HDSKSPC(HANDLE value) => new HDSKSPC(value);

        public static implicit operator HANDLE(HDSKSPC value) => new HANDLE(value.Value);

        public static explicit operator HDSKSPC(byte value) => new HDSKSPC((nint)(value));

        public static explicit operator byte(HDSKSPC value) => (byte)(value.Value);

        public static explicit operator HDSKSPC(short value) => new HDSKSPC((nint)(value));

        public static explicit operator short(HDSKSPC value) => (short)(value.Value);

        public static explicit operator HDSKSPC(int value) => new HDSKSPC((nint)(value));

        public static explicit operator int(HDSKSPC value) => (int)(value.Value);

        public static explicit operator HDSKSPC(long value) => new HDSKSPC((nint)(value));

        public static implicit operator long(HDSKSPC value) => value.Value;

        public static explicit operator HDSKSPC(nint value) => new HDSKSPC((nint)(value));

        public static implicit operator nint(HDSKSPC value) => value.Value;

        public static explicit operator HDSKSPC(sbyte value) => new HDSKSPC((nint)(value));

        public static explicit operator sbyte(HDSKSPC value) => (sbyte)(value.Value);

        public static explicit operator HDSKSPC(ushort value) => new HDSKSPC((nint)(value));

        public static explicit operator ushort(HDSKSPC value) => (ushort)(value.Value);

        public static explicit operator HDSKSPC(uint value) => new HDSKSPC((nint)(value));

        public static explicit operator uint(HDSKSPC value) => (uint)(value.Value);

        public static explicit operator HDSKSPC(ulong value) => new HDSKSPC((nint)(value));

        public static explicit operator ulong(HDSKSPC value) => (ulong)(value.Value);

        public static explicit operator HDSKSPC(nuint value) => new HDSKSPC((nint)(value));

        public static explicit operator nuint(HDSKSPC value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDSKSPC other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDSKSPC.");
        }

        public int CompareTo(HDSKSPC other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HDSKSPC other) && Equals(other);

        public bool Equals(HDSKSPC other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
