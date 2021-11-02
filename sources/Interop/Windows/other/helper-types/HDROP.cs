// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDROP : IComparable, IComparable<HDROP>, IEquatable<HDROP>, IFormattable
    {
        public readonly nint Value;

        public HDROP(nint value)
        {
            Value = value;
        }

        public static HDROP INVALID_VALUE => new HDROP(-1);

        public static HDROP NULL => new HDROP(0);

        public static bool operator ==(HDROP left, HDROP right) => left.Value == right.Value;

        public static bool operator !=(HDROP left, HDROP right) => left.Value != right.Value;

        public static bool operator <(HDROP left, HDROP right) => left.Value < right.Value;

        public static bool operator <=(HDROP left, HDROP right) => left.Value <= right.Value;

        public static bool operator >(HDROP left, HDROP right) => left.Value > right.Value;

        public static bool operator >=(HDROP left, HDROP right) => left.Value >= right.Value;

        public static explicit operator HDROP(void* value) => new HDROP((nint)(value));

        public static implicit operator void*(HDROP value) => (void*)(value.Value);

        public static explicit operator HDROP(HANDLE value) => new HDROP(value);

        public static implicit operator HANDLE(HDROP value) => new HANDLE(value.Value);

        public static explicit operator HDROP(byte value) => new HDROP((nint)(value));

        public static explicit operator byte(HDROP value) => (byte)(value.Value);

        public static explicit operator HDROP(short value) => new HDROP((nint)(value));

        public static explicit operator short(HDROP value) => (short)(value.Value);

        public static explicit operator HDROP(int value) => new HDROP((nint)(value));

        public static explicit operator int(HDROP value) => (int)(value.Value);

        public static explicit operator HDROP(long value) => new HDROP((nint)(value));

        public static implicit operator long(HDROP value) => value.Value;

        public static explicit operator HDROP(nint value) => new HDROP((nint)(value));

        public static implicit operator nint(HDROP value) => value.Value;

        public static explicit operator HDROP(sbyte value) => new HDROP((nint)(value));

        public static explicit operator sbyte(HDROP value) => (sbyte)(value.Value);

        public static explicit operator HDROP(ushort value) => new HDROP((nint)(value));

        public static explicit operator ushort(HDROP value) => (ushort)(value.Value);

        public static explicit operator HDROP(uint value) => new HDROP((nint)(value));

        public static explicit operator uint(HDROP value) => (uint)(value.Value);

        public static explicit operator HDROP(ulong value) => new HDROP((nint)(value));

        public static explicit operator ulong(HDROP value) => (ulong)(value.Value);

        public static explicit operator HDROP(nuint value) => new HDROP((nint)(value));

        public static explicit operator nuint(HDROP value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDROP other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDROP.");
        }

        public int CompareTo(HDROP other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HDROP other) && Equals(other);

        public bool Equals(HDROP other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
