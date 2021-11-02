// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPWORDHANDLE : IComparable, IComparable<SPWORDHANDLE>, IEquatable<SPWORDHANDLE>, IFormattable
    {
        public readonly nint Value;

        public SPWORDHANDLE(nint value)
        {
            Value = value;
        }

        public static SPWORDHANDLE INVALID_VALUE => new SPWORDHANDLE(-1);

        public static SPWORDHANDLE NULL => new SPWORDHANDLE(0);

        public static bool operator ==(SPWORDHANDLE left, SPWORDHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPWORDHANDLE left, SPWORDHANDLE right) => left.Value != right.Value;

        public static bool operator <(SPWORDHANDLE left, SPWORDHANDLE right) => left.Value < right.Value;

        public static bool operator <=(SPWORDHANDLE left, SPWORDHANDLE right) => left.Value <= right.Value;

        public static bool operator >(SPWORDHANDLE left, SPWORDHANDLE right) => left.Value > right.Value;

        public static bool operator >=(SPWORDHANDLE left, SPWORDHANDLE right) => left.Value >= right.Value;

        public static explicit operator SPWORDHANDLE(void* value) => new SPWORDHANDLE((nint)(value));

        public static implicit operator void*(SPWORDHANDLE value) => (void*)(value.Value);

        public static explicit operator SPWORDHANDLE(HANDLE value) => new SPWORDHANDLE(value);

        public static implicit operator HANDLE(SPWORDHANDLE value) => new HANDLE(value.Value);

        public static explicit operator SPWORDHANDLE(byte value) => new SPWORDHANDLE((nint)(value));

        public static explicit operator byte(SPWORDHANDLE value) => (byte)(value.Value);

        public static explicit operator SPWORDHANDLE(short value) => new SPWORDHANDLE((nint)(value));

        public static explicit operator short(SPWORDHANDLE value) => (short)(value.Value);

        public static explicit operator SPWORDHANDLE(int value) => new SPWORDHANDLE((nint)(value));

        public static explicit operator int(SPWORDHANDLE value) => (int)(value.Value);

        public static explicit operator SPWORDHANDLE(long value) => new SPWORDHANDLE((nint)(value));

        public static implicit operator long(SPWORDHANDLE value) => (long)(value.Value);

        public static explicit operator SPWORDHANDLE(nint value) => new SPWORDHANDLE((nint)(value));

        public static implicit operator nint(SPWORDHANDLE value) => (nint)(value.Value);

        public static explicit operator SPWORDHANDLE(sbyte value) => new SPWORDHANDLE((nint)(value));

        public static explicit operator sbyte(SPWORDHANDLE value) => (sbyte)(value.Value);

        public static explicit operator SPWORDHANDLE(ushort value) => new SPWORDHANDLE((nint)(value));

        public static explicit operator ushort(SPWORDHANDLE value) => (ushort)(value.Value);

        public static explicit operator SPWORDHANDLE(uint value) => new SPWORDHANDLE((nint)(value));

        public static explicit operator uint(SPWORDHANDLE value) => (uint)(value.Value);

        public static explicit operator SPWORDHANDLE(ulong value) => new SPWORDHANDLE((nint)(value));

        public static explicit operator ulong(SPWORDHANDLE value) => (ulong)(value.Value);

        public static explicit operator SPWORDHANDLE(nuint value) => new SPWORDHANDLE((nint)(value));

        public static explicit operator nuint(SPWORDHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SPWORDHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SPWORDHANDLE.");
        }

        public int CompareTo(SPWORDHANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is SPWORDHANDLE other) && Equals(other);

        public bool Equals(SPWORDHANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
