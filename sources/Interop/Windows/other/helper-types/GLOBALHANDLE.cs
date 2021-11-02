// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct GLOBALHANDLE : IComparable, IComparable<GLOBALHANDLE>, IEquatable<GLOBALHANDLE>, IFormattable
    {
        public readonly nint Value;

        public GLOBALHANDLE(nint value)
        {
            Value = value;
        }

        public static GLOBALHANDLE INVALID_VALUE => new GLOBALHANDLE(-1);

        public static GLOBALHANDLE NULL => new GLOBALHANDLE(0);

        public static bool operator ==(GLOBALHANDLE left, GLOBALHANDLE right) => left.Value == right.Value;

        public static bool operator !=(GLOBALHANDLE left, GLOBALHANDLE right) => left.Value != right.Value;

        public static bool operator <(GLOBALHANDLE left, GLOBALHANDLE right) => left.Value < right.Value;

        public static bool operator <=(GLOBALHANDLE left, GLOBALHANDLE right) => left.Value <= right.Value;

        public static bool operator >(GLOBALHANDLE left, GLOBALHANDLE right) => left.Value > right.Value;

        public static bool operator >=(GLOBALHANDLE left, GLOBALHANDLE right) => left.Value >= right.Value;

        public static explicit operator GLOBALHANDLE(void* value) => new GLOBALHANDLE((nint)(value));

        public static implicit operator void*(GLOBALHANDLE value) => (void*)(value.Value);

        public static explicit operator GLOBALHANDLE(HANDLE value) => new GLOBALHANDLE(value);

        public static implicit operator HANDLE(GLOBALHANDLE value) => new HANDLE(value.Value);

        public static explicit operator GLOBALHANDLE(byte value) => new GLOBALHANDLE((nint)(value));

        public static explicit operator byte(GLOBALHANDLE value) => (byte)(value.Value);

        public static explicit operator GLOBALHANDLE(short value) => new GLOBALHANDLE((nint)(value));

        public static explicit operator short(GLOBALHANDLE value) => (short)(value.Value);

        public static explicit operator GLOBALHANDLE(int value) => new GLOBALHANDLE((nint)(value));

        public static explicit operator int(GLOBALHANDLE value) => (int)(value.Value);

        public static explicit operator GLOBALHANDLE(long value) => new GLOBALHANDLE((nint)(value));

        public static implicit operator long(GLOBALHANDLE value) => value.Value;

        public static explicit operator GLOBALHANDLE(nint value) => new GLOBALHANDLE((nint)(value));

        public static implicit operator nint(GLOBALHANDLE value) => value.Value;

        public static explicit operator GLOBALHANDLE(sbyte value) => new GLOBALHANDLE((nint)(value));

        public static explicit operator sbyte(GLOBALHANDLE value) => (sbyte)(value.Value);

        public static explicit operator GLOBALHANDLE(ushort value) => new GLOBALHANDLE((nint)(value));

        public static explicit operator ushort(GLOBALHANDLE value) => (ushort)(value.Value);

        public static explicit operator GLOBALHANDLE(uint value) => new GLOBALHANDLE((nint)(value));

        public static explicit operator uint(GLOBALHANDLE value) => (uint)(value.Value);

        public static explicit operator GLOBALHANDLE(ulong value) => new GLOBALHANDLE((nint)(value));

        public static explicit operator ulong(GLOBALHANDLE value) => (ulong)(value.Value);

        public static explicit operator GLOBALHANDLE(nuint value) => new GLOBALHANDLE((nint)(value));

        public static explicit operator nuint(GLOBALHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is GLOBALHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of GLOBALHANDLE.");
        }

        public int CompareTo(GLOBALHANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is GLOBALHANDLE other) && Equals(other);

        public bool Equals(GLOBALHANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
