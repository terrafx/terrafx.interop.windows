// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct RESOURCE_HANDLE : IEquatable<RESOURCE_HANDLE>
    {
        public readonly nint Value;

        public RESOURCE_HANDLE(nint value)
        {
            Value = value;
        }

        public static RESOURCE_HANDLE INVALID_HANDLE_VALUE => new RESOURCE_HANDLE(-1);

        public static RESOURCE_HANDLE NULL => new RESOURCE_HANDLE(0);

        public static bool operator ==(RESOURCE_HANDLE left, RESOURCE_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(RESOURCE_HANDLE left, RESOURCE_HANDLE right) => left.Value != right.Value;

        public static explicit operator RESOURCE_HANDLE(void* value) => new RESOURCE_HANDLE((nint)(value));

        public static implicit operator void*(RESOURCE_HANDLE value) => (void*)(value.Value);

        public static explicit operator RESOURCE_HANDLE(HANDLE value) => new RESOURCE_HANDLE(value);

        public static implicit operator HANDLE(RESOURCE_HANDLE value) => new RESOURCE_HANDLE(value);

        public static explicit operator RESOURCE_HANDLE(byte value) => new RESOURCE_HANDLE((nint)(value));

        public static implicit operator byte(RESOURCE_HANDLE value) => (byte)(value.Value);

        public static explicit operator RESOURCE_HANDLE(short value) => new RESOURCE_HANDLE((nint)(value));

        public static implicit operator short(RESOURCE_HANDLE value) => (short)(value.Value);

        public static explicit operator RESOURCE_HANDLE(int value) => new RESOURCE_HANDLE((nint)(value));

        public static implicit operator int(RESOURCE_HANDLE value) => (int)(value.Value);

        public static explicit operator RESOURCE_HANDLE(long value) => new RESOURCE_HANDLE((nint)(value));

        public static explicit operator long(RESOURCE_HANDLE value) => (long)(value.Value);

        public static explicit operator RESOURCE_HANDLE(nint value) => new RESOURCE_HANDLE((nint)(value));

        public static implicit operator nint(RESOURCE_HANDLE value) => (nint)(value.Value);

        public static explicit operator RESOURCE_HANDLE(sbyte value) => new RESOURCE_HANDLE((nint)(value));

        public static implicit operator sbyte(RESOURCE_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator RESOURCE_HANDLE(ushort value) => new RESOURCE_HANDLE((nint)(value));

        public static implicit operator ushort(RESOURCE_HANDLE value) => (ushort)(value.Value);

        public static explicit operator RESOURCE_HANDLE(uint value) => new RESOURCE_HANDLE((nint)(value));

        public static implicit operator uint(RESOURCE_HANDLE value) => (uint)(value.Value);

        public static explicit operator RESOURCE_HANDLE(ulong value) => new RESOURCE_HANDLE((nint)(value));

        public static explicit operator ulong(RESOURCE_HANDLE value) => (ulong)(value.Value);

        public static explicit operator RESOURCE_HANDLE(nuint value) => new RESOURCE_HANDLE((nint)(value));

        public static explicit operator nuint(RESOURCE_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is RESOURCE_HANDLE other) && Equals(other);

        public bool Equals(RESOURCE_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
