// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPGRAMMARHANDLE : IComparable, IComparable<SPGRAMMARHANDLE>, IEquatable<SPGRAMMARHANDLE>, IFormattable
    {
        public readonly nint Value;

        public SPGRAMMARHANDLE(nint value)
        {
            Value = value;
        }

        public static SPGRAMMARHANDLE INVALID_VALUE => new SPGRAMMARHANDLE(-1);

        public static SPGRAMMARHANDLE NULL => new SPGRAMMARHANDLE(0);

        public static bool operator ==(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value != right.Value;

        public static bool operator <(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value < right.Value;

        public static bool operator <=(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value <= right.Value;

        public static bool operator >(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value > right.Value;

        public static bool operator >=(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value >= right.Value;

        public static explicit operator SPGRAMMARHANDLE(void* value) => new SPGRAMMARHANDLE((nint)(value));

        public static implicit operator void*(SPGRAMMARHANDLE value) => (void*)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(HANDLE value) => new SPGRAMMARHANDLE(value);

        public static implicit operator HANDLE(SPGRAMMARHANDLE value) => new HANDLE(value.Value);

        public static explicit operator SPGRAMMARHANDLE(byte value) => new SPGRAMMARHANDLE((nint)(value));

        public static explicit operator byte(SPGRAMMARHANDLE value) => (byte)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(short value) => new SPGRAMMARHANDLE((nint)(value));

        public static explicit operator short(SPGRAMMARHANDLE value) => (short)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(int value) => new SPGRAMMARHANDLE((nint)(value));

        public static explicit operator int(SPGRAMMARHANDLE value) => (int)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(long value) => new SPGRAMMARHANDLE((nint)(value));

        public static implicit operator long(SPGRAMMARHANDLE value) => value.Value;

        public static explicit operator SPGRAMMARHANDLE(nint value) => new SPGRAMMARHANDLE((nint)(value));

        public static implicit operator nint(SPGRAMMARHANDLE value) => value.Value;

        public static explicit operator SPGRAMMARHANDLE(sbyte value) => new SPGRAMMARHANDLE((nint)(value));

        public static explicit operator sbyte(SPGRAMMARHANDLE value) => (sbyte)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(ushort value) => new SPGRAMMARHANDLE((nint)(value));

        public static explicit operator ushort(SPGRAMMARHANDLE value) => (ushort)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(uint value) => new SPGRAMMARHANDLE((nint)(value));

        public static explicit operator uint(SPGRAMMARHANDLE value) => (uint)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(ulong value) => new SPGRAMMARHANDLE((nint)(value));

        public static explicit operator ulong(SPGRAMMARHANDLE value) => (ulong)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(nuint value) => new SPGRAMMARHANDLE((nint)(value));

        public static explicit operator nuint(SPGRAMMARHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SPGRAMMARHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SPGRAMMARHANDLE.");
        }

        public int CompareTo(SPGRAMMARHANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is SPGRAMMARHANDLE other) && Equals(other);

        public bool Equals(SPGRAMMARHANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
