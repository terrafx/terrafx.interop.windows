// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCS_PROCESS : IComparable, IComparable<HCS_PROCESS>, IEquatable<HCS_PROCESS>, IFormattable
    {
        public readonly nint Value;

        public HCS_PROCESS(nint value)
        {
            Value = value;
        }

        public static HCS_PROCESS INVALID_VALUE => new HCS_PROCESS(-1);

        public static HCS_PROCESS NULL => new HCS_PROCESS(0);

        public static bool operator ==(HCS_PROCESS left, HCS_PROCESS right) => left.Value == right.Value;

        public static bool operator !=(HCS_PROCESS left, HCS_PROCESS right) => left.Value != right.Value;

        public static bool operator <(HCS_PROCESS left, HCS_PROCESS right) => left.Value < right.Value;

        public static bool operator <=(HCS_PROCESS left, HCS_PROCESS right) => left.Value <= right.Value;

        public static bool operator >(HCS_PROCESS left, HCS_PROCESS right) => left.Value > right.Value;

        public static bool operator >=(HCS_PROCESS left, HCS_PROCESS right) => left.Value >= right.Value;

        public static explicit operator HCS_PROCESS(void* value) => new HCS_PROCESS((nint)(value));

        public static implicit operator void*(HCS_PROCESS value) => (void*)(value.Value);

        public static explicit operator HCS_PROCESS(HANDLE value) => new HCS_PROCESS(value);

        public static implicit operator HANDLE(HCS_PROCESS value) => new HANDLE(value.Value);

        public static explicit operator HCS_PROCESS(byte value) => new HCS_PROCESS((nint)(value));

        public static explicit operator byte(HCS_PROCESS value) => (byte)(value.Value);

        public static explicit operator HCS_PROCESS(short value) => new HCS_PROCESS((nint)(value));

        public static explicit operator short(HCS_PROCESS value) => (short)(value.Value);

        public static explicit operator HCS_PROCESS(int value) => new HCS_PROCESS((nint)(value));

        public static explicit operator int(HCS_PROCESS value) => (int)(value.Value);

        public static explicit operator HCS_PROCESS(long value) => new HCS_PROCESS((nint)(value));

        public static implicit operator long(HCS_PROCESS value) => (long)(value.Value);

        public static explicit operator HCS_PROCESS(nint value) => new HCS_PROCESS((nint)(value));

        public static implicit operator nint(HCS_PROCESS value) => (nint)(value.Value);

        public static explicit operator HCS_PROCESS(sbyte value) => new HCS_PROCESS((nint)(value));

        public static explicit operator sbyte(HCS_PROCESS value) => (sbyte)(value.Value);

        public static explicit operator HCS_PROCESS(ushort value) => new HCS_PROCESS((nint)(value));

        public static explicit operator ushort(HCS_PROCESS value) => (ushort)(value.Value);

        public static explicit operator HCS_PROCESS(uint value) => new HCS_PROCESS((nint)(value));

        public static explicit operator uint(HCS_PROCESS value) => (uint)(value.Value);

        public static explicit operator HCS_PROCESS(ulong value) => new HCS_PROCESS((nint)(value));

        public static explicit operator ulong(HCS_PROCESS value) => (ulong)(value.Value);

        public static explicit operator HCS_PROCESS(nuint value) => new HCS_PROCESS((nint)(value));

        public static explicit operator nuint(HCS_PROCESS value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCS_PROCESS other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCS_PROCESS.");
        }

        public int CompareTo(HCS_PROCESS other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HCS_PROCESS other) && Equals(other);

        public bool Equals(HCS_PROCESS other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
