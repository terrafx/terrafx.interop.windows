// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSZ : IComparable, IComparable<HSZ>, IEquatable<HSZ>, IFormattable
    {
        public readonly void* Value;

        public HSZ(void* value)
        {
            Value = value;
        }

        public static HSZ INVALID_VALUE => new HSZ((void*)(-1));

        public static HSZ NULL => new HSZ(null);

        public static bool operator ==(HSZ left, HSZ right) => left.Value == right.Value;

        public static bool operator !=(HSZ left, HSZ right) => left.Value != right.Value;

        public static bool operator <(HSZ left, HSZ right) => left.Value < right.Value;

        public static bool operator <=(HSZ left, HSZ right) => left.Value <= right.Value;

        public static bool operator >(HSZ left, HSZ right) => left.Value > right.Value;

        public static bool operator >=(HSZ left, HSZ right) => left.Value >= right.Value;

        public static explicit operator HSZ(void* value) => new HSZ(value);

        public static implicit operator void*(HSZ value) => value.Value;

        public static explicit operator HSZ(HANDLE value) => new HSZ(value);

        public static implicit operator HANDLE(HSZ value) => new HANDLE(value.Value);

        public static explicit operator HSZ(byte value) => new HSZ((void*)(value));

        public static explicit operator byte(HSZ value) => (byte)(value.Value);

        public static explicit operator HSZ(short value) => new HSZ((void*)(value));

        public static explicit operator short(HSZ value) => (short)(value.Value);

        public static explicit operator HSZ(int value) => new HSZ((void*)(value));

        public static explicit operator int(HSZ value) => (int)(value.Value);

        public static explicit operator HSZ(long value) => new HSZ((void*)(value));

        public static explicit operator long(HSZ value) => (long)(value.Value);

        public static explicit operator HSZ(nint value) => new HSZ((void*)(value));

        public static implicit operator nint(HSZ value) => (nint)(value.Value);

        public static explicit operator HSZ(sbyte value) => new HSZ((void*)(value));

        public static explicit operator sbyte(HSZ value) => (sbyte)(value.Value);

        public static explicit operator HSZ(ushort value) => new HSZ((void*)(value));

        public static explicit operator ushort(HSZ value) => (ushort)(value.Value);

        public static explicit operator HSZ(uint value) => new HSZ((void*)(value));

        public static explicit operator uint(HSZ value) => (uint)(value.Value);

        public static explicit operator HSZ(ulong value) => new HSZ((void*)(value));

        public static explicit operator ulong(HSZ value) => (ulong)(value.Value);

        public static explicit operator HSZ(nuint value) => new HSZ((void*)(value));

        public static implicit operator nuint(HSZ value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HSZ other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSZ.");
        }

        public int CompareTo(HSZ other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HSZ other) && Equals(other);

        public bool Equals(HSZ other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
