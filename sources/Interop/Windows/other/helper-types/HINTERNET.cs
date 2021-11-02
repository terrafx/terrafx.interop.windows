// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HINTERNET : IComparable, IComparable<HINTERNET>, IEquatable<HINTERNET>, IFormattable
    {
        public readonly nint Value;

        public HINTERNET(nint value)
        {
            Value = value;
        }

        public static HINTERNET INVALID_VALUE => new HINTERNET(-1);

        public static HINTERNET NULL => new HINTERNET(0);

        public static bool operator ==(HINTERNET left, HINTERNET right) => left.Value == right.Value;

        public static bool operator !=(HINTERNET left, HINTERNET right) => left.Value != right.Value;

        public static bool operator <(HINTERNET left, HINTERNET right) => left.Value < right.Value;

        public static bool operator <=(HINTERNET left, HINTERNET right) => left.Value <= right.Value;

        public static bool operator >(HINTERNET left, HINTERNET right) => left.Value > right.Value;

        public static bool operator >=(HINTERNET left, HINTERNET right) => left.Value >= right.Value;

        public static explicit operator HINTERNET(void* value) => new HINTERNET((nint)(value));

        public static implicit operator void*(HINTERNET value) => (void*)(value.Value);

        public static explicit operator HINTERNET(HANDLE value) => new HINTERNET(value);

        public static implicit operator HANDLE(HINTERNET value) => new HANDLE(value.Value);

        public static explicit operator HINTERNET(byte value) => new HINTERNET((nint)(value));

        public static explicit operator byte(HINTERNET value) => (byte)(value.Value);

        public static explicit operator HINTERNET(short value) => new HINTERNET((nint)(value));

        public static explicit operator short(HINTERNET value) => (short)(value.Value);

        public static explicit operator HINTERNET(int value) => new HINTERNET((nint)(value));

        public static explicit operator int(HINTERNET value) => (int)(value.Value);

        public static explicit operator HINTERNET(long value) => new HINTERNET((nint)(value));

        public static implicit operator long(HINTERNET value) => value.Value;

        public static explicit operator HINTERNET(nint value) => new HINTERNET((nint)(value));

        public static implicit operator nint(HINTERNET value) => value.Value;

        public static explicit operator HINTERNET(sbyte value) => new HINTERNET((nint)(value));

        public static explicit operator sbyte(HINTERNET value) => (sbyte)(value.Value);

        public static explicit operator HINTERNET(ushort value) => new HINTERNET((nint)(value));

        public static explicit operator ushort(HINTERNET value) => (ushort)(value.Value);

        public static explicit operator HINTERNET(uint value) => new HINTERNET((nint)(value));

        public static explicit operator uint(HINTERNET value) => (uint)(value.Value);

        public static explicit operator HINTERNET(ulong value) => new HINTERNET((nint)(value));

        public static explicit operator ulong(HINTERNET value) => (ulong)(value.Value);

        public static explicit operator HINTERNET(nuint value) => new HINTERNET((nint)(value));

        public static explicit operator nuint(HINTERNET value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HINTERNET other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HINTERNET.");
        }

        public int CompareTo(HINTERNET other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HINTERNET other) && Equals(other);

        public bool Equals(HINTERNET other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
