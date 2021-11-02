// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSYNTHETICPOINTERDEVICE : IComparable, IComparable<HSYNTHETICPOINTERDEVICE>, IEquatable<HSYNTHETICPOINTERDEVICE>, IFormattable
    {
        public readonly nint Value;

        public HSYNTHETICPOINTERDEVICE(nint value)
        {
            Value = value;
        }

        public static HSYNTHETICPOINTERDEVICE INVALID_VALUE => new HSYNTHETICPOINTERDEVICE(-1);

        public static HSYNTHETICPOINTERDEVICE NULL => new HSYNTHETICPOINTERDEVICE(0);

        public static bool operator ==(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) => left.Value == right.Value;

        public static bool operator !=(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) => left.Value != right.Value;

        public static bool operator <(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) => left.Value < right.Value;

        public static bool operator <=(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) => left.Value <= right.Value;

        public static bool operator >(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) => left.Value > right.Value;

        public static bool operator >=(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) => left.Value >= right.Value;

        public static explicit operator HSYNTHETICPOINTERDEVICE(void* value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static implicit operator void*(HSYNTHETICPOINTERDEVICE value) => (void*)(value.Value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(HANDLE value) => new HSYNTHETICPOINTERDEVICE(value);

        public static implicit operator HANDLE(HSYNTHETICPOINTERDEVICE value) => new HANDLE(value.Value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(byte value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static explicit operator byte(HSYNTHETICPOINTERDEVICE value) => (byte)(value.Value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(short value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static explicit operator short(HSYNTHETICPOINTERDEVICE value) => (short)(value.Value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(int value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static explicit operator int(HSYNTHETICPOINTERDEVICE value) => (int)(value.Value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(long value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static implicit operator long(HSYNTHETICPOINTERDEVICE value) => value.Value;

        public static explicit operator HSYNTHETICPOINTERDEVICE(nint value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static implicit operator nint(HSYNTHETICPOINTERDEVICE value) => value.Value;

        public static explicit operator HSYNTHETICPOINTERDEVICE(sbyte value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static explicit operator sbyte(HSYNTHETICPOINTERDEVICE value) => (sbyte)(value.Value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(ushort value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static explicit operator ushort(HSYNTHETICPOINTERDEVICE value) => (ushort)(value.Value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(uint value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static explicit operator uint(HSYNTHETICPOINTERDEVICE value) => (uint)(value.Value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(ulong value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static explicit operator ulong(HSYNTHETICPOINTERDEVICE value) => (ulong)(value.Value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(nuint value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static explicit operator nuint(HSYNTHETICPOINTERDEVICE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HSYNTHETICPOINTERDEVICE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSYNTHETICPOINTERDEVICE.");
        }

        public int CompareTo(HSYNTHETICPOINTERDEVICE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HSYNTHETICPOINTERDEVICE other) && Equals(other);

        public bool Equals(HSYNTHETICPOINTERDEVICE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
