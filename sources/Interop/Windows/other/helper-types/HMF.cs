// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMF : IComparable, IComparable<HMF>, IEquatable<HMF>, IFormattable
    {
        public readonly void* Value;

        public HMF(void* value)
        {
            Value = value;
        }

        public static HMF INVALID_VALUE => new HMF((void*)(-1));

        public static HMF NULL => new HMF(null);

        public static bool operator ==(HMF left, HMF right) => left.Value == right.Value;

        public static bool operator !=(HMF left, HMF right) => left.Value != right.Value;

        public static bool operator <(HMF left, HMF right) => left.Value < right.Value;

        public static bool operator <=(HMF left, HMF right) => left.Value <= right.Value;

        public static bool operator >(HMF left, HMF right) => left.Value > right.Value;

        public static bool operator >=(HMF left, HMF right) => left.Value >= right.Value;

        public static explicit operator HMF(void* value) => new HMF(value);

        public static implicit operator void*(HMF value) => value.Value;

        public static explicit operator HMF(HANDLE value) => new HMF(value);

        public static implicit operator HANDLE(HMF value) => new HANDLE(value.Value);

        public static explicit operator HMF(byte value) => new HMF((void*)(value));

        public static explicit operator byte(HMF value) => (byte)(value.Value);

        public static explicit operator HMF(short value) => new HMF((void*)(value));

        public static explicit operator short(HMF value) => (short)(value.Value);

        public static explicit operator HMF(int value) => new HMF((void*)(value));

        public static explicit operator int(HMF value) => (int)(value.Value);

        public static explicit operator HMF(long value) => new HMF((void*)(value));

        public static explicit operator long(HMF value) => (long)(value.Value);

        public static explicit operator HMF(nint value) => new HMF((void*)(value));

        public static implicit operator nint(HMF value) => (nint)(value.Value);

        public static explicit operator HMF(sbyte value) => new HMF((void*)(value));

        public static explicit operator sbyte(HMF value) => (sbyte)(value.Value);

        public static explicit operator HMF(ushort value) => new HMF((void*)(value));

        public static explicit operator ushort(HMF value) => (ushort)(value.Value);

        public static explicit operator HMF(uint value) => new HMF((void*)(value));

        public static explicit operator uint(HMF value) => (uint)(value.Value);

        public static explicit operator HMF(ulong value) => new HMF((void*)(value));

        public static explicit operator ulong(HMF value) => (ulong)(value.Value);

        public static explicit operator HMF(nuint value) => new HMF((void*)(value));

        public static implicit operator nuint(HMF value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HMF other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMF.");
        }

        public int CompareTo(HMF other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HMF other) && Equals(other);

        public bool Equals(HMF other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
