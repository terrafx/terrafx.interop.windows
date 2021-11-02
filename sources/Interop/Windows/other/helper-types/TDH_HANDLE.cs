// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct TDH_HANDLE : IComparable, IComparable<TDH_HANDLE>, IEquatable<TDH_HANDLE>, IFormattable
    {
        public readonly nint Value;

        public TDH_HANDLE(nint value)
        {
            Value = value;
        }

        public static TDH_HANDLE INVALID_VALUE => new TDH_HANDLE(-1);

        public static TDH_HANDLE NULL => new TDH_HANDLE(0);

        public static bool operator ==(TDH_HANDLE left, TDH_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(TDH_HANDLE left, TDH_HANDLE right) => left.Value != right.Value;

        public static bool operator <(TDH_HANDLE left, TDH_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(TDH_HANDLE left, TDH_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(TDH_HANDLE left, TDH_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(TDH_HANDLE left, TDH_HANDLE right) => left.Value >= right.Value;

        public static explicit operator TDH_HANDLE(void* value) => new TDH_HANDLE((nint)(value));

        public static implicit operator void*(TDH_HANDLE value) => (void*)(value.Value);

        public static explicit operator TDH_HANDLE(HANDLE value) => new TDH_HANDLE(value);

        public static implicit operator HANDLE(TDH_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator TDH_HANDLE(byte value) => new TDH_HANDLE((nint)(value));

        public static explicit operator byte(TDH_HANDLE value) => (byte)(value.Value);

        public static explicit operator TDH_HANDLE(short value) => new TDH_HANDLE((nint)(value));

        public static explicit operator short(TDH_HANDLE value) => (short)(value.Value);

        public static explicit operator TDH_HANDLE(int value) => new TDH_HANDLE((nint)(value));

        public static explicit operator int(TDH_HANDLE value) => (int)(value.Value);

        public static explicit operator TDH_HANDLE(long value) => new TDH_HANDLE((nint)(value));

        public static implicit operator long(TDH_HANDLE value) => value.Value;

        public static explicit operator TDH_HANDLE(nint value) => new TDH_HANDLE((nint)(value));

        public static implicit operator nint(TDH_HANDLE value) => value.Value;

        public static explicit operator TDH_HANDLE(sbyte value) => new TDH_HANDLE((nint)(value));

        public static explicit operator sbyte(TDH_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator TDH_HANDLE(ushort value) => new TDH_HANDLE((nint)(value));

        public static explicit operator ushort(TDH_HANDLE value) => (ushort)(value.Value);

        public static explicit operator TDH_HANDLE(uint value) => new TDH_HANDLE((nint)(value));

        public static explicit operator uint(TDH_HANDLE value) => (uint)(value.Value);

        public static explicit operator TDH_HANDLE(ulong value) => new TDH_HANDLE((nint)(value));

        public static explicit operator ulong(TDH_HANDLE value) => (ulong)(value.Value);

        public static explicit operator TDH_HANDLE(nuint value) => new TDH_HANDLE((nint)(value));

        public static explicit operator nuint(TDH_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is TDH_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of TDH_HANDLE.");
        }

        public int CompareTo(TDH_HANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is TDH_HANDLE other) && Equals(other);

        public bool Equals(TDH_HANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
