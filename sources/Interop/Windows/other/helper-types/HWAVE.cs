// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWAVE : IComparable, IComparable<HWAVE>, IEquatable<HWAVE>, IFormattable
    {
        public readonly nint Value;

        public HWAVE(nint value)
        {
            Value = value;
        }

        public static HWAVE INVALID_VALUE => new HWAVE(-1);

        public static HWAVE NULL => new HWAVE(0);

        public static bool operator ==(HWAVE left, HWAVE right) => left.Value == right.Value;

        public static bool operator !=(HWAVE left, HWAVE right) => left.Value != right.Value;

        public static bool operator <(HWAVE left, HWAVE right) => left.Value < right.Value;

        public static bool operator <=(HWAVE left, HWAVE right) => left.Value <= right.Value;

        public static bool operator >(HWAVE left, HWAVE right) => left.Value > right.Value;

        public static bool operator >=(HWAVE left, HWAVE right) => left.Value >= right.Value;

        public static explicit operator HWAVE(void* value) => new HWAVE((nint)(value));

        public static implicit operator void*(HWAVE value) => (void*)(value.Value);

        public static explicit operator HWAVE(HANDLE value) => new HWAVE(value);

        public static implicit operator HANDLE(HWAVE value) => new HANDLE(value.Value);

        public static explicit operator HWAVE(byte value) => new HWAVE((nint)(value));

        public static explicit operator byte(HWAVE value) => (byte)(value.Value);

        public static explicit operator HWAVE(short value) => new HWAVE((nint)(value));

        public static explicit operator short(HWAVE value) => (short)(value.Value);

        public static explicit operator HWAVE(int value) => new HWAVE((nint)(value));

        public static explicit operator int(HWAVE value) => (int)(value.Value);

        public static explicit operator HWAVE(long value) => new HWAVE((nint)(value));

        public static implicit operator long(HWAVE value) => value.Value;

        public static explicit operator HWAVE(nint value) => new HWAVE((nint)(value));

        public static implicit operator nint(HWAVE value) => value.Value;

        public static explicit operator HWAVE(sbyte value) => new HWAVE((nint)(value));

        public static explicit operator sbyte(HWAVE value) => (sbyte)(value.Value);

        public static explicit operator HWAVE(ushort value) => new HWAVE((nint)(value));

        public static explicit operator ushort(HWAVE value) => (ushort)(value.Value);

        public static explicit operator HWAVE(uint value) => new HWAVE((nint)(value));

        public static explicit operator uint(HWAVE value) => (uint)(value.Value);

        public static explicit operator HWAVE(ulong value) => new HWAVE((nint)(value));

        public static explicit operator ulong(HWAVE value) => (ulong)(value.Value);

        public static explicit operator HWAVE(nuint value) => new HWAVE((nint)(value));

        public static explicit operator nuint(HWAVE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HWAVE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HWAVE.");
        }

        public int CompareTo(HWAVE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HWAVE other) && Equals(other);

        public bool Equals(HWAVE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
