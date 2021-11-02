// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIFTIMESTAMPCHANGE : IComparable, IComparable<HIFTIMESTAMPCHANGE>, IEquatable<HIFTIMESTAMPCHANGE>, IFormattable
    {
        public readonly nint Value;

        public HIFTIMESTAMPCHANGE(nint value)
        {
            Value = value;
        }

        public static HIFTIMESTAMPCHANGE INVALID_VALUE => new HIFTIMESTAMPCHANGE(-1);

        public static HIFTIMESTAMPCHANGE NULL => new HIFTIMESTAMPCHANGE(0);

        public static bool operator ==(HIFTIMESTAMPCHANGE left, HIFTIMESTAMPCHANGE right) => left.Value == right.Value;

        public static bool operator !=(HIFTIMESTAMPCHANGE left, HIFTIMESTAMPCHANGE right) => left.Value != right.Value;

        public static bool operator <(HIFTIMESTAMPCHANGE left, HIFTIMESTAMPCHANGE right) => left.Value < right.Value;

        public static bool operator <=(HIFTIMESTAMPCHANGE left, HIFTIMESTAMPCHANGE right) => left.Value <= right.Value;

        public static bool operator >(HIFTIMESTAMPCHANGE left, HIFTIMESTAMPCHANGE right) => left.Value > right.Value;

        public static bool operator >=(HIFTIMESTAMPCHANGE left, HIFTIMESTAMPCHANGE right) => left.Value >= right.Value;

        public static explicit operator HIFTIMESTAMPCHANGE(void* value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static implicit operator void*(HIFTIMESTAMPCHANGE value) => (void*)(value.Value);

        public static explicit operator HIFTIMESTAMPCHANGE(HANDLE value) => new HIFTIMESTAMPCHANGE(value);

        public static implicit operator HANDLE(HIFTIMESTAMPCHANGE value) => new HANDLE(value.Value);

        public static explicit operator HIFTIMESTAMPCHANGE(byte value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static explicit operator byte(HIFTIMESTAMPCHANGE value) => (byte)(value.Value);

        public static explicit operator HIFTIMESTAMPCHANGE(short value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static explicit operator short(HIFTIMESTAMPCHANGE value) => (short)(value.Value);

        public static explicit operator HIFTIMESTAMPCHANGE(int value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static explicit operator int(HIFTIMESTAMPCHANGE value) => (int)(value.Value);

        public static explicit operator HIFTIMESTAMPCHANGE(long value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static implicit operator long(HIFTIMESTAMPCHANGE value) => value.Value;

        public static explicit operator HIFTIMESTAMPCHANGE(nint value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static implicit operator nint(HIFTIMESTAMPCHANGE value) => value.Value;

        public static explicit operator HIFTIMESTAMPCHANGE(sbyte value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static explicit operator sbyte(HIFTIMESTAMPCHANGE value) => (sbyte)(value.Value);

        public static explicit operator HIFTIMESTAMPCHANGE(ushort value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static explicit operator ushort(HIFTIMESTAMPCHANGE value) => (ushort)(value.Value);

        public static explicit operator HIFTIMESTAMPCHANGE(uint value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static explicit operator uint(HIFTIMESTAMPCHANGE value) => (uint)(value.Value);

        public static explicit operator HIFTIMESTAMPCHANGE(ulong value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static explicit operator ulong(HIFTIMESTAMPCHANGE value) => (ulong)(value.Value);

        public static explicit operator HIFTIMESTAMPCHANGE(nuint value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static explicit operator nuint(HIFTIMESTAMPCHANGE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HIFTIMESTAMPCHANGE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HIFTIMESTAMPCHANGE.");
        }

        public int CompareTo(HIFTIMESTAMPCHANGE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HIFTIMESTAMPCHANGE other) && Equals(other);

        public bool Equals(HIFTIMESTAMPCHANGE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
