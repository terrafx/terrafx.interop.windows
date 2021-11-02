// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PTP_CALLBACK_INSTANCE : IComparable, IComparable<PTP_CALLBACK_INSTANCE>, IEquatable<PTP_CALLBACK_INSTANCE>, IFormattable
    {
        public readonly nint Value;

        public PTP_CALLBACK_INSTANCE(nint value)
        {
            Value = value;
        }

        public static PTP_CALLBACK_INSTANCE NULL => new PTP_CALLBACK_INSTANCE(0);

        public static bool operator ==(PTP_CALLBACK_INSTANCE left, PTP_CALLBACK_INSTANCE right) => left.Value == right.Value;

        public static bool operator !=(PTP_CALLBACK_INSTANCE left, PTP_CALLBACK_INSTANCE right) => left.Value != right.Value;

        public static bool operator <(PTP_CALLBACK_INSTANCE left, PTP_CALLBACK_INSTANCE right) => left.Value < right.Value;

        public static bool operator <=(PTP_CALLBACK_INSTANCE left, PTP_CALLBACK_INSTANCE right) => left.Value <= right.Value;

        public static bool operator >(PTP_CALLBACK_INSTANCE left, PTP_CALLBACK_INSTANCE right) => left.Value > right.Value;

        public static bool operator >=(PTP_CALLBACK_INSTANCE left, PTP_CALLBACK_INSTANCE right) => left.Value >= right.Value;

        public static explicit operator PTP_CALLBACK_INSTANCE(void* value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static implicit operator void*(PTP_CALLBACK_INSTANCE value) => (void*)(value.Value);

        public static explicit operator PTP_CALLBACK_INSTANCE(byte value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static explicit operator byte(PTP_CALLBACK_INSTANCE value) => (byte)(value.Value);

        public static explicit operator PTP_CALLBACK_INSTANCE(short value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static explicit operator short(PTP_CALLBACK_INSTANCE value) => (short)(value.Value);

        public static explicit operator PTP_CALLBACK_INSTANCE(int value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static explicit operator int(PTP_CALLBACK_INSTANCE value) => (int)(value.Value);

        public static explicit operator PTP_CALLBACK_INSTANCE(long value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static implicit operator long(PTP_CALLBACK_INSTANCE value) => value.Value;

        public static explicit operator PTP_CALLBACK_INSTANCE(nint value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static implicit operator nint(PTP_CALLBACK_INSTANCE value) => value.Value;

        public static explicit operator PTP_CALLBACK_INSTANCE(sbyte value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static explicit operator sbyte(PTP_CALLBACK_INSTANCE value) => (sbyte)(value.Value);

        public static explicit operator PTP_CALLBACK_INSTANCE(ushort value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static explicit operator ushort(PTP_CALLBACK_INSTANCE value) => (ushort)(value.Value);

        public static explicit operator PTP_CALLBACK_INSTANCE(uint value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static explicit operator uint(PTP_CALLBACK_INSTANCE value) => (uint)(value.Value);

        public static explicit operator PTP_CALLBACK_INSTANCE(ulong value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static explicit operator ulong(PTP_CALLBACK_INSTANCE value) => (ulong)(value.Value);

        public static explicit operator PTP_CALLBACK_INSTANCE(nuint value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static explicit operator nuint(PTP_CALLBACK_INSTANCE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is PTP_CALLBACK_INSTANCE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PTP_CALLBACK_INSTANCE.");
        }

        public int CompareTo(PTP_CALLBACK_INSTANCE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is PTP_CALLBACK_INSTANCE other) && Equals(other);

        public bool Equals(PTP_CALLBACK_INSTANCE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
