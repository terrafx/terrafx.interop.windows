// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCONV : IComparable, IComparable<HCONV>, IEquatable<HCONV>, IFormattable
    {
        public readonly void* Value;

        public HCONV(void* value)
        {
            Value = value;
        }

        public static HCONV INVALID_VALUE => new HCONV((void*)(-1));

        public static HCONV NULL => new HCONV(null);

        public static bool operator ==(HCONV left, HCONV right) => left.Value == right.Value;

        public static bool operator !=(HCONV left, HCONV right) => left.Value != right.Value;

        public static bool operator <(HCONV left, HCONV right) => left.Value < right.Value;

        public static bool operator <=(HCONV left, HCONV right) => left.Value <= right.Value;

        public static bool operator >(HCONV left, HCONV right) => left.Value > right.Value;

        public static bool operator >=(HCONV left, HCONV right) => left.Value >= right.Value;

        public static explicit operator HCONV(void* value) => new HCONV(value);

        public static implicit operator void*(HCONV value) => value.Value;

        public static explicit operator HCONV(HANDLE value) => new HCONV(value);

        public static implicit operator HANDLE(HCONV value) => new HANDLE(value.Value);

        public static explicit operator HCONV(byte value) => new HCONV((void*)(value));

        public static explicit operator byte(HCONV value) => (byte)(value.Value);

        public static explicit operator HCONV(short value) => new HCONV((void*)(value));

        public static explicit operator short(HCONV value) => (short)(value.Value);

        public static explicit operator HCONV(int value) => new HCONV((void*)(value));

        public static explicit operator int(HCONV value) => (int)(value.Value);

        public static explicit operator HCONV(long value) => new HCONV((void*)(value));

        public static explicit operator long(HCONV value) => (long)(value.Value);

        public static explicit operator HCONV(nint value) => new HCONV((void*)(value));

        public static implicit operator nint(HCONV value) => (nint)(value.Value);

        public static explicit operator HCONV(sbyte value) => new HCONV((void*)(value));

        public static explicit operator sbyte(HCONV value) => (sbyte)(value.Value);

        public static explicit operator HCONV(ushort value) => new HCONV((void*)(value));

        public static explicit operator ushort(HCONV value) => (ushort)(value.Value);

        public static explicit operator HCONV(uint value) => new HCONV((void*)(value));

        public static explicit operator uint(HCONV value) => (uint)(value.Value);

        public static explicit operator HCONV(ulong value) => new HCONV((void*)(value));

        public static explicit operator ulong(HCONV value) => (ulong)(value.Value);

        public static explicit operator HCONV(nuint value) => new HCONV((void*)(value));

        public static implicit operator nuint(HCONV value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCONV other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCONV.");
        }

        public int CompareTo(HCONV other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HCONV other) && Equals(other);

        public bool Equals(HCONV other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
