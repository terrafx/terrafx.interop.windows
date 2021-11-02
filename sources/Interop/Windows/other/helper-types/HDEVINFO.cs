// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDEVINFO : IComparable, IComparable<HDEVINFO>, IEquatable<HDEVINFO>, IFormattable
    {
        public readonly nint Value;

        public HDEVINFO(nint value)
        {
            Value = value;
        }

        public static HDEVINFO INVALID_VALUE => new HDEVINFO(-1);

        public static HDEVINFO NULL => new HDEVINFO(0);

        public static bool operator ==(HDEVINFO left, HDEVINFO right) => left.Value == right.Value;

        public static bool operator !=(HDEVINFO left, HDEVINFO right) => left.Value != right.Value;

        public static bool operator <(HDEVINFO left, HDEVINFO right) => left.Value < right.Value;

        public static bool operator <=(HDEVINFO left, HDEVINFO right) => left.Value <= right.Value;

        public static bool operator >(HDEVINFO left, HDEVINFO right) => left.Value > right.Value;

        public static bool operator >=(HDEVINFO left, HDEVINFO right) => left.Value >= right.Value;

        public static explicit operator HDEVINFO(void* value) => new HDEVINFO((nint)(value));

        public static implicit operator void*(HDEVINFO value) => (void*)(value.Value);

        public static explicit operator HDEVINFO(HANDLE value) => new HDEVINFO(value);

        public static implicit operator HANDLE(HDEVINFO value) => new HANDLE(value.Value);

        public static explicit operator HDEVINFO(byte value) => new HDEVINFO((nint)(value));

        public static explicit operator byte(HDEVINFO value) => (byte)(value.Value);

        public static explicit operator HDEVINFO(short value) => new HDEVINFO((nint)(value));

        public static explicit operator short(HDEVINFO value) => (short)(value.Value);

        public static explicit operator HDEVINFO(int value) => new HDEVINFO((nint)(value));

        public static explicit operator int(HDEVINFO value) => (int)(value.Value);

        public static explicit operator HDEVINFO(long value) => new HDEVINFO((nint)(value));

        public static implicit operator long(HDEVINFO value) => value.Value;

        public static explicit operator HDEVINFO(nint value) => new HDEVINFO((nint)(value));

        public static implicit operator nint(HDEVINFO value) => value.Value;

        public static explicit operator HDEVINFO(sbyte value) => new HDEVINFO((nint)(value));

        public static explicit operator sbyte(HDEVINFO value) => (sbyte)(value.Value);

        public static explicit operator HDEVINFO(ushort value) => new HDEVINFO((nint)(value));

        public static explicit operator ushort(HDEVINFO value) => (ushort)(value.Value);

        public static explicit operator HDEVINFO(uint value) => new HDEVINFO((nint)(value));

        public static explicit operator uint(HDEVINFO value) => (uint)(value.Value);

        public static explicit operator HDEVINFO(ulong value) => new HDEVINFO((nint)(value));

        public static explicit operator ulong(HDEVINFO value) => (ulong)(value.Value);

        public static explicit operator HDEVINFO(nuint value) => new HDEVINFO((nint)(value));

        public static explicit operator nuint(HDEVINFO value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDEVINFO other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDEVINFO.");
        }

        public int CompareTo(HDEVINFO other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HDEVINFO other) && Equals(other);

        public bool Equals(HDEVINFO other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
