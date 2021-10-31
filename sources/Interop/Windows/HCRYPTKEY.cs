// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCRYPTKEY : IEquatable<HCRYPTKEY>
    {
        public readonly nint Value;

        public HCRYPTKEY(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCRYPTKEY left, HCRYPTKEY right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTKEY left, HCRYPTKEY right) => left.Value != right.Value;

        public static implicit operator HCRYPTKEY(nint value) => new HCRYPTKEY(value);

        public static implicit operator nint(HCRYPTKEY value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCRYPTKEY other) && Equals(other);

        public bool Equals(HCRYPTKEY other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
