// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDESK : IComparable, IComparable<HDESK>, IEquatable<HDESK>, IFormattable
    {
        public readonly nint Value;

        public HDESK(nint value)
        {
            Value = value;
        }

        public static HDESK INVALID_VALUE => new HDESK(-1);

        public static HDESK NULL => new HDESK(0);

        public static bool operator ==(HDESK left, HDESK right) => left.Value == right.Value;

        public static bool operator !=(HDESK left, HDESK right) => left.Value != right.Value;

        public static bool operator <(HDESK left, HDESK right) => left.Value < right.Value;

        public static bool operator <=(HDESK left, HDESK right) => left.Value <= right.Value;

        public static bool operator >(HDESK left, HDESK right) => left.Value > right.Value;

        public static bool operator >=(HDESK left, HDESK right) => left.Value >= right.Value;

        public static explicit operator HDESK(void* value) => new HDESK((nint)(value));

        public static implicit operator void*(HDESK value) => (void*)(value.Value);

        public static explicit operator HDESK(HANDLE value) => new HDESK(value);

        public static implicit operator HANDLE(HDESK value) => new HANDLE(value.Value);

        public static explicit operator HDESK(byte value) => new HDESK((nint)(value));

        public static explicit operator byte(HDESK value) => (byte)(value.Value);

        public static explicit operator HDESK(short value) => new HDESK((nint)(value));

        public static explicit operator short(HDESK value) => (short)(value.Value);

        public static explicit operator HDESK(int value) => new HDESK((nint)(value));

        public static explicit operator int(HDESK value) => (int)(value.Value);

        public static explicit operator HDESK(long value) => new HDESK((nint)(value));

        public static implicit operator long(HDESK value) => value.Value;

        public static explicit operator HDESK(nint value) => new HDESK((nint)(value));

        public static implicit operator nint(HDESK value) => value.Value;

        public static explicit operator HDESK(sbyte value) => new HDESK((nint)(value));

        public static explicit operator sbyte(HDESK value) => (sbyte)(value.Value);

        public static explicit operator HDESK(ushort value) => new HDESK((nint)(value));

        public static explicit operator ushort(HDESK value) => (ushort)(value.Value);

        public static explicit operator HDESK(uint value) => new HDESK((nint)(value));

        public static explicit operator uint(HDESK value) => (uint)(value.Value);

        public static explicit operator HDESK(ulong value) => new HDESK((nint)(value));

        public static explicit operator ulong(HDESK value) => (ulong)(value.Value);

        public static explicit operator HDESK(nuint value) => new HDESK((nint)(value));

        public static explicit operator nuint(HDESK value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDESK other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDESK.");
        }

        public int CompareTo(HDESK other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HDESK other) && Equals(other);

        public bool Equals(HDESK other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
