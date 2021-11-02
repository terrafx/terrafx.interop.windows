// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MSIHANDLE : IComparable, IComparable<MSIHANDLE>, IEquatable<MSIHANDLE>, IFormattable
    {
        public readonly uint Value;

        public MSIHANDLE(uint value)
        {
            Value = value;
        }

        public static bool operator ==(MSIHANDLE left, MSIHANDLE right) => left.Value == right.Value;

        public static bool operator !=(MSIHANDLE left, MSIHANDLE right) => left.Value != right.Value;

        public static bool operator <(MSIHANDLE left, MSIHANDLE right) => left.Value < right.Value;

        public static bool operator <=(MSIHANDLE left, MSIHANDLE right) => left.Value <= right.Value;

        public static bool operator >(MSIHANDLE left, MSIHANDLE right) => left.Value > right.Value;

        public static bool operator >=(MSIHANDLE left, MSIHANDLE right) => left.Value >= right.Value;

        public static implicit operator MSIHANDLE(byte value) => new MSIHANDLE((uint)(value));

        public static explicit operator byte(MSIHANDLE value) => (byte)(value.Value);

        public static explicit operator MSIHANDLE(short value) => new MSIHANDLE((uint)(value));

        public static explicit operator short(MSIHANDLE value) => (short)(value.Value);

        public static explicit operator MSIHANDLE(int value) => new MSIHANDLE((uint)(value));

        public static explicit operator int(MSIHANDLE value) => (int)(value.Value);

        public static explicit operator MSIHANDLE(long value) => new MSIHANDLE((uint)(value));

        public static implicit operator long(MSIHANDLE value) => (long)(value.Value);

        public static explicit operator MSIHANDLE(nint value) => new MSIHANDLE((uint)(value));

        public static explicit operator nint(MSIHANDLE value) => (nint)(value.Value);

        public static explicit operator MSIHANDLE(sbyte value) => new MSIHANDLE((uint)(value));

        public static explicit operator sbyte(MSIHANDLE value) => (sbyte)(value.Value);

        public static implicit operator MSIHANDLE(ushort value) => new MSIHANDLE((uint)(value));

        public static explicit operator ushort(MSIHANDLE value) => (ushort)(value.Value);

        public static implicit operator MSIHANDLE(uint value) => new MSIHANDLE((uint)(value));

        public static implicit operator uint(MSIHANDLE value) => (uint)(value.Value);

        public static explicit operator MSIHANDLE(ulong value) => new MSIHANDLE((uint)(value));

        public static implicit operator ulong(MSIHANDLE value) => (ulong)(value.Value);

        public static explicit operator MSIHANDLE(nuint value) => new MSIHANDLE((uint)(value));

        public static implicit operator nuint(MSIHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is MSIHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of MSIHANDLE.");
        }

        public int CompareTo(MSIHANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is MSIHANDLE other) && Equals(other);

        public bool Equals(MSIHANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString("X8");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
