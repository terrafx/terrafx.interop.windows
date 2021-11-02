// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HGLOBAL : IComparable, IComparable<HGLOBAL>, IEquatable<HGLOBAL>, IFormattable
    {
        public readonly nint Value;

        public HGLOBAL(nint value)
        {
            Value = value;
        }

        public static HGLOBAL INVALID_VALUE => new HGLOBAL(-1);

        public static HGLOBAL NULL => new HGLOBAL(0);

        public static bool operator ==(HGLOBAL left, HGLOBAL right) => left.Value == right.Value;

        public static bool operator !=(HGLOBAL left, HGLOBAL right) => left.Value != right.Value;

        public static bool operator <(HGLOBAL left, HGLOBAL right) => left.Value < right.Value;

        public static bool operator <=(HGLOBAL left, HGLOBAL right) => left.Value <= right.Value;

        public static bool operator >(HGLOBAL left, HGLOBAL right) => left.Value > right.Value;

        public static bool operator >=(HGLOBAL left, HGLOBAL right) => left.Value >= right.Value;

        public static explicit operator HGLOBAL(void* value) => new HGLOBAL((nint)(value));

        public static implicit operator void*(HGLOBAL value) => (void*)(value.Value);

        public static explicit operator HGLOBAL(HANDLE value) => new HGLOBAL(value);

        public static implicit operator HANDLE(HGLOBAL value) => new HANDLE(value.Value);

        public static explicit operator HGLOBAL(byte value) => new HGLOBAL((nint)(value));

        public static explicit operator byte(HGLOBAL value) => (byte)(value.Value);

        public static explicit operator HGLOBAL(short value) => new HGLOBAL((nint)(value));

        public static explicit operator short(HGLOBAL value) => (short)(value.Value);

        public static explicit operator HGLOBAL(int value) => new HGLOBAL((nint)(value));

        public static explicit operator int(HGLOBAL value) => (int)(value.Value);

        public static explicit operator HGLOBAL(long value) => new HGLOBAL((nint)(value));

        public static implicit operator long(HGLOBAL value) => value.Value;

        public static explicit operator HGLOBAL(nint value) => new HGLOBAL((nint)(value));

        public static implicit operator nint(HGLOBAL value) => value.Value;

        public static explicit operator HGLOBAL(sbyte value) => new HGLOBAL((nint)(value));

        public static explicit operator sbyte(HGLOBAL value) => (sbyte)(value.Value);

        public static explicit operator HGLOBAL(ushort value) => new HGLOBAL((nint)(value));

        public static explicit operator ushort(HGLOBAL value) => (ushort)(value.Value);

        public static explicit operator HGLOBAL(uint value) => new HGLOBAL((nint)(value));

        public static explicit operator uint(HGLOBAL value) => (uint)(value.Value);

        public static explicit operator HGLOBAL(ulong value) => new HGLOBAL((nint)(value));

        public static explicit operator ulong(HGLOBAL value) => (ulong)(value.Value);

        public static explicit operator HGLOBAL(nuint value) => new HGLOBAL((nint)(value));

        public static explicit operator nuint(HGLOBAL value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HGLOBAL other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HGLOBAL.");
        }

        public int CompareTo(HGLOBAL other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HGLOBAL other) && Equals(other);

        public bool Equals(HGLOBAL other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
