// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NCRYPT_STREAM_HANDLE : IEquatable<NCRYPT_STREAM_HANDLE>
    {
        public readonly nint Value;

        public static NCRYPT_STREAM_HANDLE NULL => (NCRYPT_STREAM_HANDLE)(0);

        public NCRYPT_STREAM_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public NCRYPT_STREAM_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public NCRYPT_STREAM_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public NCRYPT_STREAM_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public NCRYPT_STREAM_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public NCRYPT_STREAM_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(NCRYPT_STREAM_HANDLE left, NCRYPT_STREAM_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(NCRYPT_STREAM_HANDLE left, NCRYPT_STREAM_HANDLE right) => left.Value != right.Value;

        public static explicit operator NCRYPT_STREAM_HANDLE(int value) => new NCRYPT_STREAM_HANDLE(value);

        public static explicit operator NCRYPT_STREAM_HANDLE(uint value) => new NCRYPT_STREAM_HANDLE(value);

        public static explicit operator NCRYPT_STREAM_HANDLE(nint value) => new NCRYPT_STREAM_HANDLE(value);

        public static explicit operator NCRYPT_STREAM_HANDLE(nuint value) => new NCRYPT_STREAM_HANDLE(value);

        public static explicit operator NCRYPT_STREAM_HANDLE(void* value) => new NCRYPT_STREAM_HANDLE(value);

        public static explicit operator NCRYPT_STREAM_HANDLE(HANDLE value) => new NCRYPT_STREAM_HANDLE(value);

        public static implicit operator int(NCRYPT_STREAM_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(NCRYPT_STREAM_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(NCRYPT_STREAM_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(NCRYPT_STREAM_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(NCRYPT_STREAM_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(NCRYPT_STREAM_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is NCRYPT_STREAM_HANDLE other) && Equals(other);

        public bool Equals(NCRYPT_STREAM_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
