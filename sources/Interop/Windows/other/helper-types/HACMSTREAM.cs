// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACMSTREAM : IComparable, IComparable<HACMSTREAM>, IEquatable<HACMSTREAM>, IFormattable
    {
        public readonly nint Value;

        public HACMSTREAM(nint value)
        {
            Value = value;
        }

        public static HACMSTREAM INVALID_VALUE => new HACMSTREAM(-1);

        public static HACMSTREAM NULL => new HACMSTREAM(0);

        public static bool operator ==(HACMSTREAM left, HACMSTREAM right) => left.Value == right.Value;

        public static bool operator !=(HACMSTREAM left, HACMSTREAM right) => left.Value != right.Value;

        public static bool operator <(HACMSTREAM left, HACMSTREAM right) => left.Value < right.Value;

        public static bool operator <=(HACMSTREAM left, HACMSTREAM right) => left.Value <= right.Value;

        public static bool operator >(HACMSTREAM left, HACMSTREAM right) => left.Value > right.Value;

        public static bool operator >=(HACMSTREAM left, HACMSTREAM right) => left.Value >= right.Value;

        public static explicit operator HACMSTREAM(void* value) => new HACMSTREAM((nint)(value));

        public static implicit operator void*(HACMSTREAM value) => (void*)(value.Value);

        public static explicit operator HACMSTREAM(HANDLE value) => new HACMSTREAM(value);

        public static implicit operator HANDLE(HACMSTREAM value) => new HANDLE(value.Value);

        public static explicit operator HACMSTREAM(byte value) => new HACMSTREAM((nint)(value));

        public static explicit operator byte(HACMSTREAM value) => (byte)(value.Value);

        public static explicit operator HACMSTREAM(short value) => new HACMSTREAM((nint)(value));

        public static explicit operator short(HACMSTREAM value) => (short)(value.Value);

        public static explicit operator HACMSTREAM(int value) => new HACMSTREAM((nint)(value));

        public static explicit operator int(HACMSTREAM value) => (int)(value.Value);

        public static explicit operator HACMSTREAM(long value) => new HACMSTREAM((nint)(value));

        public static implicit operator long(HACMSTREAM value) => value.Value;

        public static explicit operator HACMSTREAM(nint value) => new HACMSTREAM((nint)(value));

        public static implicit operator nint(HACMSTREAM value) => value.Value;

        public static explicit operator HACMSTREAM(sbyte value) => new HACMSTREAM((nint)(value));

        public static explicit operator sbyte(HACMSTREAM value) => (sbyte)(value.Value);

        public static explicit operator HACMSTREAM(ushort value) => new HACMSTREAM((nint)(value));

        public static explicit operator ushort(HACMSTREAM value) => (ushort)(value.Value);

        public static explicit operator HACMSTREAM(uint value) => new HACMSTREAM((nint)(value));

        public static explicit operator uint(HACMSTREAM value) => (uint)(value.Value);

        public static explicit operator HACMSTREAM(ulong value) => new HACMSTREAM((nint)(value));

        public static explicit operator ulong(HACMSTREAM value) => (ulong)(value.Value);

        public static explicit operator HACMSTREAM(nuint value) => new HACMSTREAM((nint)(value));

        public static explicit operator nuint(HACMSTREAM value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HACMSTREAM other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HACMSTREAM.");
        }

        public int CompareTo(HACMSTREAM other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HACMSTREAM other) && Equals(other);

        public bool Equals(HACMSTREAM other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
