// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HAMSISESSION : IComparable, IComparable<HAMSISESSION>, IEquatable<HAMSISESSION>, IFormattable
    {
        public readonly void* Value;

        public HAMSISESSION(void* value)
        {
            Value = value;
        }

        public static HAMSISESSION INVALID_VALUE => new HAMSISESSION((void*)(-1));

        public static HAMSISESSION NULL => new HAMSISESSION(null);

        public static bool operator ==(HAMSISESSION left, HAMSISESSION right) => left.Value == right.Value;

        public static bool operator !=(HAMSISESSION left, HAMSISESSION right) => left.Value != right.Value;

        public static bool operator <(HAMSISESSION left, HAMSISESSION right) => left.Value < right.Value;

        public static bool operator <=(HAMSISESSION left, HAMSISESSION right) => left.Value <= right.Value;

        public static bool operator >(HAMSISESSION left, HAMSISESSION right) => left.Value > right.Value;

        public static bool operator >=(HAMSISESSION left, HAMSISESSION right) => left.Value >= right.Value;

        public static explicit operator HAMSISESSION(void* value) => new HAMSISESSION(value);

        public static implicit operator void*(HAMSISESSION value) => value.Value;

        public static explicit operator HAMSISESSION(HANDLE value) => new HAMSISESSION(value);

        public static implicit operator HANDLE(HAMSISESSION value) => new HANDLE(value.Value);

        public static explicit operator HAMSISESSION(byte value) => new HAMSISESSION((void*)(value));

        public static explicit operator byte(HAMSISESSION value) => (byte)(value.Value);

        public static explicit operator HAMSISESSION(short value) => new HAMSISESSION((void*)(value));

        public static explicit operator short(HAMSISESSION value) => (short)(value.Value);

        public static explicit operator HAMSISESSION(int value) => new HAMSISESSION((void*)(value));

        public static explicit operator int(HAMSISESSION value) => (int)(value.Value);

        public static explicit operator HAMSISESSION(long value) => new HAMSISESSION((void*)(value));

        public static explicit operator long(HAMSISESSION value) => (long)(value.Value);

        public static explicit operator HAMSISESSION(nint value) => new HAMSISESSION((void*)(value));

        public static implicit operator nint(HAMSISESSION value) => (nint)(value.Value);

        public static explicit operator HAMSISESSION(sbyte value) => new HAMSISESSION((void*)(value));

        public static explicit operator sbyte(HAMSISESSION value) => (sbyte)(value.Value);

        public static explicit operator HAMSISESSION(ushort value) => new HAMSISESSION((void*)(value));

        public static explicit operator ushort(HAMSISESSION value) => (ushort)(value.Value);

        public static explicit operator HAMSISESSION(uint value) => new HAMSISESSION((void*)(value));

        public static explicit operator uint(HAMSISESSION value) => (uint)(value.Value);

        public static explicit operator HAMSISESSION(ulong value) => new HAMSISESSION((void*)(value));

        public static explicit operator ulong(HAMSISESSION value) => (ulong)(value.Value);

        public static explicit operator HAMSISESSION(nuint value) => new HAMSISESSION((void*)(value));

        public static implicit operator nuint(HAMSISESSION value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HAMSISESSION other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HAMSISESSION.");
        }

        public int CompareTo(HAMSISESSION other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HAMSISESSION other) && Equals(other);

        public bool Equals(HAMSISESSION other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
