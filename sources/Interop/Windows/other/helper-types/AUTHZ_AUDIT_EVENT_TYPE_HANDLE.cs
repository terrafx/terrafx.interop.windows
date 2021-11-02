// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHZ_AUDIT_EVENT_TYPE_HANDLE : IComparable, IComparable<AUTHZ_AUDIT_EVENT_TYPE_HANDLE>, IEquatable<AUTHZ_AUDIT_EVENT_TYPE_HANDLE>, IFormattable
    {
        public readonly nint Value;

        public AUTHZ_AUDIT_EVENT_TYPE_HANDLE(nint value)
        {
            Value = value;
        }

        public static AUTHZ_AUDIT_EVENT_TYPE_HANDLE INVALID_VALUE => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE(-1);

        public static AUTHZ_AUDIT_EVENT_TYPE_HANDLE NULL => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE(0);

        public static bool operator ==(AUTHZ_AUDIT_EVENT_TYPE_HANDLE left, AUTHZ_AUDIT_EVENT_TYPE_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(AUTHZ_AUDIT_EVENT_TYPE_HANDLE left, AUTHZ_AUDIT_EVENT_TYPE_HANDLE right) => left.Value != right.Value;

        public static bool operator <(AUTHZ_AUDIT_EVENT_TYPE_HANDLE left, AUTHZ_AUDIT_EVENT_TYPE_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(AUTHZ_AUDIT_EVENT_TYPE_HANDLE left, AUTHZ_AUDIT_EVENT_TYPE_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(AUTHZ_AUDIT_EVENT_TYPE_HANDLE left, AUTHZ_AUDIT_EVENT_TYPE_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(AUTHZ_AUDIT_EVENT_TYPE_HANDLE left, AUTHZ_AUDIT_EVENT_TYPE_HANDLE right) => left.Value >= right.Value;

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(void* value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE((nint)(value));

        public static implicit operator void*(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => (void*)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(HANDLE value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE(value);

        public static implicit operator HANDLE(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(byte value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE((nint)(value));

        public static explicit operator byte(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => (byte)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(short value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE((nint)(value));

        public static explicit operator short(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => (short)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(int value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE((nint)(value));

        public static explicit operator int(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => (int)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(long value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE((nint)(value));

        public static implicit operator long(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => value.Value;

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(nint value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE((nint)(value));

        public static implicit operator nint(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => value.Value;

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(sbyte value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE((nint)(value));

        public static explicit operator sbyte(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(ushort value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE((nint)(value));

        public static explicit operator ushort(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => (ushort)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(uint value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE((nint)(value));

        public static explicit operator uint(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => (uint)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(ulong value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE((nint)(value));

        public static explicit operator ulong(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => (ulong)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_TYPE_HANDLE(nuint value) => new AUTHZ_AUDIT_EVENT_TYPE_HANDLE((nint)(value));

        public static explicit operator nuint(AUTHZ_AUDIT_EVENT_TYPE_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is AUTHZ_AUDIT_EVENT_TYPE_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of AUTHZ_AUDIT_EVENT_TYPE_HANDLE.");
        }

        public int CompareTo(AUTHZ_AUDIT_EVENT_TYPE_HANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is AUTHZ_AUDIT_EVENT_TYPE_HANDLE other) && Equals(other);

        public bool Equals(AUTHZ_AUDIT_EVENT_TYPE_HANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
