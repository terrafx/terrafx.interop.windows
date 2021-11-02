// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PAPPCONSTRAIN_REGISTRATION : IComparable, IComparable<PAPPCONSTRAIN_REGISTRATION>, IEquatable<PAPPCONSTRAIN_REGISTRATION>, IFormattable
    {
        public readonly nint Value;

        public PAPPCONSTRAIN_REGISTRATION(nint value)
        {
            Value = value;
        }

        public static PAPPCONSTRAIN_REGISTRATION NULL => new PAPPCONSTRAIN_REGISTRATION(0);

        public static bool operator ==(PAPPCONSTRAIN_REGISTRATION left, PAPPCONSTRAIN_REGISTRATION right) => left.Value == right.Value;

        public static bool operator !=(PAPPCONSTRAIN_REGISTRATION left, PAPPCONSTRAIN_REGISTRATION right) => left.Value != right.Value;

        public static bool operator <(PAPPCONSTRAIN_REGISTRATION left, PAPPCONSTRAIN_REGISTRATION right) => left.Value < right.Value;

        public static bool operator <=(PAPPCONSTRAIN_REGISTRATION left, PAPPCONSTRAIN_REGISTRATION right) => left.Value <= right.Value;

        public static bool operator >(PAPPCONSTRAIN_REGISTRATION left, PAPPCONSTRAIN_REGISTRATION right) => left.Value > right.Value;

        public static bool operator >=(PAPPCONSTRAIN_REGISTRATION left, PAPPCONSTRAIN_REGISTRATION right) => left.Value >= right.Value;

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(void* value) => new PAPPCONSTRAIN_REGISTRATION((nint)(value));

        public static implicit operator void*(PAPPCONSTRAIN_REGISTRATION value) => (void*)(value.Value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(byte value) => new PAPPCONSTRAIN_REGISTRATION((nint)(value));

        public static explicit operator byte(PAPPCONSTRAIN_REGISTRATION value) => (byte)(value.Value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(short value) => new PAPPCONSTRAIN_REGISTRATION((nint)(value));

        public static explicit operator short(PAPPCONSTRAIN_REGISTRATION value) => (short)(value.Value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(int value) => new PAPPCONSTRAIN_REGISTRATION((nint)(value));

        public static explicit operator int(PAPPCONSTRAIN_REGISTRATION value) => (int)(value.Value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(long value) => new PAPPCONSTRAIN_REGISTRATION((nint)(value));

        public static implicit operator long(PAPPCONSTRAIN_REGISTRATION value) => (long)(value.Value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(nint value) => new PAPPCONSTRAIN_REGISTRATION((nint)(value));

        public static implicit operator nint(PAPPCONSTRAIN_REGISTRATION value) => (nint)(value.Value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(sbyte value) => new PAPPCONSTRAIN_REGISTRATION((nint)(value));

        public static explicit operator sbyte(PAPPCONSTRAIN_REGISTRATION value) => (sbyte)(value.Value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(ushort value) => new PAPPCONSTRAIN_REGISTRATION((nint)(value));

        public static explicit operator ushort(PAPPCONSTRAIN_REGISTRATION value) => (ushort)(value.Value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(uint value) => new PAPPCONSTRAIN_REGISTRATION((nint)(value));

        public static explicit operator uint(PAPPCONSTRAIN_REGISTRATION value) => (uint)(value.Value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(ulong value) => new PAPPCONSTRAIN_REGISTRATION((nint)(value));

        public static explicit operator ulong(PAPPCONSTRAIN_REGISTRATION value) => (ulong)(value.Value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(nuint value) => new PAPPCONSTRAIN_REGISTRATION((nint)(value));

        public static explicit operator nuint(PAPPCONSTRAIN_REGISTRATION value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is PAPPCONSTRAIN_REGISTRATION other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PAPPCONSTRAIN_REGISTRATION.");
        }

        public int CompareTo(PAPPCONSTRAIN_REGISTRATION other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is PAPPCONSTRAIN_REGISTRATION other) && Equals(other);

        public bool Equals(PAPPCONSTRAIN_REGISTRATION other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
