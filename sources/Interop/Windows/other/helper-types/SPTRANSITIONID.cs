// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPTRANSITIONID : IComparable, IComparable<SPTRANSITIONID>, IEquatable<SPTRANSITIONID>, IFormattable
    {
        public readonly void* Value;

        public SPTRANSITIONID(void* value)
        {
            Value = value;
        }

        public static SPTRANSITIONID INVALID_VALUE => new SPTRANSITIONID((void*)(-1));

        public static SPTRANSITIONID NULL => new SPTRANSITIONID(null);

        public static bool operator ==(SPTRANSITIONID left, SPTRANSITIONID right) => left.Value == right.Value;

        public static bool operator !=(SPTRANSITIONID left, SPTRANSITIONID right) => left.Value != right.Value;

        public static bool operator <(SPTRANSITIONID left, SPTRANSITIONID right) => left.Value < right.Value;

        public static bool operator <=(SPTRANSITIONID left, SPTRANSITIONID right) => left.Value <= right.Value;

        public static bool operator >(SPTRANSITIONID left, SPTRANSITIONID right) => left.Value > right.Value;

        public static bool operator >=(SPTRANSITIONID left, SPTRANSITIONID right) => left.Value >= right.Value;

        public static explicit operator SPTRANSITIONID(void* value) => new SPTRANSITIONID(value);

        public static implicit operator void*(SPTRANSITIONID value) => value.Value;

        public static explicit operator SPTRANSITIONID(HANDLE value) => new SPTRANSITIONID(value);

        public static implicit operator HANDLE(SPTRANSITIONID value) => new HANDLE(value.Value);

        public static explicit operator SPTRANSITIONID(byte value) => new SPTRANSITIONID((void*)(value));

        public static explicit operator byte(SPTRANSITIONID value) => (byte)(value.Value);

        public static explicit operator SPTRANSITIONID(short value) => new SPTRANSITIONID((void*)(value));

        public static explicit operator short(SPTRANSITIONID value) => (short)(value.Value);

        public static explicit operator SPTRANSITIONID(int value) => new SPTRANSITIONID((void*)(value));

        public static explicit operator int(SPTRANSITIONID value) => (int)(value.Value);

        public static explicit operator SPTRANSITIONID(long value) => new SPTRANSITIONID((void*)(value));

        public static explicit operator long(SPTRANSITIONID value) => (long)(value.Value);

        public static explicit operator SPTRANSITIONID(nint value) => new SPTRANSITIONID((void*)(value));

        public static implicit operator nint(SPTRANSITIONID value) => (nint)(value.Value);

        public static explicit operator SPTRANSITIONID(sbyte value) => new SPTRANSITIONID((void*)(value));

        public static explicit operator sbyte(SPTRANSITIONID value) => (sbyte)(value.Value);

        public static explicit operator SPTRANSITIONID(ushort value) => new SPTRANSITIONID((void*)(value));

        public static explicit operator ushort(SPTRANSITIONID value) => (ushort)(value.Value);

        public static explicit operator SPTRANSITIONID(uint value) => new SPTRANSITIONID((void*)(value));

        public static explicit operator uint(SPTRANSITIONID value) => (uint)(value.Value);

        public static explicit operator SPTRANSITIONID(ulong value) => new SPTRANSITIONID((void*)(value));

        public static explicit operator ulong(SPTRANSITIONID value) => (ulong)(value.Value);

        public static explicit operator SPTRANSITIONID(nuint value) => new SPTRANSITIONID((void*)(value));

        public static implicit operator nuint(SPTRANSITIONID value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SPTRANSITIONID other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SPTRANSITIONID.");
        }

        public int CompareTo(SPTRANSITIONID other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is SPTRANSITIONID other) && Equals(other);

        public bool Equals(SPTRANSITIONID other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
