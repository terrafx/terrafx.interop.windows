// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCRYPTPROV : IEquatable<HCRYPTPROV>
    {
        public readonly nint Value;

        public HCRYPTPROV(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCRYPTPROV left, HCRYPTPROV right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTPROV left, HCRYPTPROV right) => left.Value != right.Value;

        public static implicit operator HCRYPTPROV(nint value) => new HCRYPTPROV(value);

        public static implicit operator nint(HCRYPTPROV value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCRYPTPROV other) && Equals(other);

        public bool Equals(HCRYPTPROV other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
