// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct EVT_HANDLE : IComparable, IComparable<EVT_HANDLE>, IEquatable<EVT_HANDLE>, IFormattable
    {
        public readonly nint Value;

        public EVT_HANDLE(nint value)
        {
            Value = value;
        }

        public static EVT_HANDLE INVALID_VALUE => new EVT_HANDLE(-1);

        public static EVT_HANDLE NULL => new EVT_HANDLE(0);

        public static bool operator ==(EVT_HANDLE left, EVT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(EVT_HANDLE left, EVT_HANDLE right) => left.Value != right.Value;

        public static bool operator <(EVT_HANDLE left, EVT_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(EVT_HANDLE left, EVT_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(EVT_HANDLE left, EVT_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(EVT_HANDLE left, EVT_HANDLE right) => left.Value >= right.Value;

        public static explicit operator EVT_HANDLE(void* value) => new EVT_HANDLE((nint)(value));

        public static implicit operator void*(EVT_HANDLE value) => (void*)(value.Value);

        public static explicit operator EVT_HANDLE(HANDLE value) => new EVT_HANDLE(value);

        public static implicit operator HANDLE(EVT_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator EVT_HANDLE(byte value) => new EVT_HANDLE((nint)(value));

        public static explicit operator byte(EVT_HANDLE value) => (byte)(value.Value);

        public static explicit operator EVT_HANDLE(short value) => new EVT_HANDLE((nint)(value));

        public static explicit operator short(EVT_HANDLE value) => (short)(value.Value);

        public static explicit operator EVT_HANDLE(int value) => new EVT_HANDLE((nint)(value));

        public static explicit operator int(EVT_HANDLE value) => (int)(value.Value);

        public static explicit operator EVT_HANDLE(long value) => new EVT_HANDLE((nint)(value));

        public static implicit operator long(EVT_HANDLE value) => value.Value;

        public static explicit operator EVT_HANDLE(nint value) => new EVT_HANDLE((nint)(value));

        public static implicit operator nint(EVT_HANDLE value) => value.Value;

        public static explicit operator EVT_HANDLE(sbyte value) => new EVT_HANDLE((nint)(value));

        public static explicit operator sbyte(EVT_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator EVT_HANDLE(ushort value) => new EVT_HANDLE((nint)(value));

        public static explicit operator ushort(EVT_HANDLE value) => (ushort)(value.Value);

        public static explicit operator EVT_HANDLE(uint value) => new EVT_HANDLE((nint)(value));

        public static explicit operator uint(EVT_HANDLE value) => (uint)(value.Value);

        public static explicit operator EVT_HANDLE(ulong value) => new EVT_HANDLE((nint)(value));

        public static explicit operator ulong(EVT_HANDLE value) => (ulong)(value.Value);

        public static explicit operator EVT_HANDLE(nuint value) => new EVT_HANDLE((nint)(value));

        public static explicit operator nuint(EVT_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is EVT_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of EVT_HANDLE.");
        }

        public int CompareTo(EVT_HANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is EVT_HANDLE other) && Equals(other);

        public bool Equals(EVT_HANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
