// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SAFER_LEVEL_HANDLE : IComparable, IComparable<SAFER_LEVEL_HANDLE>, IEquatable<SAFER_LEVEL_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public SAFER_LEVEL_HANDLE(void* value)
        {
            Value = value;
        }

        public static SAFER_LEVEL_HANDLE INVALID_VALUE => new SAFER_LEVEL_HANDLE((void*)(-1));

        public static SAFER_LEVEL_HANDLE NULL => new SAFER_LEVEL_HANDLE(null);

        public static bool operator ==(SAFER_LEVEL_HANDLE left, SAFER_LEVEL_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(SAFER_LEVEL_HANDLE left, SAFER_LEVEL_HANDLE right) => left.Value != right.Value;

        public static bool operator <(SAFER_LEVEL_HANDLE left, SAFER_LEVEL_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(SAFER_LEVEL_HANDLE left, SAFER_LEVEL_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(SAFER_LEVEL_HANDLE left, SAFER_LEVEL_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(SAFER_LEVEL_HANDLE left, SAFER_LEVEL_HANDLE right) => left.Value >= right.Value;

        public static explicit operator SAFER_LEVEL_HANDLE(void* value) => new SAFER_LEVEL_HANDLE(value);

        public static implicit operator void*(SAFER_LEVEL_HANDLE value) => value.Value;

        public static explicit operator SAFER_LEVEL_HANDLE(HANDLE value) => new SAFER_LEVEL_HANDLE(value);

        public static implicit operator HANDLE(SAFER_LEVEL_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator SAFER_LEVEL_HANDLE(byte value) => new SAFER_LEVEL_HANDLE((void*)(value));

        public static explicit operator byte(SAFER_LEVEL_HANDLE value) => (byte)(value.Value);

        public static explicit operator SAFER_LEVEL_HANDLE(short value) => new SAFER_LEVEL_HANDLE((void*)(value));

        public static explicit operator short(SAFER_LEVEL_HANDLE value) => (short)(value.Value);

        public static explicit operator SAFER_LEVEL_HANDLE(int value) => new SAFER_LEVEL_HANDLE((void*)(value));

        public static explicit operator int(SAFER_LEVEL_HANDLE value) => (int)(value.Value);

        public static explicit operator SAFER_LEVEL_HANDLE(long value) => new SAFER_LEVEL_HANDLE((void*)(value));

        public static explicit operator long(SAFER_LEVEL_HANDLE value) => (long)(value.Value);

        public static explicit operator SAFER_LEVEL_HANDLE(nint value) => new SAFER_LEVEL_HANDLE((void*)(value));

        public static implicit operator nint(SAFER_LEVEL_HANDLE value) => (nint)(value.Value);

        public static explicit operator SAFER_LEVEL_HANDLE(sbyte value) => new SAFER_LEVEL_HANDLE((void*)(value));

        public static explicit operator sbyte(SAFER_LEVEL_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator SAFER_LEVEL_HANDLE(ushort value) => new SAFER_LEVEL_HANDLE((void*)(value));

        public static explicit operator ushort(SAFER_LEVEL_HANDLE value) => (ushort)(value.Value);

        public static explicit operator SAFER_LEVEL_HANDLE(uint value) => new SAFER_LEVEL_HANDLE((void*)(value));

        public static explicit operator uint(SAFER_LEVEL_HANDLE value) => (uint)(value.Value);

        public static explicit operator SAFER_LEVEL_HANDLE(ulong value) => new SAFER_LEVEL_HANDLE((void*)(value));

        public static explicit operator ulong(SAFER_LEVEL_HANDLE value) => (ulong)(value.Value);

        public static explicit operator SAFER_LEVEL_HANDLE(nuint value) => new SAFER_LEVEL_HANDLE((void*)(value));

        public static implicit operator nuint(SAFER_LEVEL_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SAFER_LEVEL_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SAFER_LEVEL_HANDLE.");
        }

        public int CompareTo(SAFER_LEVEL_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is SAFER_LEVEL_HANDLE other) && Equals(other);

        public bool Equals(SAFER_LEVEL_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
