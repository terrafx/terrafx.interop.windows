// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CIMFS_IMAGE_HANDLE : IEquatable<CIMFS_IMAGE_HANDLE>
    {
        public readonly nint Value;

        public static CIMFS_IMAGE_HANDLE NULL => (CIMFS_IMAGE_HANDLE)(0);

        public CIMFS_IMAGE_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public CIMFS_IMAGE_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public CIMFS_IMAGE_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public CIMFS_IMAGE_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public CIMFS_IMAGE_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public CIMFS_IMAGE_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(CIMFS_IMAGE_HANDLE left, CIMFS_IMAGE_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(CIMFS_IMAGE_HANDLE left, CIMFS_IMAGE_HANDLE right) => left.Value != right.Value;

        public static explicit operator CIMFS_IMAGE_HANDLE(int value) => new CIMFS_IMAGE_HANDLE(value);

        public static explicit operator CIMFS_IMAGE_HANDLE(uint value) => new CIMFS_IMAGE_HANDLE(value);

        public static explicit operator CIMFS_IMAGE_HANDLE(nint value) => new CIMFS_IMAGE_HANDLE(value);

        public static explicit operator CIMFS_IMAGE_HANDLE(nuint value) => new CIMFS_IMAGE_HANDLE(value);

        public static explicit operator CIMFS_IMAGE_HANDLE(void* value) => new CIMFS_IMAGE_HANDLE(value);

        public static explicit operator CIMFS_IMAGE_HANDLE(HANDLE value) => new CIMFS_IMAGE_HANDLE(value);

        public static implicit operator int(CIMFS_IMAGE_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(CIMFS_IMAGE_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(CIMFS_IMAGE_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(CIMFS_IMAGE_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(CIMFS_IMAGE_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(CIMFS_IMAGE_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is CIMFS_IMAGE_HANDLE other) && Equals(other);

        public bool Equals(CIMFS_IMAGE_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
