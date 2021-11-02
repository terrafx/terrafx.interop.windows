// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHZ_AUDIT_EVENT_HANDLE : IEquatable<AUTHZ_AUDIT_EVENT_HANDLE>
    {
        public readonly nint Value;

        public AUTHZ_AUDIT_EVENT_HANDLE(nint value)
        {
            Value = value;
        }

        public static AUTHZ_AUDIT_EVENT_HANDLE INVALID_VALUE => new AUTHZ_AUDIT_EVENT_HANDLE(-1);

        public static AUTHZ_AUDIT_EVENT_HANDLE NULL => new AUTHZ_AUDIT_EVENT_HANDLE(0);

        public static bool operator ==(AUTHZ_AUDIT_EVENT_HANDLE left, AUTHZ_AUDIT_EVENT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(AUTHZ_AUDIT_EVENT_HANDLE left, AUTHZ_AUDIT_EVENT_HANDLE right) => left.Value != right.Value;

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(void* value) => new AUTHZ_AUDIT_EVENT_HANDLE((nint)(value));

        public static implicit operator void*(AUTHZ_AUDIT_EVENT_HANDLE value) => (void*)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(HANDLE value) => new AUTHZ_AUDIT_EVENT_HANDLE(value);

        public static implicit operator HANDLE(AUTHZ_AUDIT_EVENT_HANDLE value) => new AUTHZ_AUDIT_EVENT_HANDLE(value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(byte value) => new AUTHZ_AUDIT_EVENT_HANDLE((nint)(value));

        public static explicit operator byte(AUTHZ_AUDIT_EVENT_HANDLE value) => (byte)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(short value) => new AUTHZ_AUDIT_EVENT_HANDLE((nint)(value));

        public static explicit operator short(AUTHZ_AUDIT_EVENT_HANDLE value) => (short)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(int value) => new AUTHZ_AUDIT_EVENT_HANDLE((nint)(value));

        public static explicit operator int(AUTHZ_AUDIT_EVENT_HANDLE value) => (int)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(long value) => new AUTHZ_AUDIT_EVENT_HANDLE((nint)(value));

        public static implicit operator long(AUTHZ_AUDIT_EVENT_HANDLE value) => (long)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(nint value) => new AUTHZ_AUDIT_EVENT_HANDLE((nint)(value));

        public static implicit operator nint(AUTHZ_AUDIT_EVENT_HANDLE value) => (nint)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(sbyte value) => new AUTHZ_AUDIT_EVENT_HANDLE((nint)(value));

        public static explicit operator sbyte(AUTHZ_AUDIT_EVENT_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(ushort value) => new AUTHZ_AUDIT_EVENT_HANDLE((nint)(value));

        public static explicit operator ushort(AUTHZ_AUDIT_EVENT_HANDLE value) => (ushort)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(uint value) => new AUTHZ_AUDIT_EVENT_HANDLE((nint)(value));

        public static explicit operator uint(AUTHZ_AUDIT_EVENT_HANDLE value) => (uint)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(ulong value) => new AUTHZ_AUDIT_EVENT_HANDLE((nint)(value));

        public static explicit operator ulong(AUTHZ_AUDIT_EVENT_HANDLE value) => (ulong)(value.Value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(nuint value) => new AUTHZ_AUDIT_EVENT_HANDLE((nint)(value));

        public static explicit operator nuint(AUTHZ_AUDIT_EVENT_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is AUTHZ_AUDIT_EVENT_HANDLE other) && Equals(other);

        public bool Equals(AUTHZ_AUDIT_EVENT_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
