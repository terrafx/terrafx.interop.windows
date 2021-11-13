// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HRECOLATTICE : IComparable, IComparable<HRECOLATTICE>, IEquatable<HRECOLATTICE>, IFormattable
    {
        public readonly void* Value;

        public HRECOLATTICE(void* value)
        {
            Value = value;
        }

        public static HRECOLATTICE INVALID_VALUE => new HRECOLATTICE((void*)(-1));

        public static HRECOLATTICE NULL => new HRECOLATTICE(null);

        public static bool operator ==(HRECOLATTICE left, HRECOLATTICE right) => left.Value == right.Value;

        public static bool operator !=(HRECOLATTICE left, HRECOLATTICE right) => left.Value != right.Value;

        public static bool operator <(HRECOLATTICE left, HRECOLATTICE right) => left.Value < right.Value;

        public static bool operator <=(HRECOLATTICE left, HRECOLATTICE right) => left.Value <= right.Value;

        public static bool operator >(HRECOLATTICE left, HRECOLATTICE right) => left.Value > right.Value;

        public static bool operator >=(HRECOLATTICE left, HRECOLATTICE right) => left.Value >= right.Value;

        public static explicit operator HRECOLATTICE(void* value) => new HRECOLATTICE(value);

        public static implicit operator void*(HRECOLATTICE value) => value.Value;

        public static explicit operator HRECOLATTICE(HANDLE value) => new HRECOLATTICE(value);

        public static implicit operator HANDLE(HRECOLATTICE value) => new HANDLE(value.Value);

        public static explicit operator HRECOLATTICE(byte value) => new HRECOLATTICE((void*)(value));

        public static explicit operator byte(HRECOLATTICE value) => (byte)(value.Value);

        public static explicit operator HRECOLATTICE(short value) => new HRECOLATTICE((void*)(value));

        public static explicit operator short(HRECOLATTICE value) => (short)(value.Value);

        public static explicit operator HRECOLATTICE(int value) => new HRECOLATTICE((void*)(value));

        public static explicit operator int(HRECOLATTICE value) => (int)(value.Value);

        public static explicit operator HRECOLATTICE(long value) => new HRECOLATTICE((void*)(value));

        public static explicit operator long(HRECOLATTICE value) => (long)(value.Value);

        public static explicit operator HRECOLATTICE(nint value) => new HRECOLATTICE((void*)(value));

        public static implicit operator nint(HRECOLATTICE value) => (nint)(value.Value);

        public static explicit operator HRECOLATTICE(sbyte value) => new HRECOLATTICE((void*)(value));

        public static explicit operator sbyte(HRECOLATTICE value) => (sbyte)(value.Value);

        public static explicit operator HRECOLATTICE(ushort value) => new HRECOLATTICE((void*)(value));

        public static explicit operator ushort(HRECOLATTICE value) => (ushort)(value.Value);

        public static explicit operator HRECOLATTICE(uint value) => new HRECOLATTICE((void*)(value));

        public static explicit operator uint(HRECOLATTICE value) => (uint)(value.Value);

        public static explicit operator HRECOLATTICE(ulong value) => new HRECOLATTICE((void*)(value));

        public static explicit operator ulong(HRECOLATTICE value) => (ulong)(value.Value);

        public static explicit operator HRECOLATTICE(nuint value) => new HRECOLATTICE((void*)(value));

        public static implicit operator nuint(HRECOLATTICE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HRECOLATTICE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HRECOLATTICE.");
        }

        public int CompareTo(HRECOLATTICE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HRECOLATTICE other) && Equals(other);

        public bool Equals(HRECOLATTICE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
