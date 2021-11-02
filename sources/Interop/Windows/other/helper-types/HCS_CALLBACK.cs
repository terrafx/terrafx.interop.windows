// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCS_CALLBACK : IComparable, IComparable<HCS_CALLBACK>, IEquatable<HCS_CALLBACK>, IFormattable
    {
        public readonly void* Value;

        public HCS_CALLBACK(void* value)
        {
            Value = value;
        }

        public static HCS_CALLBACK INVALID_VALUE => new HCS_CALLBACK((void*)(-1));

        public static HCS_CALLBACK NULL => new HCS_CALLBACK(null);

        public static bool operator ==(HCS_CALLBACK left, HCS_CALLBACK right) => left.Value == right.Value;

        public static bool operator !=(HCS_CALLBACK left, HCS_CALLBACK right) => left.Value != right.Value;

        public static bool operator <(HCS_CALLBACK left, HCS_CALLBACK right) => left.Value < right.Value;

        public static bool operator <=(HCS_CALLBACK left, HCS_CALLBACK right) => left.Value <= right.Value;

        public static bool operator >(HCS_CALLBACK left, HCS_CALLBACK right) => left.Value > right.Value;

        public static bool operator >=(HCS_CALLBACK left, HCS_CALLBACK right) => left.Value >= right.Value;

        public static explicit operator HCS_CALLBACK(void* value) => new HCS_CALLBACK(value);

        public static implicit operator void*(HCS_CALLBACK value) => value.Value;

        public static explicit operator HCS_CALLBACK(HANDLE value) => new HCS_CALLBACK(value);

        public static implicit operator HANDLE(HCS_CALLBACK value) => new HANDLE(value.Value);

        public static explicit operator HCS_CALLBACK(byte value) => new HCS_CALLBACK((void*)(value));

        public static explicit operator byte(HCS_CALLBACK value) => (byte)(value.Value);

        public static explicit operator HCS_CALLBACK(short value) => new HCS_CALLBACK((void*)(value));

        public static explicit operator short(HCS_CALLBACK value) => (short)(value.Value);

        public static explicit operator HCS_CALLBACK(int value) => new HCS_CALLBACK((void*)(value));

        public static explicit operator int(HCS_CALLBACK value) => (int)(value.Value);

        public static explicit operator HCS_CALLBACK(long value) => new HCS_CALLBACK((void*)(value));

        public static explicit operator long(HCS_CALLBACK value) => (long)(value.Value);

        public static explicit operator HCS_CALLBACK(nint value) => new HCS_CALLBACK((void*)(value));

        public static implicit operator nint(HCS_CALLBACK value) => (nint)(value.Value);

        public static explicit operator HCS_CALLBACK(sbyte value) => new HCS_CALLBACK((void*)(value));

        public static explicit operator sbyte(HCS_CALLBACK value) => (sbyte)(value.Value);

        public static explicit operator HCS_CALLBACK(ushort value) => new HCS_CALLBACK((void*)(value));

        public static explicit operator ushort(HCS_CALLBACK value) => (ushort)(value.Value);

        public static explicit operator HCS_CALLBACK(uint value) => new HCS_CALLBACK((void*)(value));

        public static explicit operator uint(HCS_CALLBACK value) => (uint)(value.Value);

        public static explicit operator HCS_CALLBACK(ulong value) => new HCS_CALLBACK((void*)(value));

        public static explicit operator ulong(HCS_CALLBACK value) => (ulong)(value.Value);

        public static explicit operator HCS_CALLBACK(nuint value) => new HCS_CALLBACK((void*)(value));

        public static implicit operator nuint(HCS_CALLBACK value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCS_CALLBACK other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCS_CALLBACK.");
        }

        public int CompareTo(HCS_CALLBACK other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HCS_CALLBACK other) && Equals(other);

        public bool Equals(HCS_CALLBACK other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
