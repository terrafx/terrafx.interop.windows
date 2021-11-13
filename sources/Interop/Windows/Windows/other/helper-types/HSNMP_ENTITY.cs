// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HSNMP_ENTITY : IComparable, IComparable<HSNMP_ENTITY>, IEquatable<HSNMP_ENTITY>, IFormattable
    {
        public readonly void* Value;

        public HSNMP_ENTITY(void* value)
        {
            Value = value;
        }

        public static HSNMP_ENTITY INVALID_VALUE => new HSNMP_ENTITY((void*)(-1));

        public static HSNMP_ENTITY NULL => new HSNMP_ENTITY(null);

        public static bool operator ==(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value == right.Value;

        public static bool operator !=(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value != right.Value;

        public static bool operator <(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value < right.Value;

        public static bool operator <=(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value <= right.Value;

        public static bool operator >(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value > right.Value;

        public static bool operator >=(HSNMP_ENTITY left, HSNMP_ENTITY right) => left.Value >= right.Value;

        public static explicit operator HSNMP_ENTITY(void* value) => new HSNMP_ENTITY(value);

        public static implicit operator void*(HSNMP_ENTITY value) => value.Value;

        public static explicit operator HSNMP_ENTITY(HANDLE value) => new HSNMP_ENTITY(value);

        public static implicit operator HANDLE(HSNMP_ENTITY value) => new HANDLE(value.Value);

        public static explicit operator HSNMP_ENTITY(byte value) => new HSNMP_ENTITY((void*)(value));

        public static explicit operator byte(HSNMP_ENTITY value) => (byte)(value.Value);

        public static explicit operator HSNMP_ENTITY(short value) => new HSNMP_ENTITY((void*)(value));

        public static explicit operator short(HSNMP_ENTITY value) => (short)(value.Value);

        public static explicit operator HSNMP_ENTITY(int value) => new HSNMP_ENTITY((void*)(value));

        public static explicit operator int(HSNMP_ENTITY value) => (int)(value.Value);

        public static explicit operator HSNMP_ENTITY(long value) => new HSNMP_ENTITY((void*)(value));

        public static explicit operator long(HSNMP_ENTITY value) => (long)(value.Value);

        public static explicit operator HSNMP_ENTITY(nint value) => new HSNMP_ENTITY((void*)(value));

        public static implicit operator nint(HSNMP_ENTITY value) => (nint)(value.Value);

        public static explicit operator HSNMP_ENTITY(sbyte value) => new HSNMP_ENTITY((void*)(value));

        public static explicit operator sbyte(HSNMP_ENTITY value) => (sbyte)(value.Value);

        public static explicit operator HSNMP_ENTITY(ushort value) => new HSNMP_ENTITY((void*)(value));

        public static explicit operator ushort(HSNMP_ENTITY value) => (ushort)(value.Value);

        public static explicit operator HSNMP_ENTITY(uint value) => new HSNMP_ENTITY((void*)(value));

        public static explicit operator uint(HSNMP_ENTITY value) => (uint)(value.Value);

        public static explicit operator HSNMP_ENTITY(ulong value) => new HSNMP_ENTITY((void*)(value));

        public static explicit operator ulong(HSNMP_ENTITY value) => (ulong)(value.Value);

        public static explicit operator HSNMP_ENTITY(nuint value) => new HSNMP_ENTITY((void*)(value));

        public static implicit operator nuint(HSNMP_ENTITY value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HSNMP_ENTITY other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSNMP_ENTITY.");
        }

        public int CompareTo(HSNMP_ENTITY other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HSNMP_ENTITY other) && Equals(other);

        public bool Equals(HSNMP_ENTITY other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
