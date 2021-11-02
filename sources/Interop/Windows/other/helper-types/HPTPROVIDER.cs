// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPTPROVIDER : IComparable, IComparable<HPTPROVIDER>, IEquatable<HPTPROVIDER>, IFormattable
    {
        public readonly void* Value;

        public HPTPROVIDER(void* value)
        {
            Value = value;
        }

        public static HPTPROVIDER INVALID_VALUE => new HPTPROVIDER((void*)(-1));

        public static HPTPROVIDER NULL => new HPTPROVIDER(null);

        public static bool operator ==(HPTPROVIDER left, HPTPROVIDER right) => left.Value == right.Value;

        public static bool operator !=(HPTPROVIDER left, HPTPROVIDER right) => left.Value != right.Value;

        public static bool operator <(HPTPROVIDER left, HPTPROVIDER right) => left.Value < right.Value;

        public static bool operator <=(HPTPROVIDER left, HPTPROVIDER right) => left.Value <= right.Value;

        public static bool operator >(HPTPROVIDER left, HPTPROVIDER right) => left.Value > right.Value;

        public static bool operator >=(HPTPROVIDER left, HPTPROVIDER right) => left.Value >= right.Value;

        public static explicit operator HPTPROVIDER(void* value) => new HPTPROVIDER(value);

        public static implicit operator void*(HPTPROVIDER value) => value.Value;

        public static explicit operator HPTPROVIDER(HANDLE value) => new HPTPROVIDER(value);

        public static implicit operator HANDLE(HPTPROVIDER value) => new HANDLE(value.Value);

        public static explicit operator HPTPROVIDER(byte value) => new HPTPROVIDER((void*)(value));

        public static explicit operator byte(HPTPROVIDER value) => (byte)(value.Value);

        public static explicit operator HPTPROVIDER(short value) => new HPTPROVIDER((void*)(value));

        public static explicit operator short(HPTPROVIDER value) => (short)(value.Value);

        public static explicit operator HPTPROVIDER(int value) => new HPTPROVIDER((void*)(value));

        public static explicit operator int(HPTPROVIDER value) => (int)(value.Value);

        public static explicit operator HPTPROVIDER(long value) => new HPTPROVIDER((void*)(value));

        public static explicit operator long(HPTPROVIDER value) => (long)(value.Value);

        public static explicit operator HPTPROVIDER(nint value) => new HPTPROVIDER((void*)(value));

        public static implicit operator nint(HPTPROVIDER value) => (nint)(value.Value);

        public static explicit operator HPTPROVIDER(sbyte value) => new HPTPROVIDER((void*)(value));

        public static explicit operator sbyte(HPTPROVIDER value) => (sbyte)(value.Value);

        public static explicit operator HPTPROVIDER(ushort value) => new HPTPROVIDER((void*)(value));

        public static explicit operator ushort(HPTPROVIDER value) => (ushort)(value.Value);

        public static explicit operator HPTPROVIDER(uint value) => new HPTPROVIDER((void*)(value));

        public static explicit operator uint(HPTPROVIDER value) => (uint)(value.Value);

        public static explicit operator HPTPROVIDER(ulong value) => new HPTPROVIDER((void*)(value));

        public static explicit operator ulong(HPTPROVIDER value) => (ulong)(value.Value);

        public static explicit operator HPTPROVIDER(nuint value) => new HPTPROVIDER((void*)(value));

        public static implicit operator nuint(HPTPROVIDER value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HPTPROVIDER other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HPTPROVIDER.");
        }

        public int CompareTo(HPTPROVIDER other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HPTPROVIDER other) && Equals(other);

        public bool Equals(HPTPROVIDER other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
