// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct NCRYPT_DESCRIPTOR_HANDLE : IComparable, IComparable<NCRYPT_DESCRIPTOR_HANDLE>, IEquatable<NCRYPT_DESCRIPTOR_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public NCRYPT_DESCRIPTOR_HANDLE(void* value)
        {
            Value = value;
        }

        public static NCRYPT_DESCRIPTOR_HANDLE INVALID_VALUE => new NCRYPT_DESCRIPTOR_HANDLE((void*)(-1));

        public static NCRYPT_DESCRIPTOR_HANDLE NULL => new NCRYPT_DESCRIPTOR_HANDLE(null);

        public static bool operator ==(NCRYPT_DESCRIPTOR_HANDLE left, NCRYPT_DESCRIPTOR_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(NCRYPT_DESCRIPTOR_HANDLE left, NCRYPT_DESCRIPTOR_HANDLE right) => left.Value != right.Value;

        public static bool operator <(NCRYPT_DESCRIPTOR_HANDLE left, NCRYPT_DESCRIPTOR_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(NCRYPT_DESCRIPTOR_HANDLE left, NCRYPT_DESCRIPTOR_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(NCRYPT_DESCRIPTOR_HANDLE left, NCRYPT_DESCRIPTOR_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(NCRYPT_DESCRIPTOR_HANDLE left, NCRYPT_DESCRIPTOR_HANDLE right) => left.Value >= right.Value;

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(void* value) => new NCRYPT_DESCRIPTOR_HANDLE(value);

        public static implicit operator void*(NCRYPT_DESCRIPTOR_HANDLE value) => value.Value;

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(HANDLE value) => new NCRYPT_DESCRIPTOR_HANDLE(value);

        public static implicit operator HANDLE(NCRYPT_DESCRIPTOR_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(byte value) => new NCRYPT_DESCRIPTOR_HANDLE((void*)(value));

        public static explicit operator byte(NCRYPT_DESCRIPTOR_HANDLE value) => (byte)(value.Value);

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(short value) => new NCRYPT_DESCRIPTOR_HANDLE((void*)(value));

        public static explicit operator short(NCRYPT_DESCRIPTOR_HANDLE value) => (short)(value.Value);

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(int value) => new NCRYPT_DESCRIPTOR_HANDLE((void*)(value));

        public static explicit operator int(NCRYPT_DESCRIPTOR_HANDLE value) => (int)(value.Value);

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(long value) => new NCRYPT_DESCRIPTOR_HANDLE((void*)(value));

        public static explicit operator long(NCRYPT_DESCRIPTOR_HANDLE value) => (long)(value.Value);

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(nint value) => new NCRYPT_DESCRIPTOR_HANDLE((void*)(value));

        public static implicit operator nint(NCRYPT_DESCRIPTOR_HANDLE value) => (nint)(value.Value);

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(sbyte value) => new NCRYPT_DESCRIPTOR_HANDLE((void*)(value));

        public static explicit operator sbyte(NCRYPT_DESCRIPTOR_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(ushort value) => new NCRYPT_DESCRIPTOR_HANDLE((void*)(value));

        public static explicit operator ushort(NCRYPT_DESCRIPTOR_HANDLE value) => (ushort)(value.Value);

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(uint value) => new NCRYPT_DESCRIPTOR_HANDLE((void*)(value));

        public static explicit operator uint(NCRYPT_DESCRIPTOR_HANDLE value) => (uint)(value.Value);

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(ulong value) => new NCRYPT_DESCRIPTOR_HANDLE((void*)(value));

        public static explicit operator ulong(NCRYPT_DESCRIPTOR_HANDLE value) => (ulong)(value.Value);

        public static explicit operator NCRYPT_DESCRIPTOR_HANDLE(nuint value) => new NCRYPT_DESCRIPTOR_HANDLE((void*)(value));

        public static implicit operator nuint(NCRYPT_DESCRIPTOR_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is NCRYPT_DESCRIPTOR_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of NCRYPT_DESCRIPTOR_HANDLE.");
        }

        public int CompareTo(NCRYPT_DESCRIPTOR_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is NCRYPT_DESCRIPTOR_HANDLE other) && Equals(other);

        public bool Equals(NCRYPT_DESCRIPTOR_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
