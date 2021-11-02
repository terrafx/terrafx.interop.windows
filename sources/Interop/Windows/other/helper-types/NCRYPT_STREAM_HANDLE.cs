// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NCRYPT_STREAM_HANDLE : IComparable, IComparable<NCRYPT_STREAM_HANDLE>, IEquatable<NCRYPT_STREAM_HANDLE>, IFormattable
    {
        public readonly nint Value;

        public NCRYPT_STREAM_HANDLE(nint value)
        {
            Value = value;
        }

        public static NCRYPT_STREAM_HANDLE INVALID_VALUE => new NCRYPT_STREAM_HANDLE(-1);

        public static NCRYPT_STREAM_HANDLE NULL => new NCRYPT_STREAM_HANDLE(0);

        public static bool operator ==(NCRYPT_STREAM_HANDLE left, NCRYPT_STREAM_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(NCRYPT_STREAM_HANDLE left, NCRYPT_STREAM_HANDLE right) => left.Value != right.Value;

        public static bool operator <(NCRYPT_STREAM_HANDLE left, NCRYPT_STREAM_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(NCRYPT_STREAM_HANDLE left, NCRYPT_STREAM_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(NCRYPT_STREAM_HANDLE left, NCRYPT_STREAM_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(NCRYPT_STREAM_HANDLE left, NCRYPT_STREAM_HANDLE right) => left.Value >= right.Value;

        public static explicit operator NCRYPT_STREAM_HANDLE(void* value) => new NCRYPT_STREAM_HANDLE((nint)(value));

        public static implicit operator void*(NCRYPT_STREAM_HANDLE value) => (void*)(value.Value);

        public static explicit operator NCRYPT_STREAM_HANDLE(HANDLE value) => new NCRYPT_STREAM_HANDLE(value);

        public static implicit operator HANDLE(NCRYPT_STREAM_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator NCRYPT_STREAM_HANDLE(byte value) => new NCRYPT_STREAM_HANDLE((nint)(value));

        public static explicit operator byte(NCRYPT_STREAM_HANDLE value) => (byte)(value.Value);

        public static explicit operator NCRYPT_STREAM_HANDLE(short value) => new NCRYPT_STREAM_HANDLE((nint)(value));

        public static explicit operator short(NCRYPT_STREAM_HANDLE value) => (short)(value.Value);

        public static explicit operator NCRYPT_STREAM_HANDLE(int value) => new NCRYPT_STREAM_HANDLE((nint)(value));

        public static explicit operator int(NCRYPT_STREAM_HANDLE value) => (int)(value.Value);

        public static explicit operator NCRYPT_STREAM_HANDLE(long value) => new NCRYPT_STREAM_HANDLE((nint)(value));

        public static implicit operator long(NCRYPT_STREAM_HANDLE value) => value.Value;

        public static explicit operator NCRYPT_STREAM_HANDLE(nint value) => new NCRYPT_STREAM_HANDLE((nint)(value));

        public static implicit operator nint(NCRYPT_STREAM_HANDLE value) => value.Value;

        public static explicit operator NCRYPT_STREAM_HANDLE(sbyte value) => new NCRYPT_STREAM_HANDLE((nint)(value));

        public static explicit operator sbyte(NCRYPT_STREAM_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator NCRYPT_STREAM_HANDLE(ushort value) => new NCRYPT_STREAM_HANDLE((nint)(value));

        public static explicit operator ushort(NCRYPT_STREAM_HANDLE value) => (ushort)(value.Value);

        public static explicit operator NCRYPT_STREAM_HANDLE(uint value) => new NCRYPT_STREAM_HANDLE((nint)(value));

        public static explicit operator uint(NCRYPT_STREAM_HANDLE value) => (uint)(value.Value);

        public static explicit operator NCRYPT_STREAM_HANDLE(ulong value) => new NCRYPT_STREAM_HANDLE((nint)(value));

        public static explicit operator ulong(NCRYPT_STREAM_HANDLE value) => (ulong)(value.Value);

        public static explicit operator NCRYPT_STREAM_HANDLE(nuint value) => new NCRYPT_STREAM_HANDLE((nint)(value));

        public static explicit operator nuint(NCRYPT_STREAM_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is NCRYPT_STREAM_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of NCRYPT_STREAM_HANDLE.");
        }

        public int CompareTo(NCRYPT_STREAM_HANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is NCRYPT_STREAM_HANDLE other) && Equals(other);

        public bool Equals(NCRYPT_STREAM_HANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
