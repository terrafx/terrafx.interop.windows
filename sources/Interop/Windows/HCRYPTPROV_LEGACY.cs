// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCRYPTPROV_LEGACY : IEquatable<HCRYPTPROV_LEGACY>
    {
        public readonly nint Value;

        public HCRYPTPROV_LEGACY(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) => left.Value != right.Value;

        public static implicit operator HCRYPTPROV_LEGACY(nint value) => new HCRYPTPROV_LEGACY(value);

        public static implicit operator nint(HCRYPTPROV_LEGACY value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCRYPTPROV_LEGACY other) && Equals(other);

        public bool Equals(HCRYPTPROV_LEGACY other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
