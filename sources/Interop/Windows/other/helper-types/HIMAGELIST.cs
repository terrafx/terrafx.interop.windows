// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIMAGELIST : IComparable, IComparable<HIMAGELIST>, IEquatable<HIMAGELIST>, IFormattable
    {
        public readonly nint Value;

        public HIMAGELIST(nint value)
        {
            Value = value;
        }

        public static HIMAGELIST INVALID_VALUE => new HIMAGELIST(-1);

        public static HIMAGELIST NULL => new HIMAGELIST(0);

        public static bool operator ==(HIMAGELIST left, HIMAGELIST right) => left.Value == right.Value;

        public static bool operator !=(HIMAGELIST left, HIMAGELIST right) => left.Value != right.Value;

        public static bool operator <(HIMAGELIST left, HIMAGELIST right) => left.Value < right.Value;

        public static bool operator <=(HIMAGELIST left, HIMAGELIST right) => left.Value <= right.Value;

        public static bool operator >(HIMAGELIST left, HIMAGELIST right) => left.Value > right.Value;

        public static bool operator >=(HIMAGELIST left, HIMAGELIST right) => left.Value >= right.Value;

        public static explicit operator HIMAGELIST(void* value) => new HIMAGELIST((nint)(value));

        public static implicit operator void*(HIMAGELIST value) => (void*)(value.Value);

        public static explicit operator HIMAGELIST(HANDLE value) => new HIMAGELIST(value);

        public static implicit operator HANDLE(HIMAGELIST value) => new HANDLE(value.Value);

        public static explicit operator HIMAGELIST(byte value) => new HIMAGELIST((nint)(value));

        public static explicit operator byte(HIMAGELIST value) => (byte)(value.Value);

        public static explicit operator HIMAGELIST(short value) => new HIMAGELIST((nint)(value));

        public static explicit operator short(HIMAGELIST value) => (short)(value.Value);

        public static explicit operator HIMAGELIST(int value) => new HIMAGELIST((nint)(value));

        public static explicit operator int(HIMAGELIST value) => (int)(value.Value);

        public static explicit operator HIMAGELIST(long value) => new HIMAGELIST((nint)(value));

        public static implicit operator long(HIMAGELIST value) => value.Value;

        public static explicit operator HIMAGELIST(nint value) => new HIMAGELIST((nint)(value));

        public static implicit operator nint(HIMAGELIST value) => value.Value;

        public static explicit operator HIMAGELIST(sbyte value) => new HIMAGELIST((nint)(value));

        public static explicit operator sbyte(HIMAGELIST value) => (sbyte)(value.Value);

        public static explicit operator HIMAGELIST(ushort value) => new HIMAGELIST((nint)(value));

        public static explicit operator ushort(HIMAGELIST value) => (ushort)(value.Value);

        public static explicit operator HIMAGELIST(uint value) => new HIMAGELIST((nint)(value));

        public static explicit operator uint(HIMAGELIST value) => (uint)(value.Value);

        public static explicit operator HIMAGELIST(ulong value) => new HIMAGELIST((nint)(value));

        public static explicit operator ulong(HIMAGELIST value) => (ulong)(value.Value);

        public static explicit operator HIMAGELIST(nuint value) => new HIMAGELIST((nint)(value));

        public static explicit operator nuint(HIMAGELIST value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HIMAGELIST other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HIMAGELIST.");
        }

        public int CompareTo(HIMAGELIST other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HIMAGELIST other) && Equals(other);

        public bool Equals(HIMAGELIST other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
