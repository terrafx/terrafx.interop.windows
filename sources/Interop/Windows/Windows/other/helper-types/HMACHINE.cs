// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HMACHINE : IComparable, IComparable<HMACHINE>, IEquatable<HMACHINE>, IFormattable
    {
        public readonly void* Value;

        public HMACHINE(void* value)
        {
            Value = value;
        }

        public static HMACHINE INVALID_VALUE => new HMACHINE((void*)(-1));

        public static HMACHINE NULL => new HMACHINE(null);

        public static bool operator ==(HMACHINE left, HMACHINE right) => left.Value == right.Value;

        public static bool operator !=(HMACHINE left, HMACHINE right) => left.Value != right.Value;

        public static bool operator <(HMACHINE left, HMACHINE right) => left.Value < right.Value;

        public static bool operator <=(HMACHINE left, HMACHINE right) => left.Value <= right.Value;

        public static bool operator >(HMACHINE left, HMACHINE right) => left.Value > right.Value;

        public static bool operator >=(HMACHINE left, HMACHINE right) => left.Value >= right.Value;

        public static explicit operator HMACHINE(void* value) => new HMACHINE(value);

        public static implicit operator void*(HMACHINE value) => value.Value;

        public static explicit operator HMACHINE(HANDLE value) => new HMACHINE(value);

        public static implicit operator HANDLE(HMACHINE value) => new HANDLE(value.Value);

        public static explicit operator HMACHINE(byte value) => new HMACHINE((void*)(value));

        public static explicit operator byte(HMACHINE value) => (byte)(value.Value);

        public static explicit operator HMACHINE(short value) => new HMACHINE((void*)(value));

        public static explicit operator short(HMACHINE value) => (short)(value.Value);

        public static explicit operator HMACHINE(int value) => new HMACHINE((void*)(value));

        public static explicit operator int(HMACHINE value) => (int)(value.Value);

        public static explicit operator HMACHINE(long value) => new HMACHINE((void*)(value));

        public static explicit operator long(HMACHINE value) => (long)(value.Value);

        public static explicit operator HMACHINE(nint value) => new HMACHINE((void*)(value));

        public static implicit operator nint(HMACHINE value) => (nint)(value.Value);

        public static explicit operator HMACHINE(sbyte value) => new HMACHINE((void*)(value));

        public static explicit operator sbyte(HMACHINE value) => (sbyte)(value.Value);

        public static explicit operator HMACHINE(ushort value) => new HMACHINE((void*)(value));

        public static explicit operator ushort(HMACHINE value) => (ushort)(value.Value);

        public static explicit operator HMACHINE(uint value) => new HMACHINE((void*)(value));

        public static explicit operator uint(HMACHINE value) => (uint)(value.Value);

        public static explicit operator HMACHINE(ulong value) => new HMACHINE((void*)(value));

        public static explicit operator ulong(HMACHINE value) => (ulong)(value.Value);

        public static explicit operator HMACHINE(nuint value) => new HMACHINE((void*)(value));

        public static implicit operator nuint(HMACHINE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HMACHINE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMACHINE.");
        }

        public int CompareTo(HMACHINE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HMACHINE other) && Equals(other);

        public bool Equals(HMACHINE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
