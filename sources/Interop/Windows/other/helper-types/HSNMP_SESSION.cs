// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSNMP_SESSION : IComparable, IComparable<HSNMP_SESSION>, IEquatable<HSNMP_SESSION>, IFormattable
    {
        public readonly nint Value;

        public HSNMP_SESSION(nint value)
        {
            Value = value;
        }

        public static HSNMP_SESSION INVALID_VALUE => new HSNMP_SESSION(-1);

        public static HSNMP_SESSION NULL => new HSNMP_SESSION(0);

        public static bool operator ==(HSNMP_SESSION left, HSNMP_SESSION right) => left.Value == right.Value;

        public static bool operator !=(HSNMP_SESSION left, HSNMP_SESSION right) => left.Value != right.Value;

        public static bool operator <(HSNMP_SESSION left, HSNMP_SESSION right) => left.Value < right.Value;

        public static bool operator <=(HSNMP_SESSION left, HSNMP_SESSION right) => left.Value <= right.Value;

        public static bool operator >(HSNMP_SESSION left, HSNMP_SESSION right) => left.Value > right.Value;

        public static bool operator >=(HSNMP_SESSION left, HSNMP_SESSION right) => left.Value >= right.Value;

        public static explicit operator HSNMP_SESSION(void* value) => new HSNMP_SESSION((nint)(value));

        public static implicit operator void*(HSNMP_SESSION value) => (void*)(value.Value);

        public static explicit operator HSNMP_SESSION(HANDLE value) => new HSNMP_SESSION(value);

        public static implicit operator HANDLE(HSNMP_SESSION value) => new HANDLE(value.Value);

        public static explicit operator HSNMP_SESSION(byte value) => new HSNMP_SESSION((nint)(value));

        public static explicit operator byte(HSNMP_SESSION value) => (byte)(value.Value);

        public static explicit operator HSNMP_SESSION(short value) => new HSNMP_SESSION((nint)(value));

        public static explicit operator short(HSNMP_SESSION value) => (short)(value.Value);

        public static explicit operator HSNMP_SESSION(int value) => new HSNMP_SESSION((nint)(value));

        public static explicit operator int(HSNMP_SESSION value) => (int)(value.Value);

        public static explicit operator HSNMP_SESSION(long value) => new HSNMP_SESSION((nint)(value));

        public static implicit operator long(HSNMP_SESSION value) => (long)(value.Value);

        public static explicit operator HSNMP_SESSION(nint value) => new HSNMP_SESSION((nint)(value));

        public static implicit operator nint(HSNMP_SESSION value) => (nint)(value.Value);

        public static explicit operator HSNMP_SESSION(sbyte value) => new HSNMP_SESSION((nint)(value));

        public static explicit operator sbyte(HSNMP_SESSION value) => (sbyte)(value.Value);

        public static explicit operator HSNMP_SESSION(ushort value) => new HSNMP_SESSION((nint)(value));

        public static explicit operator ushort(HSNMP_SESSION value) => (ushort)(value.Value);

        public static explicit operator HSNMP_SESSION(uint value) => new HSNMP_SESSION((nint)(value));

        public static explicit operator uint(HSNMP_SESSION value) => (uint)(value.Value);

        public static explicit operator HSNMP_SESSION(ulong value) => new HSNMP_SESSION((nint)(value));

        public static explicit operator ulong(HSNMP_SESSION value) => (ulong)(value.Value);

        public static explicit operator HSNMP_SESSION(nuint value) => new HSNMP_SESSION((nint)(value));

        public static explicit operator nuint(HSNMP_SESSION value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HSNMP_SESSION other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSNMP_SESSION.");
        }

        public int CompareTo(HSNMP_SESSION other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HSNMP_SESSION other) && Equals(other);

        public bool Equals(HSNMP_SESSION other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
