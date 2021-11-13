// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HADDRESS : IComparable, IComparable<HADDRESS>, IEquatable<HADDRESS>, IFormattable
    {
        public readonly void* Value;

        public HADDRESS(void* value)
        {
            Value = value;
        }

        public static HADDRESS INVALID_VALUE => new HADDRESS((void*)(-1));

        public static HADDRESS NULL => new HADDRESS(null);

        public static bool operator ==(HADDRESS left, HADDRESS right) => left.Value == right.Value;

        public static bool operator !=(HADDRESS left, HADDRESS right) => left.Value != right.Value;

        public static bool operator <(HADDRESS left, HADDRESS right) => left.Value < right.Value;

        public static bool operator <=(HADDRESS left, HADDRESS right) => left.Value <= right.Value;

        public static bool operator >(HADDRESS left, HADDRESS right) => left.Value > right.Value;

        public static bool operator >=(HADDRESS left, HADDRESS right) => left.Value >= right.Value;

        public static explicit operator HADDRESS(void* value) => new HADDRESS(value);

        public static implicit operator void*(HADDRESS value) => value.Value;

        public static explicit operator HADDRESS(HANDLE value) => new HADDRESS(value);

        public static implicit operator HANDLE(HADDRESS value) => new HANDLE(value.Value);

        public static explicit operator HADDRESS(byte value) => new HADDRESS((void*)(value));

        public static explicit operator byte(HADDRESS value) => (byte)(value.Value);

        public static explicit operator HADDRESS(short value) => new HADDRESS((void*)(value));

        public static explicit operator short(HADDRESS value) => (short)(value.Value);

        public static explicit operator HADDRESS(int value) => new HADDRESS((void*)(value));

        public static explicit operator int(HADDRESS value) => (int)(value.Value);

        public static explicit operator HADDRESS(long value) => new HADDRESS((void*)(value));

        public static explicit operator long(HADDRESS value) => (long)(value.Value);

        public static explicit operator HADDRESS(nint value) => new HADDRESS((void*)(value));

        public static implicit operator nint(HADDRESS value) => (nint)(value.Value);

        public static explicit operator HADDRESS(sbyte value) => new HADDRESS((void*)(value));

        public static explicit operator sbyte(HADDRESS value) => (sbyte)(value.Value);

        public static explicit operator HADDRESS(ushort value) => new HADDRESS((void*)(value));

        public static explicit operator ushort(HADDRESS value) => (ushort)(value.Value);

        public static explicit operator HADDRESS(uint value) => new HADDRESS((void*)(value));

        public static explicit operator uint(HADDRESS value) => (uint)(value.Value);

        public static explicit operator HADDRESS(ulong value) => new HADDRESS((void*)(value));

        public static explicit operator ulong(HADDRESS value) => (ulong)(value.Value);

        public static explicit operator HADDRESS(nuint value) => new HADDRESS((void*)(value));

        public static implicit operator nuint(HADDRESS value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HADDRESS other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HADDRESS.");
        }

        public int CompareTo(HADDRESS other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HADDRESS other) && Equals(other);

        public bool Equals(HADDRESS other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
