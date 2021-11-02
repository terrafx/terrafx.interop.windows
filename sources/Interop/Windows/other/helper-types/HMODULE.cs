// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMODULE : IComparable, IComparable<HMODULE>, IEquatable<HMODULE>, IFormattable
    {
        public readonly nint Value;

        public HMODULE(nint value)
        {
            Value = value;
        }

        public static HMODULE INVALID_VALUE => new HMODULE(-1);

        public static HMODULE NULL => new HMODULE(0);

        public static bool operator ==(HMODULE left, HMODULE right) => left.Value == right.Value;

        public static bool operator !=(HMODULE left, HMODULE right) => left.Value != right.Value;

        public static bool operator <(HMODULE left, HMODULE right) => left.Value < right.Value;

        public static bool operator <=(HMODULE left, HMODULE right) => left.Value <= right.Value;

        public static bool operator >(HMODULE left, HMODULE right) => left.Value > right.Value;

        public static bool operator >=(HMODULE left, HMODULE right) => left.Value >= right.Value;

        public static explicit operator HMODULE(void* value) => new HMODULE((nint)(value));

        public static implicit operator void*(HMODULE value) => (void*)(value.Value);

        public static explicit operator HMODULE(HANDLE value) => new HMODULE(value);

        public static implicit operator HANDLE(HMODULE value) => new HANDLE(value.Value);

        public static explicit operator HMODULE(byte value) => new HMODULE((nint)(value));

        public static explicit operator byte(HMODULE value) => (byte)(value.Value);

        public static explicit operator HMODULE(short value) => new HMODULE((nint)(value));

        public static explicit operator short(HMODULE value) => (short)(value.Value);

        public static explicit operator HMODULE(int value) => new HMODULE((nint)(value));

        public static explicit operator int(HMODULE value) => (int)(value.Value);

        public static explicit operator HMODULE(long value) => new HMODULE((nint)(value));

        public static implicit operator long(HMODULE value) => (long)(value.Value);

        public static explicit operator HMODULE(nint value) => new HMODULE((nint)(value));

        public static implicit operator nint(HMODULE value) => (nint)(value.Value);

        public static explicit operator HMODULE(sbyte value) => new HMODULE((nint)(value));

        public static explicit operator sbyte(HMODULE value) => (sbyte)(value.Value);

        public static explicit operator HMODULE(ushort value) => new HMODULE((nint)(value));

        public static explicit operator ushort(HMODULE value) => (ushort)(value.Value);

        public static explicit operator HMODULE(uint value) => new HMODULE((nint)(value));

        public static explicit operator uint(HMODULE value) => (uint)(value.Value);

        public static explicit operator HMODULE(ulong value) => new HMODULE((nint)(value));

        public static explicit operator ulong(HMODULE value) => (ulong)(value.Value);

        public static explicit operator HMODULE(nuint value) => new HMODULE((nint)(value));

        public static explicit operator nuint(HMODULE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HMODULE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMODULE.");
        }

        public int CompareTo(HMODULE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HMODULE other) && Equals(other);

        public bool Equals(HMODULE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
