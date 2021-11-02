// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSNMP_ENTITY : IComparable, IComparable<HSNMP_ENTITY>, IEquatable<HSNMP_ENTITY>, IFormattable
    {
        public readonly nint Value;

        public HSNMP_ENTITY(nint value)
        {
            Value = value;
        }

        public static HSNMP_ENTITY INVALID_VALUE => new HSNMP_ENTITY(-1);

        public static HSNMP_ENTITY NULL => new HSNMP_ENTITY(0);

        public static bool operator ==(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value == right.Value;

        public static bool operator !=(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value != right.Value;

        public static bool operator <(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value < right.Value;

        public static bool operator <=(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value <= right.Value;

        public static bool operator >(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value > right.Value;

        public static bool operator >=(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value >= right.Value;

        public static explicit operator HSNMP_ENTITY(void* value) => new HSNMP_ENTITY((nint)(value));

        public static implicit operator void*(HSNMP_ENTITY value) => (void*)(value.Value);

        public static explicit operator HSNMP_ENTITY(HANDLE value) => new HSNMP_ENTITY(value);

        public static implicit operator HANDLE(HSNMP_ENTITY value) => new HANDLE(value.Value);

        public static explicit operator HSNMP_ENTITY(byte value) => new HSNMP_ENTITY((nint)(value));

        public static explicit operator byte(HSNMP_ENTITY value) => (byte)(value.Value);

        public static explicit operator HSNMP_ENTITY(short value) => new HSNMP_ENTITY((nint)(value));

        public static explicit operator short(HSNMP_ENTITY value) => (short)(value.Value);

        public static explicit operator HSNMP_ENTITY(int value) => new HSNMP_ENTITY((nint)(value));

        public static explicit operator int(HSNMP_ENTITY value) => (int)(value.Value);

        public static explicit operator HSNMP_ENTITY(long value) => new HSNMP_ENTITY((nint)(value));

        public static implicit operator long(HSNMP_ENTITY value) => value.Value;

        public static explicit operator HSNMP_ENTITY(nint value) => new HSNMP_ENTITY((nint)(value));

        public static implicit operator nint(HSNMP_ENTITY value) => value.Value;

        public static explicit operator HSNMP_ENTITY(sbyte value) => new HSNMP_ENTITY((nint)(value));

        public static explicit operator sbyte(HSNMP_ENTITY value) => (sbyte)(value.Value);

        public static explicit operator HSNMP_ENTITY(ushort value) => new HSNMP_ENTITY((nint)(value));

        public static explicit operator ushort(HSNMP_ENTITY value) => (ushort)(value.Value);

        public static explicit operator HSNMP_ENTITY(uint value) => new HSNMP_ENTITY((nint)(value));

        public static explicit operator uint(HSNMP_ENTITY value) => (uint)(value.Value);

        public static explicit operator HSNMP_ENTITY(ulong value) => new HSNMP_ENTITY((nint)(value));

        public static explicit operator ulong(HSNMP_ENTITY value) => (ulong)(value.Value);

        public static explicit operator HSNMP_ENTITY(nuint value) => new HSNMP_ENTITY((nint)(value));

        public static explicit operator nuint(HSNMP_ENTITY value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HSNMP_ENTITY other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSNMP_ENTITY.");
        }

        public int CompareTo(HSNMP_ENTITY other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HSNMP_ENTITY other) && Equals(other);

        public bool Equals(HSNMP_ENTITY other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
