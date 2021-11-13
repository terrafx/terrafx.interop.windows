// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HEMF : IComparable, IComparable<HEMF>, IEquatable<HEMF>, IFormattable
    {
        public readonly void* Value;

        public HEMF(void* value)
        {
            Value = value;
        }

        public static HEMF INVALID_VALUE => new HEMF((void*)(-1));

        public static HEMF NULL => new HEMF(null);

        public static bool operator ==(HEMF left, HEMF right) => left.Value == right.Value;

        public static bool operator !=(HEMF left, HEMF right) => left.Value != right.Value;

        public static bool operator <(HEMF left, HEMF right) => left.Value < right.Value;

        public static bool operator <=(HEMF left, HEMF right) => left.Value <= right.Value;

        public static bool operator >(HEMF left, HEMF right) => left.Value > right.Value;

        public static bool operator >=(HEMF left, HEMF right) => left.Value >= right.Value;

        public static explicit operator HEMF(void* value) => new HEMF(value);

        public static implicit operator void*(HEMF value) => value.Value;

        public static explicit operator HEMF(HANDLE value) => new HEMF(value);

        public static implicit operator HANDLE(HEMF value) => new HANDLE(value.Value);

        public static explicit operator HEMF(byte value) => new HEMF((void*)(value));

        public static explicit operator byte(HEMF value) => (byte)(value.Value);

        public static explicit operator HEMF(short value) => new HEMF((void*)(value));

        public static explicit operator short(HEMF value) => (short)(value.Value);

        public static explicit operator HEMF(int value) => new HEMF((void*)(value));

        public static explicit operator int(HEMF value) => (int)(value.Value);

        public static explicit operator HEMF(long value) => new HEMF((void*)(value));

        public static explicit operator long(HEMF value) => (long)(value.Value);

        public static explicit operator HEMF(nint value) => new HEMF((void*)(value));

        public static implicit operator nint(HEMF value) => (nint)(value.Value);

        public static explicit operator HEMF(sbyte value) => new HEMF((void*)(value));

        public static explicit operator sbyte(HEMF value) => (sbyte)(value.Value);

        public static explicit operator HEMF(ushort value) => new HEMF((void*)(value));

        public static explicit operator ushort(HEMF value) => (ushort)(value.Value);

        public static explicit operator HEMF(uint value) => new HEMF((void*)(value));

        public static explicit operator uint(HEMF value) => (uint)(value.Value);

        public static explicit operator HEMF(ulong value) => new HEMF((void*)(value));

        public static explicit operator ulong(HEMF value) => (ulong)(value.Value);

        public static explicit operator HEMF(nuint value) => new HEMF((void*)(value));

        public static implicit operator nuint(HEMF value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HEMF other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HEMF.");
        }

        public int CompareTo(HEMF other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HEMF other) && Equals(other);

        public bool Equals(HEMF other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
