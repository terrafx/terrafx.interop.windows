// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE : IComparable, IComparable<AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE>, IEquatable<AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE>, IFormattable
    {
        public readonly nint Value;

        public AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(nint value)
        {
            Value = value;
        }

        public static AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE INVALID_VALUE => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(-1);

        public static AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE NULL => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(0);

        public static bool operator ==(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE left, AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE left, AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE right) => left.Value != right.Value;

        public static bool operator <(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE left, AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE left, AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE left, AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE left, AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE right) => left.Value >= right.Value;

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(void* value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE((nint)(value));

        public static implicit operator void*(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (void*)(value.Value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(HANDLE value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(value);

        public static implicit operator HANDLE(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(byte value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE((nint)(value));

        public static explicit operator byte(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (byte)(value.Value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(short value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE((nint)(value));

        public static explicit operator short(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (short)(value.Value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(int value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE((nint)(value));

        public static explicit operator int(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (int)(value.Value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(long value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE((nint)(value));

        public static implicit operator long(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => value.Value;

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(nint value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE((nint)(value));

        public static implicit operator nint(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => value.Value;

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(sbyte value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE((nint)(value));

        public static explicit operator sbyte(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(ushort value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE((nint)(value));

        public static explicit operator ushort(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (ushort)(value.Value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(uint value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE((nint)(value));

        public static explicit operator uint(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (uint)(value.Value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(ulong value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE((nint)(value));

        public static explicit operator ulong(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (ulong)(value.Value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(nuint value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE((nint)(value));

        public static explicit operator nuint(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE.");
        }

        public int CompareTo(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE other) && Equals(other);

        public bool Equals(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
