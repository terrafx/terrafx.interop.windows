// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCRYPTOIDFUNCSET : IEquatable<HCRYPTOIDFUNCSET>
    {
        public readonly nint Value;

        public HCRYPTOIDFUNCSET(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCRYPTOIDFUNCSET left, HCRYPTOIDFUNCSET right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTOIDFUNCSET left, HCRYPTOIDFUNCSET right) => left.Value != right.Value;

        public static implicit operator HCRYPTOIDFUNCSET(nint value) => new HCRYPTOIDFUNCSET(value);

        public static implicit operator nint(HCRYPTOIDFUNCSET value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCRYPTOIDFUNCSET other) && Equals(other);

        public bool Equals(HCRYPTOIDFUNCSET other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
