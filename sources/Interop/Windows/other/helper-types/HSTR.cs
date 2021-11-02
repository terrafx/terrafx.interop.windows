// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSTR : IComparable, IComparable<HSTR>, IEquatable<HSTR>, IFormattable
    {
        public readonly nint Value;

        public HSTR(nint value)
        {
            Value = value;
        }

        public static HSTR INVALID_VALUE => new HSTR(-1);

        public static HSTR NULL => new HSTR(0);

        public static bool operator ==(HSTR left, HSTR right) => left.Value == right.Value;

        public static bool operator !=(HSTR left, HSTR right) => left.Value != right.Value;

        public static bool operator <(HSTR left, HSTR right) => left.Value < right.Value;

        public static bool operator <=(HSTR left, HSTR right) => left.Value <= right.Value;

        public static bool operator >(HSTR left, HSTR right) => left.Value > right.Value;

        public static bool operator >=(HSTR left, HSTR right) => left.Value >= right.Value;

        public static explicit operator HSTR(void* value) => new HSTR((nint)(value));

        public static implicit operator void*(HSTR value) => (void*)(value.Value);

        public static explicit operator HSTR(HANDLE value) => new HSTR(value);

        public static implicit operator HANDLE(HSTR value) => new HANDLE(value.Value);

        public static explicit operator HSTR(byte value) => new HSTR((nint)(value));

        public static explicit operator byte(HSTR value) => (byte)(value.Value);

        public static explicit operator HSTR(short value) => new HSTR((nint)(value));

        public static explicit operator short(HSTR value) => (short)(value.Value);

        public static explicit operator HSTR(int value) => new HSTR((nint)(value));

        public static explicit operator int(HSTR value) => (int)(value.Value);

        public static explicit operator HSTR(long value) => new HSTR((nint)(value));

        public static implicit operator long(HSTR value) => value.Value;

        public static explicit operator HSTR(nint value) => new HSTR((nint)(value));

        public static implicit operator nint(HSTR value) => value.Value;

        public static explicit operator HSTR(sbyte value) => new HSTR((nint)(value));

        public static explicit operator sbyte(HSTR value) => (sbyte)(value.Value);

        public static explicit operator HSTR(ushort value) => new HSTR((nint)(value));

        public static explicit operator ushort(HSTR value) => (ushort)(value.Value);

        public static explicit operator HSTR(uint value) => new HSTR((nint)(value));

        public static explicit operator uint(HSTR value) => (uint)(value.Value);

        public static explicit operator HSTR(ulong value) => new HSTR((nint)(value));

        public static explicit operator ulong(HSTR value) => (ulong)(value.Value);

        public static explicit operator HSTR(nuint value) => new HSTR((nint)(value));

        public static explicit operator nuint(HSTR value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HSTR other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSTR.");
        }

        public int CompareTo(HSTR other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HSTR other) && Equals(other);

        public bool Equals(HSTR other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
