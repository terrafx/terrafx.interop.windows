// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct LPM_HANDLE : IComparable, IComparable<LPM_HANDLE>, IEquatable<LPM_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public LPM_HANDLE(void* value)
        {
            Value = value;
        }

        public static LPM_HANDLE INVALID_VALUE => new LPM_HANDLE((void*)(-1));

        public static LPM_HANDLE NULL => new LPM_HANDLE(null);

        public static bool operator ==(LPM_HANDLE left, LPM_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(LPM_HANDLE left, LPM_HANDLE right) => left.Value != right.Value;

        public static bool operator <(LPM_HANDLE left, LPM_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(LPM_HANDLE left, LPM_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(LPM_HANDLE left, LPM_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(LPM_HANDLE left, LPM_HANDLE right) => left.Value >= right.Value;

        public static explicit operator LPM_HANDLE(void* value) => new LPM_HANDLE(value);

        public static implicit operator void*(LPM_HANDLE value) => value.Value;

        public static explicit operator LPM_HANDLE(HANDLE value) => new LPM_HANDLE(value);

        public static implicit operator HANDLE(LPM_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator LPM_HANDLE(byte value) => new LPM_HANDLE((void*)(value));

        public static explicit operator byte(LPM_HANDLE value) => (byte)(value.Value);

        public static explicit operator LPM_HANDLE(short value) => new LPM_HANDLE((void*)(value));

        public static explicit operator short(LPM_HANDLE value) => (short)(value.Value);

        public static explicit operator LPM_HANDLE(int value) => new LPM_HANDLE((void*)(value));

        public static explicit operator int(LPM_HANDLE value) => (int)(value.Value);

        public static explicit operator LPM_HANDLE(long value) => new LPM_HANDLE((void*)(value));

        public static explicit operator long(LPM_HANDLE value) => (long)(value.Value);

        public static explicit operator LPM_HANDLE(nint value) => new LPM_HANDLE((void*)(value));

        public static implicit operator nint(LPM_HANDLE value) => (nint)(value.Value);

        public static explicit operator LPM_HANDLE(sbyte value) => new LPM_HANDLE((void*)(value));

        public static explicit operator sbyte(LPM_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator LPM_HANDLE(ushort value) => new LPM_HANDLE((void*)(value));

        public static explicit operator ushort(LPM_HANDLE value) => (ushort)(value.Value);

        public static explicit operator LPM_HANDLE(uint value) => new LPM_HANDLE((void*)(value));

        public static explicit operator uint(LPM_HANDLE value) => (uint)(value.Value);

        public static explicit operator LPM_HANDLE(ulong value) => new LPM_HANDLE((void*)(value));

        public static explicit operator ulong(LPM_HANDLE value) => (ulong)(value.Value);

        public static explicit operator LPM_HANDLE(nuint value) => new LPM_HANDLE((void*)(value));

        public static implicit operator nuint(LPM_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is LPM_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of LPM_HANDLE.");
        }

        public int CompareTo(LPM_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is LPM_HANDLE other) && Equals(other);

        public bool Equals(LPM_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
