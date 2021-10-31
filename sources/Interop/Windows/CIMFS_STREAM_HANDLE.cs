// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CIMFS_STREAM_HANDLE : IEquatable<CIMFS_STREAM_HANDLE>
    {
        public readonly nint Value;

        public CIMFS_STREAM_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public CIMFS_STREAM_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public CIMFS_STREAM_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public CIMFS_STREAM_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public CIMFS_STREAM_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public CIMFS_STREAM_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(CIMFS_STREAM_HANDLE left, CIMFS_STREAM_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(CIMFS_STREAM_HANDLE left, CIMFS_STREAM_HANDLE right) => left.Value != right.Value;

        public static explicit operator CIMFS_STREAM_HANDLE(int value) => new CIMFS_STREAM_HANDLE(value);

        public static explicit operator CIMFS_STREAM_HANDLE(uint value) => new CIMFS_STREAM_HANDLE(value);

        public static explicit operator CIMFS_STREAM_HANDLE(nint value) => new CIMFS_STREAM_HANDLE(value);

        public static explicit operator CIMFS_STREAM_HANDLE(nuint value) => new CIMFS_STREAM_HANDLE(value);

        public static explicit operator CIMFS_STREAM_HANDLE(void* value) => new CIMFS_STREAM_HANDLE(value);

        public static explicit operator CIMFS_STREAM_HANDLE(HANDLE value) => new CIMFS_STREAM_HANDLE(value);

        public static implicit operator int(CIMFS_STREAM_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(CIMFS_STREAM_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(CIMFS_STREAM_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(CIMFS_STREAM_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(CIMFS_STREAM_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(CIMFS_STREAM_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is CIMFS_STREAM_HANDLE other) && Equals(other);

        public bool Equals(CIMFS_STREAM_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
