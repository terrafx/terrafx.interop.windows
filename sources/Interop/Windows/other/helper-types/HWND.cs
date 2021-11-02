// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWND : IComparable, IComparable<HWND>, IEquatable<HWND>, IFormattable
    {
        public readonly nint Value;

        public HWND(nint value)
        {
            Value = value;
        }

        public static HWND INVALID_VALUE => new HWND(-1);

        public static HWND NULL => new HWND(0);

        public static bool operator ==(HWND left, HWND right) => left.Value == right.Value;

        public static bool operator !=(HWND left, HWND right) => left.Value != right.Value;

        public static bool operator <(HWND left, HWND right) => left.Value < right.Value;

        public static bool operator <=(HWND left, HWND right) => left.Value <= right.Value;

        public static bool operator >(HWND left, HWND right) => left.Value > right.Value;

        public static bool operator >=(HWND left, HWND right) => left.Value >= right.Value;

        public static explicit operator HWND(void* value) => new HWND((nint)(value));

        public static implicit operator void*(HWND value) => (void*)(value.Value);

        public static explicit operator HWND(HANDLE value) => new HWND(value);

        public static implicit operator HANDLE(HWND value) => new HANDLE(value.Value);

        public static explicit operator HWND(byte value) => new HWND((nint)(value));

        public static explicit operator byte(HWND value) => (byte)(value.Value);

        public static explicit operator HWND(short value) => new HWND((nint)(value));

        public static explicit operator short(HWND value) => (short)(value.Value);

        public static explicit operator HWND(int value) => new HWND((nint)(value));

        public static explicit operator int(HWND value) => (int)(value.Value);

        public static explicit operator HWND(long value) => new HWND((nint)(value));

        public static implicit operator long(HWND value) => value.Value;

        public static explicit operator HWND(nint value) => new HWND((nint)(value));

        public static implicit operator nint(HWND value) => value.Value;

        public static explicit operator HWND(sbyte value) => new HWND((nint)(value));

        public static explicit operator sbyte(HWND value) => (sbyte)(value.Value);

        public static explicit operator HWND(ushort value) => new HWND((nint)(value));

        public static explicit operator ushort(HWND value) => (ushort)(value.Value);

        public static explicit operator HWND(uint value) => new HWND((nint)(value));

        public static explicit operator uint(HWND value) => (uint)(value.Value);

        public static explicit operator HWND(ulong value) => new HWND((nint)(value));

        public static explicit operator ulong(HWND value) => (ulong)(value.Value);

        public static explicit operator HWND(nuint value) => new HWND((nint)(value));

        public static explicit operator nuint(HWND value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HWND other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HWND.");
        }

        public int CompareTo(HWND other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HWND other) && Equals(other);

        public bool Equals(HWND other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
