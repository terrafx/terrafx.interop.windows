// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CIMFS_IMAGE_HANDLE : IEquatable<CIMFS_IMAGE_HANDLE>
    {
        public readonly nint Value;

        public CIMFS_IMAGE_HANDLE(nint value)
        {
            Value = value;
        }

        public static CIMFS_IMAGE_HANDLE INVALID_VALUE => new CIMFS_IMAGE_HANDLE(-1);

        public static CIMFS_IMAGE_HANDLE NULL => new CIMFS_IMAGE_HANDLE(0);

        public static bool operator ==(CIMFS_IMAGE_HANDLE left, CIMFS_IMAGE_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(CIMFS_IMAGE_HANDLE left, CIMFS_IMAGE_HANDLE right) => left.Value != right.Value;

        public static explicit operator CIMFS_IMAGE_HANDLE(void* value) => new CIMFS_IMAGE_HANDLE((nint)(value));

        public static implicit operator void*(CIMFS_IMAGE_HANDLE value) => (void*)(value.Value);

        public static explicit operator CIMFS_IMAGE_HANDLE(HANDLE value) => new CIMFS_IMAGE_HANDLE(value);

        public static implicit operator HANDLE(CIMFS_IMAGE_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator CIMFS_IMAGE_HANDLE(byte value) => new CIMFS_IMAGE_HANDLE((nint)(value));

        public static explicit operator byte(CIMFS_IMAGE_HANDLE value) => (byte)(value.Value);

        public static explicit operator CIMFS_IMAGE_HANDLE(short value) => new CIMFS_IMAGE_HANDLE((nint)(value));

        public static explicit operator short(CIMFS_IMAGE_HANDLE value) => (short)(value.Value);

        public static explicit operator CIMFS_IMAGE_HANDLE(int value) => new CIMFS_IMAGE_HANDLE((nint)(value));

        public static explicit operator int(CIMFS_IMAGE_HANDLE value) => (int)(value.Value);

        public static explicit operator CIMFS_IMAGE_HANDLE(long value) => new CIMFS_IMAGE_HANDLE((nint)(value));

        public static implicit operator long(CIMFS_IMAGE_HANDLE value) => (long)(value.Value);

        public static explicit operator CIMFS_IMAGE_HANDLE(nint value) => new CIMFS_IMAGE_HANDLE((nint)(value));

        public static implicit operator nint(CIMFS_IMAGE_HANDLE value) => (nint)(value.Value);

        public static explicit operator CIMFS_IMAGE_HANDLE(sbyte value) => new CIMFS_IMAGE_HANDLE((nint)(value));

        public static explicit operator sbyte(CIMFS_IMAGE_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator CIMFS_IMAGE_HANDLE(ushort value) => new CIMFS_IMAGE_HANDLE((nint)(value));

        public static explicit operator ushort(CIMFS_IMAGE_HANDLE value) => (ushort)(value.Value);

        public static explicit operator CIMFS_IMAGE_HANDLE(uint value) => new CIMFS_IMAGE_HANDLE((nint)(value));

        public static explicit operator uint(CIMFS_IMAGE_HANDLE value) => (uint)(value.Value);

        public static explicit operator CIMFS_IMAGE_HANDLE(ulong value) => new CIMFS_IMAGE_HANDLE((nint)(value));

        public static explicit operator ulong(CIMFS_IMAGE_HANDLE value) => (ulong)(value.Value);

        public static explicit operator CIMFS_IMAGE_HANDLE(nuint value) => new CIMFS_IMAGE_HANDLE((nint)(value));

        public static explicit operator nuint(CIMFS_IMAGE_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is CIMFS_IMAGE_HANDLE other) && Equals(other);

        public bool Equals(CIMFS_IMAGE_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
