// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSNMP_PDU : IComparable, IComparable<HSNMP_PDU>, IEquatable<HSNMP_PDU>, IFormattable
    {
        public readonly void* Value;

        public HSNMP_PDU(void* value)
        {
            Value = value;
        }

        public static HSNMP_PDU INVALID_VALUE => new HSNMP_PDU((void*)(-1));

        public static HSNMP_PDU NULL => new HSNMP_PDU(null);

        public static bool operator ==(HSNMP_PDU left, HSNMP_PDU right) => left.Value == right.Value;

        public static bool operator !=(HSNMP_PDU left, HSNMP_PDU right) => left.Value != right.Value;

        public static bool operator <(HSNMP_PDU left, HSNMP_PDU right) => left.Value < right.Value;

        public static bool operator <=(HSNMP_PDU left, HSNMP_PDU right) => left.Value <= right.Value;

        public static bool operator >(HSNMP_PDU left, HSNMP_PDU right) => left.Value > right.Value;

        public static bool operator >=(HSNMP_PDU left, HSNMP_PDU right) => left.Value >= right.Value;

        public static explicit operator HSNMP_PDU(void* value) => new HSNMP_PDU(value);

        public static implicit operator void*(HSNMP_PDU value) => value.Value;

        public static explicit operator HSNMP_PDU(HANDLE value) => new HSNMP_PDU(value);

        public static implicit operator HANDLE(HSNMP_PDU value) => new HANDLE(value.Value);

        public static explicit operator HSNMP_PDU(byte value) => new HSNMP_PDU((void*)(value));

        public static explicit operator byte(HSNMP_PDU value) => (byte)(value.Value);

        public static explicit operator HSNMP_PDU(short value) => new HSNMP_PDU((void*)(value));

        public static explicit operator short(HSNMP_PDU value) => (short)(value.Value);

        public static explicit operator HSNMP_PDU(int value) => new HSNMP_PDU((void*)(value));

        public static explicit operator int(HSNMP_PDU value) => (int)(value.Value);

        public static explicit operator HSNMP_PDU(long value) => new HSNMP_PDU((void*)(value));

        public static explicit operator long(HSNMP_PDU value) => (long)(value.Value);

        public static explicit operator HSNMP_PDU(nint value) => new HSNMP_PDU((void*)(value));

        public static implicit operator nint(HSNMP_PDU value) => (nint)(value.Value);

        public static explicit operator HSNMP_PDU(sbyte value) => new HSNMP_PDU((void*)(value));

        public static explicit operator sbyte(HSNMP_PDU value) => (sbyte)(value.Value);

        public static explicit operator HSNMP_PDU(ushort value) => new HSNMP_PDU((void*)(value));

        public static explicit operator ushort(HSNMP_PDU value) => (ushort)(value.Value);

        public static explicit operator HSNMP_PDU(uint value) => new HSNMP_PDU((void*)(value));

        public static explicit operator uint(HSNMP_PDU value) => (uint)(value.Value);

        public static explicit operator HSNMP_PDU(ulong value) => new HSNMP_PDU((void*)(value));

        public static explicit operator ulong(HSNMP_PDU value) => (ulong)(value.Value);

        public static explicit operator HSNMP_PDU(nuint value) => new HSNMP_PDU((void*)(value));

        public static implicit operator nuint(HSNMP_PDU value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HSNMP_PDU other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSNMP_PDU.");
        }

        public int CompareTo(HSNMP_PDU other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HSNMP_PDU other) && Equals(other);

        public bool Equals(HSNMP_PDU other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
