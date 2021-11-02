// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PEERDIST_INSTANCE_HANDLE : IEquatable<PEERDIST_INSTANCE_HANDLE>
    {
        public readonly nint Value;

        public PEERDIST_INSTANCE_HANDLE(nint value)
        {
            Value = value;
        }

        public static PEERDIST_INSTANCE_HANDLE INVALID_HANDLE_VALUE => new PEERDIST_INSTANCE_HANDLE(-1);

        public static PEERDIST_INSTANCE_HANDLE NULL => new PEERDIST_INSTANCE_HANDLE(0);

        public static bool operator ==(PEERDIST_INSTANCE_HANDLE left, PEERDIST_INSTANCE_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(PEERDIST_INSTANCE_HANDLE left, PEERDIST_INSTANCE_HANDLE right) => left.Value != right.Value;

        public static explicit operator PEERDIST_INSTANCE_HANDLE(void* value) => new PEERDIST_INSTANCE_HANDLE((nint)(value));

        public static implicit operator void*(PEERDIST_INSTANCE_HANDLE value) => (void*)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(HANDLE value) => new PEERDIST_INSTANCE_HANDLE(value);

        public static implicit operator HANDLE(PEERDIST_INSTANCE_HANDLE value) => new PEERDIST_INSTANCE_HANDLE(value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(byte value) => new PEERDIST_INSTANCE_HANDLE((nint)(value));

        public static implicit operator byte(PEERDIST_INSTANCE_HANDLE value) => (byte)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(short value) => new PEERDIST_INSTANCE_HANDLE((nint)(value));

        public static implicit operator short(PEERDIST_INSTANCE_HANDLE value) => (short)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(int value) => new PEERDIST_INSTANCE_HANDLE((nint)(value));

        public static implicit operator int(PEERDIST_INSTANCE_HANDLE value) => (int)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(long value) => new PEERDIST_INSTANCE_HANDLE((nint)(value));

        public static explicit operator long(PEERDIST_INSTANCE_HANDLE value) => (long)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(nint value) => new PEERDIST_INSTANCE_HANDLE((nint)(value));

        public static implicit operator nint(PEERDIST_INSTANCE_HANDLE value) => (nint)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(sbyte value) => new PEERDIST_INSTANCE_HANDLE((nint)(value));

        public static implicit operator sbyte(PEERDIST_INSTANCE_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(ushort value) => new PEERDIST_INSTANCE_HANDLE((nint)(value));

        public static implicit operator ushort(PEERDIST_INSTANCE_HANDLE value) => (ushort)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(uint value) => new PEERDIST_INSTANCE_HANDLE((nint)(value));

        public static implicit operator uint(PEERDIST_INSTANCE_HANDLE value) => (uint)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(ulong value) => new PEERDIST_INSTANCE_HANDLE((nint)(value));

        public static explicit operator ulong(PEERDIST_INSTANCE_HANDLE value) => (ulong)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(nuint value) => new PEERDIST_INSTANCE_HANDLE((nint)(value));

        public static explicit operator nuint(PEERDIST_INSTANCE_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is PEERDIST_INSTANCE_HANDLE other) && Equals(other);

        public bool Equals(PEERDIST_INSTANCE_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
