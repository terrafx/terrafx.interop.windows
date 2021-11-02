// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSNMP_CONTEXT : IComparable, IComparable<HSNMP_CONTEXT>, IEquatable<HSNMP_CONTEXT>, IFormattable
    {
        public readonly nint Value;

        public HSNMP_CONTEXT(nint value)
        {
            Value = value;
        }

        public static HSNMP_CONTEXT INVALID_VALUE => new HSNMP_CONTEXT(-1);

        public static HSNMP_CONTEXT NULL => new HSNMP_CONTEXT(0);

        public static bool operator ==(HSNMP_CONTEXT left, HSNMP_CONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HSNMP_CONTEXT left, HSNMP_CONTEXT right) => left.Value != right.Value;

        public static bool operator <(HSNMP_CONTEXT left, HSNMP_CONTEXT right) => left.Value < right.Value;

        public static bool operator <=(HSNMP_CONTEXT left, HSNMP_CONTEXT right) => left.Value <= right.Value;

        public static bool operator >(HSNMP_CONTEXT left, HSNMP_CONTEXT right) => left.Value > right.Value;

        public static bool operator >=(HSNMP_CONTEXT left, HSNMP_CONTEXT right) => left.Value >= right.Value;

        public static explicit operator HSNMP_CONTEXT(void* value) => new HSNMP_CONTEXT((nint)(value));

        public static implicit operator void*(HSNMP_CONTEXT value) => (void*)(value.Value);

        public static explicit operator HSNMP_CONTEXT(HANDLE value) => new HSNMP_CONTEXT(value);

        public static implicit operator HANDLE(HSNMP_CONTEXT value) => new HANDLE(value.Value);

        public static explicit operator HSNMP_CONTEXT(byte value) => new HSNMP_CONTEXT((nint)(value));

        public static explicit operator byte(HSNMP_CONTEXT value) => (byte)(value.Value);

        public static explicit operator HSNMP_CONTEXT(short value) => new HSNMP_CONTEXT((nint)(value));

        public static explicit operator short(HSNMP_CONTEXT value) => (short)(value.Value);

        public static explicit operator HSNMP_CONTEXT(int value) => new HSNMP_CONTEXT((nint)(value));

        public static explicit operator int(HSNMP_CONTEXT value) => (int)(value.Value);

        public static explicit operator HSNMP_CONTEXT(long value) => new HSNMP_CONTEXT((nint)(value));

        public static implicit operator long(HSNMP_CONTEXT value) => (long)(value.Value);

        public static explicit operator HSNMP_CONTEXT(nint value) => new HSNMP_CONTEXT((nint)(value));

        public static implicit operator nint(HSNMP_CONTEXT value) => (nint)(value.Value);

        public static explicit operator HSNMP_CONTEXT(sbyte value) => new HSNMP_CONTEXT((nint)(value));

        public static explicit operator sbyte(HSNMP_CONTEXT value) => (sbyte)(value.Value);

        public static explicit operator HSNMP_CONTEXT(ushort value) => new HSNMP_CONTEXT((nint)(value));

        public static explicit operator ushort(HSNMP_CONTEXT value) => (ushort)(value.Value);

        public static explicit operator HSNMP_CONTEXT(uint value) => new HSNMP_CONTEXT((nint)(value));

        public static explicit operator uint(HSNMP_CONTEXT value) => (uint)(value.Value);

        public static explicit operator HSNMP_CONTEXT(ulong value) => new HSNMP_CONTEXT((nint)(value));

        public static explicit operator ulong(HSNMP_CONTEXT value) => (ulong)(value.Value);

        public static explicit operator HSNMP_CONTEXT(nuint value) => new HSNMP_CONTEXT((nint)(value));

        public static explicit operator nuint(HSNMP_CONTEXT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HSNMP_CONTEXT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSNMP_CONTEXT.");
        }

        public int CompareTo(HSNMP_CONTEXT other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HSNMP_CONTEXT other) && Equals(other);

        public bool Equals(HSNMP_CONTEXT other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
