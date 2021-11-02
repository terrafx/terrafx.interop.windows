// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MPR_SERVER_HANDLE : IComparable, IComparable<MPR_SERVER_HANDLE>, IEquatable<MPR_SERVER_HANDLE>, IFormattable
    {
        public readonly nint Value;

        public MPR_SERVER_HANDLE(nint value)
        {
            Value = value;
        }

        public static MPR_SERVER_HANDLE INVALID_VALUE => new MPR_SERVER_HANDLE(-1);

        public static MPR_SERVER_HANDLE NULL => new MPR_SERVER_HANDLE(0);

        public static bool operator ==(MPR_SERVER_HANDLE left, MPR_SERVER_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(MPR_SERVER_HANDLE left, MPR_SERVER_HANDLE right) => left.Value != right.Value;

        public static bool operator <(MPR_SERVER_HANDLE left, MPR_SERVER_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(MPR_SERVER_HANDLE left, MPR_SERVER_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(MPR_SERVER_HANDLE left, MPR_SERVER_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(MPR_SERVER_HANDLE left, MPR_SERVER_HANDLE right) => left.Value >= right.Value;

        public static explicit operator MPR_SERVER_HANDLE(void* value) => new MPR_SERVER_HANDLE((nint)(value));

        public static implicit operator void*(MPR_SERVER_HANDLE value) => (void*)(value.Value);

        public static explicit operator MPR_SERVER_HANDLE(HANDLE value) => new MPR_SERVER_HANDLE(value);

        public static implicit operator HANDLE(MPR_SERVER_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator MPR_SERVER_HANDLE(byte value) => new MPR_SERVER_HANDLE((nint)(value));

        public static explicit operator byte(MPR_SERVER_HANDLE value) => (byte)(value.Value);

        public static explicit operator MPR_SERVER_HANDLE(short value) => new MPR_SERVER_HANDLE((nint)(value));

        public static explicit operator short(MPR_SERVER_HANDLE value) => (short)(value.Value);

        public static explicit operator MPR_SERVER_HANDLE(int value) => new MPR_SERVER_HANDLE((nint)(value));

        public static explicit operator int(MPR_SERVER_HANDLE value) => (int)(value.Value);

        public static explicit operator MPR_SERVER_HANDLE(long value) => new MPR_SERVER_HANDLE((nint)(value));

        public static implicit operator long(MPR_SERVER_HANDLE value) => (long)(value.Value);

        public static explicit operator MPR_SERVER_HANDLE(nint value) => new MPR_SERVER_HANDLE((nint)(value));

        public static implicit operator nint(MPR_SERVER_HANDLE value) => (nint)(value.Value);

        public static explicit operator MPR_SERVER_HANDLE(sbyte value) => new MPR_SERVER_HANDLE((nint)(value));

        public static explicit operator sbyte(MPR_SERVER_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator MPR_SERVER_HANDLE(ushort value) => new MPR_SERVER_HANDLE((nint)(value));

        public static explicit operator ushort(MPR_SERVER_HANDLE value) => (ushort)(value.Value);

        public static explicit operator MPR_SERVER_HANDLE(uint value) => new MPR_SERVER_HANDLE((nint)(value));

        public static explicit operator uint(MPR_SERVER_HANDLE value) => (uint)(value.Value);

        public static explicit operator MPR_SERVER_HANDLE(ulong value) => new MPR_SERVER_HANDLE((nint)(value));

        public static explicit operator ulong(MPR_SERVER_HANDLE value) => (ulong)(value.Value);

        public static explicit operator MPR_SERVER_HANDLE(nuint value) => new MPR_SERVER_HANDLE((nint)(value));

        public static explicit operator nuint(MPR_SERVER_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is MPR_SERVER_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of MPR_SERVER_HANDLE.");
        }

        public int CompareTo(MPR_SERVER_HANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is MPR_SERVER_HANDLE other) && Equals(other);

        public bool Equals(MPR_SERVER_HANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
