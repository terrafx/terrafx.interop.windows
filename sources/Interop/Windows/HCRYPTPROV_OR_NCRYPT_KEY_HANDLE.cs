// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCRYPTPROV_OR_NCRYPT_KEY_HANDLE : IEquatable<HCRYPTPROV_OR_NCRYPT_KEY_HANDLE>
    {
        public readonly nint Value;

        public HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE left, HCRYPTPROV_OR_NCRYPT_KEY_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE left, HCRYPTPROV_OR_NCRYPT_KEY_HANDLE right) => left.Value != right.Value;

        public static implicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(nint value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(value);

        public static implicit operator nint(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCRYPTPROV_OR_NCRYPT_KEY_HANDLE other) && Equals(other);

        public bool Equals(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
