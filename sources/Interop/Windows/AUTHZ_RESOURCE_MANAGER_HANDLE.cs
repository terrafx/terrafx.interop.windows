// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHZ_RESOURCE_MANAGER_HANDLE : IEquatable<AUTHZ_RESOURCE_MANAGER_HANDLE>
    {
        public readonly nint Value;

        public AUTHZ_RESOURCE_MANAGER_HANDLE(nint value)
        {
            Value = value;
        }

        public static AUTHZ_RESOURCE_MANAGER_HANDLE INVALID_HANDLE_VALUE => new AUTHZ_RESOURCE_MANAGER_HANDLE(-1);

        public static AUTHZ_RESOURCE_MANAGER_HANDLE NULL => new AUTHZ_RESOURCE_MANAGER_HANDLE(0);

        public static bool operator ==(AUTHZ_RESOURCE_MANAGER_HANDLE left, AUTHZ_RESOURCE_MANAGER_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(AUTHZ_RESOURCE_MANAGER_HANDLE left, AUTHZ_RESOURCE_MANAGER_HANDLE right) => left.Value != right.Value;

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(void* value) => new AUTHZ_RESOURCE_MANAGER_HANDLE((nint)(value));

        public static implicit operator void*(AUTHZ_RESOURCE_MANAGER_HANDLE value) => (void*)(value.Value);

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(HANDLE value) => new AUTHZ_RESOURCE_MANAGER_HANDLE(value);

        public static implicit operator HANDLE(AUTHZ_RESOURCE_MANAGER_HANDLE value) => new AUTHZ_RESOURCE_MANAGER_HANDLE(value);

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(byte value) => new AUTHZ_RESOURCE_MANAGER_HANDLE((nint)(value));

        public static implicit operator byte(AUTHZ_RESOURCE_MANAGER_HANDLE value) => (byte)(value.Value);

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(short value) => new AUTHZ_RESOURCE_MANAGER_HANDLE((nint)(value));

        public static implicit operator short(AUTHZ_RESOURCE_MANAGER_HANDLE value) => (short)(value.Value);

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(int value) => new AUTHZ_RESOURCE_MANAGER_HANDLE((nint)(value));

        public static implicit operator int(AUTHZ_RESOURCE_MANAGER_HANDLE value) => (int)(value.Value);

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(long value) => new AUTHZ_RESOURCE_MANAGER_HANDLE((nint)(value));

        public static explicit operator long(AUTHZ_RESOURCE_MANAGER_HANDLE value) => (long)(value.Value);

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(nint value) => new AUTHZ_RESOURCE_MANAGER_HANDLE((nint)(value));

        public static implicit operator nint(AUTHZ_RESOURCE_MANAGER_HANDLE value) => (nint)(value.Value);

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(sbyte value) => new AUTHZ_RESOURCE_MANAGER_HANDLE((nint)(value));

        public static implicit operator sbyte(AUTHZ_RESOURCE_MANAGER_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(ushort value) => new AUTHZ_RESOURCE_MANAGER_HANDLE((nint)(value));

        public static implicit operator ushort(AUTHZ_RESOURCE_MANAGER_HANDLE value) => (ushort)(value.Value);

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(uint value) => new AUTHZ_RESOURCE_MANAGER_HANDLE((nint)(value));

        public static implicit operator uint(AUTHZ_RESOURCE_MANAGER_HANDLE value) => (uint)(value.Value);

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(ulong value) => new AUTHZ_RESOURCE_MANAGER_HANDLE((nint)(value));

        public static explicit operator ulong(AUTHZ_RESOURCE_MANAGER_HANDLE value) => (ulong)(value.Value);

        public static explicit operator AUTHZ_RESOURCE_MANAGER_HANDLE(nuint value) => new AUTHZ_RESOURCE_MANAGER_HANDLE((nint)(value));

        public static explicit operator nuint(AUTHZ_RESOURCE_MANAGER_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is AUTHZ_RESOURCE_MANAGER_HANDLE other) && Equals(other);

        public bool Equals(AUTHZ_RESOURCE_MANAGER_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
