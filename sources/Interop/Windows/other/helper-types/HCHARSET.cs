// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCHARSET : IComparable, IComparable<HCHARSET>, IEquatable<HCHARSET>, IFormattable
    {
        public readonly void* Value;

        public HCHARSET(void* value)
        {
            Value = value;
        }

        public static HCHARSET INVALID_VALUE => new HCHARSET((void*)(-1));

        public static HCHARSET NULL => new HCHARSET(null);

        public static bool operator ==(HCHARSET left, HCHARSET right) => left.Value == right.Value;

        public static bool operator !=(HCHARSET left, HCHARSET right) => left.Value != right.Value;

        public static bool operator <(HCHARSET left, HCHARSET right) => left.Value < right.Value;

        public static bool operator <=(HCHARSET left, HCHARSET right) => left.Value <= right.Value;

        public static bool operator >(HCHARSET left, HCHARSET right) => left.Value > right.Value;

        public static bool operator >=(HCHARSET left, HCHARSET right) => left.Value >= right.Value;

        public static explicit operator HCHARSET(void* value) => new HCHARSET(value);

        public static implicit operator void*(HCHARSET value) => value.Value;

        public static explicit operator HCHARSET(HANDLE value) => new HCHARSET(value);

        public static implicit operator HANDLE(HCHARSET value) => new HANDLE(value.Value);

        public static explicit operator HCHARSET(byte value) => new HCHARSET((void*)(value));

        public static explicit operator byte(HCHARSET value) => (byte)(value.Value);

        public static explicit operator HCHARSET(short value) => new HCHARSET((void*)(value));

        public static explicit operator short(HCHARSET value) => (short)(value.Value);

        public static explicit operator HCHARSET(int value) => new HCHARSET((void*)(value));

        public static explicit operator int(HCHARSET value) => (int)(value.Value);

        public static explicit operator HCHARSET(long value) => new HCHARSET((void*)(value));

        public static explicit operator long(HCHARSET value) => (long)(value.Value);

        public static explicit operator HCHARSET(nint value) => new HCHARSET((void*)(value));

        public static implicit operator nint(HCHARSET value) => (nint)(value.Value);

        public static explicit operator HCHARSET(sbyte value) => new HCHARSET((void*)(value));

        public static explicit operator sbyte(HCHARSET value) => (sbyte)(value.Value);

        public static explicit operator HCHARSET(ushort value) => new HCHARSET((void*)(value));

        public static explicit operator ushort(HCHARSET value) => (ushort)(value.Value);

        public static explicit operator HCHARSET(uint value) => new HCHARSET((void*)(value));

        public static explicit operator uint(HCHARSET value) => (uint)(value.Value);

        public static explicit operator HCHARSET(ulong value) => new HCHARSET((void*)(value));

        public static explicit operator ulong(HCHARSET value) => (ulong)(value.Value);

        public static explicit operator HCHARSET(nuint value) => new HCHARSET((void*)(value));

        public static implicit operator nuint(HCHARSET value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCHARSET other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCHARSET.");
        }

        public int CompareTo(HCHARSET other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HCHARSET other) && Equals(other);

        public bool Equals(HCHARSET other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
