// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCRYPTOIDFUNCADDR : IEquatable<HCRYPTOIDFUNCADDR>
    {
        public readonly nint Value;

        public HCRYPTOIDFUNCADDR(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) => left.Value != right.Value;

        public static implicit operator HCRYPTOIDFUNCADDR(nint value) => new HCRYPTOIDFUNCADDR(value);

        public static implicit operator nint(HCRYPTOIDFUNCADDR value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCRYPTOIDFUNCADDR other) && Equals(other);

        public bool Equals(HCRYPTOIDFUNCADDR other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
