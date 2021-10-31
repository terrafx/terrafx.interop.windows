// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTPROV_OR_NCRYPT_KEY_HANDLE : IEquatable<HCRYPTPROV_OR_NCRYPT_KEY_HANDLE>
    {
        public readonly nuint Value;

        public HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(int value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(uint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(nint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(nuint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(void* value)
        {
            Value = ((nuint)(value));
        }

        public static bool operator ==(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE left, HCRYPTPROV_OR_NCRYPT_KEY_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE left, HCRYPTPROV_OR_NCRYPT_KEY_HANDLE right) => left.Value != right.Value;

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(int value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(uint value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(nint value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(nuint value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(void* value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(value);

        public static explicit operator int(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (int)(value.Value);

        public static explicit operator uint(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTPROV_OR_NCRYPT_KEY_HANDLE other) && Equals(other);

        public bool Equals(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
