// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HCS_OPERATION : IComparable, IComparable<HCS_OPERATION>, IEquatable<HCS_OPERATION>, IFormattable
    {
        public readonly void* Value;

        public HCS_OPERATION(void* value)
        {
            Value = value;
        }

        public static HCS_OPERATION INVALID_VALUE => new HCS_OPERATION((void*)(-1));

        public static HCS_OPERATION NULL => new HCS_OPERATION(null);

        public static bool operator ==(HCS_OPERATION left, HCS_OPERATION right) => left.Value == right.Value;

        public static bool operator !=(HCS_OPERATION left, HCS_OPERATION right) => left.Value != right.Value;

        public static bool operator <(HCS_OPERATION left, HCS_OPERATION right) => left.Value < right.Value;

        public static bool operator <=(HCS_OPERATION left, HCS_OPERATION right) => left.Value <= right.Value;

        public static bool operator >(HCS_OPERATION left, HCS_OPERATION right) => left.Value > right.Value;

        public static bool operator >=(HCS_OPERATION left, HCS_OPERATION right) => left.Value >= right.Value;

        public static explicit operator HCS_OPERATION(void* value) => new HCS_OPERATION(value);

        public static implicit operator void*(HCS_OPERATION value) => value.Value;

        public static explicit operator HCS_OPERATION(HANDLE value) => new HCS_OPERATION(value);

        public static implicit operator HANDLE(HCS_OPERATION value) => new HANDLE(value.Value);

        public static explicit operator HCS_OPERATION(byte value) => new HCS_OPERATION((void*)(value));

        public static explicit operator byte(HCS_OPERATION value) => (byte)(value.Value);

        public static explicit operator HCS_OPERATION(short value) => new HCS_OPERATION((void*)(value));

        public static explicit operator short(HCS_OPERATION value) => (short)(value.Value);

        public static explicit operator HCS_OPERATION(int value) => new HCS_OPERATION((void*)(value));

        public static explicit operator int(HCS_OPERATION value) => (int)(value.Value);

        public static explicit operator HCS_OPERATION(long value) => new HCS_OPERATION((void*)(value));

        public static explicit operator long(HCS_OPERATION value) => (long)(value.Value);

        public static explicit operator HCS_OPERATION(nint value) => new HCS_OPERATION((void*)(value));

        public static implicit operator nint(HCS_OPERATION value) => (nint)(value.Value);

        public static explicit operator HCS_OPERATION(sbyte value) => new HCS_OPERATION((void*)(value));

        public static explicit operator sbyte(HCS_OPERATION value) => (sbyte)(value.Value);

        public static explicit operator HCS_OPERATION(ushort value) => new HCS_OPERATION((void*)(value));

        public static explicit operator ushort(HCS_OPERATION value) => (ushort)(value.Value);

        public static explicit operator HCS_OPERATION(uint value) => new HCS_OPERATION((void*)(value));

        public static explicit operator uint(HCS_OPERATION value) => (uint)(value.Value);

        public static explicit operator HCS_OPERATION(ulong value) => new HCS_OPERATION((void*)(value));

        public static explicit operator ulong(HCS_OPERATION value) => (ulong)(value.Value);

        public static explicit operator HCS_OPERATION(nuint value) => new HCS_OPERATION((void*)(value));

        public static implicit operator nuint(HCS_OPERATION value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCS_OPERATION other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCS_OPERATION.");
        }

        public int CompareTo(HCS_OPERATION other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HCS_OPERATION other) && Equals(other);

        public bool Equals(HCS_OPERATION other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
