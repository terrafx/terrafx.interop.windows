// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct CIMFS_STREAM_HANDLE : IComparable, IComparable<CIMFS_STREAM_HANDLE>, IEquatable<CIMFS_STREAM_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public CIMFS_STREAM_HANDLE(void* value)
        {
            Value = value;
        }

        public static CIMFS_STREAM_HANDLE INVALID_VALUE => new CIMFS_STREAM_HANDLE((void*)(-1));

        public static CIMFS_STREAM_HANDLE NULL => new CIMFS_STREAM_HANDLE(null);

        public static bool operator ==(CIMFS_STREAM_HANDLE left, CIMFS_STREAM_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(CIMFS_STREAM_HANDLE left, CIMFS_STREAM_HANDLE right) => left.Value != right.Value;

        public static bool operator <(CIMFS_STREAM_HANDLE left, CIMFS_STREAM_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(CIMFS_STREAM_HANDLE left, CIMFS_STREAM_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(CIMFS_STREAM_HANDLE left, CIMFS_STREAM_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(CIMFS_STREAM_HANDLE left, CIMFS_STREAM_HANDLE right) => left.Value >= right.Value;

        public static explicit operator CIMFS_STREAM_HANDLE(void* value) => new CIMFS_STREAM_HANDLE(value);

        public static implicit operator void*(CIMFS_STREAM_HANDLE value) => value.Value;

        public static explicit operator CIMFS_STREAM_HANDLE(HANDLE value) => new CIMFS_STREAM_HANDLE(value);

        public static implicit operator HANDLE(CIMFS_STREAM_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator CIMFS_STREAM_HANDLE(byte value) => new CIMFS_STREAM_HANDLE((void*)(value));

        public static explicit operator byte(CIMFS_STREAM_HANDLE value) => (byte)(value.Value);

        public static explicit operator CIMFS_STREAM_HANDLE(short value) => new CIMFS_STREAM_HANDLE((void*)(value));

        public static explicit operator short(CIMFS_STREAM_HANDLE value) => (short)(value.Value);

        public static explicit operator CIMFS_STREAM_HANDLE(int value) => new CIMFS_STREAM_HANDLE((void*)(value));

        public static explicit operator int(CIMFS_STREAM_HANDLE value) => (int)(value.Value);

        public static explicit operator CIMFS_STREAM_HANDLE(long value) => new CIMFS_STREAM_HANDLE((void*)(value));

        public static explicit operator long(CIMFS_STREAM_HANDLE value) => (long)(value.Value);

        public static explicit operator CIMFS_STREAM_HANDLE(nint value) => new CIMFS_STREAM_HANDLE((void*)(value));

        public static implicit operator nint(CIMFS_STREAM_HANDLE value) => (nint)(value.Value);

        public static explicit operator CIMFS_STREAM_HANDLE(sbyte value) => new CIMFS_STREAM_HANDLE((void*)(value));

        public static explicit operator sbyte(CIMFS_STREAM_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator CIMFS_STREAM_HANDLE(ushort value) => new CIMFS_STREAM_HANDLE((void*)(value));

        public static explicit operator ushort(CIMFS_STREAM_HANDLE value) => (ushort)(value.Value);

        public static explicit operator CIMFS_STREAM_HANDLE(uint value) => new CIMFS_STREAM_HANDLE((void*)(value));

        public static explicit operator uint(CIMFS_STREAM_HANDLE value) => (uint)(value.Value);

        public static explicit operator CIMFS_STREAM_HANDLE(ulong value) => new CIMFS_STREAM_HANDLE((void*)(value));

        public static explicit operator ulong(CIMFS_STREAM_HANDLE value) => (ulong)(value.Value);

        public static explicit operator CIMFS_STREAM_HANDLE(nuint value) => new CIMFS_STREAM_HANDLE((void*)(value));

        public static implicit operator nuint(CIMFS_STREAM_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is CIMFS_STREAM_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of CIMFS_STREAM_HANDLE.");
        }

        public int CompareTo(CIMFS_STREAM_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is CIMFS_STREAM_HANDLE other) && Equals(other);

        public bool Equals(CIMFS_STREAM_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
