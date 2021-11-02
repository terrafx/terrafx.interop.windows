// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDRVR : IComparable, IComparable<HDRVR>, IEquatable<HDRVR>, IFormattable
    {
        public readonly void* Value;

        public HDRVR(void* value)
        {
            Value = value;
        }

        public static HDRVR INVALID_VALUE => new HDRVR((void*)(-1));

        public static HDRVR NULL => new HDRVR(null);

        public static bool operator ==(HDRVR left, HDRVR right) => left.Value == right.Value;

        public static bool operator !=(HDRVR left, HDRVR right) => left.Value != right.Value;

        public static bool operator <(HDRVR left, HDRVR right) => left.Value < right.Value;

        public static bool operator <=(HDRVR left, HDRVR right) => left.Value <= right.Value;

        public static bool operator >(HDRVR left, HDRVR right) => left.Value > right.Value;

        public static bool operator >=(HDRVR left, HDRVR right) => left.Value >= right.Value;

        public static explicit operator HDRVR(void* value) => new HDRVR(value);

        public static implicit operator void*(HDRVR value) => value.Value;

        public static explicit operator HDRVR(HANDLE value) => new HDRVR(value);

        public static implicit operator HANDLE(HDRVR value) => new HANDLE(value.Value);

        public static explicit operator HDRVR(byte value) => new HDRVR((void*)(value));

        public static explicit operator byte(HDRVR value) => (byte)(value.Value);

        public static explicit operator HDRVR(short value) => new HDRVR((void*)(value));

        public static explicit operator short(HDRVR value) => (short)(value.Value);

        public static explicit operator HDRVR(int value) => new HDRVR((void*)(value));

        public static explicit operator int(HDRVR value) => (int)(value.Value);

        public static explicit operator HDRVR(long value) => new HDRVR((void*)(value));

        public static explicit operator long(HDRVR value) => (long)(value.Value);

        public static explicit operator HDRVR(nint value) => new HDRVR((void*)(value));

        public static implicit operator nint(HDRVR value) => (nint)(value.Value);

        public static explicit operator HDRVR(sbyte value) => new HDRVR((void*)(value));

        public static explicit operator sbyte(HDRVR value) => (sbyte)(value.Value);

        public static explicit operator HDRVR(ushort value) => new HDRVR((void*)(value));

        public static explicit operator ushort(HDRVR value) => (ushort)(value.Value);

        public static explicit operator HDRVR(uint value) => new HDRVR((void*)(value));

        public static explicit operator uint(HDRVR value) => (uint)(value.Value);

        public static explicit operator HDRVR(ulong value) => new HDRVR((void*)(value));

        public static explicit operator ulong(HDRVR value) => (ulong)(value.Value);

        public static explicit operator HDRVR(nuint value) => new HDRVR((void*)(value));

        public static implicit operator nuint(HDRVR value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDRVR other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDRVR.");
        }

        public int CompareTo(HDRVR other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HDRVR other) && Equals(other);

        public bool Equals(HDRVR other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
